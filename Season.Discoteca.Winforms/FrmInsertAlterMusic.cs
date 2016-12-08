using Season.Discoteca.Dominio;
using Season.Discoteca.Repositorios;
using Season.Repositoris.Comum;
using System;
using System.Windows.Forms;

namespace Season.Discoteca.Winforms
{
    public partial class FrmInsertAlterMusic : Form
    {
        private Musica _music;

        public FrmInsertAlterMusic(Musica music = null)
        {
            InitializeComponent();
            _music = music;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool Validate()
        {
            if (string.IsNullOrEmpty(txtTitle.Text))
            {
                MessageBox.Show("Title cannot be empty or null", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            if (!string.IsNullOrEmpty(txtAno.Text))
            {
                int ano;
                bool resultado = int.TryParse(txtAno.Text, out ano);

                if (!resultado)
                {
                    MessageBox.Show("The music year is invalid", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                return resultado;
            }
            return true;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (Validate())
            {
                IRepositorioGenerico<Musica, long> repositorioMusicas = new MusicaRepositorio(); //** independency injection
                if (_music == null)
                {
                    _music = new Musica();
                    FillMusic();
                    repositorioMusicas.Inserir(_music);
                }
                else
                {
                    FillMusic();
                    repositorioMusicas.Atualizar(_music);
                }
                Close();
            }
        }

        private void FillMusic()
        {
            _music.Titulo = txtTitle.Text;
            _music.Ano = null;
            if (!string.IsNullOrEmpty(txtAno.Text))
            {
                _music.Ano = Convert.ToInt32(txtAno.Text);
            }
        }

        private void FrmInsertAlterMusic_Load(object sender, EventArgs e)
        {
            if (_music == null)
            {
                txtTitle.Text = string.Empty;
                txtAno.Text = string.Empty;
            }
            else
            {
                txtTitle.Text = _music.Titulo;

                if (_music.Ano.HasValue) //prop soh atribuida ao nullable
                {
                    txtAno.Text = _music.Ano.ToString();
                }

                txtTitle.Focus();
            }
        }
    }
}
