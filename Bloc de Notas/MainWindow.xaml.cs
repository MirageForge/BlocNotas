using System.IO;
using System.Windows;
using Microsoft.Win32;

namespace MiBlocDeNotas
{
    public partial class MainWindow : Window
    {
        // Variable para guardar la ruta del archivo actual
        private string rutaArchivoActual = string.Empty;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MenuNuevo_Click(object sender, RoutedEventArgs e)
        {
            txtContenido.Clear();
            rutaArchivoActual = string.Empty;
            Title = "Mi Bloc de Notas - Nuevo archivo";
        }

        private void MenuAbrir_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";

            if (openFileDialog.ShowDialog() == true)
            {
                rutaArchivoActual = openFileDialog.FileName;
                txtContenido.Text = File.ReadAllText(rutaArchivoActual);
                Title = $"Mi Bloc de Notas - {Path.GetFileName(rutaArchivoActual)}";
            }
        }

        private void MenuGuardar_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(rutaArchivoActual))
            {
                // Si es un archivo nuevo, actuamos como "Guardar Como"
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";

                if (saveFileDialog.ShowDialog() == true)
                {
                    rutaArchivoActual = saveFileDialog.FileName;
                }
                else
                {
                    return; // Si el usuario cancela, no hacemos nada
                }
            }

            // Guardamos el texto en el archivo
            File.WriteAllText(rutaArchivoActual, txtContenido.Text);
            Title = $"Mi Bloc de Notas - {Path.GetFileName(rutaArchivoActual)}";
            MessageBox.Show("Archivo guardado con éxito.", "Información", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void MenuSalir_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
