using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4.Interface
{
    {
    public interface IPersona
    {
        string Nombre { get; }
        int Edad { get; }
        void Saludar();
        void CumplirAños();
    }

    public class Persona : IPersona
    {
        private string _nombre;
        private int _edad;

        public Persona(string nombre, int edad)
        {
            _nombre = nombre;
            _edad = edad;
        }

        public string Nombre
        {
            get { return _nombre; }
        }

        public int Edad
        {
            get { return _edad; }
        }

        public void Saludar()
        {
            Console.WriteLine("Hola, mi nombre es " + _nombre);
        }

        public void CumplirAños()
        {
            _edad++;
        }
    }
}