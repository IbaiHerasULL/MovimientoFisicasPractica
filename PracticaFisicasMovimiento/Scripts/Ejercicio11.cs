using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio11 : MonoBehaviour
{
    public float speed = 5f;

    void Update()
    {
        // Comprobar si el objeto tiene la etiqueta "cubo"
        if (CompareTag("cubo"))
        {
            float horizontal = 0f;
            float vertical = 0f;

            // Leer las teclas de flecha para el movimiento del cubo
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                horizontal = -1f;  
            }
            else if (Input.GetKey(KeyCode.RightArrow))
            {
                horizontal = 1f;   
            }

            if (Input.GetKey(KeyCode.UpArrow))
            {
                vertical = 1f;     
            }
            else if (Input.GetKey(KeyCode.DownArrow))
            {
                vertical = -1f;   
            }  

            // Crear el vector de movimiento del cubo
            Vector3 moveDirection = new Vector3(horizontal, 0, vertical);
            transform.Translate(moveDirection * speed * Time.deltaTime, Space.World);
        }

        // Comprobar si el objeto tiene la etiqueta "esfera"
        if (CompareTag("esfera"))
        {
            float horizontal = 0f;
            float vertical = 0f;

            // Leer las teclas W, A, S, D para el movimiento de la esfera
            if (Input.GetKey(KeyCode.A))
            {
                horizontal = -1f;  
            }
            else if (Input.GetKey(KeyCode.D))
            {
                horizontal = 1f;   
            }

            if (Input.GetKey(KeyCode.W))
            {
                vertical = 1f;     
            }
            else if (Input.GetKey(KeyCode.S))
            {
                vertical = -1f;   
            }

            // Crear el vector de movimiento de la esfera
            Vector3 moveDirection = new Vector3(horizontal, 0, vertical).normalized; // Normalizamos para evitar velocidades inconsistentes
            transform.Translate(moveDirection * speed * Time.deltaTime, Space.World);
        }
    }

    // Método para detectar colisiones con el Trigger
    private void OnTriggerEnter(Collider other)
    {
        // Verificar si el objeto colisionado tiene la etiqueta "cilindro"
        if (other.CompareTag("cilindro"))
        {
            // Mostrar un mensaje en la consola con la etiqueta del objeto que colisionó
            Debug.Log("Colisión con: " + other.tag);
        }
    }
}
