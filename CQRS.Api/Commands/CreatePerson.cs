using CQRS.Api.Entities;
using MediatR;
using System;

namespace CQRS.Api.Commands
{
    public class CreatePerson : IRequest<CommandResult>
    {
        public string Name { get; set; }

        public DateTime Birthdate { get; set; }

        public string Email { get; set; }
    }
}
