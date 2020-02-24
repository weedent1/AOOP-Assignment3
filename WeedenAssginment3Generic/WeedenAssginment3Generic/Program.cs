using System;
using static System.Console;

namespace WeedenAssginment3Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayInfo info = new DisplayInfo();
            info.Display();

            UI ui = new UI();
            ui.Start();

            bool cont = true;

            while (cont)
            {

                string typeToAdd = ui.AskForType();
                GenericsAddition ga = new GenericsAddition();


                string firstNumber = ui.GetNumber("first");
                string secondNumber = ui.GetNumber("second");


                switch (typeToAdd)
                {
                    case "double":
                        string[] response = ga.Addition<double>(Convert.ToDouble(firstNumber), Convert.ToDouble(secondNumber), typeToAdd);
                        ui.DisplayResponse(response);
                        break;
                    case "int":
                        response = ga.Addition<int>(Convert.ToInt16(firstNumber), Convert.ToInt16(secondNumber), typeToAdd);
                        ui.DisplayResponse(response);
                        break;
                    case "float":
                        response = ga.Addition<float>(Convert.ToInt32(firstNumber), Convert.ToInt32(secondNumber), typeToAdd);
                        ui.DisplayResponse(response);
                        break;
                }

                cont = ui.Continue();
            }
        }
    }
}
