﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Entidades
{
    public delegate void FabricarMuebleDelegate(Mueble mueble);
    public delegate void DiseñarMueble(Mueble mueble);
    public static class Fabrica
    {

        public static List<Material> listaDeMateriales;
        public static List<Mueble> listaDeMuebles;
        



        static Fabrica()
        {
            listaDeMateriales = new List<Material>();
            listaDeMuebles = new List<Mueble>();
        }

        public static void AgregarMaterial(Material material)
        {

            listaDeMateriales += material;

        }
        public static void AgregarProducto(Mueble producto)
        {

            if (producto.GetType() == (typeof(Ropero)))
            {
                Thread.Sleep(5000);
                listaDeMuebles.Add(producto);
            }
            else if (producto.GetType() == (typeof(Sillon)))
            {
                Thread.Sleep(3000);
                listaDeMuebles.Add(producto);
            }


        }
        public static void AgregarProducto(Ropero producto)
        {
            if (listaDeMateriales == producto.MaterialBase && listaDeMateriales == producto.MaterialEstantes)
            {
                listaDeMuebles.Add(producto);
                Thread.Sleep(5000);
            }
        }
        public static void AgregarProducto(Sillon producto)
        {
            if (listaDeMateriales == producto.MaterialBase && listaDeMateriales == producto.MaterialTapizado)
            {
                listaDeMuebles.Add(producto);
                
                Thread.Sleep(3000);
            }
            else
            {
                throw new MuebleNoAgregadoException();
            }
        }

        public static string MostrarListaDeMateriales()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("****lista de materiales disponibles**\n");
            foreach (Material item in listaDeMateriales)
            {
                sb.AppendLine("\n_________________________________");
                sb.Append(item.ToString());
            }
            return sb.ToString();

        }

        public static string MostrarListaDeMuebles()
        {

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("*********lista de Muebles disponibles*****");
            foreach (Mueble item in listaDeMuebles)
            {
                sb.Append("\n_________________________________");
                sb.Append(item.ToString());
            }
            return sb.ToString();
        }


    }
}
