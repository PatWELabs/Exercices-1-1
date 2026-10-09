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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _1_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Meme> memes;

        public MainWindow()
        {
            generateMemes();
            InitializeComponent();
            mapToListBoxes();
        }

        private void generateMemes()
        {
            memes = new List<Meme>();

            Meme meme1 = new Meme(1, "./images/modok.jpg", "sad", "recent");
            Meme meme2 = new Meme(2, "./images/pepe.jpg", "sad", "old");
            Meme meme3 = new Meme(3, "./images/stonks.jpg", "funny", "recent");
            Meme meme4 = new Meme(4, "./images/noodle.png", "funny", "old");

            memes.Add(meme1);
            memes.Add(meme2);
            memes.Add(meme3);
            memes.Add(meme4);
        }

        private void mapToListBoxes()
        {
            List<string> possibleCaracteristics = memes.ConvertAll<string>(meme => meme.Caracteristic).Distinct().ToList<string>();
            List<string> possibleRecentness = memes.ConvertAll<string>(meme => meme.Recentness).Distinct().ToList<string>();

            Caracteristic.ItemsSource = possibleCaracteristics;
            Recentness.ItemsSource = possibleRecentness;
        }
    }
}
