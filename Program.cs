using System.Runtime.CompilerServices;

namespace sdc1_knowledge_check_2
{
    class Merchandise  // base class (parent) 
    {
        private string make; // field
        public string Make   // property
        {
            get { return make; }   // get method
            set { make = value; }  // set method
        }

        private string model; // field
        public string Model   // property
        {
            get { return model; }   // get method
            set { model = value; }  // set method
        }

        public void ToString()             // Instrument method 
        {
            Console.Write($" Make:{Make}");
            Console.WriteLine();
        }

    }

    class Instrument : Merchandise  // derived class (child)
    {
        private string name; // field
        public string Name   // property
        {
            get { return name; }   // get method
            set { name = value; }  // set method
        }
        public void ToString()             // Instrument method 
        {
            Console.WriteLine("   ♫   ♫   ♫   .");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many Instruments do you want to add? :");
            var numberOfRecords = int.Parse(Console.ReadLine());
            Console.WriteLine();
            int cpos = 0;
            var recordList = new List<Instrument>();
            for (int i = 0; i < numberOfRecords; i++)
            {
            //    // In this loop, populate the object's properties using Console.ReadLine()
                var instrument = new Instrument();
                cpos = i + 1;
                Console.Write($"Enter Instrument #{cpos}, Make:");
                instrument.Make = Console.ReadLine();
                Console.Write($"Enter Instrument #{cpos}, Model:");
                instrument.Model = Console.ReadLine();
                Console.Write($"Enter Instrument #{cpos}, Name:");
                instrument.Name = Console.ReadLine();

                recordList.Add(instrument);
                Console.WriteLine();
            }
            Console.WriteLine();
            cpos = 0;
            foreach(Instrument record in recordList)
            {
                cpos++;
                Console.WriteLine($"({cpos.ToString()}) Make[{record.Make}] Model[{record.Model}] Name[{record.Name}]");
                record.ToString();

            }

            // Print out the list of records using Console.WriteLine()
        }
    }
}