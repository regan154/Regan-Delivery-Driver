using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    [SerializeField] float fltDestroyDelay = 0.5f;
    bool blHasPackage;
    void OnCollisionEnter2D(Collision2D other) 
    {
           Debug.Log("Ouch!");
    }
     
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Package" && !blHasPackage)
        {
            Debug.Log("Package picked up");
            blHasPackage = true;
            Destroy(other.gameObject, fltDestroyDelay);
        }
        if (other.tag == "Customer" && blHasPackage)
        {
            Debug.Log("Package Delivered");
            blHasPackage = false;
        }
    }
}