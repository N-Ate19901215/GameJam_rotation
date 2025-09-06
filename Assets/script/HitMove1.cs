using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class HitMove1 : MonoBehaviour
{
    public HighFence1 highFence1;
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
                highFence1.open = true;
        }
        

    }
    void OnTriggerExit(Collider other){

            Debug.Log("パープルに当たってねええ");
            highFence1.open = false;
        

    }
}
