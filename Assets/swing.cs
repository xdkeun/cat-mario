using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swing : MonoBehaviour
{
    public float acc = 5f;
    int direction = 1;

    void Update()
    {
        if (transform.position.x > 10 || transform.position.x < -10)
        {
            direction *= -1;
        }
        transform.Translate(Vector3.right * acc * direction * Time.deltaTime);
    }
}
