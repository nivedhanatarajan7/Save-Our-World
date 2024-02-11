using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    } // Start

    // Update is called once per frame
    void Update()
    {
        transform.localRotation = Quaternion(90f, Time.time * 100f, 60f);
    } // Update
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(gameObject);
        } // if
    } // OnTriggerEnter
} // Collectible
