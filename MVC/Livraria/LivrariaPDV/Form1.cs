using Livraria;
using Livraria.DTOs;
using Newtonsoft.Json;

namespace LivrariaPDV
{
    public partial class Form1 : Form
    {

        ListaDeLivros livros;
        ListaDeUsuarios usuarios;
        ListaDeEmprestimos emprestimos;

        Livraria.Data.LivrariaContext contextoDB;

        public Form1()
        {
            InitializeComponent();

            contextoDB = new Livraria.Data.LivrariaContext();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txbNomeUsuario.Text != string.Empty && txbUsuario.Text != string.Empty && txbSenha.Text != string.Empty)
            {
                Usuario novo = new Usuario(txbNomeUsuario.Text, txbUsuario.Text, txbSenha.Text);

                usuarios.AdicionaUsuarios(novo);

                contextoDB.Usuarios.Add(novo);

                contextoDB.SaveChanges();

                //atualizaDGUsuarios();
                atualizaGridViewUsuariosFromAPI();
            }
            else
            {
                MessageBox.Show("Por favor, preencha todos os campos!!!");
            }
        }

        private void atualizaDGUsuarios()
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = usuarios.GetUsuarios();
            dgUsuarios.DataSource = bs;
            //dgUsuarios.DataSource = usuarios.GetUsuarios();
            cbUsuarios.DataSource = bs;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            livros = new ListaDeLivros();
            usuarios = new ListaDeUsuarios();
            emprestimos = new ListaDeEmprestimos();

            atualizaGridViewUsuariosFromAPI();
            atualizaGridViewLivrosFromAPI();

            //CarregaUsuarios();
            //CarregaLivros();
            //CarregaEmprestimos();
        }

        private void atualizaGridViewUsuariosFromAPI()
        {
            var url = "https://localhost:7147/api/Usuario";

            HttpClient httpClient = new HttpClient();
            
            var response = httpClient.GetAsync(url).Result;
            
            if (response.IsSuccessStatusCode)
            {
                var results = response.Content.ReadAsStringAsync().Result;

                var listUsuarios = JsonConvert.DeserializeObject<List<UsuarioDTO>>(results);
                
                BindingSource bindingSource = new BindingSource();
                
                bindingSource.DataSource = listUsuarios;
                
                dgUsuarios.DataSource = bindingSource;
                cbUsuarios.DataSource = bindingSource;
            }
        }

        private void atualizaGridViewLivrosFromAPI()
        {
            var url = "https://localhost:7147/api/Livro";

            HttpClient httpClient = new HttpClient();

            var response = httpClient.GetAsync(url).Result;

            if (response.IsSuccessStatusCode)
            {
                var results = response.Content.ReadAsStringAsync().Result;

                var listLivros = JsonConvert.DeserializeObject<List<LivroDTO>>(results);

                BindingSource bindingSource = new BindingSource();

                bindingSource.DataSource = listLivros;

                dgLivros.DataSource = bindingSource;
                cbLivros.DataSource = bindingSource;
            }
        }

        private void CarregaUsuarios()
        {
            var dadosUsuarios = contextoDB.Usuarios.ToList();

            usuarios.PopulaUsuarios(dadosUsuarios);

            BindingSource bs2 = new BindingSource();
            bs2.DataSource = dadosUsuarios;
            dgUsuarios.DataSource = bs2;

            cbUsuarios.DataSource = bs2;
        }

        private void CarregaLivros()
        {
            var dadosLivros = contextoDB.Livros.ToList();

            livros.PopulaLivros(dadosLivros);

            BindingSource bsLivros = new BindingSource();
            bsLivros.DataSource = dadosLivros;
            dgLivros.DataSource = bsLivros;

            cbLivros.DataSource = bsLivros;
        }

        private void CarregaEmprestimos()
        {
            var dadosEmprestimos = contextoDB.Emprestimos.ToList();

            emprestimos.PopulaEmprestimos(dadosEmprestimos);

            BindingSource bsEmprestimos = new BindingSource();
            bsEmprestimos.DataSource = dadosEmprestimos;
            dgEmprestimos.DataSource = bsEmprestimos;
        }

        private void btnAdLivro_Click(object sender, EventArgs e)
        {
            if (txbLivro.Text != String.Empty && txbPg.Text != String.Empty && txbCod.Text != String.Empty && txbValor.Text != String.Empty)
            {
                Livros novo = new Livros(txbLivro.Text, txbPg.Text, Convert.ToInt32(txbCod.Text), Convert.ToDecimal(txbValor.Text));

                livros.CadastraLivro(novo);

                contextoDB.Livros.Add(novo);

                contextoDB.SaveChanges();

                //atualizaDBLivros();
                atualizaGridViewLivrosFromAPI();
            }
            else
            {
                MessageBox.Show("Por favor, preencha todos os campos!!!");
            }
        }

        private void atualizaDBLivros()
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = livros.Lista();
            dgLivros.DataSource = bs;
            cbLivros.DataSource = bs;
        }

        private void btnAdEmprestimo_Click(object sender, EventArgs e)
        {
            Emprestimo novo = new Emprestimo(((Livraria.Livros)cbLivros.SelectedItem).Codigo, ((Livraria.Usuario)cbUsuarios.SelectedItem).Id);

            emprestimos.AdicionaEmprestimo(novo);

            contextoDB.Emprestimos.Add(novo);

            contextoDB.SaveChanges();

            atualizaDGEmprestimos();
        }

        private void atualizaDGEmprestimos()
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = emprestimos.GetEmprestimos();
            dgEmprestimos.DataSource = bs;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Arquivos .JSON (*.json)|*.json";
            if (DialogResult.OK == saveFileDialog1.ShowDialog())
            {
                string arquivo = saveFileDialog1.FileName;
                usuarios.SalvaLocalJSON(arquivo);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Arquivos .CSV (*.csv)|*.csv";
            if (DialogResult.OK == saveFileDialog1.ShowDialog())
            {
                string arquivo = saveFileDialog1.FileName;
                usuarios.SalvaLocalCSV(arquivo);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Arquivos .CSV (*.csv)|*.csv";

            if (DialogResult.OK == openFileDialog1.ShowDialog())
            {
                string arquivo = openFileDialog1.FileName;
                usuarios.CarregaLocal(arquivo);
                atualizaDGUsuarios();
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Arquivos .JSON (*.json)|*.json";
            if (DialogResult.OK == saveFileDialog1.ShowDialog())
            {
                string arquivo = saveFileDialog1.FileName;
                emprestimos.SalvaLocalJSON(arquivo);
            }
        }

        private void btnFiltrarUsuario_Click(object sender, EventArgs e)
        {
            BindingSource bindingSource = new BindingSource();

            var filtro = txbFiltrarUsuario.Text;

            bindingSource.DataSource = usuarios.GetUsuarios().Where((usuario) => usuario.Nome.Contains(filtro) || usuario.Login.Contains(filtro)).ToList();

            dgUsuarios.DataSource = bindingSource;
        }
    }
}