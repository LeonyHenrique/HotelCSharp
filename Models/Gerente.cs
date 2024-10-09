
using HotelCSharp.Interfaces;

namespace HotelCSharp.Models
{
    public class Gerente : Pessoa, ICamareira, IRecepcionista
    {
        public Gerente() 
        : base()
        {
        }

        public Gerente(string nome, string cpf, string telefone) 
        : base(nome, cpf, telefone)
        {
        }

        public void ArrumarACama()
        {
           System.Console.WriteLine("Sei arrumar a cama pois sou o Gerente");
        }

        public void AtenderOTelefone()
        {
            System.Console.WriteLine("Sei atender o telefone pois sou o Gerente");
        }

        public void FalarOBasicoDeIngles()
        {
            System.Console.WriteLine("Sei falar inglês pois sou o Gerente");
        }

        public void LinparOQuarto()
        {
            System.Console.WriteLine("Sei o quarto pois sou o Gerente");
        }

        public override void SeApresentar()
        {
           System.Console.WriteLine("Olá sou o Gerente");
        }
    }
}