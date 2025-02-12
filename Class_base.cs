namespace Heranca_Exercicio;

public class Class_base
{

    private bool liga;
    private bool abrir_porta;
    private bool brecar;
    private bool ligar_farois;
    private bool acelerar;
    private string tranporte = string.Empty; 

    public string Transporte
    {
        get{return tranporte;}
        set{ tranporte = value;}
    }
    public bool Liga
    {
        get{return liga;}
        set
        {
            liga = value;
            if(liga is true)
            {
                Console.WriteLine($"O {tranporte} esta ligado!");

            }
            else
            {
                Console.WriteLine($"O {tranporte} esta desligado!");
                return;

            }
        }
    }
    public bool Abrir_porta
    {
        get{return abrir_porta;}
        set
        {
            abrir_porta = value;
            if(abrir_porta is true)
            {
                Console.WriteLine($"A borta do {tranporte} esta aberta!");

            }
            else
            {
                Console.WriteLine($"A borta do {tranporte} esta fachada!");
                return;

            }
        }
    }
    public bool Ligar_farois
    {
        get{return ligar_farois;}
        set
        {
            ligar_farois = value;
            if(ligar_farois is true)
            {
                Console.WriteLine($"O farol do {tranporte} esta ligado!");

            }
            else
            {
                Console.WriteLine($"O farol do {tranporte} esta desligado!");
                return;

            }
        }
    }
    public bool Acelerar
    {
        get{return acelerar;}
        set
        {
            if(liga is true && abrir_porta is false)
            {
                acelerar = value;
                if(acelerar is true && brecar is false)
                {
                    Console.WriteLine($"O {tranporte} esta acelerando!");

                }
                else
                {
                    Console.WriteLine($"O {tranporte} não pode acelera freido!");
                    return;
                }


            }
            else
            {
                Console.WriteLine($"O {tranporte} esta desligado ou a porta esta aberta!");
                return;

            }
        }
    }
    public bool Brecar
    {
        get{return brecar;}
        set
        {
            if(acelerar is true)
            {
                brecar = value;
                Console.WriteLine($"O {tranporte} esta freiando!");

            }
            else
            {
                Console.WriteLine($"O {tranporte} esta parado!");
                return;

            }
        }
    }
    public Class_base(bool ligado, bool abrir_porta, bool brecar, bool ligarfarol, bool acelerar)
    {
        liga = ligado;
        this.abrir_porta = abrir_porta;
        this.brecar = brecar;
        ligar_farois = ligarfarol;
        this.acelerar = acelerar;
 
    }




}
