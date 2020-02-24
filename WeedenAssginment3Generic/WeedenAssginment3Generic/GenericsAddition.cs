using System;
using static System.Console;
namespace WeedenAssginment3Generic
{
    public class GenericsAddition
    {
        public delegate TypeOfValue AddMultipleTypes<TypeOfValue>(TypeOfValue num1, TypeOfValue num2);

        public GenericsAddition()
        {
        }

        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static double Add(double num1, double num2)
        {
            return num1 + num2;
        }

        public static float Add(float num1, float num2)
        {
            return num1 + num2;
        }

        public string[] Addition<TypeOfValue>(TypeOfValue num1, TypeOfValue num2, string type)
        {
            string[] response = new String[3];
            response[0] = Convert.ToString(num1);
            response[1] = Convert.ToString(num2);
            if(type == "double")
            {
                AddMultipleTypes<double> a = new AddMultipleTypes<double>(Add);
                response[2] = Convert.ToString(a(Convert.ToDouble(num1), Convert.ToDouble(num2)));
            }
            else if (type == "int")
            {
                AddMultipleTypes<int> a = new AddMultipleTypes<int>(Add);
                response[2] = Convert.ToString(a(Convert.ToInt16(num1), Convert.ToInt16(num2)));
            }
            //float
            else
            {
                AddMultipleTypes<float> a = new AddMultipleTypes<float>(Add);
                response[2] = Convert.ToString(a(Convert.ToInt32(num1), Convert.ToInt32(num2)));
            }

            return response;
        }
    }
}
