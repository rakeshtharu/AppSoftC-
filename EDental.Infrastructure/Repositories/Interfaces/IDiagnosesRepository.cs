using EDental.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDental.Infrastructure.Repositories.Interfaces;
    public interface IDiagnosesRepository
    {
        public List<Diagnosis> Get();
        public Diagnosis Get(int id);
        public int Insert(Diagnosis diagnosis);
        public int Update(Diagnosis diagnosis);
        public int Delete(Diagnosis diagnosis);
    }
