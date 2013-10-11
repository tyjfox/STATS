﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Diagnostics;
using System.Windows.Controls.Primitives;

namespace WpfApplication2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    public class AlphaButton : Button
    {
        public AlphaButton(String uppercase, String _lowercase, ref TextBox tb, 
                                ref ToggleButton Shift, ref ToggleButton caps)
        {
            this.Width = 80;
            this.Height = 72;
            this.HorizontalAlignment = HorizontalAlignment.Left;
            this.VerticalAlignment = VerticalAlignment.Top;
            this.Content = uppercase;
            this.lowercase = _lowercase;
            this.shift = Shift;
            this.capsLock = caps;
            this.tb = tb;
            this.Click += AlphaButton_Click;
        }

        protected void AlphaButton_Click(object sender, RoutedEventArgs e)
        {
            if (shift.IsChecked == true || capsLock.IsChecked == true)
            {
                tb.Text += this.Content.ToString();
                shift.IsChecked = false;
            }
            else
                tb.Text += this.lowercase;
            tb.Focus();
            tb.SelectionStart = tb.Text.Length;
        }

        private TextBox tb;
        private ToggleButton shift;
        private ToggleButton capsLock;
        public String lowercase;
    }

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            loadStandardKeyboard();
            EnterButton.Click += EnterButton_Click;
            Backspace.Click += BackspaceButton_Click;
            Space.Click += SpaceButton_Click;
            //Keyboard.Visibility = Visibility.Collapsed;
        }

        private void EnterButton_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text += System.Environment.NewLine;
            textBox1.Focus();
            textBox1.SelectionStart = textBox1.Text.Length;
        }

        private void BackspaceButton_Click(object sender, RoutedEventArgs e)
        {
            if(textBox1.Text.Length != 0)
            {
                int check = ((textBox1.Text.Length - 2) > 0) ? textBox1.Text.Length-2 : 0;
                if (textBox1.Text.Substring(check) == System.Environment.NewLine)
                    textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 2);
                else
                {
                    textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
                }
            }
            textBox1.Focus();
            textBox1.SelectionStart = textBox1.Text.Length;
        }

        private void SpaceButton_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text += " ";
            textBox1.Focus();
            textBox1.SelectionStart = textBox1.Text.Length;
        }

        private void loadStandardKeyboard()
        {
            AlphaButton Q = new AlphaButton("Q", "q", ref textBox1, ref Shift, ref Caps);
            col1.Children.Add(Q);
            AlphaButton A = new AlphaButton("A", "a", ref textBox1, ref Shift, ref Caps);
            col1.Children.Add(A);
            AlphaButton Z = new AlphaButton("Z", "z", ref textBox1, ref Shift, ref Caps);
            col1.Children.Add(Z);
            AlphaButton W = new AlphaButton("W", "w", ref textBox1, ref Shift, ref Caps);
            col2.Children.Add(W);
            AlphaButton S = new AlphaButton("S", "s", ref textBox1, ref Shift, ref Caps);
            col2.Children.Add(S);
            AlphaButton X = new AlphaButton("X", "x", ref textBox1, ref Shift, ref Caps);
            col2.Children.Add(X);
            AlphaButton E = new AlphaButton("E", "e", ref textBox1, ref Shift, ref Caps);
            col3.Children.Add(E);
            AlphaButton D = new AlphaButton("D", "d", ref textBox1, ref Shift, ref Caps);
            col3.Children.Add(D);
            AlphaButton C = new AlphaButton("C", "c", ref textBox1, ref Shift, ref Caps);
            col3.Children.Add(C);
            AlphaButton R = new AlphaButton("R", "r", ref textBox1, ref Shift, ref Caps);
            col4.Children.Add(R);
            AlphaButton F = new AlphaButton("F", "f", ref textBox1, ref Shift, ref Caps);
            col4.Children.Add(F);
            AlphaButton V = new AlphaButton("V", "v", ref textBox1, ref Shift, ref Caps);
            col4.Children.Add(V);
            AlphaButton T = new AlphaButton("T", "t", ref textBox1, ref Shift, ref Caps);
            col5.Children.Add(T);
            AlphaButton G = new AlphaButton("G", "g", ref textBox1, ref Shift, ref Caps);
            col5.Children.Add(G);
            AlphaButton B = new AlphaButton("B", "b", ref textBox1, ref Shift, ref Caps);
            col5.Children.Add(B);
            AlphaButton Y = new AlphaButton("Y", "y", ref textBox1, ref Shift, ref Caps);
            col6.Children.Add(Y);
            AlphaButton H = new AlphaButton("H", "h", ref textBox1, ref Shift, ref Caps);
            col6.Children.Add(H);
            AlphaButton N = new AlphaButton("N", "n", ref textBox1, ref Shift, ref Caps);
            col6.Children.Add(N);
            AlphaButton U = new AlphaButton("U", "u", ref textBox1, ref Shift, ref Caps);
            col7.Children.Add(U);
            AlphaButton J = new AlphaButton("J", "j", ref textBox1, ref Shift, ref Caps);
            col7.Children.Add(J);
            AlphaButton M = new AlphaButton("M", "m", ref textBox1, ref Shift, ref Caps);
            col7.Children.Add(M);
            AlphaButton I = new AlphaButton("I", "i", ref textBox1, ref Shift, ref Caps);
            col8.Children.Add(I);
            AlphaButton K = new AlphaButton("K", "k", ref textBox1, ref Shift, ref Caps);
            col8.Children.Add(K);
            AlphaButton Comma = new AlphaButton(",", ",", ref textBox1, ref Shift, ref Caps);
            col8.Children.Add(Comma);
            AlphaButton O = new AlphaButton("O", "o", ref textBox1, ref Shift, ref Caps);
            col9.Children.Add(O);
            AlphaButton L = new AlphaButton("L", "l", ref textBox1, ref Shift, ref Caps);
            col9.Children.Add(L);
            AlphaButton Period = new AlphaButton(".", ".", ref textBox1, ref Shift, ref Caps);
            col9.Children.Add(Period);
            AlphaButton P = new AlphaButton("P", "p", ref textBox1, ref Shift, ref Caps);
            col10.Children.Add(P);
            AlphaButton AP = new AlphaButton("'", "'", ref textBox1, ref Shift, ref Caps);
            col10.Children.Add(AP);
            AlphaButton Question = new AlphaButton("?", "?", ref textBox1, ref Shift, ref Caps);
            col10.Children.Add(Question);
        }
    }
}
