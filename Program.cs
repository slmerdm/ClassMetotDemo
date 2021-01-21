using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Costumer costumer1 = new Costumer();
            costumer1.Adi = "Mahmut";
            costumer1.Soyadi = "Ekin";
            costumer1.Id = 111;
            costumer1.Yasi = 29;

            Costumer costumer2 = new Costumer();
            costumer2.Adi = "Şeref";
            costumer2.Soyadi = "Asil";
            costumer2.Id = 222;
            costumer2.Yasi = 48;

            Costumer[] costumers =  new Costumer[] {costumer1,costumer2};

            foreach (var costumer in costumers)
            {
                Console.WriteLine(costumer.Adi);
                Console.WriteLine(costumer.Soyadi);
                Console.WriteLine(costumer.Yasi);
            }
            Console.WriteLine("---------metotlar----------");

            CostumerManager costumerManager = new CostumerManager();

            costumerManager.Listele(costumers);
            costumerManager.Ekle(costumer1);
            costumerManager.Sil(costumer2);
        }
    }
}
