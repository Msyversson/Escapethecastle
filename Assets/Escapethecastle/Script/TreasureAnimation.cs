using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreasureAnimation : MonoBehaviour
{
    private Animator anim; 
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>(); 
    }

    public void StartAnimation(){
        anim.Play("OpenCheast"); 
    }


}
