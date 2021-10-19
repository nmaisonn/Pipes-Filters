using System;
using CompAndDel.Pipes;
using CompAndDel.Filters;

namespace CompAndDel
{
    class Program
    {
        static void Main(string[] args)
        {
            //Obtengo la imagen a la cual le voy a aplicar los filtros
            PictureProvider xProvider= new PictureProvider();
            IPicture xPicture=xProvider.GetPicture(@"luke.jpg");
            
            //Creo los filtros y los pipes. Los relaciono entre ellos
            IPipe xPipeNull=new PipeNull();
            
            IFilter xFilterNegative=new FilterNegative();
            IPipe xPipeSerial1=new PipeSerial(xFilterNegative,xPipeNull);
            
            IFilter xFilterTwitter=new FilterTwitter();
            IPipe xPipeSerialTwitter=new PipeSerial(xFilterTwitter,xPipeSerial1);

            IFilter xFilterSaver=new FilterSaver();
            IPipe xPipeSerial2=new PipeSerial(xFilterSaver,xPipeSerialTwitter);
            
            IFilter xFilterGreyscale=new FilterGreyscale();
            IPipe xPipeSerial3=new PipeSerial(xFilterGreyscale,xPipeSerial2);
            
            IPicture xImagen=xPipeSerial3.Send(xPicture);
            
            
            
        }
    }
}
