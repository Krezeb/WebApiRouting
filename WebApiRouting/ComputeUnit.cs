using System;

namespace WebApiRouting
{
    public class ComputeUnit
    {
        public int Value1 { get; set; }
        public int Value2 { get; set; }
        public string Mode { get; set; }

        public int Compute()
        {
            if (Mode == "addition")
            {
                return Value1 + Value2;
            }
            if (Mode == "multiplication")
            {
                return Value1 * Value2;
            }
            else
            {
                return -1;
            }
        }
    }
}

/*
 * Det är nog en bra idé att flytta in beräkningen från deluppgift 2.2 in i 
 * ComputeUnit-klassen så att den kan hantera sina egna beräkningar.
 * 
 * Skapa en metod i ComputeUnit som heter Compute. 
 * Metoden tar inga parametrar och returnerar en int. 
 * Flytta in koden från Compute- metoden i ComputeController in i Compute-metoden i ComputeUnit. 
 * Du kommer förmodligen behöva ändra hur du kommer åt värdena på Value1 och Value2.
 * 
 * Efter att du fixat koden i ComputeUnit kan du i ComputeController anropa ComputeUnit:s Compute-metod och returnera värdet.
 * Kör programmet och verifiera att du får samma svar som i deluppguft 2.2.
 */