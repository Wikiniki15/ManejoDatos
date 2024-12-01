using ManejoDatos.Interfaces;
using ManejoDatos.Models;
using ManejoDatos.Repositories;

namespace ManejoDatos
{
    public partial class MainPage : ContentPage
    {
        IEstudianteUDLARepository _estudianteUDLARepository;
        EstudianteUDLA estudiante = new EstudianteUDLA();
        public MainPage()
        {
            _estudianteUDLARepository = new EstudianteUDLAPorArchivosRepository();
            InitializeComponent();

            estudiante = _estudianteUDLARepository.DevuelveEstudianteUDLA(1);
            BindingContext = estudiante;
        }

        private async void GuardarEstudiante_Clicked(object sender, EventArgs e) 
        {
            EstudianteUDLA estudiante = new EstudianteUDLA
            {
                Id = Int32.Parse(editor_id.Text),
                Nombre = editor_nombre.Text,
                Carrera = editor_carrera.Text,
            };
            bool guardar_estudiante = _estudianteUDLARepository.CrearEstudianteUDLA(estudiante);

            if (guardar_estudiante)
            {
                await DisplayAlert("Alert", "Todo posi", "OK");
                Navigation.PushAsync(new MainPage());
            }
            else
            {
                await DisplayAlert("Alert", "Negado mi pana", "OK");
            }
        }
    }

}
