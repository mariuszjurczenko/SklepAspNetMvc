using PraktyczneKursy.Models;

namespace PraktyczneKursy.Infrastructure
{
    public interface IMailService
    {
        void WyslaniePotwierdzenieZamowieniaEmail(Zamowienie zamowienie);
        void WyslanieZamowienieZrealizowaneEmail(Zamowienie zamowienie);
    }
}