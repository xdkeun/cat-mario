using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swing3 : MonoBehaviour
{
    public float acc = 5f;
    int direction = 1;

    void Update()
    {
        if (transform.position.y > 3.9 || transform.position.y < -8.1)
        {
            direction *= -1;
        }
        transform.Translate(Vector3.up * acc * direction * Time.deltaTime);
    }
}
