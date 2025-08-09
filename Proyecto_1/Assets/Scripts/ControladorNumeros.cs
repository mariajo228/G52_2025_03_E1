using UnityEngine;
using TMPro;
using packagePunto2D;

public class ControladorPunto2D : MonoBehaviour
{
    public TMP_InputField inputX;
    public TMP_InputField inputY;

    public void GuardarPunto()
    {
        Punto2D punto = new Punto2D();
        punto.x = double.Parse(inputX.text);
        punto.y = double.Parse(inputY.text);

        string json = JsonUtility.ToJson(punto);
        PlayerPrefs.SetString("DatosPunto2D", json);
        PlayerPrefs.Save();

        Debug.Log("Punto guardado: " + json);
    }

    public void CargarPunto()
    {
        if (PlayerPrefs.HasKey("DatosPunto2D"))
        {
            string json = PlayerPrefs.GetString("DatosPunto2D");
            Punto2D punto = JsonUtility.FromJson<Punto2D>(json);

            inputX.text = punto.x.ToString();
            inputY.text = punto.y.ToString();

            Debug.Log("Punto cargado: " + json);
        }
    }
}
