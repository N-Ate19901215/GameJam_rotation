using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSController : MonoBehaviour
{
    float x, z;
    float speed = 0.01f;

    public GameObject cam;
    Quaternion cameraRot, characterRot;
    float Xsensityvity = 3f, Ysensityvity = 3f;
    
    bool cursorLock = true;

    float minX = -90f, maxX = 90f;
     private GameObject Parent;

    private Vector3 Position;

    private RaycastHit Hit;

    private float Distance;

    private int Mask;
    private Vector3 lastMousePosition;
    public ObjectClickExample objectClickExample;
   
    public bool Movekotei = false;
    public bool Rotkotei = false;
    public bool revoState = false;
    // Start is called before the first frame update
    void Start()
    {
        cameraRot = cam.transform.localRotation;
        characterRot = transform.localRotation;

        Parent = transform.root.gameObject;

        Position = transform.localPosition;

        Distance = Vector3.Distance(Parent.transform.position, transform.position);

        Mask = ~(1 << LayerMask.NameToLayer("Player"));


        if (objectClickExample == null)
        {
            objectClickExample = FindObjectOfType<ObjectClickExample>();
        }

    }

    // Update is called once per frame
    void Update()
    {
        if(!Rotkotei){
        float xRot = Input.GetAxis("Mouse X") * Ysensityvity;
        float yRot = Input.GetAxis("Mouse Y") * Xsensityvity;

        cameraRot *= Quaternion.Euler(-yRot, 0, 0);
        characterRot *= Quaternion.Euler(0, xRot, 0);

        cameraRot = ClampRotation(cameraRot);

        cam.transform.localRotation = cameraRot;
        transform.localRotation = characterRot;
        


        if(Mathf.Abs(Screen.width/2-Input.mousePosition.x) > 50 || Mathf.Abs(Screen.height/2-Input.mousePosition.y) > 50){
            Cursor.lockState = CursorLockMode.Locked;
        }else{
            Cursor.lockState = CursorLockMode.None;
        }
        }
        
    }
    
    
    
    private void FixedUpdate()
    {
        if(!revoState){
            x = 0;
            z = 0;

            x = Input.GetAxisRaw("Horizontal") * speed;
            z = Input.GetAxisRaw("Vertical") * speed;

            transform.position += cam.transform.forward * z + cam.transform.right * x;
        }
        
    }


    
    

    public Quaternion ClampRotation(Quaternion q)
    {

        q.x /= q.w;
        q.y /= q.w;
        q.z /= q.w;
        q.w = 1f;

        float angleX = Mathf.Atan(q.x) * Mathf.Rad2Deg * 2f;

        angleX = Mathf.Clamp(angleX,minX,maxX);

        q.x = Mathf.Tan(angleX * Mathf.Deg2Rad * 0.5f);

        return q;
    }

    

}
