using System.Security.Cryptography;
using Heranca_Exercicio;

namespace MinhaClass
{

    public class MinhaClassEx
    {

        static void Main(string[] args)
        {

            // Execicio, cria uma class mãe que sera Herdado por uma class (Carro) e class (Aviao)
            // que terão atributos e metodos emcomun.

            Aviao fab = new Aviao(false);
            fab.Transporte = "jato-774";
            fab.Acelerar = true;
            fab.Abrir_porta = true;
            fab.Liga = true;
            fab.Ligar_farois = true;
            fab.Acelerar = false;
            fab.Brecar = true;
            fab.Abrir_porta = true;
            fab.Acelerar = false;
            fab.Acelerar = true;
            fab.Abrir_porta = false;
            fab.Pista_liberada = true;
            fab.decolar_aeronave();
            fab.Abrir_porta = true;
            fab.decolar_aeronave();

            Console.WriteLine("-----------------------------------");

            Carro volkswagen = new Carro(false);
            volkswagen.Transporte = "Fosca";
            volkswagen.Brecar = true;
            volkswagen.Liga = true;
            volkswagen.Ligar_farois = true;
            volkswagen.Abrir_porta = true;
            volkswagen.Acelerar = true;
            volkswagen.Abrir_porta = false;
            volkswagen.Acelerar = true;
            volkswagen.Brecar = true;
            volkswagen.Ligar_farois = false;
            volkswagen.farol_alto_carro();
            volkswagen.Ligar_farois = true;
            volkswagen.farol_alto_carro();
            volkswagen.Farol_alto = true;
            volkswagen.farol_alto_carro();
            volkswagen.Ligar_farois = false;
            volkswagen.farol_alto_carro();
            volkswagen.Liga = false;
            volkswagen.farol_alto_carro();


   




        }
    }
}