using System;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace MyBeerApp.ViewModel
{
    public class BeerViewModel : INotifyPropertyChanged
    {

        ObservableCollection<Beer> beers = new ObservableCollection<Beer>();

        public event PropertyChangedEventHandler PropertyChanged;

        public ObservableCollection<Beer> Beers { get { return beers; } }
        public BeerViewModel()
        {
            InitializeListOfbeers();

        }

        private void InitializeListOfbeers()
        {
            beers.Add(new Beer("Corona Extra", "corona.jpg", "La traditionnelle bière blonde Corona Extra, la bière mexicaine par excellence ! "));
            beers.Add(new Beer("Leffe Rituel", "leffe.jpg", "Une bière de haute fermentation à la belle robe cuivrée au caractère racé et prononcé !"));
            beers.Add(new Beer("Cuvée des trolls", "cuvee.jpg", "Une bière artisanale aux notes fruitées d'orange et de miel. Une référence en bière belge !"));
            beers.Add(new Beer("Rince Cochon", "rincecochon.jpg", "Rince Cochon, la bière qui met tout le monde d’accord !"));
            beers.Add(new Beer("Paix Dieu", "paixdieu.jpg", "Une bière blonde  artisanale de type Triple. Sa particularité est qu'elle n'est brassée qu'une seule fois par mois, par pleine lune. "));
            beers.Add(new Beer("Desperados", "despe.jpg", "Une bière blonde, légère et aromatisée à la tequila. Cette bière est un produit spécial qui est à la limite entre cocktail alcoolisé et bière."));
            beers.Add(new Beer("Tripel Karmeliet", "tripel.jpg", "Une bière de fermentation haute et refermentée en bouteille, elle présentait déjà à l'époque la particularité d'être produite à partir de trois céréales : l'orge, le froment et l'avoine. "));
            beers.Add(new Beer("La bière du Corbeau", "corbeau.jpg", "Une bière huileuse à la carbonatation modérée qui nous porte vers un final légèrement sec et amer."));
            beers.Add(new Beer("Pietra", "pietra.jpg", "Une bière à la robe ambrée qui se couvre d'une fine couche de mousse et offre au nez des arômes maltés accompagnés de senteurs boisées ainsi que de notes discrètes de châtaigne."));
            beers.Add(new Beer("Gulden Draak", "guldendraak.jpg", "Une bière habillée d'une robe noire et opaque, la Gulden Draak révèle rapidement des arômes puissants de malts torréfiés évoquant le chocolat noir et le cacao."));
        }
    }
}
