using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Vector3 betweenPlayers;
    public Transform player2Pos;
    public GameObject cameraGameObject;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(transform.position, player2Pos.position);
        betweenPlayers = (player2Pos.position - transform.position);
        betweenPlayers.Normalize();
        betweenPlayers *= distance / 2;

        if (this.transform.position.z >= player2Pos.transform.position.z)
        {
            cameraGameObject.transform.position = Vector3.Lerp(cameraGameObject.transform.position, -betweenPlayers, Time.deltaTime);
        }
        else if (this.transform.position.z <= player2Pos.transform.position.z)
        {
            cameraGameObject.transform.position = Vector3.Lerp(cameraGameObject.transform.position, betweenPlayers, Time.deltaTime);
        }
    }
}
