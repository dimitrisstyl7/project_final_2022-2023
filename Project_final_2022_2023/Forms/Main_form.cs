namespace Project_final_2022_2023
{
    public partial class main_form : Form
    {
        public main_form()
        {
            InitializeComponent();
        }

        private void Main_form_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            AlignButtons();
            AlignTitle();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            new info_form().ShowDialog();
        }
        private void AlignButtons()
        {
            int X = this.Width / 2 - start_button.Width / 2;
            int Y = this.Height / 2 - start_button.Height / 2;
            start_button.Location = new Point(X, Y);
            exit_button.Location = new Point(X, Y + 100);
        }

        private void AlignTitle()
        {
            int X = this.Width / 2 - title_label.Width / 2;
            title_label.Location = new Point(X, 300);
        }
    }
}