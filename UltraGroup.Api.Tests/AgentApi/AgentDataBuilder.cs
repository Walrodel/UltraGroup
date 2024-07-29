using UltraGroup.Domain.Agents.Entity;

namespace UltraGroup.Api.Tests.AgentApi
{
    internal class AgentDataBuilder
    {
        private string _name = "Test";
        private string _email = "test@email.com";
        private string _phone = "123456789";

        public Agent Build() => new() { Name = _name, Email = _email, Phone = _phone };

        public AgentDataBuilder WithName(string name)
        {
            _name = name;
            return this;
        }

        public AgentDataBuilder WithEmail(string email)
        {
            _email = email;
            return this;
        }

        public AgentDataBuilder WithPhone(string phone)
        {
            _phone = phone;
            return this;
        }
    }
}
