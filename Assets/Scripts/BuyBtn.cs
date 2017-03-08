using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyBtn : MonoBehaviour {

	[SerializeField]
	private GameObject fishPrefab;

	public GameObject FishPrefab {
		get {
			return fishPrefab;
		}
	}

	[SerializeField]
	private int price;

	public int Price {
		get {
			return price;
		}
	}

	[SerializeField]
	private Text priceTxt;

	private void Start() {
		priceTxt.text = price + "$";
	}
}
