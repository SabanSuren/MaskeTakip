//Degişkenler();

using Business.Concretes;
using Entities.Concretes;

static void Degişkenler()
{
    string mesaj = "Merhaba";

    double tutar = 1000;

    var kdv = 18;

    Person person = new Person();
    person.FirstName = "";
    person.LastName = "";
    person.DateOfBirthYear = 123;
    person.NationalIdentity = 456;
    //Vatandas vatandas = new Vatandas();

    PttManager pttManager = new PttManager(new PersonManager());

    pttManager.GiveMask(person);

         
    //Console.WriteLine(mesaj);
    //Console.WriteLine(mesaj);
    //Console.WriteLine(mesaj);
    //Console.WriteLine(mesaj);
    //Console.WriteLine(mesaj);
    //Console.WriteLine(mesaj);

    Console.ReadLine();
}

//public class Vatandas
//{
//    public string Ad { get; set; }

//    public string Soyad { get; set; }

//    public int DogumYili { get; set; }

//    public long TcNo { get; set; }
//}
