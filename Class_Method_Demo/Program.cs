namespace Class_Method_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Costumer costumer1 = new Costumer()
            {
                ID = 1001,
                FirstName = "Fatih",
                LastName = "Türkmen",
                YearOfDate = 1995
            };
            Costumer costumer2 = new Costumer()
            {
                ID = 1002,
                FirstName = "Yusuf",
                LastName = "Can",
                YearOfDate = 2015
            };
            Costumer costumer3 = new Costumer()
            {
                ID = 1003,
                FirstName = "Hasan",
                LastName = "Kale",
                YearOfDate = 1980
            };
            Costumer costumer4 = new Costumer()
            {
                ID = 1004,
                FirstName = "Hüseyin",
                LastName = "Kılıçarslan",
                YearOfDate = 1968
            };
            Costumer costumer5 = new Costumer()
            {
                ID = 1005,
                FirstName = "Mustafa",
                LastName = "Emin",
                YearOfDate = 1971
            };

            CostumerManager costumerManager = new CostumerManager();
            List<Costumer> ListofCostumers = new List<Costumer>();

            costumerManager.AddCostumer(costumer1, ListofCostumers); 
            costumerManager.AddCostumer(costumer2, ListofCostumers);
            costumerManager.AddCostumer(costumer3, ListofCostumers);
            costumerManager.AddCostumer(costumer4, ListofCostumers);
            costumerManager.AddCostumer(costumer5, ListofCostumers);
            Console.WriteLine("\n****************************************\n");
            costumerManager.ListOfCostumers(ListofCostumers);
            Console.WriteLine("\n****************************************\n");
            costumerManager.DeleteCostumer(costumer5,ListofCostumers);
            Console.WriteLine("\n****************************************\n");
            costumerManager.ListOfCostumers(ListofCostumers);


            Console.ReadKey();
        }
    }
}