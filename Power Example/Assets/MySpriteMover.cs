
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class MySpriteMover : NetworkBehaviour
{
    public GameObject spawnablePrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!isLocalPlayer)
        {
            return;
        }

        var horizontalmovement = Input.GetAxis("Horizontal");
        var verticalmovement = Input.GetAxis("Vertical");

        transform.position += new Vector3(horizontalmovement, verticalmovement, 0.0f) * 0.2f;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            var spawnobject = Instantiate(spawnablePrefab, transform.position, transform.rotation);
                NetworkServer.Spawn(spawnablePrefab);
            

        }
    }
}
