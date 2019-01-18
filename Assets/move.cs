using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class move : NetworkBehaviour {

    // Use this for initialization
   
    }

    // Update is called once per frame
    void Update() {

        
            float h = Input.GetAxis("Horizomtal");
        float v = Input.GetAxis("Vertical");
        transform.position = transform.position + new Vector3(h, 0, v);
    
}
}
