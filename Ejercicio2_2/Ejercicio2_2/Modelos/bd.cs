using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using Ejercicio2_2.Modelos;
using System.Threading.Tasks;


namespace Ejercicio2_2.Modelos
{
    public class bd
    {
        readonly SQLiteAsyncConnection db;
        public bd()
        {
        }

        public bd(String pathbasedatos)
        {
            db = new SQLiteAsyncConnection(pathbasedatos);
            db.CreateTableAsync<claseConstructor>();
        }

        public Task<List<claseConstructor>> listaFirmas()
        {
            return db.Table<claseConstructor>().ToListAsync();
        }

        public Task<Int32> EmpleadoGuardar(claseConstructor emple)
        {
            if (emple.codigo != 0){
                return db.UpdateAsync(emple);
            }
            else {
                return db.InsertAsync(emple);
            }
        }
    }
}
