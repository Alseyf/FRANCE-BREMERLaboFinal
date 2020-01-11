using DTO;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int selection;
        public ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
        public List<FullActorDTO> listeActeur = new List<FullActorDTO>();
        public ActorViewModel vue = new ActorViewModel();
        public int selectedId = 0;
        bool choix = true;
        public MainWindow()
        {
            selection = 0;
            
            InitializeComponent();
            listeActeur = client.GetFullActor(selection).ToList();
            BoxActeur.ItemsSource = listeActeur;
            BoxActeur.DisplayMemberPath = "Name";


        }

        private void RechercherTous_Click(object sender, RoutedEventArgs e)
        {
            selection = 0;

            choix = true;
            listeActeur=client.GetFullActor(selection).ToList();
            BoxActeur.ItemsSource = listeActeur;
            BoxActeur.DisplayMemberPath = "Name";
            LabelSelection.Content = selection + " - " + (selection + 10);

        }

        private void RechercherNom_Click(object sender, RoutedEventArgs e)
        {
            selection = 0;

            choix = false;
            listeActeur = client.FindActorByPartialName(Nom.Text, selection).ToList();
            BoxActeur.ItemsSource = listeActeur;
            BoxActeur.DisplayMemberPath = "Name";
            LabelSelection.Content = selection + " - " + (selection + 10);

        }

        private void BoutonPlus_Click(object sender, RoutedEventArgs e)
        {
            selection += 10;
            if (choix)
                listeActeur = client.GetFullActor(selection).ToList();
            else
                listeActeur = client.FindActorByPartialName(Nom.Text, selection).ToList();

            BoxActeur.ItemsSource = listeActeur;
            BoxActeur.DisplayMemberPath = "Name";
            LabelSelection.Content = selection + " - " + (selection+10);
        }

        private void BoutonMoins_Click(object sender, RoutedEventArgs e)
        {
            if (selection != 0)
            {
                selection -= 10;
                if (choix)
                    listeActeur = client.GetFullActor(selection).ToList();
                else
                    listeActeur = client.FindActorByPartialName(Nom.Text, selection).ToList(); 
                BoxActeur.ItemsSource = listeActeur;
                BoxActeur.DisplayMemberPath = "Name";
                LabelSelection.Content = selection + " - " + (selection+10);
            }
            
        }

   

        private void DoubleClick(object sender, MouseButtonEventArgs e)
        {
            int index = BoxActeur.SelectedIndex;
            vue = new ActorViewModel(listeActeur.ElementAt(index));
            selectedId = vue.idActor;
            ActorName.Content=vue.TxtActorName;

            GridActeur.ItemsSource = vue.Film;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var fen = new Commentaires(selectedId);
            fen.ShowDialog();
        }
    }
}
