using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace my_crud.Models
{
    public class DogRepository : IDogRepository
    {
        private DataContext context;

        public DogRepository(DataContext context)
        {
            this.context = context;
        }
        


        List<Dog> IDogRepository.GetAll()
        {
            return context.Dogs.ToList();
        }

        void IDogRepository.Create(Dog dog)
        {
            context.Dogs.Add(dog);
            context.SaveChanges();
        }

        void IDogRepository.Delete(int id)
        {
            context.Dogs.Remove(GetById(id));
            context.SaveChanges();
        }

        public Dog GetById(int id){
            return context.Dogs.SingleOrDefault(x=>x.id == id);
        }

        void IDogRepository.Update(Dog dog)
        {
            context.Entry(dog).State = EntityState.Modified;
            context.SaveChanges();
        }
    
    // public static List<Dog> dogs = new List<Dog>();

    //     public DogRepository()
    //     {
    //         if (dogs.Count == 0)
    //             Fill();
    //     }

    //     public void Fill(){

    //     }

    //     public void Delete(int id)
    //     {
    //         dogs.Remove(dogs.Find(x=>x.id==id));
    //     }

    //     public void Create(Dog dog)
    //     {
    //         dogs.Add(dog);
    //     }

    //     public void Update(Dog dog)
    //     {
    //         Delete(dog.id);
    //         Create(dog);
    //     }

    //     public Dog GetById(int id)
    //     {
    //         return dogs.Find(x=>x.id==id);
    //     }
    //     public List<Dog> GetAll()
    //     {
    //         return dogs;
    //     }
    }
}