using MediatR;
using DmsAssignment.Domain.Entities;
using DmsAssignment.Application.Bases;
using DmsAssignment.Application.Feature.Properties.Queries.Response;

namespace DmsAssignment.Application.Feature.Properties.Commands.Models
{
    public class UpdatePropertyCommand : IRequest<Response<GetPropertyResponse>>
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
    }
}
