using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager> {

	[SerializeField]
	private int currency;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void BuyFish(GameObject fishPrefab) {
		Instantiate (fishPrefab, new Vector3 (0, 0, 0), Quaternion.identity);
	}

}
