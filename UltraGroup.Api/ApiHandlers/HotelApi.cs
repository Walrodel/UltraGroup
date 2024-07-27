using MediatR;
using UltraGroup.Application.Hotels.Command;
using UltraGroup.Application.Hotels.Query;

namespace UltraGroup.Api.ApiHandlers;

public static class HotelApi
{
    public static RouteGroupBuilder MapHotel(this IEndpointRouteBuilder routeHandler)
    {
        routeHandler.MapPost("/", async (IMediator mediator, CreateHotelCommand agent) =>
        {
            var id = await mediator.Send(agent);
            return Results.Ok(id);
        })
       .Produces(statusCode: StatusCodes.Status201Created)
       .WithSummary("Create new hotel")
       .WithOpenApi();

        routeHandler.MapGet("/{id}", async (IMediator mediator, Guid id) =>
        {
            var hotel = await mediator.Send(new GetHotelByIdQuery(id));
            return hotel is null ? Results.NoContent() : Results.Ok(hotel);
        })
       .Produces(statusCode: StatusCodes.Status200OK)
       .Produces(statusCode: StatusCodes.Status204NoContent)
       .WithSummary("Get hotel by id")
       .WithOpenApi();

        routeHandler.MapPut("/{id}", async (IMediator mediator, CreateHotelCommand hotel, Guid id) =>
        {
            await mediator.Send(new UpdateHotelCommand(id, hotel.Name, hotel.City, hotel.Address, hotel.Description, hotel.AgentId, hotel.State));
            return Results.Ok();
        })
       .Produces(statusCode: StatusCodes.Status200OK)
       .WithSummary("Update hotel")
       .WithOpenApi();

        return (RouteGroupBuilder)routeHandler;

    }
}
