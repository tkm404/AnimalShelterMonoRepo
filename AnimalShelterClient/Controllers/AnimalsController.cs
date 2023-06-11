using Microsoft.AspNetCore.Mvc;
using AnimalShelterClient.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using PagedList;

namespace AnimalShelterClient.Controllers;

public class AnimalsController : Controller
{
  // public IActionResult Index()
  // {
  //   List<Animal> animals = Animal.GetAnimals();
  //   return View(animals);
  // }

  public IActionResult Index(int? page)
  // public async Task<IActionResult>
  {
    page = 1;
    List<Animal> animals = Animal.GetAnimals();
    int pageSize = 3;
    int pageNumber = (page ?? 1);
    return View(animals.ToPagedList(pageNumber, pageSize));
    // return View(await PaginatedList<Animal>.CreateAsync(animals.AsNoTracking(), pageNumber ?? 1, pageSize));
  }


  public IActionResult Search()
  {
    List<Animal> animals = Animal.GetAnimals();
    return View(animals);
  } 

  [HttpPost]
  public IActionResult Search(string category, string searchParam)
  {
    List<Animal> animals = Animal.GetSearch(category, searchParam);
    return View(animals);

  }

  public IActionResult Details(int id)
  {
    Animal animal = Animal.GetDetails(id);
    return View(animal);
  }

  public ActionResult Create()
  {
    return View();
  }

  [HttpPost]
  public ActionResult Create(Animal animal)
  {
    Animal.Post(animal);
    return RedirectToAction("Index");
  }

  public ActionResult Edit(int id)
  {
    Animal animal = Animal.GetDetails(id);
    return View(animal);
  }

  [HttpPost]
  public ActionResult Edit(Animal animal)
  {
    Animal.Put(animal);
    return RedirectToAction("Details", new {id = animal.AnimalId});
  }

  public ActionResult Delete(int id)
  {
    Animal animal = Animal.GetDetails(id);
    return View(animal);
  }

  [HttpPost, ActionName("Delete")]
  public ActionResult DeleteConfirmed(int id)
  {
    Animal.Delete(id);
    return RedirectToAction("Index");
  }
}