using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class respown : MonoBehaviour
{
    public respawnBlock getRespawnBlock;
    public Vector3 respawnPos;
    public  GameObject RevoObject;
    public  revoObject RevoObjectScript;
    public FPSController fpsController;
    public Quaternion respawnRot;
    // Start is called before the first frame update
    void Start()
    {
        respawnPos = new Vector3(0.248999998f,0.605000001f,-0.672999978f);
        RevoObject = GameObject.FindObjectOfType<revoObject>().gameObject;
        RevoObjectScript = RevoObject.GetComponent<revoObject>();
        
    }

    // Update is called once per frame
    void Update()
    {
        getRespawnBlock = FindObjectOfType<respawnBlock>();
    }

    void OnTriggerStay(Collider other){
        Debug.Log("trigger!");
        if(other.gameObject.tag == "Damage"){
            Debug.Log("respown!");
            Death();
        }

        
    }

    void Death(){
        Debug.Log("突然の死");
        fpsController.revoState = false;
        Rigidbody rb = GetComponent<Rigidbody>();
                rb.isKinematic = false;
                transform.parent = null;
        this.transform.position = new Vector3(respawnPos.x,respawnPos.y+0.2f,respawnPos.z);
        this.transform.rotation = respawnRot;
    }
}
