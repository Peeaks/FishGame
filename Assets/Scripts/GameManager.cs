using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class GameManager : Singleton<GameManager> {

	[SerializeField]
	private int money;

	[SerializeField]
	private Text moneyText;

	[SerializeField]
	private GameObject fishFood;

	public int Money {
		get {
			return money;
		}
		set {
			this.money = value;
			this.moneyText.text = value.ToString () + "<color=lime>$</color>";
		}
	}

	// Use this for initialization
	void Start () {
		Money = money;
	}
	
	// Update is called once per frame
	void Update () {
		DropFood ();
	}

	public void BuyFish(BuyBtn buyBtn) {
		if (Money >= buyBtn.Price) {
			Money -= buyBtn.Price;
			Instantiate (buyBtn.FishPrefab, new Vector3 (0, 0, 0), Quaternion.identity);
		}
	}

	private void DropFood() {
		//Change this so it doesnt drop food when clicked on button, but does when clicked on fish
		if (!EventSystem.current.IsPointerOverGameObject ()) {
			if (Input.GetMouseButtonDown(0)) {
				Vector3 clickPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
				clickPos.z = 0;
				Instantiate(fishFood, clickPos, Quaternion.identity);
			}
		}
	}

}
