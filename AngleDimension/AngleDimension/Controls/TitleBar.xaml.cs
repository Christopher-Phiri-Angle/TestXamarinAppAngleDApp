using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AngleDimension.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TitleBar : ContentView
    {
        public static readonly BindableProperty PageTitleProperty = 
            BindableProperty.Create(nameof(PageTitleText), typeof(string), typeof(TitleBar), string.Empty, 
                defaultBindingMode: BindingMode.OneWay,
                propertyChanged: PageTitletPropertyChanged);

        private static void PageTitletPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            TitleBar control = (TitleBar)bindable;
            control.PageTitle.Text = newValue?.ToString();
        }

        public static readonly BindableProperty PageDescriptionProperty = 
            BindableProperty.Create(nameof(PageDescriptionText), typeof(string), typeof(TitleBar), string.Empty, 
                defaultBindingMode: BindingMode.OneWay,
                propertyChanged: PageDescPropertyChanged);

        private static void PageDescPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            TitleBar control = (TitleBar)bindable;
            control.PageDescription.Text = newValue?.ToString();
        }

        public TitleBar()
        {
            InitializeComponent();
        }


        public string PageTitleText
        {
            get => (string)GetValue(PageTitleProperty);
            set => SetValue(PageTitleProperty, value);
        }

        public string PageDescriptionText
        {
            get => (string)GetValue(PageDescriptionProperty);
            set => SetValue(PageDescriptionProperty, value);
        }
    }
}