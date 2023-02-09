using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Fallow : MonoBehaviour
{
    public float Speed = 3f;
    public float StopDistans = 3f;

    private GameObject _targetPlayer;
    private float _distans;
    // Start is called before the first frame update
    void Start()
    {
        _targetPlayer = GameObject.FindWithTag("Player");
     
    }
    // Update is called once per frame
    void Update()
    {
        FlowwoEnemy();
    }

    private void FlowwoEnemy()
    {
        if (_targetPlayer != null)
        {
            _distans = Vector2.Distance(transform.position, _targetPlayer.transform.position);
            if (_distans > StopDistans)
            {
                transform.position = Vector2.MoveTowards(transform.position, _targetPlayer.transform.position, Speed * Time.deltaTime);
            }
        }
    }
}
