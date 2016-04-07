using UnityEngine;
using System.Collections;

public class Obstacle : MonoBehaviour {

	public float velocityInXValue = 100;
	Vector3 velocityInX;
	// Use this for initialization
	void Start () {

		velocityInX = new Vector3 (-velocityInXValue, 0, 0);

	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (velocityInX*Time.deltaTime);
	}
}
