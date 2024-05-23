using System.Windows;
using System.Windows.Controls;

namespace Positron.UserControls
{
    public partial class ucSistemaUrinario : UserControl
    {
        public ucSistemaUrinario()
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
