using System.Collections;
using System.Collections.Generic;
using Photon.Pun;
using UnityEngine;

public class playerManagement : MonoBehaviour
{
    public PhotonView PV;
    public GameObject cam;
    // Start is called before the first frame update
    void Start()
    {
        if (!PV.IsMine)
        {
            GetComponent<playerMovement>().enabled = false;
            cam.SetActive(false);
        }
    }
}
