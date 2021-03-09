using System; 

class URI {

    static void Main(string[] args) { 

            string n = Console.ReadLine();
            string v = "";
            
            int tamanho = n.Length;
            for(int i = tamanho-1; i >= 0; i--)
            {
            v = String.Concat(v,n[i]);
            }
            Console.WriteLine(v);

    }

}