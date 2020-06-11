using System;
namespace Aula15TryCatch
{
    public class Permissao
    {
        public bool Acesso { get; set; }

        public void Autorizar() {
            try{
                System.Console.WriteLine("Acessar true/false");
                Acesso = Boolean.Parse(Console.ReadLine());
            }
            catch(Exception){
                System.Console.WriteLine("erro");
            }
        }
    }
}