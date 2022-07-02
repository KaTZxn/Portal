using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ray : MonoBehaviour
{
    public Transform PortalIn,PortalOut;
    public Transform Player,PlayerCamera;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            if(Physics.Raycast(Player.position,PlayerCamera.forward, out hit, Mathf.Infinity))
            {
                //Debug.DrawRay(Player.position,PlayerCamera.forward, Color.yellow);
                Debug.Log(hit.point);
                PortalIn.SetPositionAndRotation(hit.point, Quaternion.FromToRotation(Vector3.forward, hit.normal));
            }
        }
        if(Input.GetMouseButtonDown(1))
        {
            RaycastHit hit;
            if(Physics.Raycast(Player.position,PlayerCamera.forward, out hit, Mathf.Infinity))
            {   
                if(hit.transform.gameObject.tag == "Unplaceable" )
                    return;
                Debug.Log(hit.transform.gameObject.tag);
                Debug.Log(hit.point);
                PortalOut.SetPositionAndRotation(hit.point, Quaternion.FromToRotation(Vector3.forward, hit.normal));
            }
        }
    }
}
