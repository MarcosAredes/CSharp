using System; 

class Program{
    static void Main(){
        //double > float > long > int > char

        //Implicita -> do menor para maior

            int num1 = 20;
            float num2 = num1;
            Console.WriteLine(num2);
            
        //Explicita -> do maior para menor

            float n1 = 20.5f;
            int n2 = (int)n1; //TypeCast
            Console.WriteLine(n2);
    }
}