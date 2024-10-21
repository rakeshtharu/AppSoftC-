using EDental.Data;
using EDental.Data.Models;
using Microsoft.AspNetCore.Mvc;

public class DoctorsController: Controller
{
    public IActionResult Index()
    {
        var db = new EDentalDbContext();
        var doctors = db.Doctors.ToList();
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
        //Save to db
        var db = new EDentalDbContext();
        db.Doctors.Add(doctors);
        db.SaveChanges();
        return RedirectToAction(nameof(Index));
    }

    [HttpGet]
    public IActionResult Delete(int id)
    {
        var db = new EDentalDbContext();
        var doctor = db.Doctors.Find(id);
        return View(doctor);
    }

    [HttpPost]
    public IActionResult Delete(Doctors doctors)
    {
        //Save to db
        var db = new EDentalDbContext();
        db.Doctors.Remove(doctors);
        db.SaveChanges();
        return RedirectToAction(nameof(Index));
    }
    [HttpGet]
    public IActionResult Update(int id)
    {
        var db = new EDentalDbContext();
        var doctor = db.Doctors.Find(id);

        return View(doctor);
    }

    [HttpPost]
    public IActionResult Update(Doctors doctors)
    {
        //Save to db
        var db = new EDentalDbContext();
        db.Doctors.Update(doctors);
        db.SaveChanges();
        return RedirectToAction(nameof(Index));
    }
}