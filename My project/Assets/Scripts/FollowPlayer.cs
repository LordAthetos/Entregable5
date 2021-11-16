using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    //Distancia entre la camara y el offset
    private Vector3 offset = new Vector3(20, 0, 0);

    void LateUpdate()
    {
        // Camara sigue al player a distancia offset
        transform.position = player.transform.position + offset;
    }
}
