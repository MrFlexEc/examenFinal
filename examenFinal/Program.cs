using System;

namespace examenFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            director fabrica = new director();

            builderTelefono telefono = new constructorSamsung();

            fabrica.builder(telefono);
            Telefono samsung = telefono.getTelefono();

            
        }
    }
}
