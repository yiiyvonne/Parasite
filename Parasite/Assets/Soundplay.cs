using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soundplay : MonoBehaviour
{
    AudioSource source;

    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
                
    }

    private void OnCollisionEnter(Collision col)
    {
        print("collision");

        if (col.gameObject.CompareTag("sound"))
        {
            source.Play();
        }
    }
}
