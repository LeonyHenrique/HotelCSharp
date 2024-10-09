// See https://aka.ms/new-console-template for more information
using HotelCSharp.Interfaces;
using HotelCSharp.Models;

Console.WriteLine("*******************************************");
Console.WriteLine("*                                         *");
Console.WriteLine("*      WELCOME TO THE GRAND HOTEL C#      *");
Console.WriteLine("*                                         *");
Console.WriteLine("*******************************************");
Console.WriteLine("*              ______                     *");
Console.WriteLine("*             |      |    HOTEL           *");
Console.WriteLine("*      _______|______|_______             *");
Console.WriteLine("*     |                     |             *");
Console.WriteLine("*     |   []    []   []     |             *");
Console.WriteLine("*     |                     |             *");
Console.WriteLine("*     |_____________________|             *");
Console.WriteLine("*******************************************");
Console.WriteLine();

//Contratar uma Camareira
ICamareira camareira1 = new Camareira ()
{
    Nome = "Luciana",
    CPF ="123456",
    Telefone = "22558822"
};
ICamareira camareira2 = new Camareira ()
{
    Nome = "Luci",
    CPF ="123456",
    Telefone = "22558822"
};


//Contratar um Recepcionista
IRecepcionista recepcionista1 = new Recepcionista ()
{
    Nome = "Luciano",
    CPF ="123456",
    Telefone = "22558822"
};
IRecepcionista recepcionista2 = new Recepcionista ()
{
    Nome = "Lucian",
    CPF ="123456",
    Telefone = "22558822"
};


//Gerente
IGerente gerente1 = new Gerente ()
{
    Nome = "Le",
    CPF ="1234546",
    Telefone = "22558822"
};
IGerente gerente2 = new Gerente ()
{
    Nome = "Leo",
    CPF ="1234546",
    Telefone = "22558822"
};

//inaugurando o Hotel
Hotel hotel = new Hotel ("HotelCSharp", new Endereco()
{
    CEP = "123456",
    Rua = "x y z",
    Numero = 1232,
    Complemento = "Esquina 1",
    Bairro = "Centro",
    Cidade = "São Paulo",

});
//contratando funcionario
hotel.ContratarCamareira(camareira1);
hotel.ContratarCamareira(camareira2);

hotel.ContratarRecepcionista(recepcionista1);
hotel.ContratarRecepcionista(recepcionista2);

hotel.ContratarGerente(gerente2);

//Gerente
hotel.Gerente.SaberSeApresentar();
hotel.Gerente.ArrumarACama();
hotel.Gerente.LinparOQuarto();
hotel.Gerente.AtenderOTelefone();
hotel.Gerente.FalarOBasicoDeIngles();

foreach (var camareira in hotel.Camareiras)
{
    camareira.SaberSeApresentar();
    camareira.ArrumarACama();
    camareira.LinparOQuarto();
}
foreach (var recepcionista in hotel.Recepcionistas)
{
    recepcionista.SaberSeApresentar();
    recepcionista.FalarOBasicoDeIngles();
    recepcionista.AtenderOTelefone();
}



