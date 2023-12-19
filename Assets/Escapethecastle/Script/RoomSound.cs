using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomSound : MonoBehaviour
{
//Variabel som ska aktivera ljudet, görs i inspector fönstret.
    [SerializeField]
    private AudioSource audioSource;

    //När spelaren går in i en bestämd Box collider area, så aktiveras denna funktion.
    private void OnTriggerEnter(Collider other)
    {
        //Spelar upp det valda ljudet.
        audioSource.Play();
    }

    //När spelaren lämnar den bestämda collider arean så körs denna funktion.
    private void OnTriggerExit(Collider other)
    {
        //Ljudet slutar.
        audioSource.Stop();
    }
}
