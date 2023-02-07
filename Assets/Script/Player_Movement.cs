using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    public float Speed;
    private Rigidbody2D _rbody;
    private Vector2 Movement;
    float horizontalInput;
    float verticalInput;
   public int DisplayeScorCount;
    
    // Start is called before the first frame update
    void Start()
    {
        _rbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Rotetion();
    }
    private void FixedUpdate()
    {
        Movement = new Vector2(horizontalInput, verticalInput);
        Movement = Quaternion.Euler(0, 0, transform.eulerAngles.z) * Movement;
        _rbody.AddForce(Movement * Speed * Time.deltaTime);
    }

    private void Move()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
    }

    private void Rotetion()
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
    public void UpdateScore(int AsroideDistroy)
    {
        DisplayeScorCount += AsroideDistroy;
    }
    
    
}
