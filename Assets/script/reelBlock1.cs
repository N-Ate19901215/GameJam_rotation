using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reelBlock1 : MonoBehaviour
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
        if(transform.position.z >= -41.096)
            susumu = true;
        if(transform.position.z <= -47.593)
            susumu = false;
        if(susumu == false)
        Z = +0.01f;
        else
        Z = -0.004f;

        transform.Translate(0,0,Z);
    }
}
