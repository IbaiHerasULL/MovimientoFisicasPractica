using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio12 : MonoBehaviour
{
    public float speed = 5f;     // Velocidad de movimiento
    public float rotSpeed = 3f;  // Velocidad de rotación
    public Transform esfera;      // Referencia a la esfera
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();  // Obtener el Rigidbody del cilindro
    }

    //Usamos en evento FixedUpdate para hacer más solidas las interacciones con las físicas
    void FixedUpdate()
    {
        // Movimiento básico con las teclas IJKL
        float moveHorizontal = 0f;
        float moveVertical = 0f;

        if (Input.GetKey(KeyCode.I))
        {
            moveVertical = 1f;  // Mover hacia adelante
        }
        else if (Input.GetKey(KeyCode.K))
        {
            moveVertical = -1f;  // Mover hacia atrás
        }

        if (Input.GetKey(KeyCode.J))
        {
            moveHorizontal = -1f;  // Mover hacia la izquierda
        }
        else if (Input.GetKey(KeyCode.L))
        {
            moveHorizontal = 1f;   // Mover hacia la derecha
        }

        // Dirección hacia la esfera
        Vector3 direction = new Vector3(esfera.position.x - transform.position.x, 0, esfera.position.z - transform.position.z).normalized;

        // Rotar gradualmente el cilindro hacia la esfera
        Quaternion lookRotation = Quaternion.LookRotation(direction);
        transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * rotSpeed);

        // Aplicar movimiento en la dirección actual (frontal y lateral)
        Vector3 movement = (transform.forward * moveVertical + transform.right * moveHorizontal) * speed * Time.deltaTime;
        rb.MovePosition(rb.position + movement);
    }
}

