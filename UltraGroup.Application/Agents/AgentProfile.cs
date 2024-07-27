using AutoMapper;
using UltraGroup.Application.Agents.Command;
using UltraGroup.Domain.Agents.Entity;
using UltraGroup.Domain.Agents.Entity.Dto;

namespace UltraGroup.Application.Agents
{
    public class AgentProfile : Profile
    {
        public AgentProfile()
        {
            CreateMap<Agent, AgentDto>();
            CreateMap<UpdateAgentCommand, AgentDto>();
        }
    }
}
