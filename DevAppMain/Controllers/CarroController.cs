using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DevAppMain.Areas.Identity.Data;
using DevAppMain.ViewModels;
using Dev.Business.Interfaces;
using AutoMapper;
using Dev.Business.Models;
using Dev.Business.Enumeradores;

namespace DevAppMain.Controllers
{
    //[Route("carro")]
    public class CarroController : Controller
    {
        private readonly ICarroRepositorio _contextCarro;
        private readonly IMapper _mapper;

        public CarroController(ICarroRepositorio carro, IMapper mapper)
        {
            _contextCarro = carro;
            _mapper = mapper;
        }

        // GET: Carro
        public async Task<IActionResult> Index()
        {
            return View(_mapper.Map<IEnumerable<CarroViewModel>>( await _contextCarro.ObterTodos()));
        
        }

        // GET: Carro/Details/5
        public async Task<IActionResult> Details(Guid id)
        {
            
            var carroViewModel = await _contextCarro.Buscar(m => m.Id == id);
                
            if (carroViewModel == null)
            {
                return NotFound();
            }

            return View(carroViewModel);
        }

        // GET: Carro/Create
        //[HttpGet("criar")]
        public IActionResult Create()
        {
            return View();
        }

     
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CarroViewModel carroViewModel)
        {
            carroViewModel.Status = StatusCarro.ParaVenda;
            if (ModelState.IsValid)
            {
                carroViewModel.Id = Guid.NewGuid();
                await _contextCarro.Adicionar(_mapper.Map<Carro>(carroViewModel));
                await _contextCarro.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(carroViewModel);
        }

        // GET: Carro/Edit/5
        //public async Task<IActionResult> Edit(Guid? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var carroViewModel = await _context.CarroViewModel.FindAsync(id);
        //    if (carroViewModel == null)
        //    {
        //        return NotFound();
        //    }
        //    ViewData["ConcessionariaId"] = new SelectList(_context.Set<Concessionaria>(), "Id", "Id", carroViewModel.ConcessionariaId);
        //    return View(carroViewModel);
        //}

        //// POST: Carro/Edit/5
        //// To protect from overposting attacks, enable the specific properties you want to bind to.
        //// For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(Guid id, [Bind("Id,Ano,ConcessionariaId,ClienteId,Placa,Imagem,DataEntrada,DataSaida,Status")] CarroViewModel carroViewModel)
        //{
        //    if (id != carroViewModel.Id)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            _context.Update(carroViewModel);
        //            await _context.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!CarroViewModelExists(carroViewModel.Id))
        //            {
        //                return NotFound();
        //            }
        //            else
        //            {
        //                throw;
        //            }
        //        }
        //        return RedirectToAction(nameof(Index));
        //    }
        //    ViewData["ConcessionariaId"] = new SelectList(_context.Set<Concessionaria>(), "Id", "Id", carroViewModel.ConcessionariaId);
        //    return View(carroViewModel);
        //}

        //// GET: Carro/Delete/5
        //public async Task<IActionResult> Delete(Guid? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var carroViewModel = await _context.CarroViewModel
        //        .Include(c => c.Concessionaria_EF)
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (carroViewModel == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(carroViewModel);
        //}

        //// POST: Carro/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(Guid id)
        //{
        //    var carroViewModel = await _context.CarroViewModel.FindAsync(id);
        //    _context.CarroViewModel.Remove(carroViewModel);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        //private bool CarroViewModelExists(Guid id)
        //{
        //    return _context.CarroViewModel.Any(e => e.Id == id);
        //}
    }
}
