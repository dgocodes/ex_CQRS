using CQRS.Api.Commands;
using CQRS.Api.Context;
using CQRS.Api.Entities;
using CQRS.Api.Queries;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace CQRS.Api.Handlers
{
    public class PersonHandler : IRequestHandler<GetPersonById, ICommandResult>, 
                                 IRequestHandler<CreatePerson, ICommandResult>
    {
        private readonly CQRSContext _context;

        public PersonHandler(CQRSContext context)
        {
            _context = context;
        }

        public async Task<ICommandResult> Handle(GetPersonById request, CancellationToken cancellationToken)
        {
            var person = await _context.People.FindAsync(request.Id, cancellationToken);
            return new CommandResult(true, person);
        }

        public async Task<ICommandResult> Handle(CreatePerson request, CancellationToken cancellationToken)
        {
            var person = new Person(request.Name, request.Birthdate, request.Email);

            _context.People.Add(person);
            await _context.SaveChangesAsync(cancellationToken);

            return new CommandResult(true, "Successfully Created Person", person);
        }
    }
}
