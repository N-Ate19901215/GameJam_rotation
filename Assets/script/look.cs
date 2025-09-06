using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class look : MonoBehaviour
{
    float xRot;
    float yRot;
    private bool buttonDownFlag = true;
    public GameObject cameraManager;
    public cameraChange cameraChangeScript;
    void Start()
    {
        cameraChangeScript = cameraManager.GetComponent<cameraChange>();

    }

    // Update is called once per frame
    void Update()
    {
        
        // "select" タグを持つオブジェクトをチェック
        GameObject selectedObject = GameObject.FindWithTag("select");
        
        // このオブジェクトが選択されたオブジェクト自身かチェック
        if (selectedObject != null && selectedObject == gameObject)
        {
            if(cameraChangeScript.Ctrl == false){
                if (Input.GetMouseButton(0)){
                    float h = Input.GetAxis("Mouse X"); 
                    float v = Input.GetAxis("Mouse Y"); 
                    yRot -= h * 4;
                    xRot -= v * 4;
                    transform.rotation = Quaternion.Euler(xRot, yRot, 0f);
                }
                Debug.Log("サブカメラ");
            }
        }
    }
    
    
}
