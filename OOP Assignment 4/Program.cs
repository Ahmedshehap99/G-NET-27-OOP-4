using System.Net.Sockets;

namespace OOP_Assignment_4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region PART 01
            //// Part 01


            //  Question 01 :

            //          Static Binding(Early Binding) 
            //                 =>  compile time




            //          Dynamic Binding(Late Binding)
            //                    => run time





            //  Question 02 :

            //          Method Overloading : Same method name, different parameter lists — within the same class. Resolved at compile time.



            //          Method Overriding : Derived class overrides a virtual method from the base class using the override keyword.




            // Question 03 :



            //            virtual → Allows a method to be override in a child class.

            //            override → Used in a child class to redefine a method.

            //            sealed → Prevents any other class from overriding it.

            #endregion

            #region PART 02
            namespace Assignment_04_OOP.BookingTicket.Inheritance
    {
        internal class Cinema
        {

            private Ticket[] tickets = new Ticket[20];
            private Projector projector = new Projector();

            public void AddTicket(Ticket t)
            {
                for (int i = 0; i < tickets.Length; i++)
                {
                    if (tickets[i] == null)
                    {
                        tickets[i] = t;
                        break;
                    }
                }
            }

            public void PrintAllTickets()
            {
                Console.WriteLine("\n========== All Tickets ==========");

                foreach (var t in tickets)
                {
                    if (t != null)
                        t.PrintTicket();
                }
            }

            public void OpenCinema()
            {
                Console.WriteLine("\n========== Cinema Opened ==========");
                projector.Start();
            }

            public void CloseCinema()
            {
                Console.WriteLine("\n========== Cinema Closed ==========");
                projector.Stop();
            }
            #endregion







        }
    }
}
