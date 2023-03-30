using System;

[Serializable]
public class Book
{
    public string Id { get; set; }
    public string Autor { get; set; }
    public string Tytuł { get; set; }
    public string Cena { get; set; }
    public string Strony { get; set; }
    public CoverType Okładka { get; set; }

    public Book()
    {
        Id = Guid.NewGuid().ToString("N"); 
    }

    public Book(string author, string title, string price, string pages, CoverType coverType)
    {
        Id = Guid.NewGuid().ToString("N");
        Autor = author;
        Tytuł = title;
        Cena = price;
        Strony = pages;
        this.Okładka = coverType; 
    }

}
