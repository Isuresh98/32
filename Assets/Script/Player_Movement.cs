using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    public float speed = 10f;
    private Rigidbody2D rb2d;
    private Vector2 movement;
    float horizontal;
    float vertical;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Rotet();
    }
    private void FixedUpdate()
    {
        movement = new Vector2(horizontal, vertical);
        movement = Quaternion.Euler(0, 0, transform.eulerAngles.z) * movement;
        rb2d.AddForce(movement * speed*Time.deltaTime);
    }

    private void Move()
    {
        horizontal = Input.GetAxis("Horizontal");
         vertical = Input.GetAxis("Vertical");
        
    }
    private void Rotet()
    {
        if (Input.GetKey(KeyCode.LeftAlt))
        {
            transform.Rotate(0, 0, 45 * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightAlt))
        {
            transform.Rotate(0, 0, -45 * Time.deltaTime);
        }


    }
}
