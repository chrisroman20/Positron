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

namespace WpfAppMahAppsIconPacks.UserControls
{
    /// <summary>
    /// Lógica de interacción para ucSistemaCirculatorio.xaml
    /// </summary>
    public partial class ucSistemaCirculatorio : UserControl
    {
        public ucSistemaCirculatorio()
        {
            InitializeComponent();
        }

        private void Label_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Label selectedLabel = sender as Label;
            if (selectedLabel != null)
            {
                string selectedPart = selectedLabel.Tag.ToString();
                OnPartSelected(selectedPart);
            }
        }

        public delegate void PartSelectedEventHandler(object sender, string part);
        public event PartSelectedEventHandler PartSelected;

        protected virtual void OnPartSelected(string part)
        {
            PartSelected?.Invoke(this, part);
        }
    }
}
