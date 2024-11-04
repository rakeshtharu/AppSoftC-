using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using EDental.Data;
using EDental.Data.Models;
using EDental.Infrastructure.Repositories.Interfaces;

namespace EDental.Infrastructure.Repositories.Implementations;

public class DoctorsRepository(EDentalDbContext dbContext) : IDoctorsRepository
{
    private readonly EDentalDbContext db = dbContext;
    public List<Doctors> Get()
    {
        var doctors = db.Doctors.ToList();
        return doctors;
    }

    public Doctors Get(int id)
    {
        var doctors = db.Doctors.Find(id);
        return doctors;
    }
    public int Insert(Doctors doctors)
    {
        db.Doctors.Add(doctors);
        var rowsAffected = db.SaveChanges();
        return rowsAffected;
    }
    public int Update(Doctors doctors)
    {
        db.Doctors.Update(doctors);
        var rowsAffected = db.SaveChanges();
        return rowsAffected;
    }
    public int Delete(Doctors doctors)
    {
        db.Doctors.Remove(doctors);
        var rowsAffected = db.SaveChanges();
        return rowsAffected;
    }
}
