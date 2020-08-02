using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Proyecto_Final.Models;

namespace Proyecto_Final.Controllers
{
        public class OperacionesController : Controller
        {
            // GET: Operaciones
            public ActionResult Index()
            {
                return View(new DatosOperaciones());
            }

            [HttpPost]
            public ActionResult Index(DatosOperaciones operaciones, string valor1)
            {
                if (valor1 == "sumar")
                {
                    operaciones.resultado = operaciones.num1 + operaciones.num2;
                }
                else if (valor1 == "restar")
                {
                    operaciones.resultado = operaciones.num1 - operaciones.num2;
                }
                else if (valor1 == "multiplicar")
                {
                    operaciones.resultado = operaciones.num1 * operaciones.num2;
                }
                else if (valor1 == "dividir")
                {
                    operaciones.resultado = operaciones.num1 / operaciones.num2;
                }

                return View(operaciones);
            }
        }
}