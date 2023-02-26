using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Fallow : MonoBehaviour
{
    public float Speed = 25f;
    public float StopDistans = 3f;

    private GameObject _targetPlayer;
    private float _distans;
    private Rigidbody2D _rBody;

    private Enemy_Spown _enemySpawner;
    // Start is called before the first frame update
    void Start()
    {
        _targetPlayer = GameObject.FindWithTag("Player");
        _rBody = GetComponent<Rigidbody2D>();
        _enemySpawner = FindObjectOfType<Enemy_Spown>();
    }
    // Update is called once per frame
    void Update()
    {
        FlowwoEnemy();
    }

    private void FlowwoEnemy()
    {
        _rBody.AddForce(transform.up* Speed* Time.deltaTime);
        Destroy(this.gameObject, 3f);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
        
       if (collision.gameObject.CompareTag("Bottampos"))
        {

            //enemy destroye and  after destroye enemy  set random Enemy_Spown script and set 
            // Destroy the enemy
            Destroy(gameObject);

            // Respawn the enemy in a random location
            _enemySpawner.SpawnEnemyRandom();
        }
    }
}
