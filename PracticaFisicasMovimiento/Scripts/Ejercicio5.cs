using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5 : MonoBehaviour
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

            // Mover el cubo proporcional al tiempo transcurrido por frame
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

            Vector3 moveDirection = new Vector3(horizontal, 0, vertical);

            // Mover la esfera proporcional al tiempo transcurrido por frame
            transform.Translate(moveDirection * speed * Time.deltaTime, Space.World);
        }
    }
}
