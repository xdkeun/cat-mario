using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rigid2D;
    //float jumpForce = 680.0f;
    //float walkForce = 30.0f;
    //float maxWalkSpeed = 2.0f;
    float jumpForce = 400.0f;
    float walkForce = 10.0f;
    float maxWalkSpeed = 1.2f;
    void Start()
    { this.rigid2D = GetComponent<Rigidbody2D>(); }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            this.rigid2D.AddForce(transform.up * this.jumpForce);
        }
        // �¿��̵�
        int key = 0;
        if (Input.GetKey(KeyCode.RightArrow)) key = 1;
        if (Input.GetKey(KeyCode.LeftArrow)) key = -1;

        // �÷��̾� �ӵ�
        float speedx = Mathf.Abs(this.rigid2D.velocity.x);
        if (speedx < this.maxWalkSpeed)
        {
            this.rigid2D.AddForce(transform.right * key * this.walkForce);
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        { transform.localScale = new Vector3(1, 0.5f, 1); } //Űũ�⸸ �۾���
        if (Input.GetKeyDown(KeyCode.UpArrow))
        { transform.localScale = new Vector3(1, 1, 1); } //Űũ�⸸ �۾���


        //if (this.rigid2D.velocity.y == 0)
        //{ transform.localScale = new Vector3(1, 1, 1); }//����ũ��       



        if (key != 0)
        { transform.localScale = new Vector3(key, 1, 1); }

        if (transform.position.y < -10)
        { SceneManager.LoadScene("GameScene"); }


    }

    void OnTriggerEnter2D(Collider2D other)
    {
        SceneManager.LoadScene("ClearScene");
    }

}
