using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en http://go.microsoft.com/fwlink/?LinkId=391641

namespace DataRepresentationHelper
{
    /// <summary>
    /// Página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            this.NavigationCacheMode = NavigationCacheMode.Required;
        }

        /// <summary>
        /// Se invoca cuando esta página se va a mostrar en un objeto Frame.
        /// </summary>
        /// <param name="e">Datos de evento que describen cómo se llegó a esta página.
        /// Este parámetro se usa normalmente para configurar la página.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            // TODO: Preparar la página que se va a mostrar aquí.

            // TODO: Si la aplicación contiene varias páginas, asegúrese de
            // controlar el botón para retroceder del hardware registrándose en el
            // evento Windows.Phone.UI.Input.HardwareButtons.BackPressed.
            // Si usa NavigationHelper, que se proporciona en algunas plantillas,
            // el evento se controla automáticamente.
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (RBBinario.IsChecked==true)
            {
                int num = Convert.ToInt32(Entradadecimal.Text);
                int numero = num;
                string bin = String.Empty, binc = String.Empty, octal = String.Empty;
                string octalc = String.Empty, hexa = String.Empty, hexac = String.Empty;
                do
                {
                    if (num % 2 == 1)
                        bin += "1";
                    else
                        bin += "0";
                    num /= 2;
                } while (num != 1);
                bin += "1";  //Siempre se le agrega un 1 al final 

                //Se hace un ciclo for porque el número quedó al revés y hay que invertirlo 
                for (int i = 1; i <= bin.Length; i++)
                    binc += bin[bin.Length - i];
                num = numero;
                Salida.Text = binc.ToString();

            }
            
           
        
        }

        private void TextBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }
        

    }
}
