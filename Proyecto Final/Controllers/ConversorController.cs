using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Proyecto_Final.Models;

namespace Proyecto_Final.Controllers
{
    public class ConversorController : Controller
    {
        // GET: Conversor
        public ActionResult Index()
        {
            return View(new DatosOperaciones());
        }

            [HttpPost]

            public ActionResult Index(DatosOperaciones operaciones, string valor1)
            {
                
                if (valor1 == "dolar")
                {
                    operaciones.resultado = operaciones.num1 * 58.58;
                }

                else if (valor1 == "peso")
                {
                    operaciones.resultado = operaciones.num1 / 58.58;
                }

                else if (valor1 == "celsius")
                {
                    operaciones.resultado = (operaciones.num1 - 32) / 1.8;
                }
                else if (valor1 == "fahrenheit")
                {
                    operaciones.resultado = (operaciones.num1 * 1.8) + 32;
                }
                return View(operaciones);
            }
        }
    }