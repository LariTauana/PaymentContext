using System; 

namespace PaymentContext.Domain.Entities
{
    public abstract class Payment      //Abstract pois não posso estanciar um pagamento direto, ele tem que ser um boleto, CreditCard ou PayPal 
    {
        public string Number {get; set; }                           //Até 9 dígitos
        public DateTime PaidDate { get; set; }
        public  DateTime ExpireDate{ get; set; }
        public decimal Total { get; set; }
        public decimal TotalPaid { get; set; }
        public string payer { get; set; }
        public string Document { get; set; }
        public string Address { get; set; }    //Endereço de cobrança(para emissão de notas). Nesse caso, se esse endereço pode ser diferente do de entrega(está em Student)
        public string Email { get; set; }
    }

    public class BoletoPayment : Payment
    {
        public string BarCode { get; set; }
        public string BoletoNumber { get; set; }        //Até 12 dígitos. Gerado no banco
       
    }
     public class CreditCardPayment : Payment
    {
        public string CardHolderName { get; set; }
        public string CardNumber { get; set; }      //Armazena apenas os últimos 4 dígitos
        public string LastTransactionNumber { get; set; }
   }
     public class PayPalPayment : Payment
    {
        public string TransactionCode { get; set; }
    }
}