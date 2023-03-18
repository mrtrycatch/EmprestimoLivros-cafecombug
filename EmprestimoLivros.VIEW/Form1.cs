using EmprestimoLivros.DATA.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmprestimoLivros.VIEW
{
    public partial class Form1 : Form
    {
        private LivroService oLivroService;
        public Form1()
        {
            InitializeComponent();
            oLivroService = new LivroService();
        }

        private void GrdLivros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        private void CarregaGrid()
        {
            GrdLivros.DataSource = oLivroService.oRepositoryLivro.SelecionarTodos();
            
            
        }
    }
}
