using System;

namespace packagePersona
{
    [Serializable]
    public class Estudiantes
    {
        public string CodeE;
        public string NameCarreraE;
        public string NameP;
        public string MailP;
        public string DirP;

        public Estudiantes(string codeE, string nameCarreraE, string nameP, string mailP, string dirP)
        {
            CodeE = codeE;
            NameCarreraE = nameCarreraE;
            NameP = nameP;
            MailP = mailP;
            DirP = dirP;
        }
    }
}


