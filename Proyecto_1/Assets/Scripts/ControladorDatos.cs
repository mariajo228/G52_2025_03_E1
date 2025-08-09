using UnityEngine;
using UnityEngine.UI;
using packagePersona;
using TMPro;

public class ControladorDatos : MonoBehaviour
{
    [Header("Campos de Entrada")]
    public TMP_InputField inputCodigo;
    public TMP_InputField inputCarrera;
    public TMP_InputField inputNombre;
    public TMP_InputField inputCorreo;
    public TMP_InputField inputDireccion;


    
    public void GuardarEstudiante()
    {
        Estudiantes est = new Estudiantes(
            inputCodigo.text,
            inputCarrera.text,
            inputNombre.text,
            inputCorreo.text,
            inputDireccion.text
        );

        Utilidades.GuardarJSON(est, "estudiante.json");
    }

    
    public void CargarEstudiante()
    {
        Estudiantes est = Utilidades.CargarJSON<Estudiantes>("estudiante.json");

        if (est != null)
        {
            inputCodigo.text = est.CodeE;
            inputCarrera.text = est.NameCarreraE;
            inputNombre.text = est.NameP;
            inputCorreo.text = est.MailP;
            inputDireccion.text = est.DirP;
        }
    }
}


