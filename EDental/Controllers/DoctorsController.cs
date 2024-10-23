using EDental.Data;
using EDental.Data.Models;
using EDental.Infrastructure.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Numerics;

public class DoctorsController(IDoctorsRepository doctorsRepository): Controller
{
   private readonly IDoctorsRepository doctorsRepository = doctorsRepository;  //Dependancy Injection(DI)
    public IActionResult Index()
    {
        var doctors = doctorsRepository.Get();
        return View(doctors);
    }

    [HttpGet]
    public IActionResult Add()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Add(Doctors doctors)
    {
       doctorsRepository.Insert(doctors);
        return RedirectToAction(nameof(Index));
    }
    [HttpGet]
    public IActionResult Update(int id)
    {
        var doctors = doctorsRepository.Get(id);
        return View(doctors);
    }

    [HttpPost]
    public IActionResult Update(Doctors doctors)
    {
        doctorsRepository.Update(doctors);
        return RedirectToAction(nameof(Index));
    }

    [HttpGet]
    public IActionResult Delete(int id)
    {
        var doctors = doctorsRepository.Get(id);
        return View(doctors);
    }

    [HttpPost]
    public IActionResult Delete(Doctors doctors)
    {
        //Save to db
        doctorsRepository.Delete(doctors);
        return RedirectToAction(nameof(Index));
    }
}