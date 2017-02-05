using PraktyczneKursy.Models;
using PraktyczneKursy.ViewModels;

namespace PraktyczneKursy.Infrastructure
{
    public class PostalMailService : IMailService
    {
        public void WyslaniePotwierdzenieZamowieniaEmail(Zamowienie zamowienie)
        {
            PotwierdzenieZamowieniaEmail email = new PotwierdzenieZamowieniaEmail();
            email.To = zamowienie.Email;
            email.From = "mariuszjurczenko@gmail.com";
            email.Wartosc = zamowienie.WartoscZamowienia;
            email.NumerZamowienia = zamowienie.ZamowienieID;
            email.PozycjeZamowienia = zamowienie.PozycjeZamowienia;
            email.sciezkaObrazka = AppConfig.ObrazkiFolderWzgledny;
            email.Send();
        }

        public void WyslanieZamowienieZrealizowaneEmail(Zamowienie zamowienie)
        {
            ZamowienieZrealizowaneEmail email = new ZamowienieZrealizowaneEmail();
            email.To = zamowienie.Email;
            email.From = "mariuszjurczenko@gmail.com";
            email.NumerZamowienia = zamowienie.ZamowienieID;
            email.Send();
        }
    }
}