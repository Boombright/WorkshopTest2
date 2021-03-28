using System;

namespace workshoptest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bucket 1st: ");
            int bucket1 = int.Parse(Console.ReadLine());
            Console.Write("Bucket 2st: ");
            int bucket2 = int.Parse(Console.ReadLine());
            Console.Write("Bucket 3st: ");
            int bucket3 = int.Parse(Console.ReadLine());
            Console.Write("Please add A or B: "); //ตรงนี้ผมต้องใส่เพิ่มเพื่อให้ตอนประกาศคนชนะมันประกาศได้นะครับ แฮะๆๆๆ
            char player = char.Parse(Console.ReadLine()); //เพราะงั้นตรงนี้จะใส่เป็นAหรือBก็ตามใจเลยครับ

            while (bucket1 != 0 || bucket2 != 0 || bucket3 != 0)
            {
                Console.WriteLine("Choose player: ");
                player = char.Parse(Console.ReadLine());

                Console.WriteLine("Choose Bucket: ");
                int bucketNum = int.Parse(Console.ReadLine());

                Console.WriteLine("Choose how many to remove: ");
                int bucketRemove = int.Parse(Console.ReadLine());

                if (player == 'A')
                {
                    if (bucketNum == 1)
                    {
                        bucket1 = bucket1 - bucketRemove;
                        Console.WriteLine("Bucket 1st: {0}", bucket1);
                    }
                    else if (bucketNum == 2)
                    {
                        bucket2 = bucket2 - bucketRemove;
                        Console.WriteLine("Bucket 2st: {0}", bucket2);
                    }
                    else if (bucketNum == 3)
                    {
                        bucket3 = bucket3 - bucketRemove;
                        Console.WriteLine("Bucket 3st: {0}", bucket3);
                    }
                }

                if (player == 'B')
                {
                    if (bucketNum == 1)
                    {
                        bucket1 = bucket1 - bucketRemove;
                        Console.WriteLine("Bucket 1st: {0}", bucket1);
                    }
                    else if (bucketNum == 2)
                    {
                        bucket2 = bucket2 - bucketRemove;
                        Console.WriteLine("Bucket 2st: {0}", bucket2);
                    }
                    else if (bucketNum == 3)
                    {
                        bucket3 = bucket3 - bucketRemove;
                        Console.WriteLine("Bucket 3st: {0}", bucket3);
                    }
                }

            }
            Console.WriteLine("");
            Console.WriteLine("{0} is winner", player);
            Console.ReadLine();
        }
    }
}
