using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
    GameObject player;
    public float moveSpeed;

    bool isGrounded = false;

    Vector3 moveVector; 

	void Start ()
    {
        player = gameObject;
        moveVector = new Vector3(moveSpeed, 0, 0);
    }
	
	void Update ()
    {
        if(Input.GetKey(KeyCode.RightArrow))
            player.GetComponent<Transform>().position = player.GetComponent<Transform>().position + moveVector / 20;

        if (Input.GetKey(KeyCode.LeftArrow))
            player.GetComponent<Transform>().position = player.GetComponent<Transform>().position - moveVector / 20;

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            isGrounded = false;
            player.GetComponent<Rigidbody2D>().AddForce(Vector2.up * 10, ForceMode2D.Impulse);
        }
    }

    void OnTriggerStay2D (Collider2D other)
    {
        if(other.name == "platform")
            isGrounded = true;
    }
}
