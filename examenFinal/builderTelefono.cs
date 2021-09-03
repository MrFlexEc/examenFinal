using System;
using System.Collections.Generic;
using System.Text;

namespace examenFinal
{
    abstract class builderTelefono
    {
        
        protected Telefono telefono;

        public Telefono getTelefono() 
        {
            return this.telefono;
        }
        
        public void crearNuevoTelf() 
        {
            this.telefono = new Telefono();
        }

        //Constructores para los atributos de cada telefono
        public abstract void crearModelo();
        public abstract void crearMarca();
        public abstract void crearAnio();
        public abstract void crearEspacio();

    }
}
