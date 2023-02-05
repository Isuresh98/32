using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Shoot : MonoBehaviour
{
    public GameObject BulatPrefabs;
    public GameObject BulatPoint;
    public float BulatSpeed;
    Vector3 _mousePoss;
    Vector3 _worlPoss;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Shoot();
    }
    
    private void Shoot()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _mousePoss = Input.mousePosition;
            _worlPoss = Camera.main.ScreenToWorldPoint(_mousePoss);
            Vector2 roundPos = new Vector2(Mathf.RoundToInt(_worlPoss.x), Mathf.RoundToInt(_worlPoss.y));

            GameObject Bullet = Instantiate(BulatPrefabs, BulatPoint.transform.position, Quaternion.identity);

            Rigidbody2D rbody = Bullet.GetComponent<Rigidbody2D>();
            Vector2 Direction = (roundPos-(Vector2)BulatPoint.transform.position).normalized;
            rbody.velocity = Direction * BulatSpeed * Time.deltaTime;
            Destroy(Bullet, 1f);
        }
    }

}
