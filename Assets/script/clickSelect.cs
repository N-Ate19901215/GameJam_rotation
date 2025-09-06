/*using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class ObjectClickExample : MonoBehaviour, IPointerClickHandler
{
    public bool cameraSelect = true;            
    public mainObjectSet  CameraScript;
    public GameObject cameraChangeObject;
    public cameraChange cameraChangeScript;
    
    void Start()
    {
        cameraChangeObject = GameObject.FindObjectOfType<cameraChange>().gameObject;
        cameraChangeScript = cameraChangeObject.GetComponent<cameraChange>();
    }
    void Update()
    {
        
    }
    
    // クリックされたときに呼び出されるメソッド
    public void OnPointerClick(PointerEventData eventData)
    {
        if(cameraChangeScript.Ctrl == false) {
            print($"オブジェクト {name} がクリックされたよ！");

            GameObject[] selectedObjects = GameObject.FindGameObjectsWithTag("select");
            
            // 各オブジェクトのタグをクリア
            foreach (GameObject obj in selectedObjects)
            {
                obj.tag = "unSelect";
            }
            
            this.gameObject.tag = "select";


            CameraScript.cSelectOn = true;       
            cameraSelect = true;
            CameraScript.hasExecuted = false;
        }
        else {
            print("Fpsでのクリック");
        }
        
    }

    public bool GetCameraSelect(){
        return cameraSelect;
    }

   
}
*/




using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class ObjectClickExample : MonoBehaviour, IPointerClickHandler
{
    public bool cameraSelect = true;            
    public mainObjectSet  CameraScript;
    public GameObject cameraChangeObject;
    public cameraChange cameraChangeScript;
    
    void Start()
    {
        cameraChangeObject = GameObject.FindObjectOfType<cameraChange>().gameObject;
        cameraChangeScript = cameraChangeObject.GetComponent<cameraChange>();
    }
    void Update()
    {
        
    }
    
    // クリックされたときに呼び出されるメソッド
    public void OnPointerClick(PointerEventData eventData)
    {
        if(cameraChangeScript.Ctrl == false) {
            print($"オブジェクト {name} がクリックされたよ！");

            GameObject[] selectedObjects = GameObject.FindGameObjectsWithTag("select");
            
            // 各オブジェクトのタグをクリア
            foreach (GameObject obj in selectedObjects)
            {
                obj.tag = "unSelect";
            }
            
            this.gameObject.tag = "select";


            CameraScript.cSelectOn = true;       
            cameraSelect = true;
            CameraScript.hasExecuted = false;
        }
        else {
            print("Fpsでのクリック");
        }
        
    }

    public bool GetCameraSelect(){
        return cameraSelect;
    }

   
}
