using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rot : MonoBehaviour
{
    float t = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        t += 0.01f; 
        transform.localRotation = Quaternion.Euler(-21.335f,0,t);
    }



}
