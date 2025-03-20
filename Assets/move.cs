using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private int speed = 10;
    public int jump = 20;
    public int jumpCnt = 0;

    private Vector3 movement;

    private Rigidbody rigid;

 

    // Start is called before the first frame update
    private void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        movement = transform.forward * v + transform.right * h;
        transform.position += movement * speed * Time.deltaTime;

        
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && jumpCnt < 1)
        {
            rigid.AddForce(Vector3.up * jump,ForceMode.Impulse);
            jumpCnt++;

        }
        Physics.gravity = new Vector3(0, -20f, 0);

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            jumpCnt = 0;
        }
    }
}
