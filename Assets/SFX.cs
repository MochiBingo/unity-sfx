using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFX : MonoBehaviour
{
    public AudioSource source;
    public void OnTriggerEnter(Collider other)
    {
        source.Play();
    }
}
