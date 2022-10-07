using System;
using System.Threading.Tasks;

namespace Async_Q10
{
    class Program
    {
        static async Task Main(string[] args)
        {
            flower();
            GuestPicked();
            FoodArea();

            functionStarted();
        }
        static async void flower()
        {
            Console.WriteLine("Flower decorations to be completed on stage");
        }
        static async void GuestPicked()
        {
            Console.WriteLine("Chief guest to be picked up from the airport.");
            await Task.Delay(7000);

        }
        static async void gift()
        {

            Console.WriteLine("Arrange the gifts to be distributed in the stage ");
        }
        static async void functionStarted()
        {

            Console.WriteLine("Started function as Chief guest has arrived at the venue. ");
        }
        static async void FoodArea()
        {
            Console.WriteLine("Co-ordinate with the caterers and set up the food area.");
            gift();

        }




    }


}
