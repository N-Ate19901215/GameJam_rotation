using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental;
using UnityEngine;

public class cameraChange : MonoBehaviour
{
    public GameObject subCamera;
    public GameObject MainCamera;
    [SerializeField] GameObject character;
    public bool Ctrl = false;
    public GameObject cameraaSelect;
    private ObjectClickExample objectClickExample;
    public FPSController fpscontroller;

    void Start()
    {
       
        objectClickExample = cameraaSelect.GetComponent<ObjectClickExample>();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if(MainCamera.activeSelf)
            {
                MainCamera.SetActive(false);
                subCamera.SetActive(true); 
                Ctrl = false;
                fpscontroller.Rotkotei = true;
                fpscontroller.Movekotei = true; 
                //character.GetComponent<FPSController>().enabled = false;
                //objectClickExample.cameraSelect = true;
            }
            else
            {
                MainCamera.SetActive(true);
                subCamera.SetActive(false); 
                Ctrl = true;
                fpscontroller.Rotkotei = false;
                //character.GetComponent<FPSController>().enabled = true;
                fpscontroller.Movekotei = false;
                //objectClickExample.cameraSelect = false;
            }
        }
    }
}