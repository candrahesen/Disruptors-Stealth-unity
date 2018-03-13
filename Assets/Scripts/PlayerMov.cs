using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMov : MonoBehaviour {

    public Transform playertrn;
    public Rigidbody playerRB;
    public int speed;
    private bool isFalling = false;
    public Vector3 JumpHeight = new Vector3(0, 5, 0);

	void Start () {
        playertrn = GetComponent<Transform>();
        playerRB = GetComponent<Rigidbody>();
	}


	void Update () {
        if (Input.GetKey(KeyCode.D))
        {
            playertrn.Translate(new Vector3(speed, 0, 0) * speed * Time.deltaTime);
        }           

        else if (Input.GetKey(KeyCode.A))
        {
            playertrn.Translate(new Vector3(-speed, 0, 0) * speed * Time.deltaTime);
        }            

        else if (Input.GetKey(KeyCode.Space)) {
            playerRB.velocity = JumpHeight;
            isFalling = true;
        }
	}

    void OnCollisionStay () {
        isFalling = false;
    }
}
