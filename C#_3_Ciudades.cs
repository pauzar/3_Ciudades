using system; 
{
    public class Program
    {
        public static void Main()
        {
            //FASE 1 (2 punts)
    //● Crea sis variables tipu string buides. (0,5 punts)
    string ciutat1 = "";
    string ciutat2 = "";
    string ciutat3 = "";
    string ciutat4 = "";
    string ciutat5 = "";
    string ciutat6 = "";

    //● Demana per consola que s’introdueixin els noms. (0,5 punts)
    //● Introdueix els següents noms de ciutats (Barcelona, Madrid, Valencia, Malaga, Cadis, Santander) per
    //teclat. (0,5 punts)
    Console.WriteLine("Introduzca 6 nombres de ciudades");
            
    ciutat1 = Console.ReadLine();
    ciutat2 = Console.ReadLine();
    ciutat3 = Console.ReadLine();
    ciutat4 = Console.ReadLine();
    ciutat5 = Console.ReadLine();
    ciutat6 = Console.ReadLine();
            
    //● Mostra per consola el nom de les 6 ciutats. (0,5 punts)
    Console.WriteLine("El nombre de la ciudad es "+ciutat1);
    Console.WriteLine("El nombre de la ciudad es "+ciutat2);
    Console.WriteLine("El nombre de la ciudad es "+ciutat3);
    Console.WriteLine("El nombre de la ciudad es "+ciutat4);
    Console.WriteLine("El nombre de la ciudad es "+ciutat5);
    Console.WriteLine("El nombre de la ciudad es "+ciutat6);

    //FASE 2 (2 punts)
    //● Un cop tenim els noms de les ciutats guardats en variables haurem de pasar l’informacio a un array (arrayCiutats). (1 punt)

    String [] Arrayciutats = new String[6];
    Arrayciutats[0] = ciutat1;
    Arrayciutats[1] = ciutat2;
    Arrayciutats[2] = ciutat3;
    Arrayciutats[3] = ciutat4;
    Arrayciutats[4] = ciutat5;
    Arrayciutats[5] = ciutat6;
    //● Quan tinguem l’array ple, haurem de mostrar per consola el nom de les ciutats ordenadas per ordre
    //alfabetic. (1 punt)
    Array.Sort(Arrayciutats);
            
    Console.WriteLine(Arrayciutats);

    //FASE 3 (3 punts)
    //● Cambieu les vocals “a” dels noms de les ciutats per el numero 4 i guardeu els noms modificats en un nou
    //array(ArrayCiutatsModificades). (2 punts)

    String [] Arrayciutatsmodif  = new String[6];


    Arrayciutatsmodif[0]=Arrayciutats[0].Replace("a","4");
    Arrayciutatsmodif[1]=Arrayciutats[1].Replace("a","4");
    Arrayciutatsmodif[2]=Arrayciutats[2].Replace("a","4");
    Arrayciutatsmodif[3]=Arrayciutats[3].Replace("a","4");
    Arrayciutatsmodif[4]=Arrayciutats[4].Replace("a","4");
    Arrayciutatsmodif[5]=Arrayciutats[5].Replace("a","4");
    Console.WriteLine(Arrayciutatsmodif);

    //● Mostreu per consola l’array modificat i ordenat per ordre alfabetic. (1 punt)

    //FASE 4 (3 punts)
    //●Creeu un nou array per cada una de les ciutats que tenim. La mida dels nous arrays sera la
    //llargada de cada string ( string nomCiutat.Length). (0,5 punts)
    //● Ompliu els nous arrays lletra per lletra.(2 punts)
    //● Mostreu per consola els nous arrays amb els noms invertits (Ex: Barcelona - anolecraB). (0,5 punts)
    ciutat1 = Arrayciutats[0];
    ciutat2 = Arrayciutats[1];
    ciutat3 = Arrayciutats[2];
    ciutat4 = Arrayciutats[3];
    ciutat5 = Arrayciutats[4];
    ciutat6 = Arrayciutats[5];

    String [] Arrayciutats1 = new String[ciutat1.Length];
    String [] Arrayciutats2 = new String[ciutat2.Length];
    String [] Arrayciutats3 = new String[ciutat3.Length];
    String [] Arrayciutats4 = new String[ciutat4.Length];
    String [] Arrayciutats5 = new String[ciutat5.Length];
    String [] Arrayciutats6 = new String[ciutat6.Length];


    for (var m=0;m<ciutat1.Length;m++)
    {
        Arrayciutats1[ciutat1.Length-1-m]= ciutat1.Substring(m,1);
    }
    Console.WriteLine(Arrayciutats1);

    for (var m=0;m<ciutat2.Length;m++)
    {
        Arrayciutats2[ciutat2.Length-1-m]= ciutat3.Substring(m,1);
    }
    Console.WriteLine(Arrayciutats2);

    for (var m=0;m<ciutat3.Length;m++)
    {
        Arrayciutats3[ciutat3.Length-1-m]= ciutat3.Substring(m,1);
    }
    Console.WriteLine(Arrayciutats3);
            
    for (var m=0;m<ciutat4.Length;m++)
    {
        Arrayciutats4[ciutat4.Length-1-m]= ciutat4.Substring(m,1);
    }
    Console.WriteLine(Arrayciutats4);
        
    for (var m=0;m<ciutat5.Length;m++)
    {
        Arrayciutats5[ciutat5.Length-1-m]= ciutat5.Substring(m,1);
    }
    Console.WriteLine(Arrayciutats5);
        
    for (var m=0;m<ciutat6.Length;m++)
    {
        Arrayciutats6[ciutat6.Length-1-m]= ciutat6.Substring(m,1);
    }
    Console.WriteLine(Arrayciutats6);
            
        }
    }
}