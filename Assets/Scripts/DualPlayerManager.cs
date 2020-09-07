using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class DualPlayerManager : MonoBehaviourPunCallbacks
{
    public PhotonView pv;
    // Start is called before the first frame update
    void Start()
    {
/*        if (pv.IsMine)
        {
            transform.GetComponent<PlayerMovement>().enabled = true;
        }
        else
        {
            transform.GetComponent<PlayerMovement>().enabled = false;
        }*/
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
