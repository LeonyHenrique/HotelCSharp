
using HotelCSharp.Interfaces;

namespace HotelCSharp.Models
{
    public class Recepcionista : Pessoa, IRecepcionista
    {
         public Recepcionista() 
        : base()
        {
        }

        public Recepcionista(string nome, string cpf, string telefone) 
        : base(nome, cpf, telefone)
        {
        }

        public void AtenderOTelefone()
        {
            System.Console.WriteLine("Sei atender o telefone");
        }

        public void FalarOBasicoDeIngles()
        {
            System.Console.WriteLine("Sei falar o basico de ingles");
        }

        public override void SeApresentar()
        {
           System.Console.WriteLine("Olá, sou a Recepcionista");
        }
    }
}