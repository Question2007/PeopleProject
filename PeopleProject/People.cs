using System;
using System.Collections.Generic;
using System.Text;

namespace PeopleProject
{
    internal class People
    {
        List<int> eletkorok;

        public People()
        {
            this.eletkorok = new List<int>();
        }



        public void UjSzemely(int eletkor)
        {
            if (eletkor < 0)
            {
                throw new ArgumentException("Az életkor nem lehet negatív.");
            }
            eletkorok.Add(eletkor);
        }

        public double AtlagEletkor(int minEletkor, int maxEletkor)
        {
            if (eletkorok.Count() == 0 )
            {
                throw new InvalidOperationException();
            }
            if (minEletkor < 0 || maxEletkor < 0)
            {
                throw new ArgumentException("Az életkor nem lehet negatív.");
            }
            if (minEletkor > maxEletkor)
            {
                throw new ArgumentException("A minimum életkornak kisebbnek kell lennie a maximum életkornál.");
            }

            int osszeg = 0;
            int db = 0; 
            for (int i = 0; i < eletkorok.Count(); i++)
            {
                if (eletkorok[i] >= minEletkor && eletkorok[i] <= maxEletkor)
                {
                    osszeg += eletkorok[i];
                    db += 1;
                }
            }
            if (db <= 0)
            {
                throw new InvalidOperationException("Nincs megfelelő életkorú személy a megadott tartományban.");
            }
            double atlag = (double)osszeg / db;
            return atlag;
        }
    }
}
