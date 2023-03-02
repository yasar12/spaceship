using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


public class mover : MonoBehaviour
{
   [SerializeField] float xspeed = 20;
    [SerializeField] float yspeed = 20;
    [SerializeField] float maxxmove = 5f;
    [SerializeField] float maxymove = 5;
    [SerializeField] float positionpitchfactor = 2;
    [SerializeField] float positionpitchfactor2 = 100f;
    [SerializeField] float controlpichfactor = 10f;
    // Start is called before the first frame update


    float xmover;
    float ymover;
    void Start()
    {
        
    }
 
   
    // Update is called once per frame
    void Update()
    {
        ProcessTranslation();
        ProcessRotation();
      
    }
    void ProcessRotation()
    {
        float pitch = transform.localPosition.y*positionpitchfactor+ymover*controlpichfactor;//geminin aşağı yukarı eğim almasını sağlıyor
        float yaw = 0f;
        float roll= transform.localPosition.x*positionpitchfactor2;//geminin sağa ve sola doğru eğim almasını sağlıyor
       transform.localRotation = Quaternion.Euler(pitch,yaw,roll);
    }
    void ProcessTranslation()
    { 
     xmover=  Input.GetAxis("Horizontal");
     ymover = Input.GetAxis("Vertical");

 float xoffset = xmover*Time.deltaTime*xspeed;
        float newx = transform.localPosition.x + xoffset;
        float yoffset = ymover * Time.deltaTime*yspeed;
        float newy = transform.localPosition.y + yoffset;

 float clampedxpos = Mathf.Clamp(newx,-maxxmove,maxxmove);
        float clampedypos = Mathf.Clamp(newy, -maxymove+8, maxymove);
        transform.localPosition = new Vector3(clampedxpos, clampedypos,transform.localPosition.z);
    
    }
}
