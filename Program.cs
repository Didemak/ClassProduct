using System;

namespace ClassProduct
{
    class Program
    {
        static void Main(string[] args)
        {
            Product model1 = new Product();
            model1.ayakkabıAdi = "Nike";
            model1.ayakkabıCinsiyeti = "Kadın";
            model1.maxAyakkabıNumarası = 34;

            Product model2 = new Product();
            model2.ayakkabıAdi = "Puma";
            model2.ayakkabıCinsiyeti = "Kadın";
            model2.maxAyakkabıNumarası = 40;

            Product model3 = new Product();
            model3.ayakkabıAdi = "Nike";
            model3.ayakkabıCinsiyeti = "Unisex";
            model3.maxAyakkabıNumarası = 39;

            Product model4 = new Product();
            model4.ayakkabıAdi = "Skechers";
            model4.ayakkabıCinsiyeti = "Erkek Çocuk";
            model4.maxAyakkabıNumarası = 21;

            Product model5 = new Product();
            model5.ayakkabıAdi = "Adidas";
            model5.ayakkabıCinsiyeti = "Erkek";
            model5.maxAyakkabıNumarası = 44;

            Product model6 = new Product();
            model6.ayakkabıAdi = "Lumberjack";
            model6.ayakkabıCinsiyeti = "Kız Çocuk";
            model6.maxAyakkabıNumarası = 28;

            Product[] modeller = new Product[] {model1,model2,model3,model4 };


            foreach (Product model in modeller)
            {
                Console.WriteLine("Ayakkabı Adı :"+model.ayakkabıAdi +" \n"+ "Ayakkabı Cinsiyeti :"+model.ayakkabıCinsiyeti+ " \n"+ "Ayakkabı Numarası :"+ model.maxAyakkabıNumarası);
                Console.WriteLine("-----------------");
            }

            Console.WriteLine("-------***FIRSAT ÜRÜNLERİ----------");
            for (int i = 0; i < modeller.Length; i++)
            {
                if (modeller[i].maxAyakkabıNumarası>40)
                {
                    Console.WriteLine(modeller[i].ayakkabıAdi + "da %30 a varan indirimler vardır");
                }
                else
                {
                    Console.WriteLine(modeller[i].ayakkabıAdi + "da %40 a varan indirimler vardır");
                }
            }
        }
    }
    class Product
    {
        public string ayakkabıAdi { get; set; }
        public string ayakkabıCinsiyeti { get; set; }
        public int maxAyakkabıNumarası { get; set; }
    }
}

