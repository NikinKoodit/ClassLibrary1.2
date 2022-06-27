using System;

namespace ClassLibrary1
{
    public class Class1
    {
        // testi    
        public bool Totuus { get; set; }
        public DateTime A { get; set; }
        public DateTime B { get; set; }
        public bool C { get; set; }

        public string Kiire()
        {
            return $"Olet myöhässä!{(A - B).TotalDays} päivää";
        }
        public string Aikataulussa()
        {
            return $"Sinulla on vielä {(A - B).TotalDays} päivää aikaa";
        }
        public void Tarkistus()
        {
            if (A> DateTime.Today)
            {
                Totuus = true;

            }

            else
            {
                Totuus = false;
            }

        }

        public void Myohassa()
        {
            if (C == false)
            {
                if (A <= DateTime.Today)
                {

                    Console.WriteLine(Kiire());

                }
                if (A > DateTime.Today)
                {
                    Console.WriteLine(Aikataulussa());
                }
            }
            //true ja false vöäärin päin. 
            if (C == true)
            {
                Console.WriteLine($"Opiskelusi kesti:{(A - B).TotalDays} ");
            }

        }


    }
}