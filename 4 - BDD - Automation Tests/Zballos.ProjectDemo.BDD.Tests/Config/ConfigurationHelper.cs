using Microsoft.Extensions.Configuration;

namespace Zballos.ProjectDemo.BDD.Tests.Config
{
    public class ConfigurationHelper
    {
        private readonly IConfiguration _config;

        public ConfigurationHelper()
        {
            _config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();
        }

        public string WebDrivers => $"{_config.GetSection("WebDrivers").Value}";
        public string EspnUrl => $"{_config.GetSection("Sites").GetSection("ESPN").Value}";
        public string UolUrl => $"{_config.GetSection("Sites").GetSection("UOL").Value}";
        public string FolderPicture => $"{_config.GetSection("Folder").Value}";
    }
}
