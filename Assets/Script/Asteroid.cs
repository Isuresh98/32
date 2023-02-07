using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Asteroid : MonoBehaviour
{
    private int _asteroidHelth = 3;
    private int _destroyeCount;
    private Player_Movement _playerScript;
    public GameObject prefab;
    private bool isInstantiated = false;

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

            _destroyeCount += 5;
            _playerScript.UpdateScore(_destroyeCount);
            if (!isInstantiated)
            {
                Instantiate(prefab, transform.position, Quaternion.identity);
                isInstantiated = true;
            }
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
