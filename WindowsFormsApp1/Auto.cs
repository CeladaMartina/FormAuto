using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Auto
    {
        Motor motor = new Motor();
        Persona persona;

        public Auto(Persona per)
        {
            persona = per;
        }

        public int PotenciaMotor(int pot)
        {
            return motor.CargarPotencia(pot);
        }

        public string CargarAuto(int pot)
        {
            string mensaje = "";
            mensaje = " " + persona.Nombre + " " + persona.Apellido + ", compro un auto que tiene " + PotenciaMotor(pot) + " de potencia. ";
            return mensaje;
        }
    }
}
