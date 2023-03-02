using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fire : MonoBehaviour
{
    [SerializeField] GameObject[] lasers;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        processfiring();
    }

    void processfiring() 
    {
        if (Input.GetButton("Fire1"))
        {
            
            activelaser();
        }
        else
        {
            deactivelaser();
        }
    }
     void deactivelaser()
    {
        foreach (GameObject laser in lasers)
        {
            var emisionn = laser.GetComponent<ParticleSystem>().emission;
            emisionn.enabled = false;

        }
    }
    void activelaser()
    {
        foreach(GameObject laser in lasers)
        {
            var emision = laser.GetComponent<ParticleSystem>().emission;
            emision.enabled = true;
        }
    }

}
