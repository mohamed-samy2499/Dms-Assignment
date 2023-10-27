using MediatR;
using DmsAssignment.Application.Bases;

namespace DmsAssignment.Application.Feature.Properties.Commands.Models
{
    public class AddPropertyCommand : IRequest<Response<string>>
    {
        public string Name { get; set; } = null!;

    }
}
