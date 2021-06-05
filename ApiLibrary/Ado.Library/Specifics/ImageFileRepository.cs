using Models.Dtos;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using Models.Ado.Library;
using Nucleo.Utilities;
using Nucleo.Utilities.Enums;
using Nucleo.DBAccess.Ado;
using Ado.Library;
using Nucleo.Files.Web;

namespace Ado.Library.Specifics
{
    public class ImageFileRepository :Repository <ImageFile> ,IImageFileRepository
    {
        readonly IFileRepository FileRepository;
        public ImageFileRepository(BookStoreEntities context, string identificator= "IdImageFile") : base(context,identificator)
        {
            FileRepository = new FileRepository();
        }

        public new dynamic Delete(IEnumerable<string> ids)
        {

            foreach (string id in ids)
            {
                var search = dbSet.Find(id);
                if (search!=null)
                {
                    MessageControl message = FileRepository.Delete((int)FileType.Image,search.FileDir,search.ImageFileName,search.ImageType);
                    if (message.Code == MessageCode.correct)
                    {
                        messages.Add(message);
                    }
                    else
                    {

                        if (search.Employee.Count>0)
                        {
                            Delete_People_ImageFile(search);
                        }

                        if (search.Book.Count > 0)
                        {
                            Delete_Book_ImageFile(search);
                        }

                        try
                        {

                            dbSet.Remove(search);
                            _Context.SaveChanges();
                            MessageControl messageControl = new MessageControl()
                            {
                                Code = MessageCode.correct,
                                Error = false,
                                Type = MessageType.Delete,
                                Note =$"{name} with {Identificator} = {id} was delete with exit"
                            };
                            messages.Add(messageControl);
                        }
                        catch (SqlException e){
                            MessageControl messageControl = new MessageControl()
                            {
                                Code = MessageCode.exception,
                                Error = true,
                                Type = MessageType.Exception,
                                Note = $"{e.InnerException.InnerException.Message}"
                            };
                            messages.Add(messageControl);
                        }
                        catch(Exception e)
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

        private void Delete_Book_ImageFile(ImageFile file)
        {
            foreach (Book book in file.Book)
            {
                var query = $"Delete from BookImageFile where IdBook ='{book.IdBook}';";
                try
                {
                    _Context.Database.ExecuteSqlCommand(query);
                    MessageControl messageControl = new MessageControl()
                    {
                        Code = MessageCode.correct,
                        Error = false,
                        Type = MessageType.Delete,
                        Note = $"BookImageFile with IdBook ={book.IdBook} was deleted with exit",
                    };
                    messages.Add(messageControl);
                }
                catch (DbUpdateException e)
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
        private void Delete_People_ImageFile(ImageFile file)
        {
            foreach (Employee employee in file.Employee)
            {
                var query = $"Delete from EmployeeImageFile where IdEmployee ='{employee.IdPerson}';";
                try
                {
                    _Context.Database.ExecuteSqlCommand(query);
                    MessageControl messageControl = new MessageControl()
                    {
                        Code = MessageCode.correct,
                        Error = false,
                        Type = MessageType.Delete,
                        Note = $"EmployeeImageFile with IdEmployee ={employee.IdPerson} was deleted with exit",
                    };
                    messages.Add(messageControl);
                }
                catch (DbUpdateException e)
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
      


    }
}