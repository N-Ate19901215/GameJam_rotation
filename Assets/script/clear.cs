using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class clear : MonoBehaviour
{
    public revoCamera revoCamera;
    public bool clearYes = false;
    public cameraChange cameraChange;
    public int clearYe=0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(revoCamera.MonsterParent.name == "Rocket_1_Obj"){
            Debug.Log("clearや！！！！！");
            clearYes = true;
             cameraChange.GetComponent<cameraChange>().enabled = false;
        } 
if(clearYes == true){
    clearYe ++;
    if(clearYe > 0 && clearYe < 400){

        transform.Translate(0,0.01f,0);
    }
     if(clearYe >= 400){
    transform.Translate(0,0.1f,0);
}
}
if(clearYe > 1000){
     SceneManager.LoadScene("result");
}
    }
}
