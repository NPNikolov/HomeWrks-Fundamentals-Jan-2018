using System;

namespace p10_Cube_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            double qubeSide = double.Parse(Console.ReadLine());
            string requestedParamtr = Console.ReadLine();
            double reslt = CalcQubeParameter(requestedParamtr, qubeSide);
            Console.WriteLine($"{reslt,0:f2}");
        }

        static double CalcQubeParameter(string requestedParamtr, double qubeSide)
        {
            double reslt = 0;
            if (requestedParamtr=="volume")
            {
                reslt = Math.Pow(qubeSide, 3);
            }
            else if (requestedParamtr == "area")
            {
                reslt = 6*Math.Pow(qubeSide, 2);
            }
            else
            {
                reslt = CalcDiagnls(qubeSide, requestedParamtr);
            }
            
            return Math.Round(reslt, 2);
        }

        static double CalcDiagnls(double qubeSide, string type)
        {
            byte multiplier = 0;
            if (type == "space")
            {
                multiplier = 3;
            }
            else multiplier = 2;
            double reslt = Math.Sqrt((multiplier * Math.Pow(qubeSide, 2)));
            return reslt;
        }
        
    }
}
