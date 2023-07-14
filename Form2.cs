using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula04AplicativoDeBanco
{
    public partial class Form2 : Form
    {
        // Variaveis Globais
        public List<string> extratos = new List<string>();

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < extratos.Count; i++)
            {
                listExtratos.Items.Add( extratos[i] );
            }

        }
    }
}
