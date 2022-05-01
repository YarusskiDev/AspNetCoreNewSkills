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

namespace DevAppMain.Controllers
{
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
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var carroViewModel = await _contextCarro.Buscar(m => m.Id == id);
                
            if (carroViewModel == null)
            {
                return NotFound();
            }

            return View(carroViewModel);
        }

        //// GET: Carro/Create
        //public IActionResult Create()
        //{
        //    return View();
        //}

        //// POST: Carro/Create
        //// To protect from overposting attacks, enable the specific properties you want to bind to.
        //// For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create([Bind("Id,Ano,Placa,Imagem,DataEntrada,DataSaida,Status")] CarroViewModel carroViewModel)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        carroViewModel.Id = Guid.NewGuid();
        //        _contextCarro.Adicionar(carroViewModel);
        //        await _contextCarro.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(carroViewModel);
        //}

        //// GET: Carro/Edit/5
        //public async Task<IActionResult> Edit(Guid? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var carroViewModel = await _contextCarro.CarroViewModel.FindAsync(id);
        //    if (carroViewModel == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(carroViewModel);
        //}

        //// POST: Carro/Edit/5
        //// To protect from overposting attacks, enable the specific properties you want to bind to.
        //// For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(Guid id, [Bind("Id,Ano,Placa,Imagem,DataEntrada,DataSaida,Status")] CarroViewModel carroViewModel)
        //{
        //    if (id != carroViewModel.Id)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            _contextCarro.Update(carroViewModel);
        //            await _contextCarro.SaveChangesAsync();
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
        //    return View(carroViewModel);
        //}

        //// GET: Carro/Delete/5
        //public async Task<IActionResult> Delete(Guid? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var carroViewModel = await _contextCarro.CarroViewModel
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
        //    var carroViewModel = await _contextCarro.CarroViewModel.FindAsync(id);
        //    _contextCarro.CarroViewModel.Remove(carroViewModel);
        //    await _contextCarro.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        //private bool CarroViewModelExists(Guid id)
        //{
        //    return _contextCarro.CarroViewModel.Any(e => e.Id == id);
        //}
    }
}
