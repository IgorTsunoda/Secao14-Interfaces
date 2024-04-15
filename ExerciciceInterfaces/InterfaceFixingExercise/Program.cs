using InterfaceFixingExercise.Entities;
using InterfaceFixingExercise.Services;
using System.Globalization;

namespace InterfaceFixingExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy): ");
            DateTime date = DateTime.Parse(Console.ReadLine());
            Console.Write("Contract value: ");
            double contractValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter the number of isntallments: ");
            int month = int.Parse(Console.ReadLine());

            Contract myContract = new Contract(number, date, contractValue);
            ContractService contractService = new ContractService(new PaypalPaymentService());
            contractService.ProcessContract(myContract, month);

            Console.WriteLine("Installments:");
            foreach (Installment installment in myContract.Installments)
            {
                Console.WriteLine(installment);
            }

        }
    }
}