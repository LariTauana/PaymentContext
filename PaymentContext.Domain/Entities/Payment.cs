using System; 

namespace PaymentContext.Domain.Entities
{
    public abstract class Payment      //Abstract pois não posso estanciar um pagamento direto, ele tem que ser um boleto, CreditCard ou PayPal 
    {
        public string Number {get; set; }
        public DateTime PaidDate { get; set; }
        public  DateTime ExpireDate{ get; set; }
        public decimal Total { get; set; }
        public decimal TotalPaid { get; set; }
    }

    public class BoletoPayment : Payment
    {

    }
     public class CreditCardPayment : Payment
    {
        
    }
     public class PayPalPayment : Payment
    {
        
    }
}