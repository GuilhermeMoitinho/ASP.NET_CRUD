using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using DIVTECH2.Context;
using DIVTECH2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DIVTECH2.Controllers
{
    public class FornecedorController : Controller
    {
        private readonly EmpresaContext _context;
        public FornecedorController(EmpresaContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var fornecedorbanco = _context.Fornecedores.ToList();
            return View(fornecedorbanco);
        }

        public IActionResult Criar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Criar(FornecedorModel fornecedor)
        {
            try{
                if (!ModelState.IsValid)
                {
                    ViewData["message"] = "Informações inválidas";
                }

                _context.Fornecedores.Add(fornecedor);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));

            }catch(Exception x){
                ViewData["error"] = "Ocorreu um erro ao criar o fornecedor.";
                return View(fornecedor);
            }
        }

          public IActionResult Editar(int id)
        {
            var fornecedorbanco = _context.Fornecedores.Find(id);

            if(fornecedorbanco == null)
            {
                return RedirectToAction(nameof(Index));
            }

            return View(fornecedorbanco);
        }

        
        [HttpPost]
        public IActionResult Editar(FornecedorModel fornecedor)
        {
            try{
                var fornecedorbanco = _context.Fornecedores.Find(fornecedor.Id);

                fornecedorbanco.Nome = fornecedor.Nome;
                fornecedorbanco.CNPJ = fornecedor.CNPJ;
                fornecedorbanco.Especialidade = fornecedor.Especialidade;
                fornecedorbanco.CEP = fornecedor.CEP;
                fornecedorbanco.Endereco = fornecedor.Endereco;

                _context.Fornecedores.Update(fornecedorbanco);
                _context.SaveChanges();

                return RedirectToAction(nameof(Index));

            }catch(Exception x){
                ViewData["error"] = "Ocorreu um erro ao Editar o fornecedor.";
                return View(fornecedor);
            }
        }

          public IActionResult Deletar(int id)
        {
            var fornecedoresbanco = _context.Fornecedores.Find(id);

            if(fornecedoresbanco == null)
            {
                return RedirectToAction(nameof(Index));
            }

            return View(fornecedoresbanco);
        }

         [HttpPost]
        public IActionResult Deletar(FornecedorModel fornecedor)
        {
            try{
                var fornecedoresbanco = _context.Fornecedores.Find(fornecedor.Id);

                _context.Fornecedores.Remove(fornecedoresbanco);
                _context.SaveChanges();

                return RedirectToAction(nameof(Index));

            }catch(Exception x){
                ViewData["error"] = "Ocorreu um erro ao criar o fornecedor.";
                return View(fornecedor);
            }
        }

          public IActionResult Detalhes(int id)
        {
            
            var fornecedoresbanco = _context.Fornecedores.Find(id);

            if(fornecedoresbanco == null)
            {
                return RedirectToAction(nameof(Index));
            }

            return View(fornecedoresbanco);
        }

    }
}