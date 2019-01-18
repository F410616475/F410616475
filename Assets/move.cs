using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class move : NetworkBehaviour {

    // Use this for initialization
    void Start()
    {
        if (isLocalPlayer)
        {
            GetComponent<MeshRenderer>().material.color = Color.red;
        }

    }

    // Update is called once per frame
    void Update() {

        if (isLocalPlayer)
        {


            float h = Input.GetAxis("Horizomtal");
            float v = Input.GetAxis("Vertical");
            transform.position = transform.position + new Vector3(h, 0, v);
        }
}
}
