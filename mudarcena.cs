using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mudarcena : MonoBehaviour
{
    public string novafase;

     
    void OnTriggerEnter (Collider collider)
    {
        if( collider.gameObject.tag =="Player")
        {
            SceneManager.LoadScene(novafase);
        }
    }
}
