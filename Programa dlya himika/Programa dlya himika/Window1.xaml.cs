/*
 * Created by SharpDevelop.
 * User: 2-8 класи
 * Date: 26.01.2016
 * Time: 12:52
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;

namespace Programa_dlya_himika
{
	/// <summary>
	/// Interaction logic for Window1.xaml
	/// </summary>
	public partial class Window1 : Window
	{
		public Window1()
		{
			InitializeComponent();
		}
		void menuItem1_Click(object sender, RoutedEventArgs e)
		{
			 
		}
		void menuItem2_Click(object sender, RoutedEventArgs e)
		{
			formula.Text += "H";
    			
		}
		void menuItem3_Click(object sender, RoutedEventArgs e)
		{
			
		}
	void menuItem9_Click(object sender, RoutedEventArgs e)
		{
			formula.Text += "H";
    			
		}
	void menuItem10_Click(object sender, RoutedEventArgs e)
		{
			formula.Text += "Li";
    			
		}
	void menuItem11_Click(object sender, RoutedEventArgs e)
		{
			formula.Text += "+";
    			
		}
	}
}