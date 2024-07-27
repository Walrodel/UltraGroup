using FluentAssertions;
using UltraGroup.Domain.Exceptions;

namespace UltraGroup.Domain.Tests.Agents.Entity
{
    public class AgentTests
    {
        [Fact]
        public void Agent_WithNameNull_RequiredException()
        {
            FluentActions.Invoking(() => new AgentDataBuilder().WithName(default!).Build())
                .Should().Throw<RequiredException>()
                .WithMessage("The name should not be null or empty.");
        }

        [Fact]
        public void Agent_WithNameMinimunLength_RequiredException()
        {
            FluentActions.Invoking(() => new AgentDataBuilder().WithName("Ad").Build())
                .Should().Throw<RequiredException>()
                .WithMessage($"The name should be between 3 and 100 characters.");
        }

        [Fact]
        public void Agent_WithEmailNull_RequiredException()
        {
            FluentActions.Invoking(() => new AgentDataBuilder().WithEmail(default!).Build())
                .Should().Throw<RequiredException>()
                .WithMessage("The email should not be null or empty.");
        }

        [Fact]
        public void Agent_WithEmailNotValid_RequiredException()
        {
            FluentActions.Invoking(() => new AgentDataBuilder().WithEmail("email").Build())
                .Should().Throw<RequiredException>()
                .WithMessage("The email is not valid.");
        }

        [Fact]
        public void Agent_WithEmailMinimunLength_RequiredException()
        {
            FluentActions.Invoking(() => new AgentDataBuilder().WithEmail("Ad").Build())
                .Should().Throw<RequiredException>()
                .WithMessage($"The email should be between 5 and 100 characters.");
        }

        [Fact]
        public void Agent_WithPhoneNull_RequiredException()
        {
            FluentActions.Invoking(() => new AgentDataBuilder().WithPhone(default!).Build())
                .Should().Throw<RequiredException>()
                .WithMessage("The phone should not be null or empty.");
        }

        [Fact]
        public void Agent_WithPhoneMinimunLength_RequiredException()
        {
            FluentActions.Invoking(() => new AgentDataBuilder().WithPhone("Ad").Build())
                .Should().Throw<RequiredException>()
                .WithMessage($"The phone should be between 5 and 20 characters.");
        }

        [Fact]
        public void Agent_Build_Success()
        {
            var agent = new AgentDataBuilder().Build();

            agent.Name.Should().NotBeNullOrEmpty().And.Be("Test");
            agent.Email.Should().NotBeNullOrEmpty().And.Be("test@email.com");
            agent.Phone.Should().NotBeNullOrEmpty().And.Be("123456789");
        }
    }
}
