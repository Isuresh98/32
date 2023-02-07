using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Asteroid : MonoBehaviour
{
    private int _asteroidHelth = 3;
    private Player_Movement _playerScript;
    private int _destroyAstroy;
    // Start is called before the first frame update
    void Start()
    {
        _playerScript = FindObjectOfType<Player_Movement>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_asteroidHelth <= 0)
        {
            Destroy(this.gameObject);
            _destroyAstroy += 5;
            _playerScript.UpdateScore(_destroyAstroy);

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
