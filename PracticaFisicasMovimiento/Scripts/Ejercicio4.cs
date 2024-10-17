using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4 : MonoBehaviour
{
    public float speed = 5f;

    void Update()
    {
        // Si el objeto tiene la tag "Cubo", lo movemos con las flechas del teclado
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

            transform.Translate(moveDirection * speed, Space.World);
        }

        // Si el objeto tiene la tag "Esfera", lo movemos con las teclas W, S, A, D
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

            transform.Translate(moveDirection * speed, Space.World);
        }
    }
}

