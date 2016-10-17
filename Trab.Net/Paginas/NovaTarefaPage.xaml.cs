using Newtonsoft.Json;
using System;
using Trab.Net.Logic;
using Trab.Net.Model;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Trab.Net.Paginas
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class NovaTarefaPage : Page
    {
        private Tarefa model;

        public NovaTarefaPage()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            model = e.Parameter as Tarefa;

            base.OnNavigatedTo(e);
            
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            if(model == null || model.Id == 0)
            {
                txtCodigo.Visibility = Visibility.Collapsed;
                lblCodigo.Visibility = Visibility.Collapsed;
                var json = MyLocalStorage.GetFromLocalStorage("usuario");
                var usuario = JsonConvert.DeserializeObject<Usuario>(json.ToString());
                txtUsername.Text = usuario.Login;
            }else
            {
                txtCodigo.Text = model.Id.ToString();

                txtTitulo.Text = model.Titulo;

                dtpDataLimite.Date = model.DataLimite;

                txtDescricao.Text = model.Descricao;

                txtUsername.Text = model.Username;

                ckbConcluido.IsChecked = model.Concluido;
            }
        }


        private async void btnGravar_Click(object sender, RoutedEventArgs e)
        {
            model = new Tarefa
            {

                Id = string.IsNullOrEmpty(txtCodigo.Text) 
                        ? 0 : Convert.ToInt32(txtCodigo.Text),

                Titulo = txtTitulo.Text,

                Descricao = txtDescricao.Text,

                DataLimite = dtpDataLimite.Date.DateTime,

                Concluido = ckbConcluido.IsChecked.Value,

                Username = txtUsername.Text
            };

            try
            {
                if (model.Id > 0)
                {
                    await TarefasRequestApi.AlterarTarefa(model);

                    var dialog = new MessageDialog("Sua tarefa foi alterada com sucesso!", "Sucesso!");

                    await dialog.ShowAsync();
                    Frame.Navigate(typeof(TarefasPage));
                }
                else
                {
                    await TarefasRequestApi.GravarTarefa(model);

                    txtCodigo.Text = "";
                    txtTitulo.Text = "";
                    txtDescricao.Text = "";
                    ckbConcluido.IsChecked = false;
                    var dialog = new MessageDialog("Sua tarefa foi criada com sucesso!", "Sucesso!!");
                    await dialog.ShowAsync();
                    txtTitulo.Focus(FocusState.Keyboard);
                }


            }
            catch (Exception ex)
            {
                var msg = TratarException.ErrorMessage(ex);

                var dialog = new MessageDialog(msg, "ooopsss...");
                await dialog.ShowAsync();

            }
        }
    }
}
