using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejoDeErrores
{
    public class TE
    {
        public List<Tabla_Errores> TErrores = new List<Tabla_Errores>();
        public List<Tabla_Errores> TErroresed = new List<Tabla_Errores>();

        public TE()
        {

        }
        public List<Tabla_Errores> TablaErrores
        {
            get { return TErrores; }
            set { TErrores = value; }
        }
        public void reinicialista()
        {
            TErrores.Clear();
            TErroresed.Clear();
        }
        public void inicialestaE()
        {

            Tabla_Errores te = new Tabla_Errores(0, "valor incorrecto", "escriba el valor aceptado por el tipo de variable", "valor diferente al aceptado por el tipo");
            TErrores.Add(te);

            Tabla_Errores te1 = new Tabla_Errores(1, "se espera un valor", "escriba un valor para la variable ", "se espera un valor despues de...");
            TErrores.Add(te1);

            Tabla_Errores te2 = new Tabla_Errores(2, "error al abrir", "revise la extencion del archivo o  la direccion del mismo", "error al abrir el archivo");
            TErrores.Add(te2);

            Tabla_Errores te3 = new Tabla_Errores(3, "error aritmetico", "revise la operación que esta realizando", "excepciones producidas durante operaciones aritméticas");
            TErrores.Add(te3);

            Tabla_Errores te4 = new Tabla_Errores(4, "error dividir por cero ", "escoja otro numero que no sea el 0 para dividir", "posible incongruencia en divicion,o en cualquier operación");
            TErrores.Add(te4);

            Tabla_Errores te5 = new Tabla_Errores(5, "error de conversion de tipo", "verifique que los tipos de las variables sea el mismo ", "Se produce cuando tiene lugar un error en tiempo de ejecución en una conversión explícita de un tipo base a una interfaz o a un tipo derivado.");
            TErrores.Add(te5);

            Tabla_Errores te6 = new Tabla_Errores(6, "error referencia nula", "revise que esta dando un valor ala variable", "Se produce al intentar hacer referencia a un objeto cuyo valor es null.");
            TErrores.Add(te6);

            Tabla_Errores te7 = new Tabla_Errores(7, "error de desbordamiento", "asegurese del tamaño del resultado ", "Se produce cuando una operación aritmética en un contexto produce un desbordamiento.");
            TErrores.Add(te7);
            Tabla_Errores te8 = new Tabla_Errores(8, "error de Ambito", "asegurese de que las llaves '{' tengan su contraparte '}' ", "Se produce cuando hay alguna llave sin cerrar, ambito incompleto");
            TErrores.Add(te8);
            Tabla_Errores te9 = new Tabla_Errores(9, "sintaxis desconocida", "asegurese de que la sintaxis sea correcta ", "Se produce cuando se desconoce la sintaxis de la sentencia");
            TErrores.Add(te9);
            Tabla_Errores te10 = new Tabla_Errores(10, "sintaxis erronea", "asegurese de que la sintaxis sea correcta, verifique espacios ", "Se produce cuando la sintaxis de la sentencia contiene algun error");
            TErrores.Add(te10);
            Tabla_Errores te11 = new Tabla_Errores(11, "warning", "asegurese de que las variables no esten repetidas ", "Se produce cuando mas de una variable estan inicializadas con el mismo nombre");
            TErrores.Add(te11);
        }

        public List<Tabla_Errores> llamatablaE()
        {
            return TErroresed;
        }

        public void addliste(int id, int nl)
        {
            foreach (var error in TErrores)
            {
                if (error.Id == id)
                {
                    Tabla_Errores er = new Tabla_Errores();
                    er.Descripcion = error.Descripcion;
                    er.Solucion = error.Solucion;
                    er.Error = error.Error;
                    er.NumerodeLinea = nl;
                    TErroresed.Add(er);
                }
            }
        }
        public void addliste(int id)
        {
            foreach (var error in TErrores)
            {
                if (error.Id == id)
                {
                    Tabla_Errores er = new Tabla_Errores();
                    er.Descripcion = error.Descripcion;
                    er.Solucion = error.Solucion;
                    er.Id = error.Id;
                    TErroresed.Add(er);
                }
            }
        }
    }
}
