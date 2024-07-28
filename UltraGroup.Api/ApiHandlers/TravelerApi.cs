using MediatR;
using UltraGroup.Application.Travelers.Command;
using UltraGroup.Application.Travelers.Query;

namespace UltraGroup.Api.ApiHandlers;

public static class TravelerApi
{
    public static RouteGroupBuilder MapTraveler(this IEndpointRouteBuilder routeHandler)
    {
        routeHandler.MapPost("/", async (IMediator mediator, CreateTravelerCommand agent) =>
        {
            var id = await mediator.Send(agent);
            return Results.Ok(id);
        })
       .Produces(statusCode: StatusCodes.Status201Created)
       .WithSummary("Create new traveler")
       .WithOpenApi();

        routeHandler.MapGet("/{id}", async (IMediator mediator, Guid id) =>
        {
            var traveler = await mediator.Send(new GetTravelerByIdQuery(id));
            return traveler is null ? Results.NoContent() : Results.Ok(traveler);
        })
       .Produces(statusCode: StatusCodes.Status200OK)
       .Produces(statusCode: StatusCodes.Status204NoContent)
       .WithSummary("Get travler by id")
       .WithOpenApi();

        routeHandler.MapPut("/{id}", async (IMediator mediator, CreateTravelerCommand traveler, Guid id) =>
        {
            await mediator.Send(new UpdateTravelerCommand(
                id,
                traveler.FirstName,
                traveler.LastName,
                traveler.DateOfBirth,
                traveler.Gender,
                traveler.DocumentType,
                traveler.DocumentNumber,
                traveler.Email,
                traveler.Phone));
            return Results.Ok();
        })
       .Produces(statusCode: StatusCodes.Status200OK)
       .WithSummary("Update traveler")
       .WithOpenApi();

        return (RouteGroupBuilder)routeHandler;

    }
}
