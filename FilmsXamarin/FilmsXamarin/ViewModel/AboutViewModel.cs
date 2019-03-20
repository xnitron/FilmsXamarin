using FilmsXamarin.View;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using FilmsXamarin.Model;
using System.IO;
using System.Reflection;
using System.Text;

namespace FilmsXamarin.ViewModel
{
    public class AboutViewModel
    {

        public string aboutText { get; set; }

        public AboutViewModel()
        {
            var assembly = typeof(MainPage).GetTypeInfo().Assembly;
            var path = "about_data.json";
            Stream stream = assembly.GetManifestResourceStream($"{assembly.GetName().Name}.{path}");

            using (var reader = new System.IO.StreamReader(stream))
            {
                var json = reader.ReadToEnd();
                var data = JsonConvert.DeserializeObject<AboutModel>(json);
                aboutText = data.aboutText;
            }
        }
    }
}
