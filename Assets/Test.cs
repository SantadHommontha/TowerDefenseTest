using System;
using System.Collections;

using UnityEngine;


public class Test : MonoBehaviour
{
    [SerializeField] private bool  number;
    [SerializeField] private Vector3 vec;

    [SerializeField] private bool ff;

    
   

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    IEnumerator Minemine()
    {
        


        yield return new WaitForSeconds(1f);
    }
    
}
