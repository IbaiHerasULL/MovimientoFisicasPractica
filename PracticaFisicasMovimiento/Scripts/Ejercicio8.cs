using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio8 : MonoBehaviour
{
    public float speed = 5f;              
    public Transform esfera;               
    public float rotationSpeed = 200f;     

    void Update()
    {
        // Si el objeto es el cubo, gira hacia la posición de la esfera y avanza
        if (CompareTag("cubo"))
        {
            Vector3 posicionCubo = transform.position;
            Vector3 posicionEsfera = esfera.position;

            Vector3 direccionMovimiento = new Vector3(posicionEsfera.x - posicionCubo.x, 0, posicionEsfera.z - posicionCubo.z);
            Vector3 direccionNormalizada = direccionMovimiento.normalized;

            if (direccionMovimiento.magnitude > 0.1f) 
            {
                Quaternion lookRotation = Quaternion.LookRotation(direccionNormalizada);
                transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * rotationSpeed);
            }

            transform.Translate(transform.forward * speed * Time.deltaTime);

            // Depuración: dibujar una línea que indica la dirección hacia adelante
            Debug.DrawRay(transform.position, transform.forward * 2, Color.red);
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
            if (moveDirection.magnitude > 0.1f) 
            {
                moveDirection.Normalize(); 
                transform.Translate(moveDirection * speed * Time.deltaTime, Space.World);
            }
        }
    }
}
