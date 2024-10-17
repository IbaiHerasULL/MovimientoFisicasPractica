using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7 : MonoBehaviour
{
    public float speed = 5f;
    public Transform esfera;

    void Update()
    {
        // Si el objeto es el cubo, gira hacia la posición de la esfera
        if (CompareTag("cubo"))
        {
            Vector3 posicionCubo = transform.position;
            Vector3 posicionEsfera = esfera.position;

            Vector3 direccionMovimiento = new Vector3(posicionEsfera.x - posicionCubo.x, 0, posicionEsfera.z - posicionCubo.z);

            Vector3 direccionNormalizada = direccionMovimiento.normalized;

            Quaternion lookRotation = Quaternion.LookRotation(direccionNormalizada);
            transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * speed);

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
            moveDirection.Normalize(); 
            transform.Translate(moveDirection * speed * Time.deltaTime, Space.World);
        }
    }
}

