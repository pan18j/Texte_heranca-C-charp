namespace Heranca_Exercicio;

public class Aviao : Class_base
{

    //Conteudo especifico da class avião
    private bool pista_liberada;
    public bool Pista_liberada
    {
        get{return pista_liberada;}
        set{pista_liberada = value;}
    }

    public void decolar_aeronave()
    {
        bool ligado = Liga;
        bool fechada = Abrir_porta;
        if(pista_liberada is true && ligado is true && fechada is true)
        {
            Console.WriteLine("A pista esta liberada para decolagem! Boa viagem!!");

        }
        else
        {
            Console.WriteLine("A pista não esta liberada para decolagem! A guarde alibeacão!");

        }


    }

}
