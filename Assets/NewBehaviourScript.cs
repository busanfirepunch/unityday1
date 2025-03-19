using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Dependencies.Sqlite;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private int speed = 5;
    public int jumpPower = 20;
    public int jumpCut = 0;

    private Vector3 movement;

    private Rigidbody rigid;

    private void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        movement.x = Input.GetAxis("Horizontal");
        movement.z = Input.GetAxis("Vertical");

        movement.Normalize();

        rigid.velocity = movement * speed;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && jumpCut < 1)
        {
            rigid.AddForce(Vector3.up * jumpPower , ForceMode.Impulse);
            jumpCut++;
        }
        Physics.gravity = new Vector3(0, -50f, 0);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            jumpCut = 0;
        }

    }
}
