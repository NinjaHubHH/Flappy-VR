using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	Vector3 forceUp = new Vector3(0,200,0);
	Vector3 resetVector = new Vector3 (0, 0, 0);
	Rigidbody playerRigidbody;

	// Use this for initialization
	void Start () {
		playerRigidbody = GetComponent<Rigidbody> ();
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("space")) {

			playerRigidbody.velocity = resetVector;
			playerRigidbody.AddForce (forceUp);
		}
	}

	void OnCollisionEnter(Collision collision){

		Die();
	}

	void Die(){

		Application.LoadLevel (Application.loadedLevel);
	}
}
