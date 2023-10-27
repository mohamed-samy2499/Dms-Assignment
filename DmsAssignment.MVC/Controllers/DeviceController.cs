using AutoMapper;
using DmsAssignment.Application.Feature.DeviceCategories.Queries.Models;
using DmsAssignment.Application.Feature.DeviceCategories.Queries.Response;
using DmsAssignment.Application.Feature.Devices.Commands.Models;
using DmsAssignment.Application.Feature.Devices.Queries.Models;
using DmsAssignment.Domain.Entities;
using DmsAssignment.MVC.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Diagnostics;

namespace DmsAssignment.MVC.Controllers
{
    public class DeviceController : Controller
    {
        #region Ctor
        private readonly ILogger<HomeController> _logger;
        private readonly IMediator _mediator;
        private IMapper _mapper;
        public DeviceController(ILogger<HomeController> logger, IMediator mediator, IMapper mapper)
        {
            _logger = logger;
            _mediator = mediator;
            _mapper = mapper;
        }
        #endregion

        #region Index Action
        public async Task<IActionResult> Index()
        {
            var devices = await _mediator.Send(new GetDeviceListQuery());
            return View(devices.Data);
        }
        #endregion

        #region Details Action
        public async Task<IActionResult> Details(int id, string ViewName = "Details")
        {
            try
            {

                var getDeviceByIdQuery = new GetDeviceByIdQuery()
                {
                    Id = id
                };
                var devices = await _mediator.Send(getDeviceByIdQuery);
                return View(ViewName , devices.Data);
            }
            catch (Exception ex)
            {
                return RedirectToAction(nameof(Index));
            }
        }
        #endregion

        #region Create Action
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
        #endregion

        #region Edit Action
        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            if (id > 0)
            {
                var getDeviceByIdQuery = new GetDeviceByIdQuery()
                {
                    Id = id
                };
                var device = await _mediator.Send(getDeviceByIdQuery);
                var getDeviceResponse = device.Data;
                var updateDeviceCommand = _mapper.Map<UpdateDeviceCommand>(getDeviceResponse);

                List<DevicePropertyCommand> properties = new List<DevicePropertyCommand>();
                int index = 0;
                foreach (var index1 in getDeviceResponse.PropertiesIds)
                {
                    KeyValuePair<string, string> item = getDeviceResponse.PropertiesWithValues.ElementAt(index);
                    properties.Add(new DevicePropertyCommand
                    {
                        PropertyId = index1,
                        Value = item.Value
                    });
                    index++;
                }
                updateDeviceCommand.Properties = properties;
                ViewData["CatName"] = getDeviceResponse.DeviceCategoryName;
                List<string> PropertyNames = new List<string>();
                foreach(var item in getDeviceResponse.PropertiesWithValues)
                {
                    PropertyNames.Add(item.Key);
                } 
                ViewBag.PropertyNames = PropertyNames;  
                return View(updateDeviceCommand);
            }
            return RedirectToAction(nameof(Index));
        }
        
        [HttpPost]

        public async Task<IActionResult> Edit(UpdateDeviceCommand command)
        {
            var result  = await _mediator.Send(command);
            if (result.Succeeded)
                return RedirectToAction(nameof(Index));
            return View(result);
        }
        #endregion
      
        #region Delete
        public async Task<IActionResult> Delete(int id)
        {
            var getDeviceByIdQuery = new GetDeviceByIdQuery()
            {
                Id = id
            };
            var devices = await _mediator.Send(getDeviceByIdQuery);
            return View(devices.Data);
        }
        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id, UpdateDeviceCommand deviceCommand)
        {
            if (id != deviceCommand.Id)
                return NotFound();
            try
            {
                var deleteDeviceCommand = new DeleteDeviceCommand()
                {
                    Id = id
                };
                var result = await _mediator.Send(deleteDeviceCommand);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return NotFound();
            }
        }
        #endregion

    }
}