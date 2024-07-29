using MediatR;
using UltraGroup.Application.Rooms.Command;
using UltraGroup.Application.Rooms.Query;

namespace UltraGroup.Api.ApiHandlers;

public static class RoomApi
{
    public static RouteGroupBuilder MapRoom(this IEndpointRouteBuilder routeHandler)
    {
        routeHandler.MapPost("/", async (IMediator mediator, CreateRoomCommand agent) =>
        {
            var id = await mediator.Send(agent);
            return Results.Ok(id);
        })
       .Produces(statusCode: StatusCodes.Status201Created)
       .WithSummary("Create new room")
       .WithOpenApi();

        routeHandler.MapGet("/{id}", async (IMediator mediator, Guid id) =>
        {
            var room = await mediator.Send(new GetRoomByIdQuery(id));
            return room is null ? Results.NoContent() : Results.Ok(room);
        })
       .Produces(statusCode: StatusCodes.Status200OK)
       .Produces(statusCode: StatusCodes.Status204NoContent)
       .WithSummary("Get room by id")
       .WithOpenApi();

        routeHandler.MapGet("/Availables", async (IMediator mediator, DateOnly CheckInDate, DateOnly CheckOutDate, short NumberOfPersons, string City) =>
        {
            var rooms = await mediator.Send(new GetRoomsAvailableQuery(CheckInDate, CheckOutDate, NumberOfPersons, City));
            return Results.Ok(rooms);
        })
       .Produces(statusCode: StatusCodes.Status200OK)
       .Produces(statusCode: StatusCodes.Status204NoContent)
       .WithSummary("Get rooms availables")
       .WithOpenApi();

        routeHandler.MapPut("/{id}", async (IMediator mediator, CreateRoomCommand room, Guid id) =>
        {
            await mediator.Send(new UpdateRoomCommand(id, room.NumberOfPersons, room.CosBaseCost, room.Tax, room.Type, room.State, room.Location, room.HotelId));
            return Results.Ok();
        })
       .Produces(statusCode: StatusCodes.Status200OK)
       .WithSummary("Update room")
       .WithOpenApi();

        return (RouteGroupBuilder)routeHandler;

    }
}
