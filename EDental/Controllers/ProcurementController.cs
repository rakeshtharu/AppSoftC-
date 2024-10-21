using EDental.Data;
using EDental.Data.Models;
using Microsoft.AspNetCore.Mvc;

public class ProcurementController : Controller
{
    public IActionResult Index()
    {
        var db = new EDentalDbContext();
        var procurement = db.Procurement.ToList();
        return View(procurement);
    }
    [HttpGet]
    public IActionResult Add()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Add(Procurement procurement)
    {
        //Save to db
        var db = new EDentalDbContext();
        db.Procurement.Add(procurement);
        db.SaveChanges();
        return RedirectToAction(nameof(Index));
    }

    [HttpGet]
    public IActionResult Delete(int id)
    {
        var db = new EDentalDbContext();
        var procurement = db.Procurement.Find(id);
        return View(procurement);
    }

    [HttpPost]
    public IActionResult Delete(Procurement procurement)
    {
        //Save to db
        var db = new EDentalDbContext();
        db.Procurement.Remove(procurement);
        db.SaveChanges();
        return RedirectToAction(nameof(Index));
    }
    [HttpGet]
    public IActionResult Update(int id)
    {
        var db = new EDentalDbContext();
        var procurement = db.Procurement.Find(id);

        return View(procurement);
    }

    [HttpPost]
    public IActionResult Update(Procurement procurement)
    {
        //Save to db
        var db = new EDentalDbContext();
        db.Procurement.Update(procurement);
        db.SaveChanges();
        return RedirectToAction(nameof(Index));
    }
}