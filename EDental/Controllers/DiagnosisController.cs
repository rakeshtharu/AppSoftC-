using EDental.Data;
using EDental.Data.Models;
using Microsoft.AspNetCore.Mvc;

public class DiagnosisController : Controller
{
    public IActionResult Index()
    {
        var db = new EDentalDbContext();
        var diagnosis = db.Diagnosis.ToList();
        return View(diagnosis);
    }
    [HttpGet]
    public IActionResult Add()
    {
        return View();
    }
    public IActionResult Add(Diagnosis diagnosis)
    {
        var db = new EDentalDbContext();
        db.Diagnosis.Add(diagnosis);
        db.SaveChanges();
        return RedirectToAction(nameof(Index));
    }
    [HttpGet]
    public IActionResult Update(int id)
    {
        var db = new EDentalDbContext();
        var diagnosis = db.Diagnosis.Find(id);
        return View(diagnosis);
    }

    [HttpPost]
    public IActionResult Update(Diagnosis diagnosis)
    {
        var db = new EDentalDbContext();
        db.Diagnosis.Update(diagnosis);
        db.SaveChanges();
        return RedirectToAction(nameof(Index));
    }

    [HttpGet]
    public IActionResult Delete(int id)
    {
        var db = new EDentalDbContext();
        var diagnosis = db.Diagnosis.Find(id);
        return View(diagnosis);
    }

    [HttpPost]
    public IActionResult Delete(Diagnosis diagnosis)
    {
        //Save to db
        var db = new EDentalDbContext();
        db.Diagnosis.Remove(diagnosis);
        db.SaveChanges();
        return RedirectToAction(nameof(Index));
    }
}