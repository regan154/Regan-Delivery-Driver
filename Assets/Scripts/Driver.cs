using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float fltSteerSpeed = 0.8f;
    [SerializeField] float fltMoveSpeed = 0.01f;
    
    void Start()
    {
        
    }

    void Update()
    {
        float fltSteerAmount = Input.GetAxis("Horizontal") * fltSteerSpeed;
        float fltMoveAmount = Input.GetAxis("Vertical") * fltMoveSpeed;
        transform.Rotate(0, 0, -fltSteerAmount);
        transform.Translate(0, fltMoveAmount, 0);
    }
}
