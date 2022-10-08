using System.Collections.Generic;

namespace ApiRest.Model.Repo
{
    public interface IMemoryProduct
    {
        IEnumerable<Product> GetAll(); //lista

        Product GetById(int id); //por id
    }
}
