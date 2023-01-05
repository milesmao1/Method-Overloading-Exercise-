namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)

        {


        }

             public static int Add(int x, int y)
              {
                return (x + y);
              }      
        
              public static decimal Add(decimal a, decimal b) 
              {
                return a + b;
              }
        
              public static string Add(int num1, int num2, bool isTrue) 
              {
                 var sum = num1 + num2;
                 
                    if (isTrue && sum > 1) 
            
                    {
                        return $"{sum} dollars";
                    }
                    else if (isTrue && sum == 1) 
                    {
                        return $"{sum} dollar";
                    }

              }
    }
}
