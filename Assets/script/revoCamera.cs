using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.Animations;

public class revoCamera : MonoBehaviour
{
    public GameObject RevoObject;
    public revoObject revoObjectScript;
    public bool revoParentFirst = false;
    // Start is called before the first frame update
    public GameObject character;
    public FPSController fpsController;
    public GameObject MonsterParent;
    public clear Clear;
    void Start()
    {
        RevoObject = GameObject.FindObjectOfType<revoObject>().gameObject;
        revoObjectScript = RevoObject.GetComponent<revoObject>();
        character = GameObject.FindObjectOfType<FPSController>().gameObject;
        fpsController = character.GetComponent<FPSController>();
        MonsterParent = null;

    }

    // Update is called once per frame
    void Update()
    {
        // && !revoParentFirst
        if(fpsController.revoState){
            /*
            revoObject[] RevoAllObject = GameObject.FindObjectsOfType<revoObject>();
            foreach(revoObject obj in RevoAllObject){
                if(obj.customTags.Contains("revoTag")){
                    transform.parent = obj.transform;
                    Debug.Log("なんでや"); 
                }
                */

            transform.parent = MonsterParent.transform ;

        }
            

            //if(!revoParentFirst){
            if(fpsController.revoState == true){
            Rigidbody rb = GetComponent<Rigidbody>();
            
                // 取得した Rigidbody コンポーネントが存在する場合に isKinematic を設定
                if (rb != null)
                {
                    rb.isKinematic = true;
                }
            }
            //}
        
    //if(Clear.clearYes == false){
        if(Input.GetKeyDown(KeyCode.E)){
            Debug.Log("E押したよ");
            /*
            revoObject[] RevoAllObject2 = GameObject.FindObjectsOfType<revoObject>();
            foreach(revoObject obj in RevoAllObject2){
                obj.customTags.Remove("revoTag");
            }
            Rigidbody rb = GetComponent<Rigidbody>();
            rb.isKinematic = false;
            gameObject.transform.parent = null; 
            fpsController.Movekotei = false;
            revoObjectScript.revoState = false;
*/
            //revoObjectScript.revoState = false;

            if(MonsterParent != null){
                MonsterParent = null;
                transform.parent = null;
                
                Rigidbody rb = GetComponent<Rigidbody>();
                rb.isKinematic = false;
                fpsController.revoState = false;
                
            }


       // }
        }
        
    

   
    }
    }

