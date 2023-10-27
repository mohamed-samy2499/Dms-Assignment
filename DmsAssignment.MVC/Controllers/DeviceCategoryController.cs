using AutoMapper;
using DmsAssignment.Application.Feature.DeviceCategories.Queries.Models;
using DmsAssignment.Application.Feature.DeviceCategories.Queries.Response;
using DmsAssignment.Application.Feature.DeviceCategories.Commands.Models;
using DmsAssignment.Application.Feature.DeviceCategories.Queries.Models;
using DmsAssignment.Domain.Entities;
using DmsAssignment.MVC.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Diagnostics;
using DmsAssignment.Application.Feature.Properties.Queries.Models;
using Microsoft.AspNetCore.Identity;
using System.Data;
using DmsAssignment.Application.Feature.Properties.Queries.Response;
using DmsAssignment.Application.Feature.Devices.Commands.Models;

namespace DmsAssignment.MVC.Controllers
{
    public class DeviceCategoryController : Controller
    {
        #region Ctor
        private readonly ILogger<HomeController> _logger;
        private readonly IMediator _mediator;
        private IMapper _mapper;
        public DeviceCategoryController(ILogger<HomeController> logger, IMediator mediator, IMapper mapper)
        {
            _logger = logger;
            _mediator = mediator;
            _mapper = mapper;
        }
        #endregion

        #region Index Action
        public async Task<IActionResult> Index()
        {
            var devices = await _mediator.Send(new GetDeviceCategoryListQuery());
            return View(devices.Data);
        }
        #endregion

        #region Details Action
        public async Task<IActionResult> Details(int id)
        {
            try
            {

                var getDeviceCategoryByIdQuery = new GetDeviceCategoryByIdQuery()
                {
                    Id = id
                };
                var deviceCategory = await _mediator.Send(getDeviceCategoryByIdQuery);
                return View(deviceCategory.Data);
            }
            catch (Exception ex)
            {
                return RedirectToAction(nameof(Index));
            }
        }
        #endregion

        #region Create Action
        [HttpGet]
        public async Task<IActionResult> Create()
        {

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(AddDeviceCategoryCommand command)
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
                var AvailableProperties = await _mediator.Send(new GetPropertyListQuery());

                ViewBag.AvailableProperties = AvailableProperties.Data;
                var getDeviceCategoryByIdQuery = new GetDeviceCategoryByIdQuery()
                {
                    Id = id
                };
                var deviceCategory = await _mediator.Send(getDeviceCategoryByIdQuery);
                var getDeviceCategoryResponse = deviceCategory.Data;
                var existingProperties = getDeviceCategoryResponse.Properties;
                var propertyInCategoryList = new List<DeviceCategoryPropertyDto>();
                foreach(var item in AvailableProperties.Data)
                {
                    var deviceCategoryPropertyDto = new DeviceCategoryPropertyDto() {
                        PropertyId = item.Id,
                        PropertyName = item.Name
                    };
                    if (existingProperties.Contains(deviceCategoryPropertyDto, new DeviceCategoryPropertyDtoEqualityComparer()))
                        deviceCategoryPropertyDto.IsSelected = true;
                    else
                        deviceCategoryPropertyDto.IsSelected = false;
                    propertyInCategoryList.Add(deviceCategoryPropertyDto);
                }
                ViewBag.CatName = deviceCategory.Data.Name;
                ViewBag.CatId = id;

                return View(propertyInCategoryList);
            }
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]

        public async Task<IActionResult> Edit(List<DeviceCategoryPropertyDto> model,int id)
        {
            var deviceCategory = await _mediator.Send(new GetDeviceCategoryByIdQuery()
            {
                Id = id
            });
            var command  = new UpdateDeviceCategoryCommand() {
                Id = id,
                Name = deviceCategory.Data.Name,
                Properties = model
            };
            var result = await _mediator.Send(command);
            if (result.Succeeded)
                return RedirectToAction(nameof(Index));
            return View(result);
        }
        #endregion

        #region Delete
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var getDeviceCategoryByIdQuery = new GetDeviceCategoryByIdQuery()
                {
                    Id = id
                };
                var deviceCategory = await _mediator.Send(getDeviceCategoryByIdQuery);
                return View(deviceCategory.Data);
            }
            catch (Exception ex)
            {
                return RedirectToAction(nameof(Index));
            }
        }
        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id, UpdateDeviceCategoryCommand deviceCategoryCommand)
        {
            if (id != deviceCategoryCommand.Id)
                return NotFound();
            try
            {
                var deleteDeviceCategoryCommand = new DeleteDeviceCategoryCommand()
                {
                    Id = id
                };
                var result = await _mediator.Send(deleteDeviceCategoryCommand);
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