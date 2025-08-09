using System.IO;
using UnityEngine;

public static class Utilidades
{
    
    private static string rutaBase = @"C:\Users\maria";

    public static void GuardarJSON<T>(T objeto, string nombreArchivo)
    {
       
        if (!Directory.Exists(rutaBase))
            Directory.CreateDirectory(rutaBase);

        string ruta = Path.Combine(rutaBase, nombreArchivo);
        string json = JsonUtility.ToJson(objeto, true);

        File.WriteAllText(ruta, json);
        Debug.Log($"Datos guardados en: {ruta}");
    }

    
    public static T CargarJSON<T>(string nombreArchivo)
    {
        string ruta = Path.Combine(rutaBase, nombreArchivo);

        if (File.Exists(ruta))
        {
            string json = File.ReadAllText(ruta);
            return JsonUtility.FromJson<T>(json);
        }
        else
        {
            Debug.LogWarning($"No se encontró el archivo: {ruta}");
            return default(T);
        }
    }
}


