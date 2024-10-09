
using HotelCSharp.Interfaces;

namespace HotelCSharp.Models
{
    public class Camareira : Pessoa, ICamareira
    {
        public Camareira() 
        : base()
        {
        }

        public Camareira(string nome, string cpf, string telefone) 
        : base(nome, cpf, telefone)
        {
        }

        public void ArrumarACama()
        {
            System.Console.WriteLine("Sei arrumar a cama");
        }

        public void LinparOQuarto()
        {
            System.Console.WriteLine("Sei Limpar o quarto");
        }

        public override void SeApresentar()
        {
              System.Console.WriteLine("Olá sou a Camareira");
        }
    }
}