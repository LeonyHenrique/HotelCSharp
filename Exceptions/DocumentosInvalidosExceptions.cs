
namespace HotelCSharp.Exceptions
{
    public class DocumentosInvalidosExceptions : Exception
    {
        public DocumentosInvalidosExceptions()
        : base("Documentos Inválidos, favor verificar")
        {

        }
        public DocumentosInvalidosExceptions(string mensage)
        : base(mensage)
        {

        }
    }
}