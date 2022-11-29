namespace kalıtım
{
    public class Hayvanlar:Canlılar
    {
        protected void Adaptasyon(){ 
            Console.WriteLine("Hayvanlar Adaptasyon Kurabilir.");
        }
    }

    public class Sürüngenler:Hayvanlar{
        public Sürüngenler(){ 
            base.Adaptasyon();
            base.Beslenme();
            base.Bosaltim();
            base.Solunum();
            

        }
        public void SürünerekHareketEderler(){ 
             Console.WriteLine("Sürüngenler sürünerek hareket eder.");
        }
    }

    public class Kuslar:Hayvanlar{ 

        public Kuslar(){ 
            base.Adaptasyon();
            base.Beslenme();
            base.Bosaltim();
            base.Solunum();
            
        }
        public void ucmak(){ 
             Console.WriteLine("Kuşlar uçar.");
        }
    }
}        