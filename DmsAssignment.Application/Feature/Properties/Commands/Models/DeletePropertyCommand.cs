using MediatR;
using DmsAssignment.Application.Bases;

namespace DmsAssignment.Application.Feature.Properties.Commands.Models
{
    public class DeletePropertyCommand : IRequest<Response<string>>
    {
        public int Id { get; set; }
    }
}
