using System;
using System.Diagnostics;

namespace Example3._54
{
    class Program
    {
        static void Main(string[] args)
        {
            if (CreatePerformanecCounters())
            {
                Console.WriteLine("Created performance counters");
                Console.WriteLine("Please restart the application");
                Console.ReadKey();

                return;
            }

            var totalOperationsCounter = new PerformanceCounter(
                "MyCategory",
                "# operations executed",
                "",
                false);
            var operationsPerSecondCounter = new PerformanceCounter(
                "MyCategory",
                "# operations sec",
                "",
                false);

            totalOperationsCounter.Increment();
            operationsPerSecondCounter.Increment();
        }

        private static bool CreatePerformanecCounters()
        {
            if (!PerformanceCounterCategory.Exists("MyCategory"))
            {
                CounterCreationDataCollection counters = new CounterCreationDataCollection() 
                { 
                    new CounterCreationData(
                        "# operations executed",
                        "Total number of operations executed",
                        PerformanceCounterType.NumberOfItems32
                        ),
                    new CounterCreationData(
                        "# operations / sec",
                        "Total operations executed per second",
                        PerformanceCounterType.NumberOfItems32
                        )
                };

                PerformanceCounterCategory.Create("MyCategory", "Sample category for Codeproject", counters);

                return true;
            }

            return false;
        }
    }
}
