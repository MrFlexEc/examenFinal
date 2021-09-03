using System;
using System.Collections.Generic;
using System.Text;

namespace examenFinal
{
    class director
    {
        public director() {
        
        }

        public void builder( builderTelefono builder) 
        {
            builder.crearNuevoTelf();

            builder.crearModelo();
            builder.crearMarca();
            builder.crearAnio();
            builder.crearEspacio();
        }
        
    }
}
