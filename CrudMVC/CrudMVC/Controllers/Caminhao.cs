using CrudMVC.Models;
using CrudMVC.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;

namespace CrudMVC.Controllers
{
    public class Caminhao : Controller
    {
        private readonly ICaminhaoRepositorio _caminhaoRepositorio;
        
        public Caminhao(ICaminhaoRepositorio caminhaoRepositorio) 
        {
            _caminhaoRepositorio = caminhaoRepositorio; 
        }
        public IActionResult Index()
        {
            List<CaminhaoModel> caminhaos = _caminhaoRepositorio.BuscarTodos();
            return View(caminhaos);
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Edit(int id)
        {
            CaminhaoModel caminhao = _caminhaoRepositorio.ListarPorId(id);
            return View(caminhao);
        }

        public IActionResult Delete(int id)
        {
            CaminhaoModel caminhao = _caminhaoRepositorio.ListarPorId(id);
            return View(caminhao);
        }

        public IActionResult Deletar (int id)
        {
            _caminhaoRepositorio.Apagar(id);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Create(CaminhaoModel caminhao)
        {
            if (ModelState.IsValid)
            {
                _caminhaoRepositorio.Adicionar(caminhao);
                return RedirectToAction("Index");
            }
            else
            {
                return View(caminhao);
            }
            
        }
        [HttpPost]
        public IActionResult Edit(CaminhaoModel caminhao)
        {
            _caminhaoRepositorio.Atualizar(caminhao);
            return RedirectToAction("Index");
        }
        public IActionResult Details(int id)
        {
            CaminhaoModel caminhao = _caminhaoRepositorio.ListarPorId(id);
            return View(caminhao);
        }
    }
}
