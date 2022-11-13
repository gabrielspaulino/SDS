using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace TP13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dataGridView1.Columns.Add("origem", "Origem");
            dataGridView1.Columns.Add("destino", "Destino");
            dataGridView1.Columns.Add("horario", "Horário");
            dataGridView1.Columns.Add("compania", "Compania");
            dataGridView1.Columns.Add("operando", "Operando");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Voo> voos = Desserialize.readAndDesserializeXml();
            foreach(Voo voo in voos)
            {
                dataGridView1.Rows.Add(voo.Origem, voo.Destino, voo.Horario, voo.Compania, voo.Operando);
            }
        }

        private void buttonSerializar_Click(object sender, EventArgs e)
        {
            Serialize.serializeClass();
        }
    }
}
