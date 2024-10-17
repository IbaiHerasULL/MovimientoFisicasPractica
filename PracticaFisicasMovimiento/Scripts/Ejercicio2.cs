using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2 : MonoBehaviour
{
    

    void Update()
    {
        // Comprobamos si se ha presionado la tecla H (mapeada como "Disparo")
        if (Input.GetButtonDown("Disparo"))
        {
            
            Debug.Log("Tecla H pulsada.");
            Disparar();
        }
    }
    void Disparar()
    {
        Debug.Log("¡Disparo realizado!");

    }
}

