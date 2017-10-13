using Microsoft.AspNetCore.Mvc;
using my_crud.Models;

namespace my_crud.Controllers
{
    
    public class DogController : Controller
    {
        private IDogRepository _repository; 

        public DogController(IDogRepository repository)
        {
            _repository = repository;
        }

        public IActionResult Index()
        {
            var dogs = _repository.GetAll();
            return View(dogs);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Dog dog)
        {
            _repository.Create(dog);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            _repository.Delete(id);
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            return View(_repository.GetById(id));
        }

        [HttpPost]
        public IActionResult Edit(Dog dog)
        {
            _repository.Update(dog);
            return RedirectToAction("Index");
        }
       
    }
        
}