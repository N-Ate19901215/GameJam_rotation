using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class revoObject : MonoBehaviour,    IPointerClickHandler
{
    public GameObject cameraChangeObject;
    public cameraChange cameraChangeScript;
    public List<string> customTags = new List<string>();
    
    public GameObject revocameraObject;
    public revoCamera revoCameraScript;
    public GameObject character;
    public FPSController fpsController;
     public GameObject CameraObj;
    public revoCamera RevoCamera;
    
    // Start is called before the first frame update
    void Start()
    {
        cameraChangeObject = GameObject.FindObjectOfType<cameraChange>().gameObject;
        cameraChangeScript = cameraChangeObject.GetComponent<cameraChange>();
        revocameraObject = GameObject.FindObjectOfType<revoCamera>().gameObject;
        revoCameraScript = cameraChangeObject.GetComponent<revoCamera>();
        character = GameObject.FindObjectOfType<FPSController>().gameObject;
        fpsController = character.GetComponent<FPSController>();
        CameraObj = GameObject.FindObjectOfType<revoCamera>().gameObject;
        RevoCamera = CameraObj.GetComponent<revoCamera>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (cameraChangeScript.Ctrl == true){
            /*
            // すべての revoObject を取得
            revoObject[] allRevoObjects = FindObjectsOfType<revoObject>();

            // すべての revoObject から revoTag を削除
            foreach (revoObject obj in allRevoObjects)
            {
                obj.customTags.Remove("revoTag");
            }

            // クリックされたオブジェクトに revoTag を追加
            //if (!customTags.Contains("revoTag"))
        // {
                customTags.Add("revoTag");
                
                Debug.Log("クリックしてはりますなぁ");
            //}
            //Debug.Log("クリックしてはりますなぁ");

            //character.GetComponent<FPSController>().enabled = false;
            */

            RevoCamera.MonsterParent = this.gameObject;

            //fpsController.Movekotei = true;
            fpsController.revoState = true;
            
        }
        else
        {
            fpsController.Movekotei = false;
            revoCameraScript.revoParentFirst = true;
        }

    }

}
