using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KingAlienMovement : MonoBehaviour
{
    public float velocidadX = 3;

    public float velocidadY = -1.0f;

    void Update()
    {
        transform.Translate(velocidadX * Time.deltaTime, velocidadY * Time.deltaTime, 0);

        if (transform.position.x < -1.5 || transform.position.x > 1.5)
        {
            velocidadX = -velocidadX;
        }
        if (transform.position.y < -2.0 || transform.position.y > 2.0)
        {
            velocidadY = -velocidadY;
        }
    }
}
