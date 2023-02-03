using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Shoot : MonoBehaviour
{
    public GameObject _bulatPrefabs;
    public GameObject bularPoint;
    public float _bulatSpeed;
    Vector3 mousePos;
    Vector3 worlPos;
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
            mousePos = Input.mousePosition;
            worlPos = Camera.main.ScreenToWorldPoint(mousePos);
            Vector2 roundPos = new Vector2(Mathf.RoundToInt(worlPos.x), Mathf.RoundToInt(worlPos.y));

            GameObject bullat = Instantiate(_bulatPrefabs, bularPoint.transform.position, Quaternion.identity);

            Rigidbody2D _rbody = bullat.GetComponent<Rigidbody2D>();
            Vector2 direction = (roundPos - (Vector2) bularPoint.transform.position).normalized;
            _rbody.velocity = direction * _bulatSpeed * Time.deltaTime;
            Destroy(bullat, 2f);
            

        }
    }
}
