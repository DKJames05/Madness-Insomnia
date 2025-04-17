using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class projectile : MonoBehaviour
{
    public float projectilespeed;
   // public GameObject impactEffect;

    Rigidbody2D rigidbody;

    void Start()
    
    {
        rigidbody = GetComponent<Rigidbody2D>();
        //rigidbody.linearVelocity = transform.right * projectilespeed;
    }

    void Update()
    {

        //rigidbody.transform.position = transform.right * projectilespeed;
        rigidbody.AddForce(transform.up * projectilespeed)
    }
    /*
 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Instantiate(impactEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
    */
}
