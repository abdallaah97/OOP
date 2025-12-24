using OOP.Abstraction;

namespace OOP.Classes
{
    public class VisaPaymentService : PaymentServiceBase
    {
        public VisaPaymentService() : base("Visa")
        {

        }

        public override void ExcutePayment(decimal amount)
        {
            Helper.Counter = Helper.Counter + (int)amount;
            Console.WriteLine($"Paid {amount} JOD using visa / Counter : {Helper.Counter}");
        }
    }
}
