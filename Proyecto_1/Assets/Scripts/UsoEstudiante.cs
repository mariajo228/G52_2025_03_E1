using UnityEngine;
using UnityEngine.UI;
using System;
using packagePersona;
using System.Collections.Generic;
using TMPro;

public class UsoEstudiantes : MonoBehaviour
{
    public TMP_InputField inputCodigo;
    public TMP_InputField inputCarrera;
    public TMP_InputField inputNombre;
    public TMP_InputField inputCorreo;
    public TMP_InputField inputDireccion;

    private List<Estudiantes> listaE = new List<Estudiantes>();

    
    public void AgregarEstudiante()
    {
        string codigo = inputCodigo.text;
        string carrera = inputCarrera.text;
        string nombre = inputNombre.text;
        string correo = inputCorreo.text;
        string direccion = inputDireccion.text;

        Estudiantes nuevo = new Estudiantes(codigo, carrera, nombre, correo, direccion);
        listaE.Add(nuevo);

        Debug.Log($"{nuevo.NameP} - Carrera: {nuevo.NameCarreraE}");
    }

    void Start()
    {
    }
}