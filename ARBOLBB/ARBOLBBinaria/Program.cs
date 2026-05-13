namespace ARBOLBBinaria
{
    internal class Program
    {
        public static ArbolBB abb = new ArbolBB();
        public class ArbolBB
        {
            Nodo? raiz;

            public ArbolBB()
            {
                raiz = null;
            }
            public void Insertar(int info)
            {
                Nodo nuevo = new Nodo();
                nuevo.dato = info;
                nuevo.izq = null;
                nuevo.der = null;
                if (raiz == null) raiz = nuevo;
                else
                {
                    Nodo? ante = null, valor = raiz;
                    while (valor != null)
                    {
                        ante = valor;
                        if (info < ante.dato) valor = valor.izq;
                        else valor = valor.der;
                    }
                    if (info < ante.dato) ante.izq = nuevo;
                    else ante.der = nuevo;
                }
            }
            private void ImprimirPreOrden(Nodo valor)
            {
                if (valor != null)
                {
                    Console.Write(valor.dato + " ");
                    ImprimirPreOrden(valor.izq);
                    ImprimirPreOrden(valor.der);
                }
            }
            public void ImprimirPreOrden()
            {
                ImprimirPreOrden(raiz);
                Console.WriteLine();
            }
            private void ImprimirPostOrden(Nodo valor)
            {
                if (valor != null)
                {
                    ImprimirPostOrden(valor.izq);
                    ImprimirPostOrden(valor.der);
                    Console.Write(valor.dato + " ");
                }
            }
            public void ImprimirPostOrden()
            {
                ImprimirPostOrden(raiz);
                Console.WriteLine();
            }
            static void Main(string[] args)
            {
                int opcion;
                do
                {
                    Console.WriteLine("====Árbol====");
                    Console.WriteLine("1. Insertar edad");
                    Console.WriteLine("2. Recorrido PreOrden");
                    Console.WriteLine("3. Recorrido PostOrden");
                    Console.WriteLine("4. Salir");
                    Console.Write("Digitar # de alguna opción: ");

                    opcion = int.Parse(Console.ReadLine());

                    switch (opcion)
                    {
                        case 1: InsertarEdad(); break;
                        case 2: RecorridoPreOrden(); break;
                        case 3: RecorridoPostOrden(); break;
                        case 4: Console.WriteLine("Se ejecutó el programa con éxito"); Environment.Exit(0); break;
                        default: Console.WriteLine("Colocar el # de opción correcta"); break;
                    }
                    Console.WriteLine();
                } while (opcion != 4);
            }
            static void InsertarEdad()
            {
                Console.Write("Digitar edad: ");
                int edad = int.Parse(Console.ReadLine());
                abb.Insertar(edad);
            }
            static void RecorridoPreOrden()
            {
                abb.ImprimirPreOrden();
            }
            static void RecorridoPostOrden()
            {
                abb.ImprimirPostOrden();
            }
        }
    }
}