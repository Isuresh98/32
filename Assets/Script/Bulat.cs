using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bulat : MonoBehaviour
{
    private int _destroyeCount;
    private Player_Movement _playerScript;
    // Start is called before the first frame update
    void Start()
    {
        _playerScript = FindObjectOfType<Player_Movement>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("AstBig"))
        {
            Destroy(gameObject);
        }
        if (collision.gameObject.CompareTag("AstSmall"))
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);
            _destroyeCount += 1;
            _playerScript.UpdateScore(_destroyeCount);
            
        }
       
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);
        }
    }
}
