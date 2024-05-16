using System;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

public class Buch
{
    public string Title { get; set; }
    public string Autor { get; set; }
    public string ISBN { get; set; }
    public DateTime Erscheinnungsjahr { get; set; }

    public Buch(string title, string autor, string isbn, DateTime erscheinnungsjahr)
    {
        Title = title;
        Autor = autor;
        ISBN = isbn;
        Erscheinnungsjahr = erscheinnungsjahr;
    }

    public void Hinzufügen(string title, string autor, string isbn, DateTime erscheinnungsjahr)
    {

    }

    public void Entfernen(string title, string autor, string isbn, DateTime erscheinnungsjahr)
    {

    }

    public void Anzeigen(string title, string autor, string isbn, DateTime erscheinnungsjahr)
    {

    }
}
