using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Define la posicion inicial
    private Vector3 StartPos = new Vector3(0, 0, 0);
    // Define la velocidad
    public float speed = 10.0f;
    private float verticalInput;
    // Define la Velocidad de rotacion
    private float turnSpeed = 20f;
    // Distancia del mapa
    private int zMax = 450;

    
    void Start()
    {
        // Fuerza el player al 0,0,0
        transform.position = StartPos;
    }

    void Update()
    {
        // Movimento hacia delante del player
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        // Rotacion en eje X al pulsar las flechas
        verticalInput = Input.GetAxis("Vertical");
        transform.Rotate(Vector3.left, turnSpeed * Time.deltaTime * verticalInput);
       // fin del juego cuando se llega al final del mapa
        if (transform.position.z > zMax) 
        {
            Debug.Log("THE END");
            Time.timeScale = 0;
        }
    }
}
