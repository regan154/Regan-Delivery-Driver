using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] GameObject thingtoFollow;
    //this things position should be the same as the cars position
 
    void LateUpdate()
    {
        transform.position = thingtoFollow.transform.position + new Vector3 (0,0,-10) ;  
    }
}