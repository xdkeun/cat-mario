using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swing2 : MonoBehaviour
{
    public float acc = 5f;
    int direction = 1;

    void Update()
    {
        if (transform.position.y > 4 || transform.position.y < -9)
        {
            direction *= -1;
            acc = Random.Range(1, 10);
        }
        transform.Translate(Vector3.up * acc * direction * Time.deltaTime);
    }
}
