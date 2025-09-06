using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class HitMove : MonoBehaviour
{
    public HighFence highFence;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void OnTriggerStay(Collider other){
        Debug.Log($"衝突オブジェクト: {other.gameObject.name}, タグ: {other.gameObject.tag}");
        if(other.gameObject.tag == "unSelect" || other.gameObject.tag == "select"){
                Debug.Log("パープルに当たってるで");
                highFence.open = true;
        }
        else{
            Debug.Log("パープルに当たってねええ");
            highFence.open = false;
        }

    }
    void OnTriggerExit(Collider other){

            Debug.Log("パープルに当たってねええ");
            highFence.open = false;
        

    }
}
