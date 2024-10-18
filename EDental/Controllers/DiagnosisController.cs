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
    public IActionResult add()
    {
        return View();
    }
    public IActionResult add(Diagnosis diagnosis)
    {
        var db = new EDentalDbContext();
        db.Diagnosis.Add(diagnosis);
        db.SaveChanges();
        return RedirectToAction(nameof(Index));
    }
}