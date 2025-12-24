using OOP.Interfaces;

namespace OOP.Abstraction
{
    public abstract class PaymentServiceBase : IPaymentService
    {
        private string ProviderName;

        public PaymentServiceBase(string providerName)
        {
            ProviderName = providerName;
        }

        public void Pay(decimal amount)
        {
            Validate(amount);
            ExcutePayment(amount);
            Log(amount);
        }

        public abstract void ExcutePayment(decimal amount);

        private void Validate(decimal amount)
        {
            if (amount < 0)
            {
                throw new Exception("Invalid Amount");
            }
        }

        private void Log(decimal amount)
        {
            Console.WriteLine($"{ProviderName} payment of {amount}");
        }
    }
}
