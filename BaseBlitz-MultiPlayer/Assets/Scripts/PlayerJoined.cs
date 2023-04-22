using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class PlayerJoined : MonoBehaviour
{
    public GameObject mainCamera;
    PhotonView view;
    // Start is called before the first frame update
    void Start()
    {
        view=GetComponent<PhotonView>();
    }

    // Update is called once per frame
    void Update()
    {
        if(view.IsMine){
            mainCamera.SetActive(true);
        }
        else{
            mainCamera.SetActive(false);
        }
    }
}
