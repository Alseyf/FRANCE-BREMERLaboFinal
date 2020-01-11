using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WPF
{
    /// <summary>
    /// Logique d'interaction pour Commentaires.xaml
    /// </summary>
    public partial class Commentaires : Window
    {
        public int selectedId;
        public ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
        public List<CommentDTO> listeComment = new List<CommentDTO>();


        public Commentaires()
        {
            InitializeComponent();
        }

        public Commentaires(int id)
        {
            InitializeComponent();
            selectedId = id;
            listeComment = client.GetComments(id).ToList();
            GridComment.ItemsSource = listeComment;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            CommentDTO commDTO = new CommentDTO
            {
                avatar = Avatar.Text,
                Content = Content.Text,
                Date = DateTime.Now,
                Rate = int.Parse(Note.Text)
                
            };
            Avatar.Text = "";
            Content.Text = "";
            Note.Text = "";

            client.InsertCommentOnActorId(selectedId, commDTO);
            listeComment = client.GetComments(selectedId).ToList();
            GridComment.ItemsSource = listeComment;
        }
    }
}
