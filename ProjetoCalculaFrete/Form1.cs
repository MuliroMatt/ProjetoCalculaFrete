using System.Reflection;

namespace ProjetoCalculaFrete
{
    public partial class Form1 : Form
    {
        //variáveis globais: poderão ser usadas no projeto todo
        decimal valUF, valTransp, valProf, valTotal;

        public Form1()
        {
            InitializeComponent();
        }

        private void cbProfissional_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbProfissional.Text == "1")
            {
                valProf = 2500;
            }
            if (cbProfissional.Text == "3")
            {
                valProf = 4500;
            }
            if (cbProfissional.Text == "5")
            {
                valProf = 6800;
            }
            lblValProf.Text = valProf.ToString("C");
        }

        private void cbUF_SelectedIndexChanged(object sender, EventArgs e)
        {
           switch(cbUF.Text)
            {
                case "SP":
                    valUF = 500;
                    lblValUF.Text = valUF.ToString("C");
                    break;
                case "MG":
                    valUF = 500;
                    lblValUF.Text = valUF.ToString("C");
                    break;
                case "SC":
                    valUF = 500;
                    lblValUF.Text = valUF.ToString("C");
                    break;
                case "RJ":
                    valUF = 830;
                    lblValUF.Text = valUF.ToString("C");
                    break;
                case "PR":
                    valUF = 830;
                    lblValUF.Text = valUF.ToString("C");
                    break;
                case "AM":
                    valUF = 7450;
                    lblValUF.Text = valUF.ToString("C");
                    break;
                default:
                    valUF = 2340;
                    lblValUF.Text = valUF.ToString("C");
                    break;
            }

        }

        private void btnConcluir_Click(object sender, EventArgs e)
        {
            //vai calcular a soma dos valores e exibir o valor total
            valTotal = valProf + valTransp + valUF;
            //analisar se valTotal>15000, dar 15% desc.
            if(valTotal > 15000)
            {
                lblValTotal.Text = valTotal.ToString("C");
                valTotal = valTotal - (valTotal * 15) / 100;
                lblDesconto.Text = valTotal.ToString("C");
            }
            else
            {
                lblValTotal.Text = valTotal.ToString("C");
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            lblData.Text = dateTimePicker1.Value.ToShortDateString();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            txtAvista.Text = valTotal.ToString("C");
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbCredito_SelectedIndexChanged(object sender, EventArgs e)
        {
            //verificar a parcela selecionada e dividir pelas parcelas
            if (cbCredito.Text == "1")
            {
                txtCredito.Text = valTotal.ToString("C");
            }
            if (cbCredito.Text == "2")
            {
                valTotal = valTotal / 2;
                txtCredito.Text = valTotal.ToString("C");
                limparValor();
            }
            if (cbCredito.Text == "3")
            {
                valTotal = valTotal / 3;
                txtCredito.Text = valTotal.ToString("C");
                limparValor();
            }
            if (cbCredito.Text == "4")
            {
                valTotal = valTotal / 4;
                txtCredito.Text = valTotal.ToString("C");
                limparValor();
            }
            if (cbCredito.Text == "5")
            {
                valTotal = valTotal / 5;
                txtCredito.Text = valTotal.ToString("C");
                limparValor();
            }
            if (cbCredito.Text == "6")
            {
                valTotal = valTotal / 6;
                txtCredito.Text = valTotal.ToString("C");
                limparValor();
            }
            if (cbCredito.Text == "7")
            {
                valTotal = valTotal / 7;
                txtCredito.Text = valTotal.ToString("C");
                limparValor();
            }
            if (cbCredito.Text == "8")
            {
                valTotal = valTotal / 8;
                txtCredito.Text = valTotal.ToString("C");
                limparValor();
            }
            if (cbCredito.Text == "9")
            {
                valTotal = valTotal / 9;
                txtCredito.Text = valTotal.ToString("C");
                limparValor();
            }
            if (cbCredito.Text == "10")
            {
                valTotal = valTotal / 10;
                txtCredito.Text = valTotal.ToString("C");
                limparValor();
            }
            if (cbCredito.Text == "11")
            {
                valTotal = valTotal / 11;
                txtCredito.Text = valTotal.ToString("C");
                limparValor();
            }
            if (cbCredito.Text == "12")
            {
                valTotal = valTotal / 12;
                txtCredito.Text = valTotal.ToString("C");
                limparValor();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            
        }
        //declaramos o método abaixo para reutilizarmos em cada final de parecela.
        //Assim, evitamos a redundância de cód.
        private void limparValor()
        {
            string val = lblDesconto.Text;
            val = val.Replace('R', ' ');
            val = val.Replace('$', ' ');
            valTotal = Convert.ToDecimal(val);
        }

        private void cbTransporte_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ao selecionar o tam do transp. vai atribuir o valor pra sua
            //variável e exibir na label
            if (cbTransporte.Text == "P")
            {
                valTransp = 3000;
                pictureBox1.Image = Image.FromFile("C:\\Users\\murilo.amattiuzzi.SENACEDU\\source\\repos\\ProjetoCalculaFrete\\ProjetoCalculaFrete\\img\\tamanho p.jpg");
            }
            if(cbTransporte.Text == "M")
            {
                valTransp = 4500;
                pictureBox1.Image = Image.FromFile("C:\\Users\\murilo.amattiuzzi.SENACEDU\\source\\repos\\ProjetoCalculaFrete\\ProjetoCalculaFrete\\img\\tamanho m.jpg");
            }
            if (cbTransporte.Text == "G")
            {
                valTransp = 6500;
                pictureBox1.Image = Image.FromFile("C:\\Users\\murilo.amattiuzzi.SENACEDU\\source\\repos\\ProjetoCalculaFrete\\ProjetoCalculaFrete\\img\\tamanho g.jpg");
            }
            lblValTransp.Text = valTransp.ToString("C");
        }
        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}