using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    [SerializeField] Color32 hasPackageColor = new Color32(1, 1, 1, 1);
    [SerializeField] Color32 noPackageColor = new Color32(1, 1, 1, 1);

    [SerializeField] float fltDestroyDelay = 0.5f;
    bool blHasPackage;

    SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

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
            spriteRenderer.color = hasPackageColor;
            Destroy(other.gameObject, fltDestroyDelay);
        }
        if (other.tag == "Customer" && blHasPackage)
        {
            Debug.Log("Package Delivered");
            blHasPackage = false;
            spriteRenderer.color = noPackageColor;
        }
    }
}