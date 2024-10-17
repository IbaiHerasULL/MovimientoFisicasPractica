using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio6 : MonoBehaviour
{
    public float speed = 5f;

    // Referencia a esfera
    public Transform esfera;

    void Update()
    {
         if (CompareTag("cubo"))
        {
            // Obtener la posición actual del cubo y la esfera
            Vector3 posicionCubo = transform.position;
            Vector3 posicionEsfera = esfera.position;

            // Crear el vector que une al cubo con la esfera
            Vector3 direccionMovimiento = new Vector3(posicionEsfera.x - posicionCubo.x, 0, posicionEsfera.z - posicionCubo.z);

            // Normalizar el vector de dirección para que tenga magnitud 1
            Vector3 direccionNormalizada = direccionMovimiento.normalized;

            // Mover el cubo hacia la esfera, proporcional al tiempo transcurrido por frame
            transform.Translate(direccionNormalizada * speed * Time.deltaTime, Space.World);
        }

        if (CompareTag("esfera"))
        {
            float horizontal = 0f;
            float vertical = 0f;

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

            Vector3 moveDirection = new Vector3(horizontal, 0, vertical);

            transform.Translate(moveDirection * speed * Time.deltaTime, Space.World);
        }
    }
}
