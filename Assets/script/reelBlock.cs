using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reelBlock : MonoBehaviour
{
    [SerializeField] private float Z;
    [SerializeField]bool susumu = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z >= -2.0237)
            susumu = true;
        if(transform.position.z <= -4.528)
            susumu = false;
        if(susumu == false)
        Z = +0.002f;
        else
        Z = -0.001f;

        transform.Translate(0,0,Z);
    }
}
