﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalDataBase.Controllers
{
    public class EmployeeListController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}