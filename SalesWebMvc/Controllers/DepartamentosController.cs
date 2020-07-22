using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Models;

namespace SalesWebMvc.Controllers
{
    public class DepartamentosController : Controller
    {
        public IActionResult Index() {
            List<Departamentos> list = new List<Departamentos>();
            list.Add(new Departamentos { Id = 1, Nome = "Eletronicos" });
            list.Add(new Departamentos { Id = 1, Nome = "Fashion" });

            return View(list);
            
        }
    }
}
