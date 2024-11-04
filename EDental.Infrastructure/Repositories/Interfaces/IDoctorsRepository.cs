using EDental.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDental.Infrastructure.Repositories.Interfaces;
    public interface IDoctorsRepository
    {
        public List<Doctors> Get();
        public Doctors Get(int id);
        public int Insert(Doctors doctors);
        public int Update(Doctors doctors);
        public int Delete(Doctors doctors);
    }
