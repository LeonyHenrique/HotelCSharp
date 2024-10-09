// See https://aka.ms/new-console-template for more information
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
var camareira = new Camareira ()
{
    Nome = "Luciana",
    CPF ="123456",
    Telefone = "22558822"
};
camareira.SeApresentar();
camareira.LinparOQuarto();
camareira.ArrumarACama();

//Contratar um Recepcionista
var recepcionista = new Recepcionista ()
{
    Nome = "Luciano",
    CPF ="123456",
    Telefone = "22558822"
};
recepcionista.SeApresentar();
recepcionista.AtenderOTelefone();
recepcionista.FalarOBasicoDeIngles();

//Gerente
var gerente = new Gerente ()
{
    Nome = "Le",
    CPF ="1234546",
    Telefone = "22558822"
};
gerente.SeApresentar();
gerente.AtenderOTelefone();
gerente.FalarOBasicoDeIngles();
gerente.LinparOQuarto();
gerente.ArrumarACama();
