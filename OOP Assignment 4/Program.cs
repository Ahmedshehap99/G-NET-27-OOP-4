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



            //namespace Assignment_04_OOP.BookingTicket.Inheritance
            //        {
            //            internal class Projector
            //            {
            //                public void Start()
            //                {
            //                    Console.WriteLine("Projector started.");
            //                }

            //                public void Stop()
            //                {
            //                    Console.WriteLine("Projector stopped.");
            //                }






            //namespace Assignment_04_OOP.BookingTicket.Inheritance
            //        {
            //            internal class StandardTicket : Ticket
            //            {


            //                public string seatNumber { get; set; }
            //                public StandardTicket(string movieName, decimal price, string seat) : base(movieName, price)
            //                {
            //                    seatNumber = seat;

            //                }







            //                public override void PrintTicket()
            //                {
            //                    base.PrintTicket();
            //                    Console.WriteLine($"  Seat: {seatNumber}");
            //                }

            //            }
            //        }
            //        }
            //}

            //namespace Assignment_04_OOP.BookingTicket.Inheritance
            //        {
            //            internal class VIPTicket : Ticket

            //            {
            //                public bool LoungeAccess { get; set; }

            //                public decimal ServiceFee { get; } = 50;
            //                public VIPTicket(string movieName, decimal price, bool louAccs) : base(movieName, price + 50)
            //                {

            //                    LoungeAccess = louAccs;
            //                }

            //                public override void PrintTicket()
            //                {
            //                    base.PrintTicket();
            //                    Console.WriteLine($"  Lounge: {(LoungeAccess ? "Yes" : "No")} | Service Fee: {ServiceFee} EGP");
            //                }


            //            }

            //internal class Ticket
            //{

            //    public string MovieName { get; set; }
            //    public decimal Price { get; private set; }

            //    public int TicketId { get; }

            //    private static int counter = 0;

            //    public Ticket(string movieName, decimal price)
            //    {
            //        if (price <= 0)
            //        {
            //            throw new ArgumentException("Price must be greater than zero.");
            //        }





            //        MovieName = movieName;
            //        Price = price;

            //        counter++;
            //        TicketId = counter;


            //    }

            //    public static int GetTotalTickets()
            //    {
            //        return counter;
            //    }

            //    public decimal PriceAfterTax()
            //    {
            //        return Price * 1.14m;
            //    }


            //    public void SetPrice(decimal price)
            //    {
            //        if (price > 0)
            //            Price = price;
            //    }

            //    public void SetPrice(decimal basePrice, decimal multiplier)
            //    {
            //        if (basePrice > 0 && multiplier > 0)
            //            Price = basePrice * multiplier;
            //    }



            //    public virtual void PrintTicket()
            //    {
            //        Console.WriteLine($"Ticket #{TicketId} | {MovieName} | Price: {Price} EGP | After Tax: {PriceAfterTax:F2} EGP");
            //    }






        //    Cinema cinema = new Cinema();
        //    cinema.OpenCinema();



        //    Console.WriteLine("\n========== SetPrice Test ==========");


        //    StandardTicket t1 = new StandardTicket("Inception", 120, "A-5");


        //    Console.WriteLine("Setting price directly: 150");
        //    t1.SetPrice(150);


        //    Console.WriteLine("Setting price with multiplier: 100 x 1.5 = 150");
        //    t1.SetPrice(100, 1.5m);


        //    VIPTicket t2 = new VIPTicket("Avengers", 200, true);
        //    IMAXTicket t3 = new IMAXTicket("Dune", 180, false);



        //    cinema.AddTicket(t1);
        //    cinema.AddTicket(t2);
        //    cinema.AddTicket(t3);

        //    cinema.PrintAllTickets();

        //    ProcessTicket(t2);

        //    cinema.CloseCinema();
        //}



        //static void ProcessTicket(Ticket t)
        //    {
        //        Console.WriteLine("\n========== Process Single Ticket ==========");
        //        t.PrintTicket();
        //    }


