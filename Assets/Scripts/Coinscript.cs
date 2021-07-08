using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coinscript : MonoBehaviour
{
    protected AudioSource coinpickup;
    // Play a sound when the coin gets picked up.
    protected void Start()
    {
        coinpickup = GetComponent<AudioSource>();
    }
}
