using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HabitosTracker.Domain.Validation;

namespace HabitosTracker.Domain.Entities
{
    public sealed class Usuario : Entity
    {
        public string Nome { get; private set; }
        public string Email { get; private set; }

        public ICollection<Habito> Habitos { get; set; }

        public Usuario(string nome,string email)
        {
            ValidateDomain(nome, email);
        }

        public Usuario(int id,string nome, string email)
        {
            DomainExceptionValidation.When(id < 0, "Id invalido!");
            Id = id;
            ValidateDomain(nome, email);
        }

        public void Update(string nome,string email)
        {
            ValidateDomain(nome, email);
        }

        public void ValidateDomain(string nome,string email)
        {
            DomainExceptionValidation.When(string.IsNullOrEmpty(nome),"Nome não pode ser nulo.");
            DomainExceptionValidation.When(nome.Length < 3 || nome.Length > 40, "Nome não pode ser nulo.");

            DomainExceptionValidation.When(string.IsNullOrEmpty(email), "Email não pode ser nulo.");
            DomainExceptionValidation.When(email.Length < 3 || email.Length > 40, "Email não pode ter menos de" +
                " 3 caracteres ou mais de 40");

            Nome = nome;
            Email = email;
        }

    }
}
