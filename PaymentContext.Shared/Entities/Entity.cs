using System;

namespace PaymentContext.Shared.Entities
{
    public abstract class Entity : Notifiable     //abstrata pois não posso estanciar entidade
    {
        protected Entity()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; private set; }  //Entidade tem ID, ValueObject não
    }
}