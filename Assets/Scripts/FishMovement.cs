using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishMovement : MonoBehaviour {

	[SerializeField]
	private float speed;

	private Vector3 oldPos;
	private Vector2 waypoint;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		CheckForWaypoint ();
		MoveToWaypoint ();

	}

	// This method checks if the fishes old position is equal to its current position
	// Is this is the case it will create a new random waypoint
	private void CheckForWaypoint() {
		if (oldPos != null && oldPos == transform.position) {
			//Create new waypoint
			waypoint = new Vector3(Random.Range(-8, 8), Random.Range(-4, 4));
		}

		oldPos = transform.position;
	}

	// This method moves the fish towards the waypoint variable
	private void MoveToWaypoint() {
		transform.position = Vector2.MoveTowards(new Vector2(transform.position.x, transform.position.y), waypoint, speed * Time.deltaTime);
	}

}
