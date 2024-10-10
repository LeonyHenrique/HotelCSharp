// See https://aka.ms/new-console-template for more information
using HotelCSharp.Exceptions;
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
//Daqui p baixo tudo por conta do RH
IRHTerceirizado rh =new RH("RH CSharp", hotel);

//Contratar uma camareira
var camareira3 = new Camareira
{
    Nome= "Lucinda"
};

rh.ContratarCamareira(camareira3);

//Contratar uma recepcionista
var recepcionista3 = new Recepcionista
{
    Nome= "Luciana",
    CPF= "123154",
    Telefone="22558822"
};
rh.ContratarRecepcionista(recepcionista3);

//Promover uma camareira
var camareiraASerPromovida = new Camareira
{
    Nome= "Lucinda"

};
try
{
    rh.PromoverParaGerente(camareiraASerPromovida);
}
catch (DocumentosInvalidosExceptions ex)
{
    //tomar ação pq sei que foi erro de documento
    System.Console.WriteLine( ex.Message);
}
catch (Exception ex)
{
    //se cair aqui é pq deu ruim no sistema
    System.Console.WriteLine(ex.Message);
}



//Promover uma recepcionista
var recepcionistaASerPromovida = new Recepcionista
{
    Nome= "Luciana",
    CPF= "123154",

};
try
{
   rh.PromoverParaGerente(recepcionistaASerPromovida);
}
catch (DocumentosInvalidosExceptions ex)
{
    System.Console.WriteLine( ex.Message);
}

System.Console.WriteLine();



