using System;

namespace ClassLibrary1
{
    public class Class1
    {
        // testi    
        public bool Totuus { get; set; }
        public DateTime StartLearninDate { get; set; }
        public bool InProgress { get; set; }
        public DateTime CompletionDate { get; set; }

        public string Kiire()
        {
            return $"Olet myöhässä!{(CompletionDate - StartLearninDate).TotalDays}";
        }
        public string Aikataulussa()
        {
            return $"Sinulla on vielä {(CompletionDate - StartLearninDate).TotalDays} päivää aikaa";
        }
        public void Tarkistus()
        {
            if (CompletionDate > DateTime.Today)
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
            if (InProgress == false)
            {
                if (CompletionDate <= DateTime.Today)
                {

                    Console.WriteLine(Kiire());

                }
                if (CompletionDate > DateTime.Today)
                {
                    Console.WriteLine(Aikataulussa());
                }
            }

            if (InProgress == true)
            {
                Console.WriteLine($"Opiskelusi kesti:{(CompletionDate - StartLearninDate).TotalDays} ");
            }

        }


    }
}