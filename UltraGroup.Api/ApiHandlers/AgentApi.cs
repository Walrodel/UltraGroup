using MediatR;
using UltraGroup.Application.Agents.Command;
using UltraGroup.Application.Agents.Query;

namespace UltraGroup.Api.ApiHandlers;

public static class AgentApi
{
    public static RouteGroupBuilder MapAgent(this IEndpointRouteBuilder routeHandler)
    {
        routeHandler.MapPost("/", async (IMediator mediator, CreateAgentCommand agent) =>
        {
            var id = await mediator.Send(agent);
            return Results.Ok(id);
        })
       .Produces(statusCode: StatusCodes.Status201Created)
       .WithSummary("Create new agent")
       .WithOpenApi();

        routeHandler.MapGet("/{id}", async (IMediator mediator, Guid id) =>
        {
            var agent = await mediator.Send(new GetAgentByIdQuery(id));
            return agent is null ? Results.NoContent() : Results.Ok(agent);
        })
       .Produces(statusCode: StatusCodes.Status200OK)
       .Produces(statusCode: StatusCodes.Status204NoContent)
       .WithSummary("Get agent by id")
       .WithOpenApi();

        routeHandler.MapPut("/{id}", async (IMediator mediator, CreateAgentCommand agent, Guid id) =>
        {
            await mediator.Send(new UpdateAgentCommand(id, agent.Name, agent.Email, agent.Phone));
            return Results.Ok();
        })
       .Produces(statusCode: StatusCodes.Status201Created)
       .WithSummary("Create new agent")
       .WithOpenApi();

        return (RouteGroupBuilder)routeHandler;

    }
}
