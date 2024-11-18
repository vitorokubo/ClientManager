using ClientManager.Domain.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientManager.Domain.Entities
{
    public sealed class Cliente : Entity
    {

        public Cliente(string name, string? telefone = null, string? email = null)
        {
            ValidateDomain(name);
            Name = name;
            Telefone = telefone;
            Email = email;
        }

        public string Name { get; private set; }
        public string? Telefone { get; private set; }
        public string? Email { get; private set; }

        public void Update(string? name= null, string? telefone = null, string? email = null)
        {
           if(name !=null) Name = name;
           if (telefone != null) Telefone = telefone;
           if (Email != null) Email = email;
        }

        private void ValidateDomain(string name)
        {
            DomainExceptionValidation.When(string.IsNullOrEmpty(name), "Invalid name.Name is required");
            DomainExceptionValidation.When(name.Length < 3, "Invalid name, to hort, minimum 3 charecters");
        }

    }
}
