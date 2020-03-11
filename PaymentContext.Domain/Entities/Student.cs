using System.Collections.Generic;
using System.Linq;

namespace PaymentContext.Domain.Entities
{
    public class Student
    {
        private IList<Subscription> _subscriptions;
        public Student(string firstName, string lastName, string document, string email)
        {
            FirstName = FirstName;
            LastName = lastName;
            Document = document;
            Email = email;
            _subscriptions = new List<Subscription>();
        }


        public string FirstName {get; private set; }
        public string LastName {get; private set; }
        public string Document {get; private set;}
        public string Email{get; private set; }
        public string Address { get; private set; }     //Endereço de entrega
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