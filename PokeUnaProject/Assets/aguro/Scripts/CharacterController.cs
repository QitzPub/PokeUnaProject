using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour {

	Rigidbody2D rigid2d;
	private float speed;


	void Start () {
	this.rigid2d = GetComponent<Rigidbody2D>();
	this.speed = 0;

	}

	void Update () {

		// Spaceキーを離すと動き出す
		if(Input.GetKeyUp(KeyCode.Space)) {

			this.speed = 100.0f;
			this.rigid2d.AddForce(transform.right * speed);
      //Debug.Log("speed");

		}

	}

  void FixedUpdate(){

    this.rigid2d.velocity *= 0.995f;

  }

}