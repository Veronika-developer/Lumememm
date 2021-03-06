﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Lumememm
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            var tap = new TapGestureRecognizer();
            tap.Tapped += Tap_Tapped;
            head.GestureRecognizers.Add(tap);
            body.GestureRecognizers.Add(tap);
            body2.GestureRecognizers.Add(tap);
        }
        //Изменение цвета частей снеговика рандомно
        Random rnd = new Random();
        private void Tap_Tapped(object sender, EventArgs e)
        {
            Frame fr = sender as Frame;
            if(fr == head)
            {
                int R = rnd.Next(0, 255);
                int G = rnd.Next(0, 255);
                int B = rnd.Next(0, 255);
                head.BackgroundColor = Color.FromRgb(R, G, B);
            }
            else if (fr == body)
            {
                int R = rnd.Next(0, 255);
                int G = rnd.Next(0, 255);
                int B = rnd.Next(0, 255);
                body.BackgroundColor = Color.FromRgb(R, G, B);
            }
            else if (fr == body2)
            {
                int R = rnd.Next(0, 255);
                int G = rnd.Next(0, 255);
                int B = rnd.Next(0, 255);
                body2.BackgroundColor = Color.FromRgb(R, G, B);
            }
        }
        //Управление прозрачности над снеговиком
        private void SliderOpacity_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            snowman.Opacity = SliderOpacity.Value / 100;
            if((int)snowman.Opacity == 1)
            {
                SliderLabel.Text = "";//снеговик тает
            }
            else
            {
                SliderLabel.Text = "Lumemees sulas";
            }
        }
        //Таяние снеговика
        private async void Btn_Clicked(object sender, EventArgs e)
        {
            for (int i = 0; i < 40; i++)
            {
                snowman.Opacity -= 0.03;
                await Task.Run(() => Thread.Sleep(10));
            }
            await DisplayAlert("Lumememm", "Lumememm sulas", "ОK");//Всплывающее окно о том что снеговик расстаял
        }
    }
}
