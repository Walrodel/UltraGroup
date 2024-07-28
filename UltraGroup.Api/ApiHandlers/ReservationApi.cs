using MediatR;
using UltraGroup.Application.Reservations.Command;
using UltraGroup.Application.Reservations.Query;

namespace UltraGroup.Api.ApiHandlers;

public static class ReservationApi
{
    public static RouteGroupBuilder MapReservation(this IEndpointRouteBuilder routeHandler)
    {
        routeHandler.MapPost("/", async (IMediator mediator, CreateReservationCommand agent) =>
        {
            var id = await mediator.Send(agent);
            return Results.Ok(id);
        })
       .Produces(statusCode: StatusCodes.Status201Created)
       .WithSummary("Create new reservation")
       .WithOpenApi();

        routeHandler.MapGet("/{id}", async (IMediator mediator, Guid id) =>
        {
            var reservation = await mediator.Send(new GetReservationByIdQuery(id));
            return reservation is null ? Results.NoContent() : Results.Ok(reservation);
        })
       .Produces(statusCode: StatusCodes.Status200OK)
       .Produces(statusCode: StatusCodes.Status204NoContent)
       .WithSummary("Get reservation by id")
       .WithOpenApi();

        routeHandler.MapGet("/agent/{agentId}", async (IMediator mediator, Guid agentId) =>
        {
            var reservations = await mediator.Send(new GetReservationsByAgentQuery(agentId));
            return Results.Ok(reservations);
        })
      .Produces(statusCode: StatusCodes.Status200OK)
      .Produces(statusCode: StatusCodes.Status204NoContent)
      .WithSummary("Get reservation by id agent")
      .WithOpenApi();

        return (RouteGroupBuilder)routeHandler;

    }
}
