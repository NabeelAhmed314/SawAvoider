using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;




public class GameManagement : MonoBehaviourPunCallbacks
{
    // Start is called before the first frame update
    void Start()
    {
        if (PhotonNetwork.IsConnected)
        {
            int range = Random.Range(-2, 2);
            PhotonNetwork.Instantiate("Player", new Vector3(range, 0, 0), Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    public override void OnJoinedRoom()
    {
        Debug.Log(PhotonNetwork.NickName + "joined room" + PhotonNetwork.CurrentRoom.Name);
    }

    public override void OnPlayerEnteredRoom(Player newPlayer)
    {
        Debug.Log(newPlayer.NickName + "joined room" + PhotonNetwork.CurrentRoom.Name + "Count" + PhotonNetwork.CurrentRoom.PlayerCount);
    }
}
