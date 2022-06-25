using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{

    [SerializeField]public Transform portalOut; 

    private void OnTriggerEnter(Collider other)
    {
        //transform.position = portalOut.position + new Vector3(1,0,0);//プレイヤーを出口に転送する
        transform.SetPositionAndRotation(portalOut.position + new Vector3(1,0,0), Quaternion.FromToRotation(portalOut.position, new Vector3(0,0,-1)));
    }

}
