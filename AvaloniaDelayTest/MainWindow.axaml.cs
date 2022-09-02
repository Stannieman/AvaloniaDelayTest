using System;
using System.Threading.Tasks;
using Avalonia.Controls;

namespace AvaloniaDelayTest
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            StartTimer();
        }

        private async void StartTimer()
        {
            while (true)
            {
                var startTime = DateTime.Now;

                await Task.Delay(250);

                var duration = DateTime.Now - startTime;
                if (duration > TimeSpan.FromMilliseconds(500))
                {
                    Console.WriteLine($"Too long: {duration}");
                }
            }
        }
    }
}
