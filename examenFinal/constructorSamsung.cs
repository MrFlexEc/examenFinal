using System;
using System.Collections.Generic;
using System.Text;

namespace examenFinal
{
    class constructorSamsung: builderTelefono
    {
        public constructorSamsung() 
        {
        
        }

        public override void crearModelo() 
        {
            this.telefono.setMarca("Marca");
        }
        public override void crearMarca()
        {
            this.telefono.setModelo("A50");
        }
        public override void crearAnio() 
        {
            this.telefono.setAnio(2020);
        }
        public override void crearEspacio() 
        {
            this.telefono.setEspacio(128);
        }
    }
}
