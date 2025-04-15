using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HabitosTracker.Domain.Validation;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace HabitosTracker.Domain.Entities
{
    public sealed class Habito : Entity
    {
        public string Nome { get; private set; }
        public DateTime CreatedAt { get; private set; }

        public ICollection<HabitoCompleto> HabitoCompletos { get; set; }
        
        public Habito(string nome, DateTime createdAt)
        {
            Validate(nome, createdAt);
        }

        public Habito(int id, string nome, DateTime createdAt)
        {
            DomainExceptionValidation.When(id <= 0,"Id inválido.");
            Id = id;
            Validate(nome, createdAt);
        }

        public void Update(string nome, DateTime createdAt)
        {
            Validate(nome, createdAt);
        }


        public void Validate(string nome,DateTime createdAt)
        {
            DomainExceptionValidation.When(string.IsNullOrEmpty(nome), "Nome não pode ser nulo.");
            DomainExceptionValidation.When(nome.Length < 3 || nome.Length > 40, "Nome não pode ser nulo.");

            DomainExceptionValidation.When(createdAt == DateTime.MinValue, "Data invalida!");
            DomainExceptionValidation.When(createdAt > DateTime.Now, "A data não pode estar no futuro");
            DomainExceptionValidation.When(createdAt < DateTime.Today, "A data não pode estar no passado");

            CreatedAt = createdAt;
            Nome = nome;
        }
    }
}
