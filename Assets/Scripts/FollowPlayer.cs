using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    //public variables
    public GameObject player;
    //private variables
    private Vector3 cameraOffset = new Vector3(0, 7, -10);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //move camera to player + offset
        transform.position = player.transform.position + cameraOffset; 
    }
}
