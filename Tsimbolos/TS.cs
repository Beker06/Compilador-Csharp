using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManejoDeErrores;

namespace Tsimbolos
{
    public class TS
    {
        public List<tabla_de_simbolos> TSimbolos = new List<tabla_de_simbolos>();
        TE tabla_errorres = new TE();

        public TS()
        {

        }
        public List<tabla_de_simbolos> TablaSimbolos
        {
            get { return TSimbolos; }
            set { TSimbolos = value; }
        }

        public void reinicialista()
        {
            TSimbolos.Clear();
        }

        #region Tabla de Simbolos , 51
        public void inicialista()
        {
            //string simb,string val,int nunlin,int tam,int ambit,int id_,string tip,string descrip
            tabla_de_simbolos ts = new tabla_de_simbolos("<</", "", -0, -0, -0, 0, "comentario", "inicio de un comentario de mas de una linea", "");
            TSimbolos.Add(ts);
            tabla_de_simbolos ts1 = new tabla_de_simbolos("/>>", "", -0, -0, -0, 1, "comentario", "final de un comentario de mas de una linea", "");
            TSimbolos.Add(ts1);
            tabla_de_simbolos ts2 = new tabla_de_simbolos("<<", "", -0, -0, -0, 2, "comentario", "inicio de un comentario de una linea", "");
            TSimbolos.Add(ts2);
            tabla_de_simbolos ts3 = new tabla_de_simbolos(">>", "", -0, -0, -0, 3, "comentario", "final de un comentario de una linea", "");
            TSimbolos.Add(ts3);
            tabla_de_simbolos ts4 = new tabla_de_simbolos("{", "", -0, -0, -0, 4, "bloque", "inicio de un bloque", "");
            TSimbolos.Add(ts4);
            tabla_de_simbolos ts5 = new tabla_de_simbolos("}", "", -0, -0, -0, 5, "bloque", "final de un bloque", "");
            TSimbolos.Add(ts5);
            tabla_de_simbolos ts6 = new tabla_de_simbolos("<#int", "", -0, -0, -0, 6, "palabra reservada", "numero entero", "");
            TSimbolos.Add(ts6);
            tabla_de_simbolos ts7 = new tabla_de_simbolos("<#integer", "", -0, -0, -0, 7, "palabra reservada", "numero entero", "");
            TSimbolos.Add(ts7);
            tabla_de_simbolos ts8 = new tabla_de_simbolos("<#double", "", -0, -0, -0, 8, "palabra reservada", "numero con decimales", "");
            TSimbolos.Add(ts8);
            tabla_de_simbolos ts9 = new tabla_de_simbolos("<#string", "", -0, -0, -0, 9, "palabra reservada", "cadena de caracteres", "");
            TSimbolos.Add(ts9);
            tabla_de_simbolos ts10 = new tabla_de_simbolos("<#bool", "", -0, -0, -0, 10, "palabra reservada", "booleano true o false", "");
            TSimbolos.Add(ts10);
            tabla_de_simbolos ts11 = new tabla_de_simbolos("<#boolean", "", -0, -0, -0, 11, "palabra reservada", "booleano true o false", "");
            TSimbolos.Add(ts11);
            tabla_de_simbolos ts12 = new tabla_de_simbolos(":", "", -0, -0, -0, 12, "asignacion", "simbolo de asignacion", "");
            TSimbolos.Add(ts12);
            tabla_de_simbolos ts13 = new tabla_de_simbolos(";", "", -0, -0, -0, 13, "posicionador", "final de linea", "");
            TSimbolos.Add(ts13);
            tabla_de_simbolos ts14 = new tabla_de_simbolos("'", "", -0, -0, -0, 14, "indicador de texto", "inicio y final de un texto", "");
            TSimbolos.Add(ts14);
            tabla_de_simbolos ts15 = new tabla_de_simbolos("&/", "", -0, -0, -0, 15, "posicionador", "salto de linea en un texto", "");
            TSimbolos.Add(ts15);
            tabla_de_simbolos ts16 = new tabla_de_simbolos("[", "", -0, -0, -0, 16, "arreglo", "inicio de asignacion de un arreglo", "");
            TSimbolos.Add(ts16);
            tabla_de_simbolos ts17 = new tabla_de_simbolos("]", "", -0, -0, -0, 17, "arreglo", "final de asignacion de un arreglo", "");
            TSimbolos.Add(ts17);
            tabla_de_simbolos ts18 = new tabla_de_simbolos("+", "", -0, -0, -0, 18, "operador", "suma", "");
            TSimbolos.Add(ts18);
            //tabla_de_simbolos ts19 = new tabla_de_simbolos("+", "", -0, -0, -0, 19, "concatenador", "concatenador de elementos");
            //TSimbolos.Add(ts19);
            tabla_de_simbolos ts20 = new tabla_de_simbolos("-", "", -0, -0, -0, 20, "operador", "resta", "");
            TSimbolos.Add(ts20);
            tabla_de_simbolos ts21 = new tabla_de_simbolos("*", "", -0, -0, -0, 21, "operador", "multiplicacion", "");
            TSimbolos.Add(ts21);
            tabla_de_simbolos ts22 = new tabla_de_simbolos("/", "", -0, -0, -0, 22, "operador", "division", "");
            TSimbolos.Add(ts22);
            tabla_de_simbolos ts23 = new tabla_de_simbolos("!", "", -0, -0, -0, 23, "signo relacionador", "negacion", "");
            TSimbolos.Add(ts23);
            tabla_de_simbolos ts24 = new tabla_de_simbolos(">", "", -0, -0, -0, 24, "signo comparador", "mayor que", "");
            TSimbolos.Add(ts24);
            tabla_de_simbolos ts25 = new tabla_de_simbolos("<", "", -0, -0, -0, 25, "signo comparador", "menor que", "");
            TSimbolos.Add(ts25);
            tabla_de_simbolos ts26 = new tabla_de_simbolos(">:", "", -0, -0, -0, 26, "signo comparador", "mayor o igual que", "");
            TSimbolos.Add(ts26);
            tabla_de_simbolos ts27 = new tabla_de_simbolos("<:", "", -0, -0, -0, 27, "signo comparador", "menor o igual que", "");
            TSimbolos.Add(ts27);
            tabla_de_simbolos ts28 = new tabla_de_simbolos("&", "", -0, -0, -0, 28, "signo relacionador", "expresion y (and)", "");
            TSimbolos.Add(ts28);
            tabla_de_simbolos ts29 = new tabla_de_simbolos("||", "", -0, -0, -0, 29, "signo relacionador", "expresion or", "");
            TSimbolos.Add(ts29);
            tabla_de_simbolos ts30 = new tabla_de_simbolos("::", "", -0, -0, -0, 30, "signo comparador", "expresion igual", "");
            TSimbolos.Add(ts30);
            tabla_de_simbolos ts31 = new tabla_de_simbolos("!:", "", -0, -0, -0, 31, "signo comparador", "expresion distinto", "");
            TSimbolos.Add(ts31);
            tabla_de_simbolos ts32 = new tabla_de_simbolos("<<si_", "", -0, -0, -0, 32, "palabra reservada", "si tal condicion se cumple", "");
            TSimbolos.Add(ts32);
            tabla_de_simbolos ts33 = new tabla_de_simbolos("<<ysi_", "", -0, -0, -0, 33, "palabra reservada", "y si tal condicion se cumple en vez de la anterior", "");
            TSimbolos.Add(ts33);
            tabla_de_simbolos ts34 = new tabla_de_simbolos("<<sino", "", -0, -0, -0, 34, "palabra reservada", "si no se cumple la condicion", "");
            TSimbolos.Add(ts34);
            tabla_de_simbolos ts35 = new tabla_de_simbolos("#ncasd", "", -0, -0, -0, 35, "palabra reservada", "opciones (casos)", "");
            TSimbolos.Add(ts35);
            tabla_de_simbolos ts36 = new tabla_de_simbolos("casd", "", -0, -0, -0, 36, "palabra reservada", "caso", "");
            TSimbolos.Add(ts36);
            tabla_de_simbolos ts37 = new tabla_de_simbolos("fcasd", "", -0, -0, -0, 37, "palabra reservada", "final del caso", "");
            TSimbolos.Add(ts37);
            tabla_de_simbolos ts38 = new tabla_de_simbolos("#mintrs", "", -0, -0, -0, 38, "palabra reservada", "mientras", "");
            TSimbolos.Add(ts38);
            tabla_de_simbolos ts39 = new tabla_de_simbolos("#pr", "", -0, -0, -0, 39, "palabra reservada", "for", "");
            TSimbolos.Add(ts39);
            tabla_de_simbolos ts40 = new tabla_de_simbolos("#prlist", "", -0, -0, -0, 40, "palabra reservada", "foreach", "");
            TSimbolos.Add(ts40);
            tabla_de_simbolos ts41 = new tabla_de_simbolos("#funcion", "", -0, -0, -0, 41, "palabra reservada", "expresion para determinar un metodo", "");
            TSimbolos.Add(ts41);
            tabla_de_simbolos ts42 = new tabla_de_simbolos("#try", "", -0, -0, -0, 42, "palabra reservada", "intenta realizar el codigo contenido", "");
            TSimbolos.Add(ts42);
            tabla_de_simbolos ts43 = new tabla_de_simbolos("#catch", "", -0, -0, -0, 43, "palabra reservada", "muestra una accion a seguir en caso de error", "");
            TSimbolos.Add(ts43);
            tabla_de_simbolos ts44 = new tabla_de_simbolos("#mostrar", "", -0, -0, -0, 44, "palabra reservada", "muestra en consola", "");
            TSimbolos.Add(ts44);
            tabla_de_simbolos ts45 = new tabla_de_simbolos("#leer", "", -0, -0, -0, 45, "palabra reservada", "pide en consola", "");
            TSimbolos.Add(ts45);
            tabla_de_simbolos ts46 = new tabla_de_simbolos("#ejc", "", -0, -0, -0, 46, "palabra reservada", "ejecuta setencia", "");
            TSimbolos.Add(ts46);
            tabla_de_simbolos ts47 = new tabla_de_simbolos("#clase", "", -0, -0, -0, 47, "palabra reservada", "clase", "");
            TSimbolos.Add(ts47);
            tabla_de_simbolos ts48 = new tabla_de_simbolos("(", "", -0, -0, -0, 48, "parametro", "inicia peticion de parametro", "");
            TSimbolos.Add(ts48);
            tabla_de_simbolos ts49 = new tabla_de_simbolos(")", "", -0, -0, -0, 49, "parametro", "termina peticion de parametro", "");
            TSimbolos.Add(ts49);
            tabla_de_simbolos ts50 = new tabla_de_simbolos(",", "", -0, -0, -0, 50, "concatenador", "concatena variables", "");
            TSimbolos.Add(ts50);

            //---------------------------------------------asi deberian entrar los datos nuevos encontrados-------------------------------------------------
            //tabla_de_simbolos ts51 = new tabla_de_simbolos("", "", -0, -0, -0, 51, "numero", "especifica un numero");
            //TSimbolos.Add(ts51);
            //tabla_de_simbolos ts52 = new tabla_de_simbolos("", "", -0, -0, -0, 52, "identificador", "especifica una palabra que identifica una variable");
            //TSimbolos.Add(ts52);
            //----------------------------------------------------------------------------------------------------------------------------------------------

        }
        #endregion

        public List<tabla_de_simbolos> llamatabla()
        {
            return TSimbolos;
        }

        public void añadir_obj(tabla_de_simbolos Ts)
        {
            TSimbolos.Add(Ts);
        }

        public bool compararAL(string argsplit)
        {
            bool bandera = false;
            foreach (var palabra in TSimbolos)
            {

                if (palabra.simbolo == argsplit)
                {
                    bandera = true;
                    break;
                }
                else
                {
                    bandera = false;
                }

            }
            return bandera;
        }
        //----------------------------------------------------------------
        public bool revisar_duplicados()
        {
            bool flag = false;
            //int cont = 0;
            foreach (var sent1 in TSimbolos)
            {
                foreach (var sent2 in TSimbolos)
                {
                    if (sent1.ID == sent2.ID)//&& sent1.TipoVar == sent2.TipoVar
                    {

                        flag = true;


                        //cont += 1;
                    }
                }
            }
            return flag;
        }
        //----------------------------------------------------------------
        public void compararALsemantic()
        {
            foreach (var palabra in TSimbolos)
            {
                foreach (var palabra2 in TSimbolos)
                {
                    if (palabra.Simbolo == palabra2.Simbolo)
                    {
                        palabra2.TipoVar = palabra.TipoVar;
                        //break;
                    }
                }
            }
        }

        //----------------------------------------------------------------

        public int compararALRef(string argsplit)
        {
            int id = 0;
            foreach (var palabra in TSimbolos)
            {

                if (palabra.simbolo == argsplit)
                {
                    id = palabra.id;
                    break;
                }
                else
                {
                    id = 0;
                }

            }
            return id;
        }

        //--------------------------------------------------------------
        public int contlineas()
        {
            int numid = 0;
            foreach (var nlinea in TSimbolos)
            {
                numid = numid + 1;
            }
            return numid - 1;
        }
    }
}
