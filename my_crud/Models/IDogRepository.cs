using System.Collections.Generic;
using my_crud.Models;

namespace my_crud.Models
{
    public interface IDogRepository
    {
        Dog GetById(int id);
        List<Dog>GetAll();
        void Create (Dog dog);
        void Delete (int id);
        void Update (Dog dog);
    }
}