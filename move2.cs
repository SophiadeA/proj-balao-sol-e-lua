using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move2 : MonoBehaviour
{
    public Vector3 mov;
    // Start is called before the first frame update
    void Start()
    {
        mov= new Vector3 (0,0,0);
    }

    // Update is called once per frame
    void Update()
    {
        if ( Input.GetKey(KeyCode.UpArrow))
        {
            mov.Set(0f,0.3f,0f);
            transform.Translate (mov);
        }
         
        if ( Input.GetKey(KeyCode.DownArrow))
        {
             mov.Set(0f,-0.3f,0f);
            transform.Translate (mov);
            
        }
    }
}