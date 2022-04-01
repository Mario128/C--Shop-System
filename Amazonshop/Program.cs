using Amazonshop.models;
using System.Net.Mail;
using AShop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazonshop
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Article> Products = new List<Article>();

            char choiceMain, choiceSearch, choiceBasket, choicePurchase;
            string searchBrand, searchName;
            int searchId, number;
           
            Category searchCategory;
            Shop AShop = new Shop();
            User user;
           
            List<Article> foundArticle;

            do
            {
                Console.Clear();
                choiceMain = MainMenu();

                switch (choiceMain)
                {
                    case 's':
                        choiceSearch = SearchMenu();

                        switch (choiceSearch)
                        {
                            case 'i':
                                Console.Write("ID Suchen:");
                                searchId = Convert.ToInt32(Console.ReadLine());
                                foundArticle = AShop.SearchForID(searchId);
                                Console.WriteLine("Produkt mit eingegebener ID: " + searchId);
                                if (foundArticle == null)
                                {
                                    Console.WriteLine("Kein Produkt gefunden!");
                                }

                                else
                                {

                                    foreach (Article a in foundArticle)
                                    {
                                        Console.WriteLine(a);
                                        Console.WriteLine("In Warenkorb hinzufügen[j, n]: ");
                                        choiceBasket = Convert.ToChar(Console.ReadLine().ToLower());

                                        switch (choiceBasket)
                                        {
                                            case 'j':
                                                Console.WriteLine("\nWieviele ausgewählte Artikel dieser Art benötigen Sie");
                                                number = Convert.ToInt32(Console.ReadLine());
                                                AShop.AddToBasket(a, number);
                                                Console.WriteLine("Ihr/e ausgewählter/n Artikel wurde/n dem Warenkorb hinzugefügt.");

                                                break;

                                            case 'n':
                                                Console.WriteLine("Ihre Artikelsuche wird nun beendet.");
                                                break;
                                        }

                                    }

                                }

                                Console.ReadKey();
                                break;

                            case 'm':
                                Console.WriteLine("Marke suchen: ");
                                searchBrand = Console.ReadLine();
                                foundArticle = AShop.SearchForBrand(searchBrand);
                                Console.WriteLine("Produkt mit der Marke: " + searchBrand);
                                if (foundArticle == null)
                                {
                                    Console.WriteLine("Kein Produkt gefunden!");
                                }
                                else
                                {
                                    foreach (Article m in foundArticle)
                                    {
                                        Console.WriteLine(m);
                                        Console.WriteLine("In Warenkorb hinzufügen[j,n]: ");
                                        choiceBasket = Convert.ToChar(Console.ReadLine().ToLower());

                                        switch (choiceBasket)
                                        {
                                            case 'j':
                                                Console.WriteLine("\nWieviele ausgewählte Artikel dieser Art benötigen Sie?");
                                                number = Convert.ToInt32(Console.ReadLine());
                                                AShop.AddToBasket(m, number);
                                                Console.WriteLine("Ihr/e ausgewählter/n Artikel wurde/n dem Warenkorb hinzugefügt.");
                                                break;

                                            case 'n':
                                                Console.WriteLine("Ihre Artikelsuche wird nun beendet");
                                                break;
                                        }
                                    }
                                }
                                Console.ReadKey();
                                break;

                            case 'n':
                                Console.WriteLine("Nach Namen suchen: ");
                                searchName = Console.ReadLine();
                                foundArticle = AShop.SearchForName(searchName);
                                Console.WriteLine("Produkt mit gewünschten Namen: " + searchName);
                                if (foundArticle == null)
                                {
                                    Console.WriteLine("Kein Produkt gefunden!");
                                }
                                else
                                {
                                    foreach (Article n in foundArticle)
                                    {
                                        Console.WriteLine(n);
                                        Console.WriteLine("In Warenkorb hinzufügen[j,n]: ");
                                        choiceBasket = Convert.ToChar(Console.ReadLine().ToLower());

                                        switch (choiceBasket)
                                        {
                                            case 'j':
                                                Console.WriteLine("\nWieviele ausgewählte Artikel dieser Art benötigen Sie?");
                                                number = Convert.ToInt32(Console.ReadLine());
                                                AShop.AddToBasket(n, number);
                                                Console.WriteLine("Ihr/e ausgewählter/n Artikel wurde/n dem Warenkorb hinzugefügt.");
                                                break;

                                            case 'n':
                                                Console.WriteLine("Ihre Artikelsuche wird nun beendet!");
                                                break;
                                        }

                                    }
                                }
                                Console.ReadKey();
                                break;

                            case 'k':
                                Console.WriteLine("Nach Kategorie suchen:[1... Kleidung, 2... Bücher, 3... Elektronik, 4... Sport, 5... Unterhaltung] ");
                                searchCategory = (Category)Convert.ToInt32(Console.ReadLine());

                                foundArticle = AShop.SearchForCategory(searchCategory);
                                Console.WriteLine("Produkt(e) mit der gewünschten Kategorie: " + searchCategory);

                                if (foundArticle == null)
                                {
                                    Console.WriteLine("Kein Produkt gefunden");
                                }

                                else
                                {
                                    foreach (Article k in foundArticle)
                                    {
                                        Console.WriteLine(k);
                                        Console.WriteLine("In Warenkorb hinzufügen? [j,n]: ");
                                        choiceBasket = Convert.ToChar(Console.ReadLine().ToLower());
                                        switch (choiceBasket)
                                        {
                                            case 'j':
                                                Console.WriteLine("\nWieviele ausgewählte Artikel dieser Art benötigen Sie?");
                                                number = Convert.ToInt32(Console.ReadLine());
                                                AShop.AddToBasket(k, number);
                                                Console.WriteLine("Ihr/e ausgewählter/n Artikel wurde/n dem Warenkorb hinzugefügt:");
                                                break;

                                            case 'n':
                                                Console.WriteLine("Ihre Artikelsuche wird nun beendet!");
                                                break;
                                        }
                                    }
                                }
                                Console.ReadKey();
                                break;
                        }
                        break;

                    case 'w':
                        foreach (Article a in AShop.Basket)
                        {
                            Console.WriteLine("Name: " + a.Name);
                            Console.WriteLine("Preis: " + a.Price + " Euro");
                        }

                        Console.WriteLine("\n");
                        Console.WriteLine("Anzahl der Artikel: " + AShop.CountArticle);
                        Console.WriteLine("Gesamtpreis: " + AShop.Price + " Euro");
                        Console.ReadKey();
                        Console.Clear();


                        Console.WriteLine("Wollen Sie diese Artikel bestellen?[j,n]: ");
                        choicePurchase = Convert.ToChar(Console.ReadLine().ToLower());
                        switch (choicePurchase)
                        {
                            case 'j':
                                string body = "";
                                foreach(Article a in AShop.Basket)
                                {
                                    body = body + "" + Convert.ToString(a);
                                }
                                Console.WriteLine("Anzahl der Artikel: " + AShop.CountArticle);
                                Console.WriteLine("Gesamtpreis: " + AShop.Price + " Euro");
                                body = body + "\nAnzahl der Artikel: " + AShop.CountArticle;
                                body = body + "\nGesamtpreis: " + AShop.Price + "Euro";
                                Console.WriteLine("Geben Sie nun ihre Personendaten ein:");
                                user = PersonData();
                                Console.WriteLine("Nun benötigen wir nur noch Ihre Email-Adresse:");
                                string email = Console.ReadLine();
                                SendMail(email, body);
                                Console.WriteLine("Ihnen wird nun eine Bestätigungs-Email gesendet.");
                                                               
                                break;

                            case 'n':
                                Console.WriteLine("Sie werden nun zum Warenkorb zurückgeleitet.");
                                break;
                        }
                        break;
                }
            } while (choiceMain != 'b');
        }


        static char MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Zutreffende Taste drücken");
            Console.WriteLine("s... Nach Produkt suchen");
            Console.WriteLine("w... Warenkorb auflisten");
            Console.WriteLine("b... Menü beenden");

            return char.ToLower(Console.ReadKey().KeyChar);
        }

        static char SearchMenu()
        {
            Console.Clear();
            Console.WriteLine("Zutreffende Taste drücken");
            Console.WriteLine("i... Nach ID suchen");
            Console.WriteLine("m... Nach Marke suchen");
            Console.WriteLine("n... Nach Name suchen");
            Console.WriteLine("k... Nach Kategorie suchen");
            Console.WriteLine("b... Menü beenden");


            return char.ToLower(Console.ReadKey().KeyChar);
        }
    


        private static void SendMail(string email, string body)
        {
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("#");
            if(email == null) {  }
            else { mail.To.Add(email); }
            mail.Subject = "Bestätigung der Amazonbestellung vom " + DateTime.Today.ToShortDateString();

            mail.Body = body;
            SmtpClient client = new SmtpClient("smtp-mail.outlook.com", 587);
            client.Credentials = new System.Net.NetworkCredential("#", "#");
            client.EnableSsl = true;
            client.Send(mail);
            Console.WriteLine("Die Bestätigungsemail wurde gesendet!");
        }

        private static User PersonData()
        {
            User u = new User();

            Console.Write("Vorname: ");
            u.Firstname = Console.ReadLine();
            Console.Write("Nachname: ");
            u.Lastname = Console.ReadLine();           
            Console.Write("Alter: ");
            u.Age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Land: ");
            u.Country = Console.ReadLine();
            Console.Write("PLZ: ");
            u.PostalCode = Convert.ToInt32(Console.ReadLine());
            Console.Write("Stadt: ");
            u.City = Console.ReadLine();
            Console.Write("Straße: ");
            u.Street = Console.ReadLine();

            return u;
        }
    }
}
