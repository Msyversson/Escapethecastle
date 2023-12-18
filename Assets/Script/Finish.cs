using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Finish : MonoBehaviour
{
   public GameObject finish;

   //När player går in i boxen triggar victory canvas  
   private void OnTriggerEnter(Collider other)
   {
    if (other.CompareTag("Player"))
    {
        finish.SetActive(true);
    }
   }

    private void OnTriggerExit(Collider other)
   {
    if (other.CompareTag("Player"))
    {
        finish.SetActive(false);
    }
   }

}
