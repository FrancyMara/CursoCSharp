﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos 
    
    {

    public class  Moto {
        private string Marca;
        private string Modelo;
        private uint Cilindrada;

        public Moto (string marca, string modelo, uint cilindrada) {
            //Marca = marca;
            //Modelo = modelo;
            //Cilindrada = cilindrada;
            SetMarca(marca);
            SetModelo(modelo);
            SetCilindrada(cilindrada);


        }

        public Moto () { 

        }

        public string GetMarca() { 
            return Marca; }

        public void SetMarca(string marca) {
            Marca = marca;

        }

        public string GetModelo() {
            return Modelo;

         
        }

        public void SetModelo(string modelo) {
            Modelo = modelo;
        }

        public uint GetCilindrada() {
            return Cilindrada;
        }

        public void SetCilindrada(uint cilindrada) {
           // 1 Opçao
            //if (cilindrada > 0) {

                //Cilindrada = cilindrada;

            //}
            // 2 Opção
            //Cilindrada = Math.Abs(cilindrada);

            Cilindrada = cilindrada;

            
        }
    }
    internal class GetSet {
        public static void Executar() {
            var moto1 = new Moto("Biz", "HONDA", 100);

            Console.WriteLine(moto1.GetMarca());
            Console.WriteLine(moto1.GetModelo());
            Console.WriteLine(moto1.GetCilindrada());


            var moto2 = new Moto();

            moto2.SetMarca("TESTE");
            moto2.SetModelo("TESTE1");
            moto2.SetCilindrada(250);
            Console.WriteLine(moto2.GetMarca() + " " + moto2.GetModelo()  + " " + moto2.GetCilindrada () );





        }
    }
}
