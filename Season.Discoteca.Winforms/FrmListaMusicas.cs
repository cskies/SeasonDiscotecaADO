using Season.Discoteca.Dominio;
using Season.Discoteca.Repositorios;
using Season.Repositoris.Comum;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Season.Discoteca.Winforms
{
    public partial class FrmListaMusicas : Form
    {
        private IRepositorioGenerico<Musica, long> _repositorioMusicas = new MusicaRepositorio();

        public FrmListaMusicas()
        {
            InitializeComponent();
        }

        private void FrmListaMusicas_Load(object sender, EventArgs e)
        {
            CarregarListaMusicasAsync();
        }

        private async void CarregarListaMusicasAsync() //manipula a TASK do CarregarListaMusicas()
        {
            //await espera a task terminar // (task) ja finazliada
            await CarregarListaMusicas().ContinueWith((task) =>
            {
                List<Musica> musicas = task.Result;

                dgvMusicas.Invoke(new Action(() => 
                {
                    dgvMusicas.DataSource = musicas;
                    dgvMusicas.Refresh();
                }));
            }); 
        }

        private Task<List<Musica>> CarregarListaMusicas()  //return a Task = smp chamando num método async
        {
            return Task.Run<List<Musica>>(() =>
            {
                List<Musica> musicas = _repositorioMusicas.Selecionar();
                return musicas;
            });
        }

        private void btnDeleteMusic_Click(object sender, EventArgs e)
        {
            if (dgvMusicas.SelectedRows.Count > 0 && MessageBox.Show("Tem ctz?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int idMusica = Convert.ToInt32(dgvMusicas.SelectedRows[0].Cells[0].Value);
                Musica musicaASerDeletada = new Musica
                {
                    Id = idMusica
                };

                _repositorioMusicas.Excluir(musicaASerDeletada);
                CarregarListaMusicasAsync();
            }
        }

        private void btnAddMusic_Click(object sender, EventArgs e)
        {
            //criar instancia do frm
            var form = new FrmInsertAlterMusic();
            form.ShowDialog(); //trava a thread
            CarregarListaMusicasAsync();
        }

        private void btnAlterMusic_Click(object sender, EventArgs e)
        {
            if (dgvMusicas.SelectedRows.Count > 0)
            {
                var musicToBeEdited = new Musica();
                musicToBeEdited.Id = long.Parse(dgvMusicas.SelectedRows[0].Cells[0].Value.ToString());
                musicToBeEdited.Titulo = dgvMusicas.SelectedRows[0].Cells[1].Value.ToString();
                musicToBeEdited.Ano = null;
                if (dgvMusicas.SelectedRows[0].Cells[2].Value != null)
                {
                    musicToBeEdited.Ano = Convert.ToInt32(dgvMusicas.SelectedRows[0].Cells[2].Value);
                }

                var form = new FrmInsertAlterMusic(musicToBeEdited);
                form.ShowDialog();
                CarregarListaMusicasAsync();
            }
        }
    }
}
