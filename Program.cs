namespace Dice
{
    class rand
    {
         static int dicrand()
        {
            Random r=new Random();
            return r.Next(1,7);
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("welcome to snakes and ladder");
            Console.WriteLine("enter no of players");
            int n=Convert.ToInt32(Console.ReadLine());
            int []gr=new int[n];
            int []score=new int[n];
            int points=100;
            for(int i=0;i<n;i++)
            {   
                score[i]=0;
                int v=dicrand();
                int e=dicrand();
                score[i]=v+e;
                gr[i]=score[i];  
            }
            for(int i=0;i<n;i++)
            {
                if(gr[i]==points)
                Console.WriteLine("player "+i+" is the winner");
                else
                break;
            }
        

        }
    }
}