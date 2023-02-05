using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Asteroid : MonoBehaviour
{
    private int _asteroidHelth = 3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (_asteroidHelth <= 0)
        {
            Destroy(this.gameObject);
        }
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            _asteroidHelth--;
            Destroy(collision.gameObject);
        }
    }
}
