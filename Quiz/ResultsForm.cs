
namespace Quiz
{
    using System.Windows.Forms;

    public partial class ResultsForm : Form
    {
        public ResultsForm()
        {
            InitializeComponent();
        }

        public string SetResults
        {
            set { this.ResultsTextBox.Text = value; }
        }
    }
}
