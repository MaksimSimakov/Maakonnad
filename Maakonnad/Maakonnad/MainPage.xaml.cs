using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Maakonnad
{
    public partial class MainPage : ContentPage
    {
        Picker picker1;
        Picker picker2;
        Editor editor;
        Image image;
        Entry entry;

        public MainPage()
        {
            Grid gr = new Grid
            {
                RowDefinitions =
                {
                    new RowDefinition{Height=new GridLength(1,GridUnitType.Star)},
                    new RowDefinition{Height=new GridLength(1,GridUnitType.Star)},
                    new RowDefinition{Height=new GridLength(1,GridUnitType.Star)},
                },
                ColumnDefinitions =
                {
                    new ColumnDefinition{Width=new GridLength(1,GridUnitType.Star)},
                    new ColumnDefinition{Width=new GridLength(1,GridUnitType.Star)},
                }
                
            };
            picker1 = new Picker
            {
                Title = "Уезды"
            };
            picker1.Items.Add("Харьюмаа");
            picker1.Items.Add("Рапламаа");
            picker1.Items.Add("Ярвамаа");
            picker1.Items.Add("Пярнумаа");
            picker1.Items.Add("Тартумаа");
            gr.Children.Add(picker1, 0, 0);
            picker1.SelectedIndexChanged += Picker_SelectedIndexChanged;
            editor = new Editor { Placeholder = "Выбери уезд" };
            gr.Children.Add(editor, 0, 2);

            picker2 = new Picker
            {
                Title = "Столицы уездов"
            };
            picker2.Items.Add("Таллинн");
            picker2.Items.Add("Рапла");
            picker2.Items.Add("Ярва");
            picker2.Items.Add("Пярну");
            picker2.Items.Add("Тарту");
            gr.Children.Add(picker2, 1, 0);

            Content = gr;
        }
  
        private void Picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            editor.Text = "Выбрано: " + picker1.Items[picker1.SelectedIndex]; 
        }
    }
}
