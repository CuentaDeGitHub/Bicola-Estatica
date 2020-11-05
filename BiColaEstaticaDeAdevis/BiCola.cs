using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BiColaEstaticaDeAdevis
{
    class BiCola
    {
        private int tail;
        public int Tail
        {
            get { return tail; }
            set { tail = value; }
        }
        private int head;
        public int Head
        {
            get { return head; }
            set { head = value; }
        }
        private int maximo;
        public int Maximo
        {
            get { return maximo; }
            set { maximo = value; }
        }
        public string[] arregloBicola;
        public BiCola(int Tamaño)
        {
            Maximo = Tamaño;
            arregloBicola = new string[Maximo];
            head = tail = -1;
        }

        public bool EstaVacia()
        {
            if (Head == -1)
            {
                return true;
            }
            return false;
        }

        public bool EstaLlena()
        {
            if(Tail == Maximo - 1 && Head == 0)
            {
                return true;
            }
            return false;
        }
        public void EncolarIzquierda(string elemento)
        {
            if (EstaLlena())
            {
                return;
            }
            if (EstaVacia())
            {
                tail = head = 0;
                arregloBicola[head] = elemento;
            }
            else
            {
                if(Head - 1 == -1)
                {
                    int contador = ++tail;

                    for (int i = 0; i< tail; i++) 
                    {
                        arregloBicola[contador] = arregloBicola[--contador];
                    }
                    arregloBicola[Head] = elemento;
                }
                else
                {
                    arregloBicola[--head] = elemento;
                }
            }
        }
        public void EncolarDerecha(string elemento)
        {
            if (EstaLlena())
            {
                return;
            }
            if (EstaVacia())
            {
                tail = head = 0;
                arregloBicola[Head] = elemento;
            }
            else
            {
                if(tail + 1 == Maximo)
                {
                    int contador = --head;      
                    for (int i = 0; i < (Maximo - head); i++)
                    {
                        arregloBicola[contador] = arregloBicola[++contador];;
                    }
                    arregloBicola[tail] = elemento;
                }
                else
                {
                    arregloBicola[++tail] = elemento;
                }
            }
        }
        public void DesencolarIzquierda()
        {
            if (EstaVacia())
            {
                return;
            }
            if (head == tail)
            {
                arregloBicola[head] = null;
                head = tail = -1;
            }
            else
            {
                arregloBicola[head] = null;
                head = head + 1;
            }
        }
        public void DesencolarDerecha()
        {
            if (EstaVacia())
            {
                return;
            }
            if (Head == Tail)
            {
                arregloBicola[Head] = null;
                Head = Tail = -1;
            }
            else
            {
                arregloBicola[Tail] = null;
                Tail = Tail - 1;
            }
        }

       public string Front()
        {
            return arregloBicola[0];
        }

        public string Imprimir()
        {
            string colaString = "";
            if (EstaVacia())
            {
                return "La cola esta vacia";
            }
            else
            {
                colaString += arregloBicola[0];
                for (int i = 1; i < arregloBicola.Length; i++)
                {

                    colaString += "," + arregloBicola[i];
                }
                return colaString;
            }
        }
        public string ImprimirFormato()
        {
            string colaString = "";
            if (EstaVacia())
            {
                return "La cola esta vacia";
            }
            else
            {
                colaString += arregloBicola[head];
                for (int i = head + 1; i != tail + 1; i++)
                {
                    colaString += "," + arregloBicola[i];
                }
                return colaString;
            }
        }   

    }
}
