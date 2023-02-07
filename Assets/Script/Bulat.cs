using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bulat : MonoBehaviour
{
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
            _destroyAstroy += 1;
            _playerScript.UpdateScore(_destroyAstroy);
        }
    }
}
