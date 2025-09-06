using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraReset : MonoBehaviour
{
    public Vector3 modelPos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        modelPos = transform.position;
    } 
}
