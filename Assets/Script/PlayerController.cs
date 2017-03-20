using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public float speed = 10;

	void FixedUpdate() {
		// Input取得
		float x = Input.GetAxis ("Horizontal");
		float z = Input.GetAxis ("Vertical");

		// 自分自身のRigitbody取得
		Rigidbody rigidbody = GetComponent<Rigidbody> ();

		// rigidbodyのx,y軸に力を加える
		rigidbody.AddForce(x * speed, 0, z * speed);
	}
}
