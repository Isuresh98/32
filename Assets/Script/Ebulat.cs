using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ebulat : MonoBehaviour
{
    public float Speed = 5f;
   

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * Speed * Time.deltaTime);
        Destroy(gameObject, 2f);
    }

    
}
