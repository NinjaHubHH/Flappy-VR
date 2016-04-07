using UnityEngine;
using System.Collections;

public class ObstacleManager : MonoBehaviour {

	public GameObject obstacle;


	// Use this for initialization
	void Start () {

		InvokeRepeating ("createObstacle",0f, 3f);
	
	}
	
	// Update is called once per frame
	void Update () {
	
	
	}

	void createObstacle(){
		Vector3 randomPosition = new Vector3(transform.position.x, Mathf.Clamp(Random.Range(-1f, 3.3f), 0.7f,3.2f), 0f);
		Instantiate (obstacle, randomPosition, Quaternion.identity);

	}
}	
