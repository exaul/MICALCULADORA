using MICALCULADORA.Models;
using MICALCULADORA.Services.Interface;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MICALCULADORA.ViewModel
{
    public class CalculadoraPageViewModel : INotifyPropertyChanged
    {
        private readonly ICalculadoraServices calculadoraServices;
        private int resultado;

        public int Numero1 { get; set; }
        public int Numero2 { get; set; }
        public Operaciones.Operacion Seleccionoperacion { get; set; }
        public int Resultado
        {
            get => resultado;
            set
            {
                resultado = value;
                OnPropertyChanged();
                 }
        }
        public Command HacerCalculoCommand { get; set; }
        public Command SeleccionaSumaCommand { get; set; }
        public Command SeleccionaRestaCommand { get; set; }
        public Command SeleccionaMultiplicacionCommand { get; set; }
        public Command SeleccionaDivisionCommand { get; set; }



        public CalculadoraPageViewModel(ICalculadoraServices calculadoraServices)
        {
            this.calculadoraServices = calculadoraServices;
            HacerCalculoCommand = new Command(CalcularDosNumeros);
            SeleccionaSumaCommand = new Command(SeleccionarOperacionSuma);
            SeleccionaRestaCommand = new Command(SeleccionarOperacionresta);
            SeleccionaMultiplicacionCommand = new Command(SeleccionarOperacionMultiplicacion);
            SeleccionaDivisionCommand = new Command(SeleccionarOperacionDivision);


        }
        private void CalcularDosNumeros()
        {
            Resultado = calculadoraServices.CalcularDosNumeros(Numero1, Numero2, Seleccionoperacion);
        }
        private void SeleccionarOperacionSuma()
        {
            Seleccionoperacion = Operaciones.Operacion.suma;
        }
        private void SeleccionarOperacionresta()
        {
            Seleccionoperacion = Operaciones.Operacion.resta;
        }
        private void SeleccionarOperacionMultiplicacion()
        {
            Seleccionoperacion = Operaciones.Operacion.multiplicacion;
        }
        private void SeleccionarOperacionDivision()
        {
            Seleccionoperacion = Operaciones.Operacion.Division;
        }
        public event PropertyChangedEventHandler PropertyChanged;
        
        public void OnPropertyChanged([CallerMemberName] string name = "") =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
 