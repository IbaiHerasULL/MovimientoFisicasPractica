using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3 : MonoBehaviour
{
    // Vector que representa la dirección del movimiento 
    public Vector3 moveDirection = new Vector3(1, 0, 0); 

    // Velocidad del cubo 
    public float speed = 2f; 

    // Booleano para alternar entre movimiento relativo al sistema local o mundial
    public bool usarSistemaLocal = true; 

    void Update()
    {
        
        if (usarSistemaLocal)
        {
            // Mueve el cubo usando el sistema de referencia local
            transform.Translate(moveDirection * speed * Time.deltaTime, Space.Self);
        }
        else
        {
            // Mueve el cubo usando el sistema de referencia mundial
            transform.Translate(moveDirection * speed * Time.deltaTime, Space.World);
        }
    }
}

