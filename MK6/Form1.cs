using Newtonsoft.Json;
using System.Drawing.Printing;
namespace MK6
{
    public partial class Form1 : Form
    {
        private TextBox textBoxResult;
        private TextBox txtUah;
        private TextBox txtStartingCurrency;

        private Button btnGetData;
        private Button btnGetResult;

        private ComboBox comboBoxCurrencies;
        private ComboBox comboBoxDirection;

        private Label lblUah;
        private Label lblCurrency;
        private Label lblDirection;

        private static readonly HttpClient client = new HttpClient();
        private List<ExchangeRate> _exchangeRates;

        private void BuildInterface()
        {
            this.Text = "Currency Exchange";
            this.ClientSize = new Size(1200, 650);

            textBoxResult = new TextBox();
            textBoxResult.Multiline = true;
            textBoxResult.ScrollBars = ScrollBars.Vertical;
            textBoxResult.ReadOnly = true;
            textBoxResult.Location = new Point(20, 20);
            textBoxResult.Size = new Size(700, 590);
            this.Controls.Add(textBoxResult);

            txtStartingCurrency = new TextBox { Location = new Point(1015, 57), Size = new Size(170, 30) };
            this.Controls.Add(txtStartingCurrency);
            txtUah = new TextBox { Location = new Point(1015, 150), Size = new Size(170, 30) };
            this.Controls.Add(txtUah);

            btnGetData = new Button();
            btnGetData.Text = "Отримати дані";
            btnGetData.Size = new Size(220, 55);
            btnGetData.Location = new Point(750, 30);
            this.Controls.Add(btnGetData);

            btnGetResult = new Button();
            btnGetResult.Text = "Конвертувати";
            btnGetResult.Size = new Size(170, 30);
            btnGetResult.Location = new Point(1015, 220);
            this.Controls.Add(btnGetResult);

            comboBoxCurrencies = new ComboBox();
            comboBoxCurrencies.Location = new Point(750, 150);
            comboBoxCurrencies.Size = new Size(220, 40);
            comboBoxCurrencies.DropDownStyle = ComboBoxStyle.DropDownList;
            this.Controls.Add(comboBoxCurrencies);
            comboBoxDirection = new ComboBox();
            comboBoxDirection.Location = new Point(750, 222);
            comboBoxDirection.Size = new Size(220, 40);
            comboBoxDirection.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxDirection.Items.Add("UAH -> Валюта");
            comboBoxDirection.Items.Add("Валюта -> UAH");

            comboBoxDirection.SelectedIndex = 0;
            this.Controls.Add(comboBoxDirection);

            lblUah = new Label { Text = "UAH", Location = new Point(977, 155), AutoSize = true };
            this.Controls.Add(lblUah);
            lblCurrency = new Label { Text = "", Location = new Point(977, 62), AutoSize = true };
            this.Controls.Add(lblCurrency);
            lblDirection = new Label { Text = "Напрямок конвертації", Location = new Point(750, 200), AutoSize = true };
            this.Controls.Add(lblDirection);

            btnGetData.Click += btnGetData_Click;
            btnGetResult.Click += btnGetResult_Click;
            comboBoxCurrencies.SelectedIndexChanged += comboBoxCurrencies_SelectedIndexChanged;
            comboBoxDirection.SelectedIndexChanged += comboBoxDirection_SelectedIndexChanged;
        }


        private async void btnGetData_Click(object sender, EventArgs e)
        {
            try
            {
                string apiUrl = "https://bank.gov.ua/NBUStatService/v1/statdirectory/exchange?json";
                var response = await GetExchangeRates(apiUrl); // Додаємо 'await'
                                                               // Десеріалізація JSON у список об'єктів
                _exchangeRates = JsonConvert.DeserializeObject<List<ExchangeRate>>(response);

                // Виведення даних (наприклад, у TextBox)
                foreach (var rate in _exchangeRates)
                {
                    textBoxResult.AppendText($"Валюта: {rate.txt} ({rate.cc}), " +
                        $"Курс: {rate.rate}, " +
                        $"Дата: {rate.exchangeDate}\r\n");
                }

                // Очищення ComboBox перед заповненням
                comboBoxCurrencies.Items.Clear();

                // Заповнення ComboBox назвами валют        

                // Прив'язуємо джерело даних для ComboBox до списку об'єктів exchangeRates
                comboBoxCurrencies.DataSource = _exchangeRates;

                // Вказуємо, яке поле об'єкта ExchangeRate буде відображатися в ComboBox (назва валюти)
                comboBoxCurrencies.DisplayMember = "txt";

                // Вказуємо, яке поле об'єкта ExchangeRate буде використовуватися як значення (курс валюти)
                comboBoxCurrencies.ValueMember = "rate";


                // Встановлення вибору за замовчуванням
                if (comboBoxCurrencies.Items.Count > 0)
                {
                    comboBoxCurrencies.SelectedIndex = 0; // Вибрати перший елемент
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btnGetResult_Click(object sender, EventArgs e)
        {
            try
            {
                if (_exchangeRates == null || _exchangeRates.Count == 0)
                {
                    MessageBox.Show("Спочатку натисніть «Отримати дані».");
                    return;
                }

                if (!double.TryParse(txtStartingCurrency.Text, out double amount))
                {
                    MessageBox.Show("Введіть правильну суму.");
                    return;
                }

                if (comboBoxCurrencies.SelectedItem == null)
                {
                    MessageBox.Show("Оберіть валюту.");
                    return;
                }

                ExchangeRate selectedCurrency =
                    (ExchangeRate)comboBoxCurrencies.SelectedItem;

                double rate = selectedCurrency.rate;

                if (comboBoxDirection.SelectedIndex == 0)
                {
                    double result = amount / rate;
                    txtUah.Text = result.ToString("F2");
                }

                else
                {
                    double result = amount * rate;
                    txtUah.Text = result.ToString("F2");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
        private void comboBoxCurrencies_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxCurrencies.SelectedItem == null)
                return;

            ExchangeRate selectedCurrency =
                (ExchangeRate)comboBoxCurrencies.SelectedItem;

            if (comboBoxDirection.SelectedIndex == 0)
            {
                lblCurrency.Text = "UAH";
                lblUah.Text = selectedCurrency.cc;
            }
            else
            {
                lblCurrency.Text = selectedCurrency.cc;
                lblUah.Text = "UAH";
            }
        }

        private void comboBoxDirection_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxCurrencies.SelectedItem == null)
                return;

            ExchangeRate selectedCurrency =
                (ExchangeRate)comboBoxCurrencies.SelectedItem;

            if (comboBoxDirection.SelectedIndex == 0)
            {
                lblCurrency.Text = "UAH";
                lblUah.Text = selectedCurrency.cc;
            }
            else
            {
                lblCurrency.Text = selectedCurrency.cc;
                lblUah.Text = "UAH";
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
