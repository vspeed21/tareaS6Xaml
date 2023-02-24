using EjercicioMVVMS2.NewFolder2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Text;
using Xamarin.Forms;

namespace EjercicioMVVMS2.NewFolder
{
    public class VMExpresion : INotifyPropertyChanged
    {
        public VMExpresion() {
            Sumar = new Command(() =>
            {
                Expresion ex = new Expresion()
                {
                    numero1 = this.numero1,
                    numero2 = this.numero2,
                };

                Resultado = ex.suma();
            });
            Restar = new Command(() =>
            {
                Expresion ex = new Expresion()
                {
                    numero1 = this.numero1,
                    numero2 = this.numero2,
                };

                Resultado = ex.resta();
            });
            Multiplicar = new Command(() =>
            {
                Expresion ex = new Expresion()
                {
                    numero1 = this.numero1,
                    numero2 = this.numero2,
                };

                Resultado = ex.multiplicacion();
            });
            Dividir = new Command(() =>
            {
                Expresion ex = new Expresion()
                {
                    numero1 = this.numero1,
                    numero2 = this.numero2,
                };

                Resultado = ex.division();
            });
        }  

        double numero1;
        public double Numero1
        {
            get => numero1;
            set
            {
                numero1 = value;
                var arg = new PropertyChangedEventArgs(nameof(Numero1));
                PropertyChanged?.Invoke(this, arg);
            }
        }

        double numero2;
        public double Numero2
        {
            get => numero2;
            set
            {
                numero2 = value;
                var arg = new PropertyChangedEventArgs(nameof(Numero2));
                PropertyChanged?.Invoke(this, arg);
            }
        }

        string resultado;

        public string Resultado
        {

            get => resultado;
            set
            {

                resultado = value;
                var arg = new PropertyChangedEventArgs(nameof(Resultado));
                PropertyChanged?.Invoke(this, arg);

            }

        }

        public Command Sumar { get; }
        public Command Restar { get; }
        public Command Multiplicar { get; }
        public Command Dividir { get; }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
