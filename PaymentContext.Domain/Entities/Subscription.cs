using System;
using System.Collections.Generic;

namespace PaymentContext.Domain.Entities
{
    public class Subscription
    {
        public bool Active {get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastUpdateDate { get; set; }    //data da ultima atualização
        public DateTime? ExpireDate { get; set; }    //exclamação, pois é nulable
        public List<Payment> Payments { get; set; }
   }

}