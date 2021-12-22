// See https://aka.ms/new-console-template for more information
using static System.Console;
// using Microsoft.Extensions.Logging;
using System.Text;
using CalculatorLogger;


namespace project1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // var loggerFactory = db.GetService<ILoggerFactory>();
            // loggerFactory.AddProvider(new LoggerProvider());

             // define a file to write to
            // string textFile = Combine(CurrentDirectory, "streams.txt");

            // // create a text file and return a helper writer 
            // StreamWriter text = File.CreateText(textFile);

            // try
            // {
                var logger = new Logger();

                Write("Input Your First Number: ");
                int FirstNumber =  Convert.ToInt32(ReadLine());

                Write("Input Your Second Number: ");
                int SecondNumber = Convert.ToInt32(ReadLine());

                decimal division = (decimal)  FirstNumber / SecondNumber;
                decimal addition = (decimal)  FirstNumber + SecondNumber;
                decimal Multiplication = (decimal)  FirstNumber * SecondNumber;
                decimal subtraction = (decimal)  FirstNumber - SecondNumber;

                Write("What operation do you want to perform: ");
                var OperatorType = Convert.ToChar(ReadLine());

                switch (OperatorType)
                {
                    case '+':
                        WriteLine($"{FirstNumber} + {SecondNumber} = {addition}");
                        logger.Log($"{FirstNumber} + {SecondNumber} = {addition}");
                        break;
                    case '-':
                        WriteLine($"{FirstNumber} - {SecondNumber} = {subtraction}");
                        logger.Log($"{FirstNumber} - {SecondNumber} = {subtraction}");
                        break;
                    case '/':
                        WriteLine($"{FirstNumber} / {SecondNumber} = {division}");
                        logger.Log($"{FirstNumber} / {SecondNumber} = {division}");
                        break;
                    case '*':
                        WriteLine($"{FirstNumber} * {SecondNumber} = {Multiplication}");
                        logger.Log($"{FirstNumber} * {SecondNumber} = {Multiplication}");
                        break;
                    default:
                        WriteLine("You entered the wrong operator sign");
                        break;

                } 
            // }
            // catch (Exception ex)
            // {
                
            //     throw logger.Log(ex.Message);
            // }
            
        }
    } 
}
