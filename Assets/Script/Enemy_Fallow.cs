using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Fallow : MonoBehaviour
{
    public float speed = 5f;
    public float stopDistance = 2f;

    private GameObject _targetPlayer;
    private Rigidbody2D rb2d;
    // Start is called before the first frame update
    void Start()
    {

        rb2d = GetComponent<Rigidbody2D>();
        _targetPlayer = GameObject.FindWithTag("Player");

    }
    // Update is called once per frame
    void Update()
    {
        FollowTarget();
    }

    private void FollowTarget()
    {
        if (_targetPlayer != null)
        {
            float distance = Vector2.Distance(transform.position, _targetPlayer.transform.position);
            if (distance > stopDistance)
            {
                transform.position = Vector2.MoveTowards(transform.position, _targetPlayer.transform.position, speed * Time.deltaTime);
            }
        }
    }
}
