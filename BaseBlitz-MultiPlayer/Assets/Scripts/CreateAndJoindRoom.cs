using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;

public class CreateAndJoindRoom : MonoBehaviourPunCallbacks
{
    public InputField createText;
    public InputField joinText;

    public void CreateRoom(){
        PhotonNetwork.CreateRoom(createText.text);
    }

    public void JoinRoom(){
        PhotonNetwork.JoinRoom(joinText.text);
    }

    public override void OnJoinedRoom(){
        PhotonNetwork.LoadLevel("Game");
    }
}
