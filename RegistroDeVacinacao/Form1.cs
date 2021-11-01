using System;
using System.IO;
using System.Windows.Forms;

namespace RegistroDeVacinacao
{
    public partial class RegistroVacinaColabForm : Form
    {
        public RegistroVacinaColabForm()
        {
            InitializeComponent();
        }

        private void registroVacinaColabForm_Load(object sender, EventArgs e)
        {

        }
        private void NomeColabTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void LimparTela()
        {
            NomeColabTextBox.Clear();
            IdColabTextBox.Clear();
            FabricVacinaListBox.SelectedIndex = 0;
            DoseDataMonthCalendar.SetDate(DateTime.Now);
            DoseNumericUpDown.Value = 1;
            NomeColabTextBox.Focus();
        }
        

        private void EnviarButton_Click(object sender, EventArgs e)
        {
            if (NomeColabTextBox.Text.Trim() == "")
            {
                MessageBox.Show("Nome é obrigatório.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                NomeColabTextBox.Focus();
                NomeColabTextBox.SelectAll();
                return;
            }

            string caminho = @"C:\Windows\Temp\RegistroDeVacinacao.csv";

            string registro = string.Format("{0};{1};{2};{3};{4}", NomeColabTextBox.Text.ToUpper(),
                IdColabTextBox.Text, FabricVacinaListBox.SelectedItem, DoseNumericUpDown.Value,
                DoseDataMonthCalendar.SelectionStart.ToString("dd/MM/yyyy"));

            if (!File.Exists(caminho))
            {
                StreamWriter sw1 = new StreamWriter(caminho, true);
                sw1.WriteLine("Nome;ID;Fabricante;Dose;Data");
                sw1.Close();
            }

            StreamWriter sw = new StreamWriter(caminho, true);
            sw.WriteLine(registro);
            sw.Close();
            MessageBox.Show("Vacinação registrada com sucesso.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LimparTela();
        }
    }
}
