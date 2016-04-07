using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	Vector3 forceUp = new Vector3(0,200,0);
	Vector3 resetVector = new Vector3 (0, 0, 0);
	Rigidbody playerRigidbody;
    Animator animator;

	// Use this for initialization
	void Start () {
		playerRigidbody = GetComponent<Rigidbody> ();
        animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("space")) {
            animator.SetBool("Fly", true);
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
