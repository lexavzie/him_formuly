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
using Microsoft.Win32;
using System.IO;


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
			fff.AppendText("H");
    			
		}
		void menuItem3_Click(object sender, RoutedEventArgs e)
		{
			
		}
		/*Вывод каждого символа c меню в текстовый блок*/
	void menuItem9_Click(object sender, RoutedEventArgs e)
		{
		fff.AppendText("H");
    			
		}
	void menuItem10_Click(object sender, RoutedEventArgs e)
		{
		fff.AppendText("Li");
    			
		}
	void menuItem11_Click(object sender, RoutedEventArgs e)
		{
		fff.AppendText("Na");
    			
		}
	void menuItem12_Click(object sender, RoutedEventArgs e)
		{
		fff.AppendText("K");
    			
		}
	void menuItem13_Click(object sender, RoutedEventArgs e)
		{
		fff.AppendText("Cu");
    			
		}
	void menuItem14_Click(object sender, RoutedEventArgs e)
		{
		fff.AppendText("Rb");
    			
		}
	void menuItem15_Click(object sender, RoutedEventArgs e)
		{
		fff.AppendText("Ag");
    			
		}
	void menuItem16_Click(object sender, RoutedEventArgs e)
		{
		fff.AppendText("Cs");
    			
		}
	void menuItem17_Click(object sender, RoutedEventArgs e)
		{
		fff.AppendText("Au");
    			
		}
	void menuItem18_Click(object sender, RoutedEventArgs e)
		{
		fff.AppendText("Fr");
    			
		}
	void menuItem19_Click(object sender, RoutedEventArgs e)
		{
		fff.AppendText("Be");
    			
		}
	void menuItem20_Click(object sender, RoutedEventArgs e)
		{
		fff.AppendText("Mg");
    			
		}
	void menuItem21_Click(object sender, RoutedEventArgs e)
		{
		fff.AppendText("Ca");
    			
		}
	void menuItem22_Click(object sender, RoutedEventArgs e)
		{
		fff.AppendText("Zn");
    			
		}
	void menuItem23_Click(object sender, RoutedEventArgs e)
		{
		fff.AppendText("Sr");
    			
		}
	void menuItem24_Click(object sender, RoutedEventArgs e)
		{
		fff.AppendText("Cd");
    			
		}
	void menuItem25_Click(object sender, RoutedEventArgs e)
		{
		fff.AppendText("Ba");
    			
		}
	void menuItem26_Click(object sender, RoutedEventArgs e)
		{
		fff.AppendText("Hg");
    			
		}
	void menuItem27_Click(object sender, RoutedEventArgs e)
		{
		fff.AppendText("Ra");
    			
		}
	void menuItem28_Click(object sender, RoutedEventArgs e)
		{
		fff.AppendText("B");
    			
		}
	void menuItem30_Click(object sender, RoutedEventArgs e)
		{
		fff.AppendText("Al");
    			
		}
	void menuItem31_Click(object sender, RoutedEventArgs e)
		{
		fff.AppendText("Sc");
    			
		}
	void menuItem32_Click(object sender, RoutedEventArgs e)
		{
		fff.AppendText("Ga");
    			
		}
	void menuItem33_Click(object sender, RoutedEventArgs e)
		{
		fff.AppendText("Y");
    			
		}
	void menuItem34_Click(object sender, RoutedEventArgs e)
		{
		fff.AppendText("In");
    			
		}
	void menuItem35_Click(object sender, RoutedEventArgs e)
		{
		fff.AppendText("La");
    			
		}
	void menuItem36_Click(object sender, RoutedEventArgs e)
		{
		fff.AppendText("Tl");
    			
		}
	void menuItem37_Click(object sender, RoutedEventArgs e)
		{
		fff.AppendText("Ac");
    			
		}
	void menuItem38_Click(object sender, RoutedEventArgs e)
		{
		fff.AppendText("C");
    			
		}
	void menuItem39_Click(object sender, RoutedEventArgs e)
		{
		fff.AppendText("Si");
    			
		}
	void menuItem40_Click(object sender, RoutedEventArgs e)
		{
		fff.AppendText("Ti");
    			
		}
	void menuItem41_Click(object sender, RoutedEventArgs e)
		{
		fff.AppendText("Ge");
    			
		}
	void menuItem42_Click(object sender, RoutedEventArgs e)
		{
		fff.AppendText("Zr");
    			
		}
	void menuItem43_Click(object sender, RoutedEventArgs e)
		{
		fff.AppendText("Sn");
    			
		}
	void menuItem44_Click(object sender, RoutedEventArgs e)
		{
		fff.AppendText("Hf");
    			
		}
	void menuItem45_Click(object sender, RoutedEventArgs e)
		{
		fff.AppendText("Pb");
    			
		}
	void menuItem46_Click(object sender, RoutedEventArgs e)
		{
		fff.AppendText("Rf");
    			
		}
	void menuItem47_Click(object sender, RoutedEventArgs e)
		{
		fff.AppendText("N");
    			
		}
	void menuItem48_Click(object sender, RoutedEventArgs e)
		{
		fff.AppendText("P");
    			
		}
	void menuItem49_Click(object sender, RoutedEventArgs e)
		{
		fff.AppendText("V");
    			
		}
	void menuItem50_Click(object sender, RoutedEventArgs e)
		{
		fff.AppendText("As");
    			
		}
	void menuItem51_Click(object sender, RoutedEventArgs e)
		{
		fff.AppendText("Nb");
    			
		}
	void menuItem52_Click(object sender, RoutedEventArgs e)
		{
		fff.AppendText("Sb");
    			
		}
	void menuItem53_Click(object sender, RoutedEventArgs e)
		{
		fff.AppendText("Ta");
    			
		}
	void menuItem54_Click(object sender, RoutedEventArgs e)
		{
		fff.AppendText("Bi");
    			
		}
	void menuItem56_Click(object sender, RoutedEventArgs e)
		{
		fff.AppendText("Db");
    			
		}
	void menuItem57_Click(object sender, RoutedEventArgs e)
		{
		fff.AppendText("O");
    			
		}
	void menuItem58_Click(object sender, RoutedEventArgs e)
		{
		fff.AppendText("S");
    			
		}
	void menuItem59_Click(object sender, RoutedEventArgs e)
		{
		fff.AppendText("Cr");
    			
		}
	void menuItem60_Click(object sender, RoutedEventArgs e)
		{
		fff.AppendText("Se");
    			
		}
	void menuItem61_Click(object sender, RoutedEventArgs e)
		{
		fff.AppendText("Mo");
    			
		}
	void menuItem62_Click(object sender, RoutedEventArgs e)
		{
		fff.AppendText("Te");
    			
		}
	void menuItem63_Click(object sender, RoutedEventArgs e)
		{
		fff.AppendText("W");
    			
		}
	void menuItem64_Click(object sender, RoutedEventArgs e)
		{
		fff.AppendText("Po");
    			
		}
	void menuItem65_Click(object sender, RoutedEventArgs e)
		{
		fff.AppendText("Sg");
    			
		}
	void menuItem66_Click(object sender, RoutedEventArgs e)
		{
		fff.AppendText("F");
    			
		}
	void menuItem67_Click(object sender, RoutedEventArgs e)
		{
		fff.AppendText("Cl");
    			
		}
	void menuItem68_Click(object sender, RoutedEventArgs e)
		{
		fff.AppendText("Mn");
    			
		}
	void menuItem69_Click(object sender, RoutedEventArgs e)
		{
		fff.AppendText("Br");
    			
		}
	void menuItem70_Click(object sender, RoutedEventArgs e)
		{
		fff.AppendText("Tc");
    			
		}
	void menuItem71_Click(object sender, RoutedEventArgs e)
		{
		fff.AppendText("I");
    			
		}
	void menuItem72_Click(object sender, RoutedEventArgs e)
		{
		fff.AppendText("Re");
    			
		}
	void menuItem73_Click(object sender, RoutedEventArgs e)
		{
		fff.AppendText("At");
    			
		}
	void menuItem74_Click(object sender, RoutedEventArgs e)
		{
		fff.AppendText("Bh");
    			
		}
	void menuItem75_Click(object sender, RoutedEventArgs e)
		{
		fff.AppendText("Fe");
    			
		}
	void menuItem76_Click(object sender, RoutedEventArgs e)
		{
		fff.AppendText("Co");
    			
		}
	void menuItem77_Click(object sender, RoutedEventArgs e)
		{
		fff.AppendText("Ni");
    			
		}
	void menuItem78_Click(object sender, RoutedEventArgs e)
		{
		fff.AppendText("Ru");
    			
		}
	void menuItem79_Click(object sender, RoutedEventArgs e)
		{
		fff.AppendText("Rh");
    			
		}
	void menuItem80_Click(object sender, RoutedEventArgs e)
		{
		fff.AppendText("Pb");
    			
		}
	void menuItem81_Click(object sender, RoutedEventArgs e)
		{
		fff.AppendText("Re");
    			
		}
	void menuItem82_Click(object sender, RoutedEventArgs e)
		{
		fff.AppendText("Os");
    			
		}
	void menuItem83_Click(object sender, RoutedEventArgs e)
		{
		fff.AppendText("Ir");
    			
		}
	void menuItem84_Click(object sender, RoutedEventArgs e)
		{
		fff.AppendText("Pt");
    			
		}
	void menuItem85_Click(object sender, RoutedEventArgs e)
		{
		fff.AppendText("Bh");
    			
		}
	void menuItem86_Click(object sender, RoutedEventArgs e)
		{
		fff.AppendText("Hs");
    			
		}
	void menuItem87_Click(object sender, RoutedEventArgs e)
		{
		fff.AppendText("Mt");
    			
		}
	void menuItem88_Click(object sender, RoutedEventArgs e)
		{
		fff.AppendText("Ds");
    			
		}
	void menuItem89_Click(object sender, RoutedEventArgs e)
		{
		fff.AppendText("He");
    			
		}
	void menuItem90_Click(object sender, RoutedEventArgs e)
		{
		fff.AppendText("Ne");
    			
		}
	void menuItem91_Click(object sender, RoutedEventArgs e)
		{
		fff.AppendText("Ar");
    			
		}
	void menuItem92_Click(object sender, RoutedEventArgs e)
		{
		fff.AppendText("Kr");
    			
		}
	void menuItem93_Click(object sender, RoutedEventArgs e)
		{
		fff.AppendText("Xe");
    			
		}
	void menuItem94_Click(object sender, RoutedEventArgs e)
		{
		fff.AppendText("Rn");
    			
		}
	void menuItem55_Click(object sender, RoutedEventArgs e)
		{
		fff.AppendText("+");
    			
		}
	void menuItem29_Click(object sender, RoutedEventArgs e)
		{
		fff.AppendText("-");
    			
		}
	void menuItem95_Click(object sender, RoutedEventArgs e)
		{
		fff.AppendText("=");
    			
		}
	void menuItem96_Click(object sender, RoutedEventArgs e)
		{
		fff.AppendText("(");
    			
		}
	void menuItem97_Click(object sender, RoutedEventArgs e)
		{
		fff.AppendText(")");
    			
		}
	void menuItem98_Click(object sender, RoutedEventArgs e)
		{
		fff.AppendText("↑");
    			
		}
	void menuItem99_Click(object sender, RoutedEventArgs e)
		{
		fff.AppendText("↓");
    			
		}
	void menuItem100_Click(object sender, RoutedEventArgs e)
		{
		fff.AppendText("→");
    			
		}
		/*открытие файла*/
		void Open_Click(object sender, RoutedEventArgs e)
		{
			OpenFileDialog ofd = new OpenFileDialog();
    		ofd.Filter = "RichText Files (*.rtf)|*.rtf|All files (*.*)|*.*";
 
   			 if (ofd.ShowDialog() == true)
    			{
        	TextRange doc = new TextRange(fff.Document.ContentStart, fff.Document.ContentEnd);
       		 using (FileStream fs = new FileStream(ofd.FileName, FileMode.Open))
        	{
            if (System.IO.Path.GetExtension(ofd.FileName).ToLower() == ".rtf")
            {
                doc.Load(fs, DataFormats.Rtf);
            }
            else if (System.IO.Path.GetExtension(ofd.FileName).ToLower() == ".txt")
            {
                doc.Load(fs, DataFormats.Text);
            }
            else
            {
                doc.Load(fs, DataFormats.Xaml);
            }
        	}
 			
			}
		}
		/*сохранение файла*/
		void Save_Click(object sender, RoutedEventArgs e)
		{
			SaveFileDialog sfd = new SaveFileDialog();
   			 sfd.Filter = "Text Files (*.txt)|*.txt|RichText Files (*.rtf)|*.rtf|XAML Files (*.xaml)|*.xaml|All files (*.*)|*.*";
    		if (sfd.ShowDialog() == true)
    		{
       		 TextRange doc = new TextRange(fff.Document.ContentStart, fff.Document.ContentEnd);
      		  using (FileStream fs = new FileStream(sfd.FileName, FileMode.Create))
      		  {
          	  if (System.IO.Path.GetExtension(sfd.FileName).ToLower() == ".rtf")
           	  {
                doc.Save(fs, DataFormats.Rtf);
              }
              else if (System.IO.Path.GetExtension(sfd.FileName).ToLower() == ".txt")
              {
                doc.Save(fs, DataFormats.Text);
              }
              else
              {
                doc.Save(fs, DataFormats.Xaml);
            }
        }
    }
		}
		/*создание файла*/
		void New_Click(object sender, RoutedEventArgs e)
		{
			fff.Document.Blocks.Clear();
		}
		void Print_Click(object sender, RoutedEventArgs e)
		{
		PrintDialog printDialog = new PrintDialog();
		if (printDialog.ShowDialog() == true)
		{
         printDialog.PrintVisual(fff, "Распечатываем элемент Canvas");
		}
		}
		/*кнопки полужирного, подчёркнутого и курсивного текста*/
		private void cmdFormatting_Click(object sender, RoutedEventArgs e)
        {
            // Ссылка на объект выделения
            TextSelection selection = fff.Selection;

            // Если текст не найден, код интерпретирует
            // шрифт как обычный
            FontWeight weightState = FontWeights.Normal;
            FontStyle styleState = FontStyles.Normal;
            TextDecorationCollection currentState = null;

            if (e.OriginalSource == cmdBold)
            {
                // Проверка, выведен ли фрагмент полужирным цветом
                if (selection.GetPropertyValue(Run.FontWeightProperty) !=
                    DependencyProperty.UnsetValue)
                {
                    weightState = (FontWeight)selection.GetPropertyValue(
                        Run.FontWeightProperty);
                }

                if (weightState == FontWeights.Normal)
                {
                    selection.ApplyPropertyValue(Run.FontWeightProperty, FontWeights.Bold);
                }
                else
                {
                    selection.ApplyPropertyValue(Run.FontWeightProperty, FontWeights.Normal);
                }
            }

            if (e.OriginalSource == cmdItalic)
            {
                // Проверка, выведен ли фрагмент наклонным стилем
                if (selection.GetPropertyValue(Run.FontStyleProperty) != DependencyProperty.UnsetValue)
                    styleState = (FontStyle)selection.GetPropertyValue(Run.FontStyleProperty);

                if (styleState == FontStyles.Italic)
                {
                    selection.ApplyPropertyValue(Run.FontStyleProperty, FontStyles.Normal);
                }
                else
                {
                    selection.ApplyPropertyValue(Run.FontStyleProperty, FontStyles.Italic);
                }
            }

            if (e.OriginalSource == cmdUnder)
            {
                // Проверка, выведен ли фрагмент с подчеркиванием
                if (selection.GetPropertyValue(Run.TextDecorationsProperty) != DependencyProperty.UnsetValue)
                    currentState = (TextDecorationCollection)selection.GetPropertyValue(Run.TextDecorationsProperty);

                if (currentState != TextDecorations.Underline)
                {
                    selection.ApplyPropertyValue(Run.TextDecorationsProperty, TextDecorations.Underline);
                }
                else
                {
                    selection.ApplyPropertyValue(Run.TextDecorationsProperty, null);
                }
            }

            // Возврат фокуса полю, чтобы пользователь мог продолжить работу с ним
            fff.Focus();
        }
	}
}