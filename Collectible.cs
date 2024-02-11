using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    int collected = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    } // start
    public void OnTriggerEnter(Collider item) 
    {
        if(item.CompareTag("Player"))
        {
            Debug.Log("Sample collected.");
            gameObject.SetActive(false);
            collected++;
        } // if
    } // OnTriggerEnter
    // Update is called once per frame
    void FixedUpdate()
    {
        
    } // FixedUpdate
} // Collectible
