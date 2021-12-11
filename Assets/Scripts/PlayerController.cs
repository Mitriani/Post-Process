using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class PlayerController : MonoBehaviour
{
    //[SerializeField] private GameObject platform;
    
    private float speed = 8;
    void Start()
    {

    }

    void Update()
    {
       
    }

    private void FixedUpdate()
    {
        float z = Input.GetAxis("Vertical");
        float y = Input.GetAxis("Horizontal");
        transform.Translate(new Vector3(0, 0, z) * speed * Time.deltaTime);
        transform.Rotate(new Vector3(0, y, 0) * 3);
    }
}
