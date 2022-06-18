using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTest : MonoBehaviour
{
    [SerializeField]public Transform portalOut;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            transform.Translate(0,0,0.1f);
        }
        else if(Input.GetKey(KeyCode.S))
        {
            transform.Translate(0,0,-0.1f);
        }
        if(Input.GetKey(KeyCode.A))
        {
            transform.Translate(-0.1f,0,0);
        }
        else if(Input.GetKey(KeyCode.D))
        {
            transform.Translate(0.1f,0,0);
        }
        
    }
    private void OnTriggerEnter(Collider other)
    {
        transform.position = portalOut.position;
    }
}
