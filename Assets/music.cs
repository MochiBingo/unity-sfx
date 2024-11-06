using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class music : MonoBehaviour
{
    public AudioSource source;
    public void OnTriggerEnter(Collider other)
    {
        source.Pause();
    }
    public void OnTriggerExit(Collider other)
    {
        source.UnPause();
    }
}
