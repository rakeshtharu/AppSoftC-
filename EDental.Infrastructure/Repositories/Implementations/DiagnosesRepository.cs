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

public class DiagnosesRepository(EDentalDbContext dbContext) : IDiagnosesRepository
{
    private readonly EDentalDbContext db = dbContext;
    public List<Diagnosis> Get()
    {
        var diagnoses = db.Diagnosis.ToList();
        return diagnoses;
    }
    public Diagnosis Get(int id)
    {
       var diagnoses = db.Diagnosis.Find(id);
       return diagnoses;
    }
    public int Delete(Diagnosis diagnosis)
    {
        db.Diagnosis.Remove(diagnosis);
        var rowsAffected = db.SaveChanges();
        return rowsAffected;
    }
    public int Insert(Diagnosis diagnosis)
    {
        db.Diagnosis.Add(diagnosis);
        var rowsAffected = db.SaveChanges();
        return rowsAffected;
    }

    public int Update(Diagnosis diagnosis)
    {
        db.Diagnosis.Update(diagnosis);
        var rowsAffected = db.SaveChanges();
        return rowsAffected;
    }
}
