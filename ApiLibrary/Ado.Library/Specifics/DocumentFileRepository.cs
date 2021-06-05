﻿using Models.Dtos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Models.Ado.Library;
using Nucleo.DBAccess.Ado;
using Nucleo.Utilities.Enums;
using Nucleo.Utilities;
using Ado.Library;
using Nucleo.Files.Web;

namespace Ado.Library.Specifics
{
    public class DocumentFileRepository : Repository<DocumentFile>, IDocumentFileRepository
    {
        readonly FileRepository FileRepository;
        public DocumentFileRepository(BookStoreEntities context,string identificator="IdDocument") : base(context,identificator)
        {
            FileRepository = new FileRepository();
        }

        public new dynamic Delete(IEnumerable<string> ids)
        {

            foreach (string id in ids)
            {
                var search = dbSet.Find(id);
                if (search != null)
                {
                    MessageControl message = FileRepository.Delete((int)FileType.Document, search.DocumentDir, search.DocumentName,search.DocumentType);
                    if (message.Code == MessageCode.correct)
                    {
                        messages.Add(message);
                    }
                    else
                    {
                        try
                        {
                            dbSet.Remove(search);
                            _Context.SaveChanges();
                            MessageControl messageControl = new MessageControl()
                            {
                                Code = MessageCode.correct,
                                Error = false,
                                Type = MessageType.Delete,
                                Note = $"{name} with {Identificator} = {id} was delete with exit"
                            };
                            messages.Add(messageControl);
                        }
                        catch (SqlException e)
                        {
                            MessageControl messageControl = new MessageControl()
                            {
                                Code = MessageCode.exception,
                                Error = true,
                                Type = MessageType.Exception,
                                Note = $"{e.InnerException.InnerException.Message}"
                            };
                            messages.Add(messageControl);
                        }
                        catch (Exception e)
                        {
                            MessageControl messageControl = new MessageControl()
                            {
                                Code = MessageCode.exception,
                                Error = true,
                                Type = MessageType.Exception,
                                Note = $"{e.InnerException.InnerException.Message}"
                            };
                            messages.Add(messageControl);
                        }

                    }
                }
                else
                {
                    MessageControl messageControl = new MessageControl()
                    {
                        Code = MessageCode.error,
                        Error = true,
                        Type = MessageType.Not_Found,
                        Note = $"{name} with {Identificator} : {id} not was found"
                    };
                    messages.Add(messageControl);
                }
            }

            return messages;
        }
    }
}