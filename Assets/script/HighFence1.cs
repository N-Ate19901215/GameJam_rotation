using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighFence1 : MonoBehaviour
{
    public bool open;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(open == false){
            if(transform.position.y >= 7.434876){
                transform.Translate(0,-0.01f,0);
            }
        }
        else{
            
            if(transform.position.y <= 8.131){
                transform.Translate(0,0.01f,0);
            }
        }

    }
}
