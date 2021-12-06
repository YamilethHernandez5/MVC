using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Asp.NEt.Models;

namespace Asp.NEt.Controllers
{
    public class PersonalController : Controller
    {
      public IActionResult Index()
      {
          Personal personal = new Personal();
          personal.Name = "Julissa";
          personal.Lastname = "Claros";
          personal.Age = 18;
          return View(personal);
      }
        
     
    }
}