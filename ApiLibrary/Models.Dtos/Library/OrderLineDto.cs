﻿using Core.Models.Abstracts;

namespace Models.Dtos
{
    public class OrderLineDto : IEntity
    {
        public string IdOrderLine { get; set; }
        public string IdOrder { get; set; }
        public string IdBook { get; set; }
        public int Quantity { get; set; }
        public System.DateTime CreateDate { get; set; }
        public System.DateTime LastUpdateDate { get; set; }
        public int StatusCode { get; set; }
        public string _Id { get => IdOrderLine; set => IdOrderLine = value; }
    }
}