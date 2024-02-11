using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour
{
    [SerializeField] float xSpeed;
    [SerializeField] float ySpeed;
    [SerializeField] float zSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    } // Start
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(360 * xSpeed * Time.deltaTime, 360 * ySpeed * Time.deltaTime, 360 * zSpeed * Time.deltaTime);
    } // Update
} // Spin
