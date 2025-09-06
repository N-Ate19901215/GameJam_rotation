using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighFence : MonoBehaviour
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
            if(transform.position.y >= 6.29){
                transform.Translate(0,-0.01f,0);
            }
        }
        else{
            Debug.Log("パープルに当たってるで");
            if(transform.position.y <= 7.033){
                transform.Translate(0,0.01f,0);
            }
        }

    }
}
