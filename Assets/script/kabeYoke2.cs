using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kabeYoke2 : MonoBehaviour
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
        if(transform.position.x >= -8.386965)
            susumu = true;
        if(transform.position.x <= -11.26)
            susumu = false;
        if(susumu == false)
        Z = +0.002f;
        else
        Z = -0.002f;

        transform.Translate(Z,0,0);
    }
}
