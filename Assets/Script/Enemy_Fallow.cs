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
    // Start is called before the first frame update
    void Start()
    {
        _targetPlayer = GameObject.FindWithTag("Player");

        _rBody = GetComponent<Rigidbody2D>();
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

        /* if (_targetPlayer != null)
         {
             _distans = Vector2.Distance(transform.position, _targetPlayer.transform.position);
             if (_distans > StopDistans)
             {
                 transform.position = Vector2.MoveTowards(transform.position, _targetPlayer.transform.position, Speed * Time.deltaTime);
             }
         }
        */
    }
}
