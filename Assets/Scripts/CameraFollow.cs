using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour
{
    GameObject player;

	void Start ()
    {
        player = GameObject.Find("guy");
	}
	
	void Update ()
    {
        transform.position = new Vector3(player.transform.position.x, transform.position.y, transform.position.z);
	}
}
