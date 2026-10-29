class Programm()
{
    public static void Main()
    {
        
        //try
        //{
        while (true)
        {
            try
            {


                Console.Write("Введите первое число");
                double parametr1 = Convert.ToDouble(Console.ReadLine());

                
                Console.Write("Введите второе число");
                double parametr2 = Convert.ToDouble(Console.ReadLine());

                
                Console.Write("Введите операцию");
                string op = Console.ReadLine();

               switch (op)
                {
                    case "+":
                        double res = parametr1 + parametr2;
                        Console.WriteLine(res);
                        break;
                    default:
                        throw new InvalidOperationException();
                }
               
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Не удалось преобразовать данные ");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine("Неверный символ операции");
            }
        }
            

                                                                
        //}
        //catch (FormatException ex) 
        //{
        //    string message = ex.Message;
        //    string stack = ex.StackTrace;
        //    var type = ex.GetType();
        //}
        //catch (DivideByZeroException ex)
        //{
            
        //}
        //catch
        //{

        //}
        //finally
        //{
            
            

            
        //}
    }
}
