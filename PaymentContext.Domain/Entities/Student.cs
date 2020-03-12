using System.Collections.Generic;
using System.Linq;
using PaymentContext.Domain.ValueObjects;
using PaymentContext.Shared.Entities;

namespace PaymentContext.Domain.Entities
{
    public class Student : Entity
    {
        private IList<Subscription> _subscriptions;
        public Student(Name name, Document document, Email email)
        {
            Name = name;
            Document = document;
            Email = email;
            _subscriptions = new List<Subscription>();
        }


        public Name Name {get; private set; }
        public Document Document {get; private set;}
        public Email Email{get; private set; }
        public Address Address { get; private set; }     //Endereço de entrega
        public IReadOnlyCollection<Subscription> Subscriptions { get{return _subscriptions.ToArray();} }    //Dessa forma(com "IReadOnlyCollection" ao invés de "List"), sou obrigada a chamar o "AddSubscription()" no StudentTests
   
        public void AddSubscription(Subscription subscription)
        {
            //Se já tiver uma assinatura ativa, cancela

            //Cancela todas as ouras assinaturas, e coloca esta como principal
            foreach(var sub in Subscriptions){
                sub.Inactivate();
            }

            _subscriptions.Add(subscription);
        }
    } 
}