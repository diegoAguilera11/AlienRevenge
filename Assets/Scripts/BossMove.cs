using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossMove : MonoBehaviour
{
    public float velocidadX = 3;

    public float velocidadY = -1.5f;
    void Update()
    {
        transform.Translate(velocidadX * Time.deltaTime, velocidadY * Time.deltaTime, 0);

        if (transform.position.x < -2.0 || transform.position.x > 2.0)
        {
            velocidadX = -velocidadX;
        }
        if (transform.position.y < -2.8 || transform.position.y > 2.8)
        {
            velocidadY = -velocidadY;
        }

    }
}
