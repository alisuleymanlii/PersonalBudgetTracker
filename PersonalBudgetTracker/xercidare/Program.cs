//--------------------------------PAROL SISTEM-----------------------------------------------------
string isimliste = "";
string sifrelist = "";
string yedeklist = "";

string isimdata = "isimdata.txt";
string sifredata = "sifredata.txt";
string yedekdata = "yedekdata.txt";

if ((File.Exists(isimdata) && File.Exists(sifredata) && File.Exists(yedekdata)) && (new FileInfo(isimdata).Length > 0 && new FileInfo(sifredata).Length > 0 && new FileInfo(yedekdata).Length > 0))
{
    isimliste = File.ReadAllLines(isimdata)[0];
    sifrelist = File.ReadAllLines(sifredata)[0];
    yedeklist = File.ReadAllLines(yedekdata)[0];
}
else
{
    Console.WriteLine("❗Admin hesabınız yoxdur❗");
    Console.WriteLine("❓Admin hesabı ne üçün lazımdır? \n✅Admin hesabı sizin şexsi xerclərinizin başqaları terefinden asandlıqla görülmemesi üçün lazımdır!");
    Console.Write("Admin hesabı üçün ad: ");
    string ad = Console.ReadLine();
    isimliste = ad;
    File.WriteAllText(isimdata, isimliste);

    Console.Write("Admin hesabı üçün şifre(Sadece herf ve reqemler): ");
    string sifre = Console.ReadLine();
    sifrelist = sifre;
    File.WriteAllText(sifredata, sifrelist);

    Console.WriteLine("Eger sifreniz unudarsanız bu suala verdiyiniz cavabla şifrenizi tezeliye bileceksiniz.");
    Console.Write("Sual - En sevdiyiniz film hansıdır?");
    string film = Console.ReadLine().ToLowerInvariant();
    yedeklist = film;
    File.WriteAllText(yedekdata, film);

    Console.WriteLine("💥Uğurla admin hesabınız açıldı!");
}

string isimgiris = "";
string sifregiris = "";
string filmgiris = "";
bool girisugurlu = false;

while (!girisugurlu)
{
    int giriscehd = 3;
    while (giriscehd > 0)
    {
        Console.Write("Adınızı girin: ");
        isimgiris = Console.ReadLine();
        if (isimgiris != isimliste)
        {
            giriscehd--;
            Console.WriteLine("Sehv giriş elədin! Qalan cehd şansı: " + giriscehd);
        }
        else
        {
            break;
        }
    }
    if (giriscehd == 0)
    {
        break;
    }

    giriscehd = 3;
    while (giriscehd > 0)
    {
        Console.Write("Şifrenizi girin: ");
        sifregiris = Console.ReadLine();
        if (sifregiris != sifrelist)
        {
            giriscehd--;
            Console.WriteLine("Sehv giriş elədin! Qalan cehd şansı: " + giriscehd);
        }
        else
        {
            girisugurlu = true;
            Console.WriteLine("Uğurla giriş elədiniz!");
            break;
        }
    }
    if (!girisugurlu)
    {
        Console.WriteLine("Şifre yenileme üçün şans! \nEn çox sevdiyiniz film hansıdır?");
        filmgiris = Console.ReadLine().ToLowerInvariant();
        if (filmgiris == yedeklist)
        {
            Console.Write("Yeni Sifrenizi girin: ");
            sifrelist = Console.ReadLine();
            File.WriteAllText(sifredata, sifrelist);
            if (sifregiris == sifrelist)
            {
                Console.WriteLine("Sifreniz ugurla yenilendi yeniden giris edirsiniz!");
                girisugurlu = true;
            }
        }
        else
        {
            Console.WriteLine("Şansınız qalmadı! Proqram bağlanır.");
            break;
        }
    }
}
//---------------------------------------------------------------------------------


//------------------------------NOTLAR--------------------------------------------
Console.WriteLine("---------------------------");
    Console.WriteLine("Gelir/Xerc proqramina xos geldiniz! Bu proqramin ümumi meqsedi gelir ve xercinizi elave edib ayliq gelirinizi hesablamaqdir.");
//---------------------------------------------------------------------------------



//--------------------------Kategoriya data--------------------------------------
string qidadb = "qidadb.txt";
string neqliyyatdb = "neqdb.txt";
string tehsildb = "tehsildb.txt";

List<string> qidalist = new List<string>();
List<string> neqlist = new List<string>();
List<string> tehlist = new List<string>();
//---------------------------------------------------------------------------

//------------------------------Gelir-Xerc datalar---------------------------

List<string> gelirlist = new List<string>();
List<string> xerclist = new List<string>();

string gelirdata = "gelirdata.txt";
string xercdata = "xercdata.txt";

if (File.Exists(gelirdata) && File.Exists(xercdata))
{
    string[] gelirlerim = File.ReadAllLines(gelirdata);
    string[] xerclerim = File.ReadAllLines(xercdata);

    int say = Math.Min(gelirlerim.Length, xerclerim.Length);

    for (int i = 0; i < say; i++)
    {
        gelirlist.Add(gelirlerim[i]);
        xerclist.Add(xerclerim[i]);

        File.WriteAllLines(gelirdata, gelirlist);
        File.WriteAllLines(xercdata, xerclist);
    }
}

























if (girisugurlu)
{
    do
    {
        Console.WriteLine("----**Menyu**----");
        Console.WriteLine("\n1-Gelir Elave Et \n2-Xerc Elave Et \n3-Ayliq Hesabla \n4-Yekun Netice \n5-Bağla");
        Console.Write("ID seçin: ");
        int id = Convert.ToInt32(Console.ReadLine());

        if (id == 1)
        {

        }
        else if (id == 2)
        {

        }
        else if (id == 3)
        {

        }
        else if (id == 4)
        {

        }
        else
        {
            Console.WriteLine("Sehv ID!");
        }
    } while (true);
}




