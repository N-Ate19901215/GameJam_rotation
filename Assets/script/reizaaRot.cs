using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reizaaRot : MonoBehaviour
{
    float t;
    float p;
    float pA;
    int pRot = 1;
    int time;
    Vector3 startPos;
    // Start is called before the first frame update
    void Start()
    {
        startPos = this.transform.position;
        Debug.Log(startPos);
    }

    // Update is called once per frame
    
    void OnTriggerStay (Collider other){
        if(other.gameObject.tag == "Untagged" || other.gameObject.tag == "select" || other.gameObject.tag == "unSelect"){
            Debug.Log("貫通中");
            pRot = -1;
           /* // Triggerで接触したオブジェクトは
        // 全てボールとみなすことにする
        var rb = other.GetComponent<Rigidbody>();
        if (rb == null) return;
        
        // 入射ベクトル（速度）
        var inDirection = rb.velocity;
        // 法線ベクトル
        var inNormal = transform.up;
        // 反射ベクトル（速度）
        var result = Vector3.Reflect(inDirection, inNormal);
        
        // バウンド後の速度をボールに反映
        rb.velocity = result;*/
        }
    }
    void Update()
    {
        
        t += 0.5f;
        transform.localRotation = Quaternion.Euler(0,0,t);
       

      
        transform.Translate(0, 0, -0.05f*pRot); 

        time ++ ;
        if(time > 100)
        {
            this.transform.position = new Vector3(startPos.x, startPos.y, startPos.z);

            Debug.Log("初期化");
            pRot = 1;
            p = 0;
            time = 0;
            
        }

        
    }

}
