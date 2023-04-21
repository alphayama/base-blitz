using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;
using TMPro;


public class CreateAndJoinRoom : MonoBehaviourPunCallbacks
{
    public TMP_InputField createText;
    public TMP_InputField joinText;

    public void CreateRoom(){
        PhotonNetwork.CreateRoom(createText.text);
    }

    public void JoinRoom(){
        PhotonNetwork.JoinRoom(joinText.text);
    }

    public override void OnJoinedRoom(){
        PhotonNetwork.LoadLevel("ARExample");
    }
}
