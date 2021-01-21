using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CostumerManager
    {
        public void Ekle(Costumer costumer)
        {
            Console.WriteLine("Müşteri Eklendi : " + costumer.Adi + " " + costumer.Soyadi);
        }
        
        public void Sil(Costumer costumer)
        {
            Console.WriteLine("Müşteri Silindi : " + costumer.Adi + " " + costumer.Soyadi + " " + costumer.Id);
        }

        public void Listele(Costumer[] costumer)
        {
            Console.WriteLine("Müşteri Listesi : ");
            foreach (var costumers in costumer)
            {
                Console.WriteLine(costumers.Id + " " + costumers.Adi + " " + costumers.Soyadi + " " + costumers.Yasi);
            }
        }
    }
}
