using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class respawnBlock : MonoBehaviour
{
    public respown respawn;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   // public Vector3 GetRespownPos(){
        
        //this.gameObject.transform.position;
    //}
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            Debug.Log("リス地更新");
            respawn.respawnPos = this.gameObject.transform.position;
            respawn.respawnRot = this.gameObject.transform.rotation;
            Debug.Log(respawn.respawnRot);
        }
    }
}
