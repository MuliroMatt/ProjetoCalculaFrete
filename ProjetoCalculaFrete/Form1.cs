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
           

        }

        private void btnConcluir_Click(object sender, EventArgs e)
        {
                //vai calcular a soma dos valores e exibir o valor total
                valTotal = valProf + valTransp + valUF;
                lblValTotal.Text = valTotal.ToString("C");
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            lblData.Text = dateTimePicker1.Value.ToShortDateString();
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