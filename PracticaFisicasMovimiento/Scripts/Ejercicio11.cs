using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio11 : MonoBehaviour
{
    public float speed = 5f;

    //Usamos en evento FixedUpdate para hacer más solidas las interacciones con las físicas
    void FixedUpdate()
    {
        if (CompareTag("cubo"))
        {
            float horizontal = 0f;
            float vertical = 0f;

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

            Vector3 moveDirection = new Vector3(horizontal, 0, vertical);
            transform.Translate(moveDirection * speed * Time.deltaTime, Space.World);
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

            Vector3 moveDirection = new Vector3(horizontal, 0, vertical).normalized; 
            transform.Translate(moveDirection * speed * Time.deltaTime, Space.World);
        }
    }

    // Método para detectar colisiones con el Trigger
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("cilindro"))
        {
            Debug.Log("Colisión con: " + other.tag);
        }
    }
}
