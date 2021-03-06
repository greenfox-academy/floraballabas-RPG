﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using GreenFox;

namespace RPGGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Skeletons skeletons;

        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            Tile.DrawMap(foxDraw);
            Hero hero = new Hero(foxDraw);
            skeletons = new Skeletons(foxDraw);
            Boss boss = new Boss(foxDraw);
        }
        
        private void WindowKeyDown(object sender, KeyEventArgs e)
        {
            var foxDraw = new FoxDraw(canvas);
            if (e.Key == Key.Left)
            {
                Hero.HeroLeft(foxDraw);
            }
            if (e.Key == Key.Right)
            {
                Hero.HeroRight(foxDraw);
            }
            if (e.Key == Key.Up)
            {
                Hero.HeroUp(foxDraw);
            }
            if (e.Key == Key.Down)
            {
                Hero.HeroDown(foxDraw);
            }
        }
    } 
}
