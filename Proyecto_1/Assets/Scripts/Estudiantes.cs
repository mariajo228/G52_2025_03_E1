using UnityEngine;
using System;

namespace packagePersona
{
    public class Estudiantes : Persona
    {
        private string codeE;
        private string nameCarreraE;

        public Estudiantes()
        {
        }

        public Estudiantes(string codeE, string nameCarreraE, string nameP, string mailP, string dirP)
            : base (nameP, mailP, dirP)

        {
            this.codeE = codeE;
            this.nameCarreraE = nameCarreraE;
        }

        public string CodeE { get => codeE; set => codeE = value; }
        public string NameCarreraE { get => nameCarreraE; set => nameCarreraE = value; }
    }

}

