namespace Lab30
{
    public partial class Form1 : Form
    {
        // ====== Елементи керування (створюємо у коді, без перетягування) ======
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem convertToolStripMenuItem;

        private Label lblMetersTitle;
        private Label lblCmTitle;
        private Label lblConvertedCmTitle;
        private Label lblEquals; // =

        private TextBox txtM;            // поле для метрів
        private TextBox txtCm;           // поле для сантиметрів
        private TextBox txtConvertedCm;  // поле для результату (сантиметри)

        private GroupBox grpConversionType;
        private RadioButton rbToCm;      // напрям: в сантиметри
        private RadioButton rbFromCm;    // напрям: із сантиметрів

        private Button btnConvert;
        private Button btnExit;

        // ====== Робочі змінні ======
        private int m;                   // кількість метрів
        private int cm;                  // кількість сантиметрів
        private int convertedCm;         // результат у сантиметрах
        private bool bConvertingToCm;    // true = переводимо В сантиметри

        private void BuildInterface()
        {
            // --- Налаштування самої форми ---
            this.Text = "Конвертер"; // назва форми
            this.ClientSize = new Size(410, 240);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;

            // --- Головне меню (MenuStrip) ---
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem("&File");
            exitToolStripMenuItem = new ToolStripMenuItem("E&xit");
            convertToolStripMenuItem = new ToolStripMenuItem("&Convert");
            fileToolStripMenuItem.DropDownItems.Add(exitToolStripMenuItem);
            menuStrip1.Items.Add(fileToolStripMenuItem);
            menuStrip1.Items.Add(convertToolStripMenuItem);
            this.MainMenuStrip = menuStrip1;
            this.Controls.Add(menuStrip1);

            // --- Підписи (Label) ---
            lblMetersTitle = new Label { Text = "метри", Location = new Point(35, 45), AutoSize = true };
            this.Controls.Add(lblMetersTitle);
            lblCmTitle = new Label { Text = "сантиметри", Location = new Point(120, 45), AutoSize = true };
            this.Controls.Add(lblCmTitle);
            lblConvertedCmTitle = new Label { Text = "сантиметри", Location = new Point(300, 45), AutoSize = true };
            this.Controls.Add(lblConvertedCmTitle);
            lblEquals = new Label { Text = "=", Location = new Point(265, 73), AutoSize = true };
            this.Controls.Add(lblEquals);

            // --- Поля вводу (TextBox) ---
            txtM = new TextBox { Location = new Point(35, 70), Width = 70 };
            this.Controls.Add(txtM);
            txtCm = new TextBox { Location = new Point(120, 70), Width = 70 };
            this.Controls.Add(txtCm);
            txtConvertedCm = new TextBox { Location = new Point(300, 70), Width = 70 };
            this.Controls.Add(txtConvertedCm);

            // --- Контейнер GroupBox з перемикачами (RadioButton) ---
            grpConversionType = new GroupBox { Text = "Напрям", Location = new Point(35, 105), Size = new Size(335, 70) };
            this.Controls.Add(grpConversionType);
            rbToCm = new RadioButton { Text = "в сантиметри", Location = new Point(15, 22), AutoSize = true };
            grpConversionType.Controls.Add(rbToCm);
            rbFromCm = new RadioButton { Text = "із сантиметрів", Location = new Point(15, 44), AutoSize = true };
            grpConversionType.Controls.Add(rbFromCm);

            // --- Кнопки ---
            btnConvert = new Button();
            btnConvert.Text = "Convert";
            btnConvert.Location = new Point(35, 190);
            btnConvert.Width = 100;
            this.Controls.Add(btnConvert);

            btnExit = new Button();
            btnExit.Text = "Exit";
            btnExit.Location = new Point(270, 190);
            btnExit.Width = 100;
            this.Controls.Add(btnExit);

            // --- Підключення обробників подій ---
            this.Load += Form1_Load;

            txtM.TextChanged += txtM_TextChanged; // звернення до textBox
            txtCm.TextChanged += txtCm_TextChanged;
            txtConvertedCm.TextChanged += txtConvertedCm_TextChanged;

            rbToCm.CheckedChanged += rbToCm_CheckedChanged;
            rbFromCm.CheckedChanged += rbFromCm_CheckedChanged;

            txtM.Click += txtM_Click;
            txtCm.Click += txtCm_Click;
            txtConvertedCm.Click += txtConvertedCm_Click;

            btnConvert.Click += btnConvert_Click;
            btnExit.Click += btnExit_Click;

            convertToolStripMenuItem.Click += convertToolStripMenuItem_Click;
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;

            // --- Початковий стан перемикача ---
            rbToCm.Checked = true;
        }

        // ====== Перевірка коректності введених даних ======
        private int ValidateKeyPress(string sControlText)
        {
            if (!int.TryParse(sControlText, out int iTest))
            {
                MessageBox.Show("Неправильний формат даних при введені", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -9999;
            }
            return iTest;
        }

        // ====== Обробники зміни тексту в полях вводу ======
        private void txtM_TextChanged(object sender, EventArgs e)
        {
            int result = ValidateKeyPress(txtM.Text); 
            if (result > -9999)
                m = result;
            else
            {
                txtM.Text = m.ToString();
                txtM.SelectAll();
            }
        }
        private void txtCm_TextChanged(object sender, EventArgs e)
        {
            int result = ValidateKeyPress(txtCm.Text);
            if (result > -9999)
                cm = result;
            else
            {
                txtCm.Text = cm.ToString();
                txtCm.SelectAll();
            }
        }
        private void txtConvertedCm_TextChanged(object sender, EventArgs e)
        {
            int result = ValidateKeyPress(txtConvertedCm.Text);
            if (result > -9999)
                convertedCm = result;
            else
            {
                txtConvertedCm.Text = convertedCm.ToString();
                txtConvertedCm.SelectAll();
            }
        }

        // ====== Вмикання / вимикання полів залежно від напряму ======
        private void ToggleControls()
        {
            txtM.Enabled = bConvertingToCm;
            txtCm.Enabled = bConvertingToCm;
            txtConvertedCm.Enabled = !bConvertingToCm; // ! — логічне НЕ
        }

        // ====== Обробник завантаження форми Form1_Load ======
        private void Form1_Load(object sender, EventArgs e)
        {
            bConvertingToCm = true; // сантиметри за замовчуванням
            ToggleControls();

            txtConvertedCm.Text = "0";
            txtCm.Text = "0";
            txtM.Text = "0";
        }

        // ====== Реакція на зміну перемикачів ======
        private void rbToCm_CheckedChanged(object sender, EventArgs e)
        {
            bConvertingToCm = rbToCm.Checked;
            ToggleControls();
        }

        private void rbFromCm_CheckedChanged(object sender, EventArgs e)
        {
            bConvertingToCm = !rbFromCm.Checked;
            ToggleControls();
        }

        // ====== Обробники Click — виділення тексту в полі ======
        private void txtM_Click(object sender, EventArgs e)
        {
            txtM.SelectAll();
        }
        private void txtCm_Click(object sender, EventArgs e)
        {
            txtCm.SelectAll();
        }
        private void txtConvertedCm_Click(object sender, EventArgs e)
        {
            txtConvertedCm.SelectAll();
        }

        // ====== Розрахунок сантиметрів ======
        private int CalculateCm(int meters, int centimeters)
        {
            return meters * 100 + centimeters;
        }

        // ====== Виконання перетворення в обраному напрямі ======
        private void ConvertValues(bool bToCm)
        {
            if (bToCm)   // метри + сантиметри -> сантиметри
            {
                convertedCm = CalculateCm(m, cm);
                txtConvertedCm.Text = Convert.ToString(convertedCm);
            }
            else         // сантиметри -> метри + сантиметри
            {
                m = convertedCm / 100;   // цілі метри
                cm = convertedCm % 100;  // залишок у сантиметрах
                txtM.Text = Convert.ToString(m);
                txtCm.Text = Convert.ToString(cm);
            }
        }

        // ====== Обробники кнопок та пунктів меню ======
        private void btnConvert_Click(object sender, EventArgs e)
        {
            ConvertValues(bConvertingToCm);
        }
        private void convertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConvertValues(bConvertingToCm);
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public Form1()
        {
            InitializeComponent();
            BuildInterface();
        }
    }
}