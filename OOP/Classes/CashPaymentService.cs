using OOP.Abstraction;

namespace OOP.Classes
{
    public class CashPaymentService : PaymentServiceBase
    {
        public CashPaymentService() : base("Cash")
        {

        }
        public override void ExcutePayment(decimal amount)
        {
            Console.WriteLine($"Cash payment {amount} JOD");
        }
    }
}
