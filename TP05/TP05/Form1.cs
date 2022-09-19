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

namespace TP05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = textBox1.Text; //C:\\Users\\Gabriel\\Desktop\\facul\\voos.xml
            XmlDocument voosXml = new XmlDocument();
            try
            {
                voosXml.Load(path);
                label2.Text = "Arquivo xml carregado com sucesso";
            }
            catch (Exception exception)
            {
                label2.Text = "Erro ao carregar arquivo xml\n" + exception.Message;
            }
        }
    }
}
