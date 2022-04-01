using AShop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazonshop.models
{
    class Shop
    {
        private List<Article> _articles = new List<Article>();
        public List<Article> Articles { get { return this._articles; } }

        private List<Article> _basket = new List<Article>();
        public List<Article> Basket { get { return this._basket; } }

        private decimal _price;
        public decimal Price
        {
            get { return this._price; }
            set
            {
                if (value >= 0.0m)
                {
                    _price = value;
                }
            }
        }
        private int _countArticle;
        public int CountArticle
        {
            get { return this._countArticle; }
            set
            {
                if(value>=0.0)
                {
                    _countArticle = value;
                }               
            }
        }

        private void CreateShop()
        {
            //TVs
            TV tv1 = new TV(1, " MU6179", " Die TV-Geräte der MU6er Serie bilden den Einstieg in die Welt der UHD-Auflösung.", 999.0m, 3840 * 2160, true, " Flat", 55, 17000, " schwarz", " Samsung");
            tv1.AddCategory(Category.electronics);
            tv1.AddCategory(Category.entertainment);
            TV tv2 = new TV(2, "32HC3160", "Diese Baureihe bietet Ihnen ein einzigartiges Fernseherlebnis.", 299.0m, 3840 * 2160, false, "Flat", 32, 4400, "grau", "Thomson");
            tv2.AddCategory(Category.electronics);
            tv2.AddCategory(Category.entertainment);
            TV tv3 = new TV(3, "LH85QMDP", "Das neueste Modell von Samsung verzaubert mit seinem Slim-Direct Bildschirm", 7613.17m, 3840 * 2160, true, "Slim-Flat", 85, 50000, "schwarz", "Samsung");
            tv3.AddCategory(Category.electronics);
            tv3.AddCategory(Category.entertainment);

            this._articles.Add(tv1);
            this._articles.Add(tv2);
            this._articles.Add(tv3);

            //Smartphones
            Smartphone sp1 = new Smartphone(64, 12, "IOS 11", true, 4.7, 136, "weiß", "Apple", "Klasse Handy", "IPhone 7", 558m, 4);
            sp1.AddCategory(Category.electronics);
            sp1.AddCategory(Category.entertainment);
            Smartphone sp2 = new Smartphone(64, 24, "Android 7.0", true, 5.8, 165, "schwarz", "Samsung", "Samsung überzeugt mit einem neuen tollen Bildschirm", "Galaxy S8", 568.00m, 5);
            sp2.AddCategory(Category.electronics);
            sp2.AddCategory(Category.entertainment);
            Smartphone sp3 = new Smartphone(16, 12, "Android 7.0", true, 5.2, 151, "titanium grau", "Huawei", "12MP Leica Dual-Kamera: Mehr Licht, mehr Details für fantastische Fotos und Videos", "Huawei P9", 286.00m, 6);
            sp3.AddCategory(Category.electronics);
            sp3.AddCategory(Category.entertainment);

            this._articles.Add(sp1);
            this._articles.Add(sp2);
            this._articles.Add(sp3);

            //Audiobooks            
            Audiobook ab1 = new Audiobook(575, "Psychothriller", "Flugangst 7A", 17.95m, 7, "Sebastian Fitzek");
            ab1.AddCategory(Category.books);
            ab1.AddCategory(Category.electronics);
            ab1.AddCategory(Category.entertainment);
            Audiobook ab2 = new Audiobook(1136, "Verschwörungen", "Origin", 34.95m, 8, "Dan Brown");
            ab2.AddCategory(Category.books);
            ab2.AddCategory(Category.electronics);
            ab2.AddCategory(Category.entertainment);
            Audiobook ab3 = new Audiobook(747, "Balance zwischen Beruf- und Privatleben", "Die 7 Wege zur Effektivität", 34.95m, 9, "Stephen R. Covey");
            ab3.AddCategory(Category.books);
            ab3.AddCategory(Category.electronics);
            ab3.AddCategory(Category.entertainment);

            this._articles.Add(ab1);
            this._articles.Add(ab2);
            this._articles.Add(ab3);

            //Textbooks
            TextBook tb1 = new TextBook(256, "Lustiges Tagebuch", "Gregs Tagebuch 12 - Und tschüss!", 14.99m, 10, "Luis ausm Ultn");
            tb1.AddCategory(Category.books);
            tb1.AddCategory(Category.entertainment);
            TextBook tb2 = new TextBook(640, "Roman", "Darker - Fifty Shades of Grey", 15.50m, 11, "E L James");
            tb2.AddCategory(Category.books);
            tb2.AddCategory(Category.entertainment);
            TextBook tb3 = new TextBook(448, "Memorien eines Psychotherapeuten", "Wie man wird, was man ist", 2.70m, 12, "Irvin D. Yalom");
            tb2.AddCategory(Category.books);
            tb2.AddCategory(Category.entertainment);

            this._articles.Add(tb1);
            this._articles.Add(tb2);
            this._articles.Add(tb3);

            //Tshirts             
            TShirt ts1 = new TShirt(Cut.VNeck,"Atmungsaktives Sportshirt","Sportshirt", 30.00m, 13, "dunkel Blau", "Atmungsaktive Faser", "Nike", Gender.male, 58);
            ts1.AddCategory(Category.clothes);
            ts1.AddCategory(Category.sports);
            TShirt ts2 = new TShirt(Cut.RoundNeck, "Das neueste Shirt von LEVIS", "T-Shirt", 31.57m, 14, "weiß", "Baumwolle", "LEVIS", Gender.female, 53);
            ts2.AddCategory(Category.clothes);
            TShirt ts3 = new TShirt(Cut.VNeck, "Unheimlich modisches T-Shirt von Tommy Hilfiger", "T-Shirt", 37.70m, 15, "schwarz", "Baumwolle", "Tommy Jeans", Gender.male, 58);
            ts3.AddCategory(Category.clothes);

            this._articles.Add(ts1);
            this._articles.Add(ts2);
            this._articles.Add(ts3);

            //Shoes
            Shoes s1 = new Shoes("Gummi", Shutter.shoelace, "Sport-Schuh", "Extrem leicht und bequem", "Casual Lace Up", 31.99m, 16, "dunkelgrün", "Mesh", "Maylen Hughes", Gender.male, 42);
            s1.AddCategory(Category.clothes);
            s1.AddCategory(Category.sports);
            Shoes s2 = new Shoes("Gummi", Shutter.velcroFastener, "Elegante Stieflette", "Stieflette mit 3cm hohen Absatz", "Leder Stieflette", 49.90m, 17, "schwarz", "Leder", "Review", Gender.female, 39);
            s2.AddCategory(Category.clothes);
            Shoes s3 = new Shoes("Gummi", Shutter.shoelace, "Cool, In", "Angenehm und leicht", "Straßenschuhe", 69.99m, 18, "braun", "Kunstfaser", "Burton", Gender.male, 41);
            s3.AddCategory(Category.clothes);

            this._articles.Add(s1);
            this._articles.Add(s2);
            this._articles.Add(s3);
        }

        public Shop()
        {
            CreateShop();
        }

        public List<Article> SearchForID(int id)
        {
            if (id == -1) { return null; }
            List<Article> foundArticle = new List<Article>();
            foreach (Article actArticle in this.Articles)
            {
                if (actArticle.IdNumber == id) { foundArticle.Add(actArticle); }
            }
            if (foundArticle.Count <= 0) { return null; }

            return foundArticle;
        }
        public List<Article> SearchForName(string name)
        {
            if (name == "") { return null; }
            name = name.Trim();

            List<Article> foundArticle = new List<Article>();
            foreach (Article actArticle in this.Articles)
            {
                if (actArticle.Name.ToLower().Equals(name.ToLower())) { foundArticle.Add(actArticle); }
            }

            if (foundArticle.Count <= 0) { return null; }
            return foundArticle;
        }

        public List<Article> SearchForBrand(string brand)
        {
            if (brand == "") { return null; }
            brand = brand.Trim();

            List<Article> foundArticle = new List<Article>();
            foreach (Article actArticle in this.Articles)
            {
                if (actArticle is Clothes)
                {
                    Clothes c = (Clothes)actArticle;
                    if (c.Brand.ToLower().Equals(brand.ToLower()))
                    {
                        foundArticle.Add(c);
                    }
                }
                if (actArticle is ElectricalEquipment)
                {
                    ElectricalEquipment e = (ElectricalEquipment)actArticle;

                    if (e.Brand.ToLower().Equals(brand.ToLower()))
                    {
                        foundArticle.Add(e);
                    }
                }
            }
            if (foundArticle.Count <= 0) { return null; }
            return foundArticle;
        }

        public List<Article> SearchForCategory(Category category)
        {
            if(category == Category.noCategory) { return null; }

            List<Article> foundArticle = new List<Article>();
            foreach (Article actArticle in this.Articles)
            {
                foreach (Category cat in actArticle.Categories)
                {
                    if (cat == category) {
                        foundArticle.Add(actArticle);
                    }
                }
            }
            if(foundArticle.Count <= 0) { return null; }
            return foundArticle;

        }

        public void AddToBasket(Article a, int number) {

            if(a == null) { return ; }

            for (int i = 1; i <= number; i++){
                this.Basket.Add(a);
                this.Price += a.Price;
                this.CountArticle++;
            }
        }
    }
}

