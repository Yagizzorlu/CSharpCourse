namespace Arrays
{
    public class Program
    {
        static void Main(string[] args)
        {
            //string student1 = "Yağız";
            //string student2 = "Ahmet";
            //string student3 = "Metehan";
            //string student4 = "Mert";

            string[] students = new string[4];
            students[0] = "Yağız";
            students[1] = "Ahmet";
            students[2] = "Metehan";
            students[3] = "Mert";

            foreach (var student in students) 
            {
                Console.WriteLine(student);     //Tek tek hepsini dolaşır.
            }

            string[] students2 = new string[] { "Yağız", "Ahmet", "Metehan", "Mert" };  //Böyle de bir yazım şekli var.
            foreach (var student in students2)
            {
                Console.WriteLine(student);
            }

            string[,] regions = new string[5, 3];  //5 satır 3 sütun anlamındadır bu.
            regions[0, 0] = "İstanbul";
            regions[0, 1] = "İzmit";
            regions[0, 2] = "Balıkesir";
            regions[1, 0] = "Ankara";
            regions[1, 1] = "Konya";
            regions[1, 2] = "Kırıkkale";
            regions[2, 0] = "Antalya";
            regions[2, 1] = "Adana";
            regions[2, 2] = "Mersin";
            regions[3, 0] = "Rize";
            regions[3, 1] = "Trabzon";
            regions[3, 2] = "Samsun";
            regions[4, 0] = "İzmir";
            regions[4, 1] = "Muğla";
            regions[4, 2] = "Manisa";

            for (int i = 0; i <= regions.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i, j]);
                }
                Console.WriteLine("----------------");
            }
        }
    }
}
