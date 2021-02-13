using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SmartHome.Web.ApiModels;

namespace SmartHome.Web.Controllers
{
    public class DeviceController : Controller
    {
        public ViewResult Index()
        {
            Device device = new Device();
            return View(device);
        }
    }
}