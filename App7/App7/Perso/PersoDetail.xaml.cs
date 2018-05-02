using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Reflection;
using System.IO;
using System.Xml.Serialization;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App7.Perso
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PersoDetail : TabbedPage
    {
        public PersoDetail ()
        {
            InitializeComponent();


            var editor = new Label { Text = "loading...", HeightRequest = 300 };

            #region How to load a text file embedded resource
            var assembly = IntrospectionExtensions.GetTypeInfo(typeof(MainPage)).Assembly;
            Stream stream = assembly.GetManifestResourceStream("App7.Perso.XMLFile1.xml");


            List<Monkey> monkeys;

            using (var reader = new System.IO.StreamReader(stream))
            {
                var serializer = new XmlSerializer(typeof(List<Monkey>));
                monkeys = (List<Monkey>)serializer.Deserialize(reader);
            }


            /*  string text = "";
              using (var reader = new System.IO.StreamReader(stream))
              {
                  text = reader.ReadToEnd();
              }*/
            #endregion

            //editor.Text = text;
            var listView = new ListView();
            listView.ItemsSource = monkeys;
            System.Diagnostics.Debug.Write(listView);


            foreach (var monkey in monkeys)
            {
                this.Children.Add(new ContentPage
                {
                    Title = monkey.Name,

                    Content = new StackLayout
                    {
                        Padding = new Thickness(0, 20, 0, 0),
                        VerticalOptions = LayoutOptions.StartAndExpand,

                        Children = {
                        new Label { Text = monkey.Details,
                            FontSize = Device.GetNamedSize (NamedSize.Medium, typeof(Label)),
                            FontAttributes = FontAttributes.Bold
                        }
                        }
                    }


                });


            }


        

            

     
            


        }
    }

    public class Monkey
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public string Details { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }



}



