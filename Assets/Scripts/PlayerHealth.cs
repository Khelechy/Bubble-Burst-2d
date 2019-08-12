using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour {

	public static PlayerHealth Instance {set; get;}


	public int playerHp = 100;

	void Start(){
		Instance = this;
	}


	public void playerTakeDamage (int damage) {
		playerHp -= damage;

		if (playerHp <= 0) {
			Die ();
		}
	}

	void Die(){
		GameManager.Instance.GameOver();
	}

}