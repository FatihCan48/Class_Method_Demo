using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Method_Demo
{
    public class CostumerManager
    {
        public void AddCostumer(Costumer costumer,List<Costumer> costumers)
        {
            costumers.Add(costumer);
            Console.WriteLine(costumer.FirstName + " " + costumer.LastName + " isimli müşteri başarıyla eklenmiştir.");
        }
        public void DeleteCostumer(Costumer costumer, List<Costumer> costumers)
        {
            Console.WriteLine("Müşteriyi silmek istediğinizden emin misiniz ?");
            string karar = Console.ReadLine();

            if (karar == "Evet" || karar == "evet")
            {
                Console.WriteLine(costumer.FirstName + " " + costumer.LastName + " isimli müşteri başarıyla silinmiştir.");
                costumers.Remove(costumer);
            }
            else if (karar == "Hayır" || karar == "hayır")
            {
                Console.WriteLine("Silme işlemi gerçekleştirilmedi.");
            }
            else
                Console.WriteLine("Geçersiz giriş.");
        }
        public void ListOfCostumers(List<Costumer> costumers)
        {
            Console.WriteLine("\t---- List Of Costumers ----");
            Console.WriteLine("\n******************************************");
            foreach (var c in costumers)
            {
                Console.WriteLine(c.ID + "-" + c.FirstName + " " + c.LastName );
            }
        }
    }
}
