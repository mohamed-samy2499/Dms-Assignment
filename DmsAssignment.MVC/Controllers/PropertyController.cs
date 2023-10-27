using AutoMapper;
using DmsAssignment.Application.Feature.Properties.Queries.Models;
using DmsAssignment.Application.Feature.Properties.Queries.Response;
using DmsAssignment.Application.Feature.Properties.Commands.Models;
using DmsAssignment.Domain.Entities;
using DmsAssignment.MVC.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Diagnostics;

namespace DmsAssignment.MVC.Controllers
{
    public class PropertyController : Controller
    {
        #region Ctor
        private readonly ILogger<HomeController> _logger;
        private readonly IMediator _mediator;
        private IMapper _mapper;
        public PropertyController(ILogger<HomeController> logger, IMediator mediator, IMapper mapper)
        {
            _logger = logger;
            _mediator = mediator;
            _mapper = mapper;
        }
        #endregion

        #region Index Action
        public async Task<IActionResult> Index()
        {
            var Properties = await _mediator.Send(new GetPropertyListQuery());
            return View(Properties.Data);
        }
        #endregion

        #region Details Action
        public async Task<IActionResult> Details(int id, string ViewName = "Details")
        {
            try
            {

                var getPropertyByIdQuery = new GetPropertyByIdQuery()
                {
                    Id = id
                };
                var devices = await _mediator.Send(getPropertyByIdQuery);
                return View(ViewName , devices.Data);
            }
            catch (Exception ex)
            {
                return RedirectToAction(nameof(Index));
            }
        }
        #endregion

        #region Create Action
        [HttpGet]
        public  IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(AddPropertyCommand command)
        {
            var result  = await _mediator.Send(command);
            if(result.Succeeded)
                return RedirectToAction(nameof(Index));
            return View(command);
        }
        #endregion

        #region Edit Action
        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            if (id > 0)
            {
                var getPropertyByIdQuery = new GetPropertyByIdQuery()
                {
                    Id = id

                };
                var property = await _mediator.Send(getPropertyByIdQuery);
                var getPropertyResponse = property.Data;
                var updatePropertyCommand = _mapper.Map<UpdatePropertyCommand>(getPropertyResponse);

              
                return View(updatePropertyCommand);
            }
            return RedirectToAction(nameof(Index));
        }
        
        [HttpPost]

        public async Task<IActionResult> Edit(UpdatePropertyCommand command)
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
            var getPropertyByIdQuery = new GetPropertyByIdQuery()
            {
                Id = id
            };
            var Properties = await _mediator.Send(getPropertyByIdQuery);
            return View(Properties.Data);
        }
        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id, UpdatePropertyCommand propertyCommand)
        {
            if (id != propertyCommand.Id)
                return NotFound();
            try
            {
                var deletePropertyCommand = new DeletePropertyCommand()
                {
                    Id = id
                };
                var result = await _mediator.Send(deletePropertyCommand);
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