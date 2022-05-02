
class ClassDate
{
    //private int _jour, _mois, _annee;
    public int jour { get; set; }
    public int mois { get; set; }
    public int annee { get; set; }
    public string date{ get
        {
            return jour + "/" + mois + "/" + annee;
        }
        set
        {
            string[] chn = value.Split('/');
            jour = Convert.ToInt32(chn[0]);
            mois = Convert.ToInt32(chn[1]);
            annee = Convert.ToInt32(chn[2]);
        } 
    }
}


class Program
{


    static void Main(string[] args) 
    {
        Console.WriteLine("Propriétés");
        Console.WriteLine("==========");

        /*ExempleGetSet ex1 = new ExempleGetSet(123, "coucou")
        ex1.print();
        Console.ReadLine();*/

        ClassDate date1 = new ClassDate();

        date1.date = "01/02/2021";
        Console.WriteLine(date1.date + " Day : " + date1.jour + " Month : " +date1.mois + " Year : " + date1.annee);


    }

    
}