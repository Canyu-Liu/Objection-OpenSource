
using CommunityToolkit.Maui.Core.Primitives;

namespace Objection
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
            Accelerometer.Default.Start(SensorSpeed.UI);
            Accelerometer.Default.ReadingChanged += Accelerometer_ReadingChanged;
        }

        private void Accelerometer_ReadingChanged(object? sender, AccelerometerChangedEventArgs e)
        {
           if (0.96 < e.Reading.Acceleration.Y)
            {
                ObjectionMedia.Play();
                Objection_png.IsVisible = true;
            }
            else if (ObjectionMedia.CurrentState == MediaElementState.Stopped)
            {
                Objection_png.IsVisible = false;
            }
        }
    }

}
