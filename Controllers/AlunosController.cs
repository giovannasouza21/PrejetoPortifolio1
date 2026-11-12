
using Mecanica.api.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PrejetoPortifolio1.models;

namespace PrejetoPortifolio1.Controllers
{
    public class AlunosController : Controller
    {
        private readonly AppDbContext _context;

        public AlunosController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Alunos
        public async Task<IActionResult> Index()
        {
            return View(await _context.alunos.ToListAsync());
        }

        // GET: Alunos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aluno = await _context.alunos.FindAsync(id);

            if (aluno == null)
            {
                return NotFound();
            }

            return View(aluno);
        }

        // GET: Alunos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Alunos/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Aluno aluno)
        {
            if (!ModelState.IsValid)
            {
                return View(aluno);
            }

            _context.alunos.Add(aluno);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        // GET: Alunos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aluno = await _context.alunos.FindAsync(id);

            if (aluno == null)
            {
                return NotFound();
            }

            return View(aluno);
        }

        // POST: Alunos/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Aluno aluno)
        {
            if (id != aluno.Id)
            {
                return NotFound();
            }

            if (!ModelState.IsValid)
            {
                return View(aluno);
            }

            var alunoExistente = await _context.alunos.FindAsync(id);

            if (alunoExistente == null)
            {
                return NotFound();
            }

            alunoExistente.Nome = aluno.Nome;
            alunoExistente.Turma = aluno.Turma;
            alunoExistente.TurmaId = aluno.TurmaId;
            alunoExistente.QuemEVoce = aluno.QuemEVoce;
            alunoExistente.AreasDeAtuacao = aluno.AreasDeAtuacao;
            alunoExistente.Tecnologias = aluno.Tecnologias;
            alunoExistente.Habilidades = aluno.Habilidades;
            alunoExistente.Ferramentas = aluno.Ferramentas;

            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        // GET: Alunos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aluno = await _context.alunos.FindAsync(id);

            if (aluno == null)
            {
                return NotFound();
            }

            return View(aluno);
        }

        // POST: Alunos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var aluno = await _context.alunos.FindAsync(id);

            if (aluno == null)
            {
                return NotFound();
            }

            _context.alunos.Remove(aluno);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
    }
}
