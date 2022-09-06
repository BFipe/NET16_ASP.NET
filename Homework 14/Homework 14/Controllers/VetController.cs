using Microsoft.AspNetCore.Mvc;
using Homework_14.Models;
using System;

namespace Homework_14.Controllers
{
    public class VetController : Controller
    {
        [HttpGet]
        public IActionResult VetApplication()
        {
            ModelState.Clear();
            return View();
        }


        [HttpPost]
        public IActionResult VetApplication(DogViewModel dog)
        {
            Console.WriteLine($"Pet name: {dog.PetName}, age: {dog.PetAge}, weight: {dog.PetWeight}, owner: {dog.OwnerName}");
            return VetApplication();
        }
    }
}

