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
using BuckVerwaltungssystem;

public class Buch
{
    public string Title { get; set; }
    public string Autor { get; set; }
    public string ISBN { get; set; }
    public int Erscheinungsjahr { get; set; }

    public Buch(string title, string autor, string isbn, int erscheinungsjahr)
    {
        Title = title;
        Autor = autor;
        ISBN = isbn;
        Erscheinungsjahr = erscheinungsjahr;
    }

    public void Hinzufügen(string title, string autor, string isbn, int erscheinungsjahr)
    {

    }

    public void Entfernen(string title, string autor, string isbn, int erscheinungsjahr)
    {

    }

    public string AnzeigenVonInformationen(string title, string autor, string isbn, int erscheinungsjahr)
    {
        return $"Titel: {title}, Autor: {autor}, ISBN: {isbn}, Erscheinungsjahr: {erscheinungsjahr}";
    }
}
