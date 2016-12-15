using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Extraindo_Comportamentos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Conta conta = new Conta();

            Cliente cliente = new Cliente();

            conta.clinete = cliente;
            cliente.nome = "Marco Aurelio";
            cliente.rg = "50.606.547-8";
            cliente.endereço = "Cruzeiro do sul n558";

            MessageBox.Show("Nome do cliente: " + cliente.nome);
            MessageBox.Show("RG: " + cliente.rg);
            MessageBox.Show("Endereço: " + cliente.endereço);
            
          

}}}