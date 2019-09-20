using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace MyControls.MyControls.Fbutton
{
    public class Fbutton:Button
    {
        static Fbutton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(Fbutton), new FrameworkPropertyMetadata(typeof(Fbutton)));
        }

        public Brush DownLine
        {
            get { return (Brush)GetValue(DownLineProperty); }
            set { SetValue(DownLineProperty, value); }
        }

        // Using a DependencyProperty as the backing store for DownLine.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty DownLineProperty =
            DependencyProperty.Register("DownLine", typeof(Brush), typeof(Fbutton), new PropertyMetadata());




    }
}
