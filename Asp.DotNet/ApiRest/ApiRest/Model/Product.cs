using System;

namespace ApiRest.Model
{
    public class Product
    {
        public int Id { get; init; } //EL ID ES ÚNICO
        public string Name { get; set; } //El set permite modificar
        public string Description { get; set; }
        public decimal Price { get; set; }
        public DateTime DateUpload { get; init; }
        public string Sku { get; set; }
    }
}
