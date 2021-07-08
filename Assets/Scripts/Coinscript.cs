using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coinscript : MonoBehaviour
{
    protected AudioSource coinpickup;
    // Start is called before the first frame update
    protected void Start()
    {
        coinpickup = GetComponent<AudioSource>();
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
