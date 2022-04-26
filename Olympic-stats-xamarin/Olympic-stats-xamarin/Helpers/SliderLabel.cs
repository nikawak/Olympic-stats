using Xamarin.Forms;

namespace Olympic_stats_xamarin.Helpers
{
    internal class SliderLabel : AbsoluteLayout
    {
        private Label _value;
        private Slider _slider;

        public SliderLabel()
        {
            _slider = new Slider() { Margin = new Thickness(0, 20, 0, 0) };
            _value = new Label();
            _value.SetBinding(Label.TextProperty, new Binding("Value", source: _slider) { StringFormat = "{0:F0}" });

            SetLayoutBounds(_slider, new Rectangle(0f, 1f, 1f, 1f));
            SetLayoutFlags(_slider, AbsoluteLayoutFlags.All);

            Children.Add(_slider);
            Children.Add(_value);

            _slider.ValueChanged += (s, e) =>
            {
                PositionLabel(e.NewValue);
            };
        }

        private void PositionLabel(double newValue)
        {
            if (newValue == 0) return;

            var pos = (newValue - _slider.Minimum)/(_slider.Maximum - _slider.Minimum);

            SetLayoutFlags(_value, AbsoluteLayoutFlags.PositionProportional);
            SetLayoutBounds(_value, new Rectangle(pos, 0f, AutoSize, AutoSize));
        }

        public double Minimum
        {
            get => (double)_slider.GetValue(Slider.MinimumProperty);
            set => _slider.SetValue(Slider.MinimumProperty, value);
        }
        public double Maximum
        {
            get => (double)_slider.GetValue(Slider.MaximumProperty);
            set => _slider.SetValue(Slider.MaximumProperty, value);
        }

        public static readonly BindableProperty ValueProperty = 
            BindableProperty.Create("Value", typeof(double), typeof(SliderLabel),0,BindingMode.TwoWay,propertyChanging:
                HandlerPropertChanging);

        private static void HandlerPropertChanging(BindableObject bindable, object oldValue, object newValue)
        {
            if(bindable is SliderLabel slider)
            {
                slider.PositionLabel((double)newValue);
                slider._slider.Value = (double)newValue;
            }
        }
    }
}
