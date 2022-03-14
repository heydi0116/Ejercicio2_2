using System;
using System.Collections.Generic;
using System.Text;
using SQLite;


namespace Ejercicio2_2.Modelos
{
    public class claseConstructor
    {
        [PrimaryKey, AutoIncrement]
        public int codigo { get; set; }

        public string nombre { get; set; }

        public string descripcion { get; set; }

        public byte[] arreglo { get; set; }

    }

}
