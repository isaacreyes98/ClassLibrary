namespace Power;
public class Class1
{
        /// <summary>
        /// this method calculates the root
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
     public static double power(double a,double b) { 
        double powe;
        powe = Math.Pow(a, b);
        Console.WriteLine("The power of" +a+ "and" +b+ "is" +powe);
        return powe;
    }
        public static double pow(double powe, double c) {
            double powe1;
            powe1= Math.Pow(powe, c);
            Console.WriteLine("The power of" +powe+ "and" +c+ "is" +powe1);
            return powe1;
        }
        
 }

