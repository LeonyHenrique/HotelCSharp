
using HotelCSharp.Interfaces;

namespace HotelCSharp.Models
{
    public class RH : IRHTerceirizado
    {
        public string Nome { get; set; }
        public Hotel Hotel { get; set; }

        public RH(string nome, Hotel hotel) {
            this.Nome = nome;
            this.Hotel = hotel;
        }
        public void ContratarCamareira(ICamareira camareira)
        {
           //logica para entrevista
           
           Hotel.Camareiras.Add(camareira);
        }

        public void ContratarRecepcionista(IRecepcionista recepcionista)
        {
            //logica para entrevista
           Hotel.Recepcionistas.Add(recepcionista);
        }

        public void PromoverParaGerente(Camareira camareira)
        {
           //logica para entrevista
           Hotel.ContratarGerente(new Gerente()
           {
            Nome = camareira.Nome,
            CPF = camareira.CPF,
            Telefone = camareira.Telefone
           });
        }

        public void PromoverParaGerente(Recepcionista recepcionista)
        {
           //logica para entrevista
            Hotel.ContratarGerente(new Gerente()
           {
            Nome = recepcionista.Nome,
            CPF = recepcionista.CPF,
            Telefone = recepcionista.Telefone
           });
        }
    }
}