using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    public AudioSource audiofundo;
    public AudioClip[] musicafundo;
    // Start is called before the first frame update
    void Start()
    {
        AudioClip musicafundo1 = musicafundo[0];
        audiofundo.clip = musicafundo1;
        audiofundo.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
