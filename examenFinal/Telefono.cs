using System;
using System.Collections.Generic;
using System.Text;

namespace examenFinal
{
    class Telefono
    {
        private string marca = "";
        private string modelo = "";
        private int anio = 0;
        private int espacio = 0;

        public Telefono() 
        {
        
        }
        public string getMarca() 
        {
            return this.marca;
        }
        public string getModelo ()
        {
            return this.modelo;
        }
        public int getAnio()
        {
            return this.anio;
        }
        public int getEspacio()
        {
            return this.espacio;
        }
        public void setMarca( string marca)
        {
            this.marca = marca;
        }
        public void setModelo(string modelo)
        {
            this.modelo = modelo;
        }
        public void setAnio(int anio)
        {
            this.anio = anio;
        }
        public void setEspacio(int espacio) 
        {
            this.espacio = espacio;
        }
    }
}
