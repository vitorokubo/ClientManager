using ClientManager.Domain.Entities;
using ClientManager.Domain.Validation;
using FluentAssertions;

namespace ClientManager.Tests
{
    public class ClienteUnitTest1
    {
        [Fact]
        public void CreateCliente_WithValidaParameters_ResultObjectValidState()
        {
            Action action = () => new Cliente("Nome Qualquer");
            action.Should()
                .NotThrow<DomainExceptionValidation>();
        }
    }
}