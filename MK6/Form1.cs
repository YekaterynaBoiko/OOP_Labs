using Newtonsoft.Json;
namespace MK6
{
    public partial class Form1 : Form
    {
        private TextBox textBoxResult;
        private Button btnGetData;

        private static readonly HttpClient client = new HttpClient();

        private void BuildInterface()
        {
            this.Text = "Currency Exchange";
            this.ClientSize = new Size(800, 500);

            textBoxResult = new TextBox();
            textBoxResult.Multiline = true;
            textBoxResult.ScrollBars = ScrollBars.Vertical;
            textBoxResult.ReadOnly = true;
            textBoxResult.Location = new Point(20, 20);
            textBoxResult.Size = new Size(570, 450);
            this.Controls.Add(textBoxResult);

            btnGetData = new Button();
            btnGetData.Text = "Отримати дані";
            btnGetData.Size = new Size(160, 50);
            btnGetData.Location = new Point(620, 20);
            this.Controls.Add(btnGetData);

            btnGetData.Click += btnGetData_Click;
        }

        private async void btnGetData_Click(object sender, EventArgs e)
        {
            try
            {
                string apiUrl = "https://bank.gov.ua/NBUStatService/v1/statdirectory/exchange?json";
                var response = await GetExchangeRates(apiUrl);
                // Десеріалізація JSON у список об'єктів
                List<ExchangeRate> exchangeRates = JsonConvert.DeserializeObject<List<ExchangeRate>>(response);
                // Виведення даних (наприклад, у TextBox)
                foreach (var rate in exchangeRates)
                {
                    textBoxResult.AppendText($"Валюта: {rate.txt} ({rate.cc}), " +
                        $"Курс: {rate.rate}, " +
                        $"Дата: {rate.exchangeDate}\r\n");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private async Task<string> GetExchangeRates(string url)
        {
            HttpResponseMessage responseMessage = await client.GetAsync(url);
            responseMessage.EnsureSuccessStatusCode();
            return await responseMessage.Content.ReadAsStringAsync();
        }
 
        public Form1()
        {
            InitializeComponent();
            BuildInterface();
        }
    }
}
