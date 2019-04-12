using FilmsXamarin.View;
using Newtonsoft.Json;
using FilmsXamarin.Model;
using System.IO;
using System.Reflection;

namespace FilmsXamarin.ViewModel
{
    public class AboutViewModel
    {
        public string aboutText { get; set; }

        public AboutViewModel()
        {
            var assembly = typeof(MainPage).GetTypeInfo().Assembly;
            var dataFileName = "about_data.json";

            Stream aboutDataStream = assembly.GetManifestResourceStream($"{assembly.GetName().Name}.{dataFileName}");

            using (var reader = new System.IO.StreamReader(aboutDataStream))
            {
                var line = reader.ReadToEnd();
                var data = JsonConvert.DeserializeObject<AboutModel>(line);

                aboutText = data.aboutText;
            }
        }
    }
}
