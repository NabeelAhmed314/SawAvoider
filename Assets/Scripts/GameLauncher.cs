using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using System;

public class GameLauncher : MonoBehaviourPunCallbacks
{
    public GameObject connectingPanel;
    public GameObject nicknamePanel;
    public GameObject lobbyPanel;


    private void Awake()
    {
        PhotonNetwork.AutomaticallySyncScene = true;
    }


    public void ConnectedToPhotonServer()
    {
        if (!PhotonNetwork.IsConnected)
        {
            PhotonNetwork.ConnectUsingSettings();
            connectingPanel.SetActive(true);
            nicknamePanel.SetActive(false);
        }   
    }

    public override void OnConnectedToMaster()
    {
        Debug.Log(PhotonNetwork.NickName + "Connect to server");
        connectingPanel.SetActive(false);
        lobbyPanel.SetActive(true);
    }

    public override void OnConnected()
    {
        Debug.Log("Connected to internet");
    }

    public void JoinRandomRoom()
    {
        PhotonNetwork.JoinRandomRoom();
    }

    public override void OnJoinRandomFailed(short returnCode, string message)
    {
        base.OnJoinRandomFailed(returnCode, message);
        CreateAndJoinRoom();
    }

    private void CreateAndJoinRoom()
    {
        string room = "Room" + UnityEngine.Random.Range(0, 10000);
        RoomOptions roomOptions = new RoomOptions();
        roomOptions.IsOpen = true;
        roomOptions.IsVisible = true;
        roomOptions.MaxPlayers = 10;
        PhotonNetwork.CreateRoom(room, roomOptions);
    }

    public override void OnJoinedRoom()
    {
        Debug.Log(PhotonNetwork.NickName + "Joined to" + PhotonNetwork.CurrentRoom.Name);
        PhotonNetwork.LoadLevel("Game");
    }

    public override void OnPlayerEnteredRoom(Player newPlayer)
    {
        Debug.Log(newPlayer.NickName + "joined to" + PhotonNetwork.CurrentRoom.Name);
    }
}
