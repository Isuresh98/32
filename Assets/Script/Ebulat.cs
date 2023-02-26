using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ebulat : MonoBehaviour
{
    public float speed = 5f;
   

    // Update is called once per frame
    void Update()
    {
        // Move the bullet in the forward direction
        transform.Translate(Vector3.up * speed * Time.deltaTime);

        // Destroy the bullet after a set amount of time
        Destroy(gameObject, 2f);
    }

    
}
