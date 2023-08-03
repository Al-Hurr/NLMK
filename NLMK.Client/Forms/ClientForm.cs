using NLMK.Client.Services;
using Timer = System.Windows.Forms.Timer;

namespace NLMK.Client.Forms
{
    public partial class ClientForm : Form
    {
        private Timer _timer;
        private bool _visible;
        private readonly HttpClientService _httpClientService;

        public ClientForm(HttpClientService httpClientService)
        {
            InitializeComponent();
            InitalizeTimer();
            _httpClientService = httpClientService;
        }

        private void InitalizeTimer()
        {
            _timer = new Timer();
            _timer.Interval = 500;
            _timer.Tick += Timer_Tick;
        }

        private void DividentTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateNumControls(sender, e);
        }

        private void DividertextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateNumControls(sender, e);
        }

        private void ValidateNumControls(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
            {
                return;
            }

            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                return;
            }

            if (sender is TextBox textBox)
            {
                if (textBox.Text.Length >= 5)
                {
                    return;
                }

                int number = int.Parse(textBox.Text + e.KeyChar);
                if (number > 10_000)
                {
                    MessageBox.Show("Число должен быть не больше 10 000");
                    e.Handled = true;
                }
            }
        }

        private async void Calculate_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(DividentTextBox.Text) || string.IsNullOrEmpty(DividerTextBox.Text))
            {
                MessageBox.Show("Запоните все поля", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if(int.Parse(DividerTextBox.Text) == 0)
            {
                MessageBox.Show("Нельзя делить на ноль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            QuotientTextBox.Text = "";

            try
            {
                _timer.Start();
                this.DividerTextBox.Enabled = false;
                this.DividentTextBox.Enabled = false;
                int divident = int.Parse(DividentTextBox.Text);
                int divider = int.Parse(DividerTextBox.Text);

                var result = await _httpClientService.SendCalculateAsync(divident, divider);
                QuotientTextBox.Text = result;
            }
            catch (HttpRequestException)
            {
                MessageBox.Show("Ошибка на стороне сервера." + Environment.NewLine +
                    "Обратитесь в тех. поддержку", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                _timer.Stop();
                InfoLabel.Visible = PictureBox.Visible = false;
                this.DividerTextBox.Enabled = true;
                this.DividentTextBox.Enabled = true;
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            _visible = !_visible;
            InfoLabel.Visible = PictureBox.Visible = _visible;
        }
    }
}