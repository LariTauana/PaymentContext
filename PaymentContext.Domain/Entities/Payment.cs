using System;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Domain.Entities
{
    public abstract class Payment      //Abstract pois não posso estanciar um pagamento direto, ele tem que ser um boleto, CreditCard ou PayPal 
    {
        protected Payment(DateTime paidDate, DateTime expireDate, decimal total, decimal totalPaid, string payer, Document document, Address address, Email email)
        {
            Number = Guid.NewGuid().ToString().Replace("-","").Substring(0, 10).ToUpper();
            PaidDate = paidDate;
            ExpireDate = expireDate;
            Total = total;
            TotalPaid = totalPaid;
            Payer = payer;
            Document = document;
            Address = address;
            Email = email;
        }

        public string Number {get; private set; }           //Até 9 dígitos
        public DateTime PaidDate { get; private set; }
        public DateTime ExpireDate{ get; private set; }
        public decimal Total { get; private set; }
        public decimal TotalPaid { get; private set; }
        public string Payer { get; private set; }
        public Document Document { get; private set; }
        public Address Address { get; private set; }    //Endereço de cobrança(para emissão de notas). Nesse caso, se esse endereço pode ser diferente do de entrega(está em Student)
        public Email Email { get; private set; }
    }
}