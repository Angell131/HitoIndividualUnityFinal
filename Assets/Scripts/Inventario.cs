using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventario : MonoBehaviour
{
    public float puntos;
    public Text textoPuntos;

    private void Update()
    {
        textoPuntos.text = "Puntos " + puntos.ToString();
    }
}
