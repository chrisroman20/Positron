using MahApps.Metro.Controls;
using System.Windows;
using System.Windows.Controls;
using Positron.UserControls;
using WpfAppMahAppsIconPacks.UserControls;

namespace Positron
{
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            cbSistemas.SelectionChanged += cbSistemas_SelectionChanged;
        }

        private void cbSistemas_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string selectedSystem = (cbSistemas.SelectedItem as ComboBoxItem).Content.ToString();
            contentControlSistema.Content = null;
            sistemaTitulo.Text = selectedSystem;


            switch (selectedSystem) {
                case "Sistema tegumentario":
                    ucSistemaTegumentario sistemaTegumentario = new ucSistemaTegumentario();
                    sistemaTegumentario.PartSelected += SistemaPartSelected;
                    contentControlSistema.Content = sistemaTegumentario;
                    break;
                case "Sistema urinario":
                    ucSistemaUrinario sistemaUrinario = new ucSistemaUrinario();
                    sistemaUrinario.PartSelected += SistemaPartSelected;
                    contentControlSistema.Content = sistemaUrinario;
                    break;
                case "Sistema reproductor masculino":
                    ucSistemaReproductorM sistemaReproductorM = new ucSistemaReproductorM();
                    sistemaReproductorM.PartSelected += SistemaPartSelected;
                    contentControlSistema.Content = sistemaReproductorM;
                    break;
                case "Sistema circulatorio":
                    ucSistemaCirculatorio sistemaCirculatorio = new ucSistemaCirculatorio();
                    sistemaCirculatorio.PartSelected += SistemaPartSelected;
                    contentControlSistema.Content = sistemaCirculatorio;
                    break;
                case "Sistema nervioso":
                    ucSistemaNervioso sistemaNervioso = new ucSistemaNervioso();
                    sistemaNervioso.PartSelected += SistemaPartSelected;
                    contentControlSistema.Content = sistemaNervioso;
                    break;
                default:
                    break;
            }

        }

        private void SistemaPartSelected(object sender, string part)
        {
            if (!lbPartes.Items.Contains(part))
            {
                lbPartes.Items.Add(part);
            }
        }
    }
}
