using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class SpawnManager : MonoBehaviour
{
    GameObject player;
    public GameObject spawn1, spawn2;
    // Start is called before the first frame update
    private void Start()
    {


        // if (PhotonNetwork.CurrentRoom.PlayerCount == 1)
        // {
        //     PhotonNetwork.Instantiate("Player", spawn1.transform.position, Quaternion.identity);
        // }
        // if (PhotonNetwork.CurrentRoom.PlayerCount == 2)
        // {
        //     PhotonNetwork.Instantiate("Player", spawn2.transform.position, Quaternion.identity);
        // }
    }
}