//*****************************************************************************************
//*                                                                                       *
//* This is an auto-generated file by Microsoft ML.NET CLI (Command-Line Interface) tool. *
//*                                                                                       *
//*****************************************************************************************

using System;
using PredictUxWithoutFci.Model;

namespace PredictUxWithoutFci.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create single instance of sample data from first line of dataset for model input
            ModelInput sampleData = new ModelInput()
            {
                FirstContentfulPaint = 810F,
                TimeToInteract = 1623.0004F,
                ServerResponseTime = 148.574F,
                BootUpTime = 95.844F,
                FirstMeaningfulPaint = 810F,
                TotalBlockingTime = 1F,
                TotalByteWeight = 964194F,
                LargestContentfulPaint = 890F,
            };

            // Make a single prediction on the sample data and print results
            var predictionResult = ConsumeModel.Predict(sampleData);

            Console.WriteLine("Using model to make single prediction -- Comparing actual UserExperience with predicted UserExperience from sample data...\n\n");
            Console.WriteLine($"FirstContentfulPaint: {sampleData.FirstContentfulPaint}");
            Console.WriteLine($"TimeToInteract: {sampleData.TimeToInteract}");
            Console.WriteLine($"ServerResponseTime: {sampleData.ServerResponseTime}");
            Console.WriteLine($"BootUpTime: {sampleData.BootUpTime}");
            Console.WriteLine($"FirstMeaningfulPaint: {sampleData.FirstMeaningfulPaint}");
            Console.WriteLine($"TotalBlockingTime: {sampleData.TotalBlockingTime}");
            Console.WriteLine($"TotalByteWeight: {sampleData.TotalByteWeight}");
            Console.WriteLine($"LargestContentfulPaint: {sampleData.LargestContentfulPaint}");
            Console.WriteLine($"\n\nPredicted UserExperience: {predictionResult.Score}\n\n");
            Console.WriteLine("=============== End of process, hit any key to finish ===============");
            Console.ReadKey();
        }
    }
}
