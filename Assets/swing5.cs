using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swing5 : MonoBehaviour
{
    public float acc = 5f;
    int direction = 1;
    int tt = 0;

    void Update()
    {
        if (transform.position.y > 6 || transform.position.y < -5)
        {
            direction *= -1;
        }
        transform.Translate(Vector3.up * acc * direction * Time.deltaTime);
    }
}
