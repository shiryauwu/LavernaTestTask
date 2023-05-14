using Newtonsoft.Json.Linq;
using System.Net;
using System.Security.Policy;

namespace TestTask
{
    public partial class Form1 : Form
    {
        string appId = "81d82e16b8085a7d65e60d6401116ec5";  //���� API
        string units = "metric";  //������ ��� ������ ����������� �� �������
        string lang = "ru";  // ���� ������: �������
        
        HttpClient httpClient = new HttpClient();  //�������� HTTP ������� ��� ���������� ������ � �����

        public Form1()
        {
            InitializeComponent();
        }
        public string GetTemperature(string cityName)  //����� ��� ������ �����������
        {
            string url = $"https://api.openweathermap.org/data/2.5/weather?q={cityName}&APPID={appId}&units={units}&lang={lang}";  //������ ��� ������� � API
            try
            {
                var response = httpClient.GetStringAsync(url).Result;  // ������������ ���������� ������ � API
                var responseMain = JObject.Parse(response).GetValue("main").ToString();  //�������������� JSON
                var responseTemp = JObject.Parse(responseMain).GetValue("temp").ToString();
                return $"{responseTemp} �C";  //����� ����������
            }
            catch (Exception ex)
            {
                return "";
            }
        }
        public string GetWeatherDescription(string cityName)
        {
            string url = $"https://api.openweathermap.org/data/2.5/weather?q={cityName}&APPID={appId}&units={units}&lang={lang}";  //������ ��� ������� � API
            try
            {
                var response = httpClient.GetStringAsync(url).Result;  // ������������ ���������� ������ � API
                var responseWeather = JObject.Parse(response).GetValue("weather");  //�������������� JSON
                var responseWeatherArray = responseWeather[0].ToString();
                var responseDescription = JObject.Parse(responseWeatherArray).GetValue("description").ToString();
                return responseDescription;  //����� ����������
            }
            catch (Exception ex)
            {
                return "";
            }
        }
        public string GetWindSpeed(string cityName)
        {
            string url = $"https://api.openweathermap.org/data/2.5/weather?q={cityName}&APPID={appId}&units={units}&lang={lang}";  //������ ��� ������� � API
            try
            {
                var response = httpClient.GetStringAsync(url).Result;  // ������������ ���������� ������ � API
                var responseWind = JObject.Parse(response).GetValue("wind").ToString();  //�������������� JSON
                var responseSpeed = JObject.Parse(responseWind).GetValue("speed").ToString();
                return $"{responseSpeed} ��/�";  //����� ����������
            }
            catch (Exception ex)
            {
                
                return "";
            }
        }
        private void button1_Click(object sender, EventArgs e)  // ��������� ������� ������� �� ������
        {
            string cityName;  

            cityName = textBox7.Text;  // ���� ������������� �������� ������

            textBox1.Text = GetTemperature(cityName);  // ������������ ���� ���������� ������
            textBox2.Text = GetWeatherDescription(cityName);  // ������������ ���� ���������� ������
            textBox3.Text = GetWindSpeed(cityName);  // ������������ ���� ���������� ������
            if (textBox1.Text == "")  //  ��������� ������ 
            {
                MessageBox.Show("����� �� ������!");
            }
        }

       
    }
}