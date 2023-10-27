using MediatR;
using DmsAssignment.Application.Bases;
using DmsAssignment.Application.Feature.Properties.Queries.Response;

namespace DmsAssignment.Application.Feature.Properties.Queries.Models
{
    public class GetPropertyByIdQuery : IRequest<Response<GetPropertyResponse>>
    {
        public int Id { get; set; }
    }
}
