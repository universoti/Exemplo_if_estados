using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using webestados.Models.Estados;

namespace webestados.Controllers.Estados
{
    public class EstadosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult EstadoPesquisado(string id)
        {           
            EstadosViewModel selecionado = new EstadosViewModel();
            selecionado = new ListarEstadosViewModel().ListarEstadosPesq().Where(c => c.Sigla == id).FirstOrDefault();

            ViewBag.Sigla = selecionado.Sigla;
            ViewBag.Descricao = selecionado.NomeEstado;
            ViewBag.Aliquota = selecionado.Aliquota;
            
            return View();
        }
    }
}