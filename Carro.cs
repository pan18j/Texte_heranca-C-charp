namespace Heranca_Exercicio;

public class Carro : Class_base
{

    private bool farol_alto;

    public bool Farol_alto
    {
        get{return farol_alto;}
        set{farol_alto = value;}
    }

    public void farol_alto_carro()
    {
        if(Ligar_farois is true)
        { 
            
            if(farol_alto is true)
            {
                Console.WriteLine("O farol alto do carro esta ligado!");

            }
            else
                Console.WriteLine("O farol baixo esta ligado!");
                return;
        }
        else
        {
            Console.WriteLine("Ligue chave do carro!");

        }

    }



}
