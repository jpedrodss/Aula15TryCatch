namespace Aula15TryCatch
{
    public class Mario : Permissao
    {
        public void Correr(){
            System.Console.WriteLine("mario correndo");
            try
            {
                System.Console.WriteLine("deseja que mário corra mais rápido?");
                Acesso = System.Boolean.Parse(System.Console.ReadLine());

                if(Acesso){
                    System.Console.WriteLine("mario ta correndo mais rapido");
                }
            }
            catch (System.Exception)
            {
                System.Console.WriteLine("erro");                
            }
        } 
    }
}