using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAnimation : MonoBehaviour
{
    public Animator myAnimationController;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) { 

            myAnimationController.SetBool("openDoor", true);
            print("open door...");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player")){

            myAnimationController.SetBool("openDoor", false);
            print("close door...");
        }
    }
   
}
