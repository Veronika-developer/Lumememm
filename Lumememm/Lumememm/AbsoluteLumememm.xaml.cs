using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lumememm
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AbsoluteLumememm : ContentPage
    {
        public AbsoluteLumememm()
        {
            AbsoluteLayout absoluteLayout = new AbsoluteLayout 
            { 
                BackgroundColor = Color.LightBlue
            };

            BoxView head = new BoxView { BackgroundColor = Color.White, CornerRadius = 100 };
            BoxView body = new BoxView { BackgroundColor = Color.White, CornerRadius = 100 };
            BoxView body2 = new BoxView { BackgroundColor = Color.White, CornerRadius = 100 };
            BoxView nose = new BoxView { BackgroundColor = Color.Orange, CornerRadius = 100 };
            BoxView eye = new BoxView { BackgroundColor = Color.Black, CornerRadius = 100 };
            BoxView eye2 = new BoxView { BackgroundColor = Color.Black, CornerRadius = 100 };
            //BoxView pugoviza = new BoxView { BackgroundColor = Color.Black, CornerRadius = 100 };

            AbsoluteLayout.SetLayoutBounds(head, new Rectangle(0.5, 0.02, 110, 110));
            // устанавливаем пропорциональные координаты
            AbsoluteLayout.SetLayoutFlags(head, AbsoluteLayoutFlags.PositionProportional);

            AbsoluteLayout.SetLayoutBounds(body, new Rectangle(0.5, 0.25, 140, 140));
            AbsoluteLayout.SetLayoutFlags(body, AbsoluteLayoutFlags.PositionProportional);

            AbsoluteLayout.SetLayoutBounds(body2, new Rectangle(0.5, 0.55, 170, 170));
            // пропорциональные координаты и размеры
            AbsoluteLayout.SetLayoutFlags(body2, AbsoluteLayoutFlags.PositionProportional);

            AbsoluteLayout.SetLayoutBounds(nose, new Rectangle(0.5, 0.12, 12, 12));
            AbsoluteLayout.SetLayoutFlags(nose, AbsoluteLayoutFlags.PositionProportional);

            AbsoluteLayout.SetLayoutBounds(eye, new Rectangle(0.4, 0.08, 12, 12));
            AbsoluteLayout.SetLayoutFlags(eye, AbsoluteLayoutFlags.PositionProportional);

            AbsoluteLayout.SetLayoutBounds(eye2, new Rectangle(0.6, 0.08, 12, 12));
            AbsoluteLayout.SetLayoutFlags(eye2, AbsoluteLayoutFlags.PositionProportional);

            //AbsoluteLayout.SetLayoutBounds(pugoviza, new Rectangle(0.5, 0.26, 15, 15));
            //AbsoluteLayout.SetLayoutFlags(pugoviza, AbsoluteLayoutFlags.PositionProportional);
            int y = (int)0.26;
            for(int i = 0; i < 6; i++)
            {
                BoxView pugoviza = new BoxView() { BackgroundColor = Color.White, CornerRadius = 100 };
                AbsoluteLayout.SetLayoutBounds(pugoviza, new Rectangle(0.5, y, 15, 15));
                absoluteLayout.Children.Add(pugoviza);
            }

            absoluteLayout.Children.Add(head);
            absoluteLayout.Children.Add(body);
            absoluteLayout.Children.Add(body2);
            absoluteLayout.Children.Add(nose);
            absoluteLayout.Children.Add(eye);
            absoluteLayout.Children.Add(eye2);
            //absoluteLayout.Children.Add(pugoviza);

            Content = absoluteLayout;
        }
    }
}