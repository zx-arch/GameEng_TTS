using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TembokGerak : MonoBehaviour
{

    private Vector3 startPosition;

    public float min=2f;
    public float max=3f;

    // Use this for initialization
    void Start () {
       
        min=transform.position.z-6;
        max=transform.position.z+6;
   
    }
   
    // Update is called once per frame
    void Update () {
       
       
        transform.position =new Vector3(transform.position.x, transform.position.y, Mathf.PingPong(Time.time*3,max-min)+min);
        
    }
}
