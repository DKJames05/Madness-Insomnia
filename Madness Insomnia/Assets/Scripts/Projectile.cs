using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectile : MonoBehaviour
{
    public float projectilespeed;
    public GameObject impactEffect;

    private Rigidbody2D rigidbody;

    void start()
    
    {
        rigidbody = GetComponent<Rigidbody2D>();
        rigidbody.linearVelocity = transform.right * projectilespeed;
    }

 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Instantiate(impactEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
