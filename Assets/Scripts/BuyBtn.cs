using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyBtn : MonoBehaviour {

	[SerializeField]
	private int price;

	[SerializeField]
	private Text priceTxt;

	private void Start() {
		priceTxt.text = price + "$";
	}
}
