using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using static System.Net.WebRequestMethods;
using static Xamarin.Essentials.Permissions;

namespace Exercise3
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            //Absolute Layout Format

            //The maroon container
            //BoxView maroonBox = new BoxView { Color = Color.Maroon, CornerRadius=20 };
            //AbsoluteLayout.SetLayoutBounds(maroonBox, new Rectangle(0.5, 0.5, 0.95, 0.95));
            //AbsoluteLayout.SetLayoutFlags(maroonBox, AbsoluteLayoutFlags.All);


            //Grid
            //Grid myGrid = new Grid
            //{
            //    BackgroundColor = Color.Green,
            //    RowSpacing = 1,
            //    ColumnSpacing = 3,
            //    RowDefinitions =
            //    {

            //        //new RowDefinition { Height = new GridLength(1, GridUnitType.Auto) },
            //        new RowDefinition { Height = new GridLength(75)},
            //        new RowDefinition { Height = new GridLength(75)},
            //        new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
            //        new RowDefinition { Height = new GridLength(150) },
            //        new RowDefinition { Height = new GridLength(75)},
            //        new RowDefinition { Height = new GridLength(75)},
            //        new RowDefinition { Height = new GridLength(75)},
            //        new RowDefinition { Height = new GridLength(75)},
            //        new RowDefinition { Height = new GridLength(75)},
            //        new RowDefinition { Height = new GridLength(75)},
            //    },
            //    ColumnDefinitions =
            //    {
            //        new ColumnDefinition{Width = new GridLength(2, GridUnitType.Star)}, //Blank
            //        //new ColumnDefinition { Width = new GridLength(2, GridUnitType.Star) },
            //    }

            //};

            //AbsoluteLayout.SetLayoutBounds(myGrid, new Rectangle(0.5, 0.5, 0.95, 0.95));
            //AbsoluteLayout.SetLayoutFlags(myGrid, AbsoluteLayoutFlags.PositionProportional);


            //Image circle = new Image { Source = "https://www.iconsdb.com/icons/preview/gray/circle-xxl.png", Margin=10 };
            //Label uniName = new Label { Text = "University of Northumbria, London, UK", Margin =10};
            //Image proPic = new Image { Source = "https://st3.depositphotos.com/6672868/13701/v/600/depositphotos_137014128-stock-illustration-user-profile-icon.jpg"};
            //Label idNo = new Label { Text="ID NO: 9999999"};


            //myGrid.Children.Add(circle, 0, 0);
            //myGrid.Children.Add(uniName, 1, 0);
            //myGrid.Children.Add(proPic, 2, 0);
            //myGrid.Children.Add(idNo, 3, 0);


            //Grid.SetRowSpan(lbl8, 3);
            //Grid.SetColumnSpan(lbl4, 3);


        }

    }
}
