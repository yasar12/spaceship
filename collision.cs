using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class collision : MonoBehaviour
{
   [SerializeField] ParticleSystem boomm;
    private void OnCollisionEnter(Collision collision)
    {
boomm.gameObject.SetActive(true);
        Invoke("boom", 1f);
    }

    void  boom()
    {
        
         SceneManager.LoadScene(0);
    }
}
