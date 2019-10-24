using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Shapes;

namespace TomatoeSimulation
{
    /// <summary>
    /// An object of this class is used of the simulation to update the view.
    /// </summary>
    class SimulationView
    {
        // area to paint tomatoes on
        private Canvas canvas;
        // TextBlock to display the current step in the simulation.
        private TextBlock currentStep;

        /// <summary>
        /// Create an object of the SimulationView class.
        /// </summary>
        /// <param name="canvas">A referens to the canvas to paint on.</param>
        /// <param name="currentStep">A referens to the TextBlock to show the current step in the simulation.</param>
        public SimulationView(Canvas canvas, TextBlock currentStep)
        {
            this.canvas = canvas;
            this.currentStep = currentStep;
        }

        /// <summary>
        /// Add a row of tomatoes to the specified row in the canvas.
        /// </summary>
        /// <param name="tomatoeBox">The TomatoeBox in the simulation.</param>
        /// <param name="currentRow"></param>
        public void AddRow(ITomatoeBoxView tomatoeBox, int currentRow)
        {
            int tomatoeWidth = 10;
            for (int i = 0; i < tomatoeBox.Size(); ++i)
            {
                var circle = new Ellipse();
                if (tomatoeBox.IsRipeAt(i))
                {
                    circle.Fill = new SolidColorBrush(Windows.UI.Colors.Tomato);
                }
                else
                {
                    circle.Fill = new SolidColorBrush(Windows.UI.Colors.GreenYellow);

                }
                circle.Width = tomatoeWidth;
                circle.Height = tomatoeWidth;

                canvas.Children.Add(circle);
                Canvas.SetLeft(circle, i * tomatoeWidth);
                Canvas.SetTop(circle, currentRow * tomatoeWidth);
            }
            currentStep.Text = currentRow.ToString();
        }

        /// <summary>
        /// Clear the canvas. Removes all tomatoes from view.
        /// </summary>
        public void Clear()
        {
            while (canvas.Children.Count > 0)
            {
                canvas.Children.RemoveAt(0);
            }
            
        }
    }
}
