using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ElemedidOsa1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        Picker picker, picker2;
        Editor editor, editor2;
        Image img;
        Entry entr;
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
                    new ColumnDefinition{Width=new GridLength(1,GridUnitType.Star)}
                }
            };
            picker = new Picker
            {
                Title = "Уезды"
            };
            picker.Items.Add("Харьюмаа");
            picker.Items.Add("Ляэнемаа");
            picker.Items.Add("Пярнумаа");
            picker.Items.Add("Вильяндимаа");
            picker.Items.Add("Ярвамаа");
            picker.Items.Add("Рапламаа");
            picker.Items.Add("Ляэне-Вирумаа");
            picker.Items.Add("Йыгевамаа");
            picker.Items.Add("Ида-Вирумаа");
            picker.Items.Add("Тартумаа");
            picker.Items.Add("Пылвамаа");
            picker.Items.Add("Валгамаа");
            picker.Items.Add("Вырумаа");
            picker.Items.Add("Хийумаа");
            picker.Items.Add("Сааремаа");
            gr.Children.Add(picker, 0, 1);
            picker.SelectedIndexChanged += Picker_SelectedIndexChanged;

            editor = new Editor { Placeholder = "Уезд" };
            gr.Children.Add(editor, 0, 0);

            picker2 = new Picker
            {
                Title = "Столицы уездов"
            };
            picker2.Items.Add("Таллинн");
            picker2.Items.Add("Хаапсалу");
            picker2.Items.Add("Пярну");
            picker2.Items.Add("Вильянди");
            picker2.Items.Add("Пайде");
            picker2.Items.Add("Рапла");
            picker2.Items.Add("Раквере");
            picker2.Items.Add("Йыгева");
            picker2.Items.Add("Йыхви");
            picker2.Items.Add("Тарту");
            picker2.Items.Add("Пылва");
            picker2.Items.Add("Валга");
            picker2.Items.Add("Выру");
            picker2.Items.Add("Кярдла");
            picker2.Items.Add("Курессааре");
            gr.Children.Add(picker2, 1, 1);
            picker2.SelectedIndexChanged += Picker2_SelectedIndexChanged;

            editor2 = new Editor { Placeholder = "Столица уезда" };
            gr.Children.Add(editor2, 1, 0);

            img = new Image { Source = "nope" };
            gr.Children.Add(img, 0, 2);

            entr = new Entry { Text = "Население" };
            gr.Children.Add(entr, 1, 2);
            Content = gr;
        }

        private void Picker2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(picker2.SelectedIndex == 0)
            {
                editor2.Text = "Выбранная столица " + picker2.Items[picker2.SelectedIndex];
                editor.Text = "Выбранная столица: " + picker.Items[picker.SelectedIndex = 0];
                img.Source = "Harjumaa.png";
                entr.Text = "605 029 чел. (2020)";
            }
            else if(picker2.SelectedIndex == 1)
            {
                editor2.Text = "Выбранная столица " + picker2.Items[picker2.SelectedIndex];
                editor.Text = "Выбранная столица: " + picker.Items[picker.SelectedIndex = 1];
                img.Source = "Laanemaa.png";
                entr.Text = "24 734 чел. (2012)";
            }
            else if (picker2.SelectedIndex == 2)
            {
                editor2.Text = "Выбранная столица " + picker2.Items[picker2.SelectedIndex];
                editor.Text = "Выбранная столица: " + picker.Items[picker.SelectedIndex = 2];
                img.Source = "Parnu.png";
                entr.Text = "84 388 чел. (2012)";
            }
            else if (picker2.SelectedIndex == 3)
            {
                editor2.Text = "Выбранная столица " + picker2.Items[picker2.SelectedIndex];
                editor.Text = "Выбранная столица: " + picker.Items[picker.SelectedIndex = 3];
                img.Source = "Viljandimaa.png";
                entr.Text = "48 604 чел. (2012)";
            }
            else if (picker2.SelectedIndex == 4)
            {
                editor2.Text = "Выбранная столица " + picker2.Items[picker2.SelectedIndex];
                editor.Text = "Выбранная столица: " + picker.Items[picker.SelectedIndex = 4];
                img.Source = "Jarvamaa.png";
                entr.Text = "31 204 чел. (2012)";
            }
            else if (picker2.SelectedIndex == 5)
            {
                editor2.Text = "Выбранная столица " + picker2.Items[picker2.SelectedIndex];
                editor.Text = "Выбранная столица: " + picker.Items[picker.SelectedIndex = 5];
                img.Source = "Raplamaa.png";
                entr.Text = "35 503 чел. (2012)";
            }
            else if (picker2.SelectedIndex == 6)
            {
                editor2.Text = "Выбранная столица " + picker2.Items[picker2.SelectedIndex];
                editor.Text = "Выбранная столица: " + picker.Items[picker.SelectedIndex = 6];
                img.Source = "LaaneVirumaa.png";
                entr.Text = "58 862 чел. (2020)";
            }
            else if (picker2.SelectedIndex == 7)
            {
                editor2.Text = "Выбранная столица " + picker2.Items[picker2.SelectedIndex];
                editor.Text = "Выбранная столица: " + picker.Items[picker.SelectedIndex = 7];
                img.Source = "Jogevamaa.png";
                entr.Text = "31 967 чел. (2012)";
            }
            else if (picker2.SelectedIndex == 8)
            {
                editor2.Text = "Выбранная столица " + picker2.Items[picker2.SelectedIndex];
                editor.Text = "Выбранная столица: " + picker.Items[picker.SelectedIndex = 8];
                img.Source = "IdaVirumaa.png";
                entr.Text = "134 259 чел. (2020)";
            }
            else if (picker2.SelectedIndex == 9)
            {
                editor2.Text = "Выбранная столица " + picker2.Items[picker2.SelectedIndex];
                editor.Text = "Выбранная столица: " + picker.Items[picker.SelectedIndex = 9];
                img.Source = "Tartumaa.png";
                entr.Text = "153 317 чел. (2020)";
            }
            else if (picker2.SelectedIndex == 10)
            {
                editor2.Text = "Выбранная столица " + picker2.Items[picker2.SelectedIndex];
                editor.Text = "Выбранная столица: " + picker.Items[picker.SelectedIndex = 10];
                img.Source = "Polvamaa.png";
                entr.Text = "28 026 чел. (2012)";
            }
            else if (picker2.SelectedIndex == 11)
            {
                editor2.Text = "Выбранная столица " + picker2.Items[picker2.SelectedIndex];
                editor.Text = "Выбранная столица: " + picker.Items[picker.SelectedIndex = 11];
                img.Source = "Valgamaa.png";
                entr.Text = "31 068 чел. (2012)";
            }
            else if (picker2.SelectedIndex == 12)
            {
                editor2.Text = "Выбранная столица " + picker2.Items[picker2.SelectedIndex];
                editor.Text = "Выбранная столица: " + picker.Items[picker.SelectedIndex = 12];
                img.Source = "Vorumaa.png";
                entr.Text = "34 178 чел. (2012)";
            }
            else if (picker2.SelectedIndex == 13)
            {
                editor2.Text = "Выбранная столица " + picker2.Items[picker2.SelectedIndex];
                editor.Text = "Выбранная столица: " + picker.Items[picker.SelectedIndex = 13];
                img.Source = "Hiiumaa.png";
                entr.Text = "9315 чел. (2020)";
            }
            else if (picker2.SelectedIndex == 14)
            {
                editor2.Text = "Выбранная столица " + picker2.Items[picker2.SelectedIndex];
                editor.Text = "Выбранная столица: " + picker.Items[picker.SelectedIndex = 14];
                img.Source = "Saaremaa.png";
                entr.Text = "31 835 чел. (2012)";
            }
        }

        private void Picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(picker.SelectedIndex == 0)
            {
                editor.Text = "Выбранный уезд: " + picker.Items[picker.SelectedIndex];
                editor2.Text = "Выбранная столица: " + picker2.Items[picker2.SelectedIndex = 0];
                img.Source = "Harjumaa.png";
            }
            else if(picker.SelectedIndex == 1)
            {
                editor.Text = "Выбранный уезд: " + picker.Items[picker.SelectedIndex];
                editor2.Text = "Выбранная столица: " + picker2.Items[picker2.SelectedIndex = 1];
            }
            else if (picker.SelectedIndex == 2)
            {
                editor.Text = "Выбранный уезд: " + picker.Items[picker.SelectedIndex];
                editor2.Text = "Выбранная столица: " + picker2.Items[picker2.SelectedIndex = 2];
            }
            else if (picker.SelectedIndex == 3)
            {
                editor.Text = "Выбранный уезд: " + picker.Items[picker.SelectedIndex];
                editor2.Text = "Выбранная столица: " + picker2.Items[picker2.SelectedIndex = 3];
            }
            else if (picker.SelectedIndex == 4)
            {
                editor.Text = "Выбранный уезд: " + picker.Items[picker.SelectedIndex];
                editor2.Text = "Выбранная столица: " + picker2.Items[picker2.SelectedIndex = 4];
            }
            else if (picker.SelectedIndex == 5)
            {
                editor.Text = "Выбранный уезд: " + picker.Items[picker.SelectedIndex];
                editor2.Text = "Выбранная столица: " + picker2.Items[picker2.SelectedIndex = 5];
            }
            else if (picker.SelectedIndex == 6)
            {
                editor.Text = "Выбранный уезд: " + picker.Items[picker.SelectedIndex];
                editor2.Text = "Выбранная столица: " + picker2.Items[picker2.SelectedIndex = 6];
            }
            else if (picker.SelectedIndex == 7)
            {
                editor.Text = "Выбранный уезд: " + picker.Items[picker.SelectedIndex];
                editor2.Text = "Выбранная столица: " + picker2.Items[picker2.SelectedIndex = 7];
            }
            else if (picker.SelectedIndex == 8)
            {
                editor.Text = "Выбранный уезд: " + picker.Items[picker.SelectedIndex];
                editor2.Text = "Выбранная столица: " + picker2.Items[picker2.SelectedIndex = 8];
            }
            else if (picker.SelectedIndex == 9)
            {
                editor.Text = "Выбранный уезд: " + picker.Items[picker.SelectedIndex];
                editor2.Text = "Выбранная столица: " + picker2.Items[picker2.SelectedIndex = 9];
            }
            else if (picker.SelectedIndex == 10)
            {
                editor.Text = "Выбранный уезд: " + picker.Items[picker.SelectedIndex];
                editor2.Text = "Выбранная столица: " + picker2.Items[picker2.SelectedIndex = 10];
            }
            else if (picker.SelectedIndex == 11)
            {
                editor.Text = "Выбранный уезд: " + picker.Items[picker.SelectedIndex];
                editor2.Text = "Выбранная столица: " + picker2.Items[picker2.SelectedIndex = 11];
            }
            else if (picker.SelectedIndex == 12)
            {
                editor.Text = "Выбранный уезд: " + picker.Items[picker.SelectedIndex];
                editor2.Text = "Выбранная столица: " + picker2.Items[picker2.SelectedIndex = 12];
            }
            else if (picker.SelectedIndex == 13)
            {
                editor.Text = "Выбранный уезд: " + picker.Items[picker.SelectedIndex];
                editor2.Text = "Выбранная столица: " + picker2.Items[picker2.SelectedIndex = 13];
            }
            else if (picker.SelectedIndex == 14)
            {
                editor.Text = "Выбранный уезд: " + picker.Items[picker.SelectedIndex];
                editor2.Text = "Выбранная столица: " + picker2.Items[picker2.SelectedIndex = 14];
            }
        }
    }
}