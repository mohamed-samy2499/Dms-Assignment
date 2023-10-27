using DmsAssignment.Application.Feature.DeviceCategories.Queries.Models;
using DmsAssignment.Application.Feature.DeviceCategories.Queries.Response;
using DmsAssignment.Application.Feature.Devices.Commands.Models;
using DmsAssignment.Application.Feature.Devices.Queries.Models;
using DmsAssignment.MVC.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Diagnostics;

namespace DmsAssignment.MVC.Controllers
{
    public class DeviceController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IMediator _mediator;
        public DeviceController(ILogger<HomeController> logger, IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
        }

        public async Task<IActionResult> Index()
        {
            var devices = await _mediator.Send(new GetDeviceListQuery());
            return View(devices.Data);
        }
        public async Task<IActionResult> Details(int Id)
        {
            var getDeviceByIdQuery = new GetDeviceByIdQuery()
            {
                Id = Id
            };
            var devices = await _mediator.Send(getDeviceByIdQuery);
            return View(devices.Data);
        }
        public async Task<IActionResult> DeviceCategory()
        {
            var result = await _mediator.Send(new GetDeviceCategoryListQuery());
            return View(result.Data);
        }
        [HttpGet]
        public async Task<IActionResult> Create(int DeviceCategoryId)
        {
            if(DeviceCategoryId > 0)
            {

                // Send the query to retrieve DeviceCategory with properties
                var query = new GetDeviceCategoryByIdQuery { Id = DeviceCategoryId }; 
                var response = await _mediator.Send(query);


                ViewData["CategoryName"] = response.Data.Name;
                ViewData["CategoryId"] = DeviceCategoryId;


                ViewBag.DeviceCategoryProperties = response.Data.Properties; // Store it in ViewBag

                return View();
            }
            else
            {
                return RedirectToAction("DeviceCategory");   
            }
        }
        [HttpPost]
        public async Task<IActionResult> Create(AddDeviceCommand command)
        {
            var result  = await _mediator.Send(command);
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}