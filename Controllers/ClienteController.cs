using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using mvc_entity.Models;
using mvc_entity.Servicos;

namespace mvc_entity.Controllers
{
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly DbContexto _context;

        public ClienteController(DbContexto context)
        {
            _context = context;
        }

        // GET: /cliente
        [HttpGet]
        [Route("/cliente")]
        public async Task<IActionResult> Index()
        {
            return StatusCode(200, await _context.Clientes.ToListAsync());
        }

        // GET: /cliente/5
        [HttpGet]
        [Route("/cliente/{id}")]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cliente = await _context.Clientes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cliente == null)
            {
                return NotFound();
            }

            return StatusCode(200, cliente);
        }

       
        // POST: /clientes
        [Route("/cliente")]
        [HttpPost]
        public async Task<IActionResult> Create([Bind("Id,Nome,DataDeNascimento,Telefone,Rua,numero,Bairro,Cidade,Estado")] Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cliente);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return StatusCode(201, cliente);
        }        

        // PUT: cliente/5
        [HttpPut]
        [Route("/cliente/{id}")]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,DataDeNascimento,Telefone,Rua,numero,Bairro,Cidade,Estado")] Cliente cliente)
        {
           

            if (ModelState.IsValid)
            {
                try
                {
                    cliente.Id = id;
                    _context.Update(cliente);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ClienteExists(cliente.Id))
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
            return StatusCode(200, cliente);
        }        

        // DELETE: clientes/5
        [HttpDelete]
        [Route("/cliente/{id}")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cliente = await _context.Clientes.FindAsync(id);
            _context.Clientes.Remove(cliente);
            await _context.SaveChangesAsync();
            return StatusCode(204);
        }

        private bool ClienteExists(int id)
        {
            return _context.Clientes.Any(e => e.Id == id);
        }
    }
}
