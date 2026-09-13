using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fujitsu
{
    internal class Program
    {
        class ItemsDeCompra
        {
            public string Nombre { get; set; }
            public double Peso { get; set; }
        }
        static void Main(string[] args)
        {
            //lista desordenada
            List<ItemsDeCompra> Items = new List<ItemsDeCompra>();
            Items.Add(new ItemsDeCompra() { Nombre = "Mesa", Peso = 31.5 });
            Items.Add(new ItemsDeCompra() { Nombre = "Carne", Peso = 3.5 });
            Items.Add(new ItemsDeCompra() { Nombre = "Tomate", Peso = 2 });
            Items.Add(new ItemsDeCompra() { Nombre = "Lechuga", Peso = 0.8 });
            Items.Add(new ItemsDeCompra() { Nombre = "Pan", Peso = 1 });
            Items.Add(new ItemsDeCompra() { Nombre = "Queso", Peso = 3.5 });
            Items.Add(new ItemsDeCompra() { Nombre = "Jamon", Peso = 10.5 });
            Items.Add(new ItemsDeCompra() { Nombre = "Salmon", Peso = 8 });
            Items.Add(new ItemsDeCompra() { Nombre = "Mayonesa", Peso = 0.5 });
            Items.Add(new ItemsDeCompra() { Nombre = "Cebollas", Peso = 1.2 });
            Items.Add(new ItemsDeCompra() { Nombre = "Pechuga", Peso = 0.6 });
            Items.Add(new ItemsDeCompra() { Nombre = "Yogur", Peso = 0.9 });
            Items.Add(new ItemsDeCompra() { Nombre = "Nectarina", Peso = 2.6 });
            //ordenar lista
            var ListaOrdenada = Items.OrderByDescending(a => a.Peso).ToList();
            //colocar en cesta
            List<ItemsDeCompra> ItemsEnCesta = new List<ItemsDeCompra>(); //Puedo hacer var como cuadno ordene lista si no quiero explicitar el tipo de dato, pero me gusta mas explicitarlo.
            ItemsEnCesta = GuardarEnCesta(ListaOrdenada);
            //mostrar resultado
            foreach (var item in ItemsEnCesta)
            {
                Console.WriteLine(item.Nombre);
            }
            Console.WriteLine("Peso total: " + ItemsEnCesta.Sum(item => item.Peso) + "Kg.");
        }
        //colocar en cesta
        static List<ItemsDeCompra> GuardarEnCesta(List<ItemsDeCompra> Lista)
        {
            List<ItemsDeCompra> ItemsEnCesta = new List<ItemsDeCompra>();
            
            double peso = 0;
            for (int i = 0; i < Lista.Count - 1; i++)
            {
                peso += Lista[i].Peso;
                if (peso <= 20)
                    ItemsEnCesta.Add(Lista[i]);
                else
                    peso -= Lista[i].Peso;
            }
            return ItemsEnCesta;
        }
    }
}
