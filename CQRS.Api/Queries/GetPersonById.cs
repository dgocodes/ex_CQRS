using CQRS.Api.Entities;
using MediatR;
using System;

namespace CQRS.Api.Queries
{
    public class GetPersonById : IRequest<CommandResult>
    {
        public Guid Id { get; }

        public GetPersonById(Guid id)
        {
            Id = id;
        }
    }
}
