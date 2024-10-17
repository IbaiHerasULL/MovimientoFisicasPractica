using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio1 : MonoBehaviour
{
    public float velocidad = 5f;

    void Update()
    {
        // Obtener los valores de los ejes Horizontal (Izquierda/Derecha) y Vertical (Arriba/Abajo)
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        // Comprobar si se presionan las teclas de flecha
        if (Input.GetKey(KeyCode.UpArrow))
        {
            float resultado = velocidad * vertical;
            Debug.Log("Flecha Arriba: " + resultado);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            float resultado = velocidad * vertical;
            Debug.Log("Flecha Abajo: " + resultado);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            float resultado = velocidad * horizontal;
            Debug.Log("Flecha Izquierda: " + resultado);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            float resultado = velocidad * horizontal;
            Debug.Log("Flecha Derecha: " + resultado);
        }
    }
}
