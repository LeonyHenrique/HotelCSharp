
using System.Collections.Generic;
using HotelCSharp.Interfaces;

namespace HotelCSharp.Models
{
    public class Hotel
    {
        public string Nome {get;set;}
        public Endereco Endereco {get;set;}
        public List <IRecepcionista> Recepcionistas {get; private set;}
        public List <ICamareira> Camareiras {get;private set;}
        public IGerente Gerente {get;private set;}
        public Hotel(string nome)
        {
            this.Nome = nome;
            Recepcionistas = new List <IRecepcionista>();
            Camareiras = new List <ICamareira>();
        }
        public Hotel(string nome, Endereco endereco)
        {
            this.Nome = nome;
            this.Endereco = endereco;
            Recepcionistas = new List <IRecepcionista>();
            Camareiras = new List <ICamareira>();
        }
        public void ContratarGerente(IGerente gerente)
        {
            this.Gerente = gerente;
        }
        public void ContratarCamareira(ICamareira camareira)
        {
            Camareiras.Add(camareira);
        }
        public void ContratarRecepcionista(IRecepcionista recepcionista)
        {
            Recepcionistas.Add(recepcionista);
        }


    }
}