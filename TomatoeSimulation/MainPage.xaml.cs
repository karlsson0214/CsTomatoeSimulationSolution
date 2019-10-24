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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace TomatoeSimulation
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        // simulation object
        private Controller controller;
        public MainPage()
        {
            this.InitializeComponent();

            SimulationView view = new SimulationView(tomatoeCanvas, currentStep);

            Simulation simulation = new Simulation(20);
            controller = new Controller(simulation, view);
            controller.SetUp(); 
        }

        private void reset_Click(object sender, RoutedEventArgs e)
        {
            controller.SetUp();
        }

        private void step_Click(object sender, RoutedEventArgs e)
        {
            controller.Step();
        }

        private void run_Click(object sender, RoutedEventArgs e)
        {
            controller.Run(10);
        }
    }
}
