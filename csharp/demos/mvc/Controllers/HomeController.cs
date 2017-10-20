using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using mvc.Models;

namespace mvc.Controllers
{
    public class HomeController : Controller
    {
        // Method which generates index at default route
        [HttpGet]
        [Route("")]
        public string Index()
        {
            return "Hello World";
        }

        // Example to use URL parameter to return string value
        [HttpGet]
        [Route("string/{value}")]
        public string StringProcessor(string value)
        {
            return value;
        }

        // Example to use URL parameter to create Json data
        [HttpGet]
        [Route("json/{value}")]
        public JsonResult JsonProcessor(string value)
        {
            return Json(value);
        }
    }
}
