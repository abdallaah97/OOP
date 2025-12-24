//Polymorphsim

using OOP.Classes;
using OOP.Interfaces;
using System.Runtime.Serialization;

Helper.AutoId();
Helper.AutoId();
Helper.AutoId();

IPaymentService paymentService = new VisaPaymentService();
paymentService.Pay(55.4m);

Console.WriteLine(Helper.Counter);

string dateTime = DateTime.Now.DatetimeFormat();


TestClass testClass = new TestClass();
testClass.Print("ww", "sdsd");
