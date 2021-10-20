using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.Controller;
using WindowsFormsApp2.Models;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        PersonasController persona = new PersonasController();
        BaseDatos bd = new BaseDatos();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM personas";
            DataTable resultado = bd.DsplayData(sql);
            dataGridView1.DataSource = resultado;
        }


        private void btInsertar_Click(object sender, EventArgs e)
        {
            string resultado = persona.insertarPersonas(tbDocumento.Text, tbNombre.Text, tbApellido.Text, tbEdad.Text, tbSexo.Text);
            MessageBox.Show(resultado);
            string sql = "SELECT * FROM personas";
            DataTable resultado1 = bd.DsplayData(sql);
            dataGridView1.DataSource = resultado1;
            tbDocumento.Text = "";
            tbNombre.Text = "";
            tbApellido.Text = "";
            tbEdad.Text = "";
            tbSexo.Text = "";
        }

        private void btActualizar_Click(object sender, EventArgs e)
        {
            string resultado = persona.actualizarPersonas(tbNombre.Text, tbApellido.Text, tbEdad.Text, tbSexo.Text, tbDocumento.Text);
            MessageBox.Show(resultado);
            string sql = "SELECT * FROM personas";
            DataTable resultado1 = bd.DsplayData(sql);
            dataGridView1.DataSource = resultado1;
            tbDocumento.Text = "";
            tbNombre.Text = "";
            tbApellido.Text = "";
            tbEdad.Text = "";
            tbSexo.Text = "";
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            string resultado = persona.eliminarPersonas(tbDocumento.Text);
            MessageBox.Show(resultado);
            string sql = "SELECT * FROM personas";
            DataTable resultado1 = bd.DsplayData(sql);
            dataGridView1.DataSource = resultado1;
            tbDocumento.Text = "";
            tbNombre.Text = "";
            tbApellido.Text = "";
            tbEdad.Text = "";
            tbSexo.Text = "";
        }

        private void btTodo_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM personas";
            DataTable resultado = bd.DsplayData(sql);
            dataGridView1.DataSource = resultado;
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            DataTable resultado = persona.buscarPersonas(tbDocumento.Text);
            dataGridView1.DataSource = resultado;
        }
    }
}