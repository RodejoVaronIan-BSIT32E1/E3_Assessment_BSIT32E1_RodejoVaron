
namespace traingleTechnique
{
    class triangleTechnique
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculate Area of Triangle.");
            Console.WriteLine("Enter Height:");
            var height = Console.ReadLine();
            Console.WriteLine("Enter Width:");
            var width = Console.ReadLine();
            var area = (float.Parse(width) * float.Parse(height)) / 2;

            Console.WriteLine("Area: " + area);

            Console.WriteLine();

            Console.WriteLine("Biggest Number.");
            int[] sampleArr = { 10, 30, 40, 23, 2 };
            int largest = 0;
            
            Console.WriteLine("Array: [{0}]", string.Join(", ", sampleArr));

            for (int i = 0; i < sampleArr.Length; i++)
            {

                if (largest < sampleArr[i])
                {
                    largest = sampleArr[i];
                }
            }
            Console.WriteLine("Largest Number In Array: " + largest);

            Console.WriteLine();

            Console.WriteLine("Square Root.");


            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine(Math.Sqrt(i) + " Square Root of " + i);
            }


        }
    }
}
