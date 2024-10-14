using EDental.Data;
using Microsoft.AspNetCore.Mvc;

public class DoctorsController: Controller
{
    public IActionResult Index()
    {
        var db = new EDentalDbContext();
        var doctors = db.Doctors.ToList();
        return View(doctors);
    }
}