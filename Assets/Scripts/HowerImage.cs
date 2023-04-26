using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HowerImage : MonoBehaviour {

    public AudioSource AS;
    public AudioClip AC;

    public void howerImg() 
    {
    AS.PlayOneShot(AC);
    }

    public void cursorOff()
    {
        AS.Stop();
    }
}
