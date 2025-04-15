using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HabitosTracker.Domain.Validation;

namespace HabitosTracker.Domain.Entities
{
    public sealed class HabitoCompleto : Entity
    {
        public DateTime Data { get; private set; }

        public int HabitoId { get; private set; }
        public Habito Habito { get; set; }

        public HabitoCompleto(int habitoId, DateTime date)
        {
            HabitoId = habitoId;
            Data = date;
        }

        public HabitoCompleto(int id,int habitoId, DateTime date)
        {
            Id = id;
            HabitoId = habitoId;
            Data = date;
        }

        public void Update(DateTime date)
        {
            Validate(date);
        }

        public void Validate(DateTime date)
        {
            DomainExceptionValidation.When(date == DateTime.MinValue, "Data invalida!");
            DomainExceptionValidation.When(date > DateTime.Now, "A data não pode estar no futuro");
            DomainExceptionValidation.When(date < DateTime.Today, "A data não pode estar no passado");

            Data = date;
        }
    }
}
