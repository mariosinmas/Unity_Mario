using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour {

	Rigidbody rb;
	public float velocidad = 10f;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		float mHorizontal = Input.GetAxis ("Horizontal");
		float mVertical = Input.GetAxis ("Vertical");

		Vector3 movimiento = new Vector3 (mHorizontal,0,mVertical);
		rb.AddForce (movimiento * velocidad * Time.deltaTime);	}
}
