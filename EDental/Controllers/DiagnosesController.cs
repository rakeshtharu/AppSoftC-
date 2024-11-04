using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EDental.Data.Models;
using EDental.Infrastructure.Repositories.Interfaces;

namespace EDental.Controllers
{
    public class DiagnosesController(IDiagnosesRepository diagnosesRepository) : Controller
    {
        private readonly IDiagnosesRepository _diagnosesRepository = diagnosesRepository;

        // GET: Diagnoses
        public async Task<IActionResult> Index()
        {
            var diagnoses = _diagnosesRepository.Get().ToList();
            return View();
        }


        // GET: Diagnoses/Details/5
        public async Task<IActionResult> Details(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var diagnosis = _diagnosesRepository.Get(id);
            if (diagnosis == null)
            {
                return NotFound();
            }

            return View(diagnosis);
        }

        // GET: Diagnoses/Create
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,DiagnosisName,Procedures,Medication")] Diagnosis diagnosis)
        {
            if (ModelState.IsValid)
            {
                _diagnosesRepository.Insert(diagnosis);
                return RedirectToAction(nameof(Index));
            }
            return View(diagnosis);
        }
        public async Task<IActionResult> Edit(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var diagnosis = _diagnosesRepository.Get(id);
            if (diagnosis == null)
            {
                return NotFound();
            }
            return View(diagnosis);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,DiagnosisName,Procedures,Medication")] Diagnosis diagnosis)
        {
            if (id != diagnosis.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _diagnosesRepository.Update(diagnosis);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DiagnosisExists(diagnosis.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(diagnosis);
        }
        public async Task<IActionResult> Delete(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var diagnosis = _diagnosesRepository.Get(id);
            if (diagnosis == null)
            {
                return NotFound();
            }

            return View(diagnosis);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var diagnosis = _diagnosesRepository.Get(id);
            if (diagnosis != null)
            {
                _diagnosesRepository.Delete(diagnosis);
            }

            return RedirectToAction(nameof(Index));
        }

        private bool DiagnosisExists(int id)
        {
            var data = _diagnosesRepository.Get(id);
            if (data != null)
            {
                return true;
            }
            return false;
        }
    }
}
