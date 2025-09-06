using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental;
using UnityEngine;

public class mainObjectSet : MonoBehaviour
{
    public ObjectClickExample objectClickExample;
    private bool cSelect ;
    public bool hasExecuted = false;
    private Transform parentTransform;
    float xPos;
    float yPos;
    public bool cSelectOn = false;
    public GameObject CtrlOns;
    public GameObject CtrlOffs;
    public GameObject aliikii;
    public cameraChange CameraChange;
    
    
    // Start is called before the first frame update
    void Start()
    {
        if (objectClickExample == null)
        {
            objectClickExample = FindObjectOfType<ObjectClickExample>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        cSelect = objectClickExample.GetCameraSelect();
        if(cSelect  && !hasExecuted){
            transform.parent = GameObject.FindWithTag ("select").transform;
            transform.localPosition = new Vector3(0,5,1);

            parentTransform = transform.parent;
            transform.LookAt(parentTransform);
            
           

            hasExecuted = true;
        }

        if(!CameraChange.Ctrl){
            if(cSelectOn){
                CtrlOns.SetActive(true);
                CtrlOffs.SetActive(false);
                aliikii.SetActive(false);
            }
            else{
                CtrlOns.SetActive(false);
                CtrlOffs.SetActive(true);
                aliikii.SetActive(false);
            }
        }
        else{
            aliikii.SetActive(true);
        }

        if(Input.GetKeyDown(KeyCode.Q))
        {
            Debug.Log("ooooooooooooooo!!!");
            GameObject[] selectedObjects = GameObject.FindGameObjectsWithTag("select");
        
        // 各オブジェクトのタグをクリア
            foreach (GameObject obj in selectedObjects)
            {
                obj.tag = "unSelect";
            }
            this.gameObject.transform.parent = null;  


            cSelectOn = false;
            //objectClickExample.cameraSelect = false;
            //hasExecuted = false;
        }

        if(!cSelectOn && Input.GetMouseButton(0)){
            float h = Input.GetAxis("Mouse X"); 
            float v = Input.GetAxis("Mouse Y"); 
               
            // カメラの右方向と上方向を取得
            Vector3 right = transform.right; 
            Vector3 up = transform.up;

            // カメラのローカル座標に基づいて位置を更新
            transform.localPosition += right * h * 0.1f;
            transform.localPosition += up * v * 0.1f;
        }

        if(!cSelectOn && Input.GetMouseButton(1)){
            float Rx = Input.GetAxis("Mouse X"); 
            float Ry = Input.GetAxis("Mouse Y"); 

            transform.Rotate(Ry*4, Rx*-4, 0);
        }

        /*if(Mathf.Abs(Screen.width/2-Input.mousePosition.x) > 50 || Mathf.Abs(Screen.height/2-Input.mousePosition.y) > 50){
            Cursor.lockState = CursorLockMode.Locked;
        }
        else{
            Cursor.lockState = CursorLockMode.None;
        }*/
        
    }

    
        
}




