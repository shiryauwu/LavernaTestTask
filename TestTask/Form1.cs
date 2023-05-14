using Newtonsoft.Json.Linq;
using System.Net;
using System.Security.Policy;

namespace TestTask
{
    public partial class Form1 : Form
    {
        string appId = "81d82e16b8085a7d65e60d6401116ec5";  //ключ API
        string units = "metric";  //Данные для вывода температуры по цельсию
        string lang = "ru";  // Язык вывода: русский
        
        HttpClient httpClient = new HttpClient();  //Создание HTTP клиента для дальнейшей работы с вебом

        public Form1()
        {
            InitializeComponent();
        }
        public string GetTemperature(string cityName)  //Метод для вывода температуры
        {
            string url = $"https://api.openweathermap.org/data/2.5/weather?q={cityName}&APPID={appId}&units={units}&lang={lang}";  //ссылка для доступа к API
            try
            {
                var response = httpClient.GetStringAsync(url).Result;  // Присваивание переменной данных с API
                var responseMain = JObject.Parse(response).GetValue("main").ToString();  //Десериализация JSON
                var responseTemp = JObject.Parse(responseMain).GetValue("temp").ToString();
                return $"{responseTemp} °C";  //Вывод результата
            }
            catch (Exception ex)
            {
                return "";
            }
        }
        public string GetWeatherDescription(string cityName)
        {
            string url = $"https://api.openweathermap.org/data/2.5/weather?q={cityName}&APPID={appId}&units={units}&lang={lang}";  //ссылка для доступа к API
            try
            {
                var response = httpClient.GetStringAsync(url).Result;  // Присваивание переменной данных с API
                var responseWeather = JObject.Parse(response).GetValue("weather"); //Десериализация JSON
                var responseWeatherArray = responseWeather[0].ToString();
                var responseDescription = JObject.Parse(responseWeatherArray).GetValue("description").ToString();
                return responseDescription;  //Вывод результата
            }
            catch (Exception ex)
            {
                return "";
            }
        }
        public string GetWindSpeed(string cityName)
        {
            string url = $"https://api.openweathermap.org/data/2.5/weather?q={cityName}&APPID={appId}&units={units}&lang={lang}";  //ссылка для доступа к API
            try
            {
                var response = httpClient.GetStringAsync(url).Result;  // Присваивание переменной данных с API
                var responseWind = JObject.Parse(response).GetValue("wind").ToString();  //Десериализация JSON
                var responseSpeed = JObject.Parse(responseWind).GetValue("speed").ToString();
                return $"{responseSpeed} км/ч";  //Вывод результата
            }
            catch (Exception ex)
            {
                
                return "";
            }
        }
        private void button1_Click(object sender, EventArgs e)  // Обработка события нажатия на кнопку
        {
            string cityName;  

            cityName = getCityNameBox.Text;  // Ввод пользователем названия города

            temperatureBox.Text = GetTemperature(cityName); // Присваивание полю результата метода
            descriptionBox.Text = GetWeatherDescription(cityName);  // Присваивание полю результата метода
            speedBox.Text = GetWindSpeed(cityName);  // Присваивание полю результата метода
            if (temperatureBox.Text == "")  //  Обработка ошибки 
            {
                MessageBox.Show("Город не найден!");
            }
        }

       
    }
}
