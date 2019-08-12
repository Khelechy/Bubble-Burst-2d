using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

	public static GameManager Instance {set; get;}

	public int thePlayerHealth;
	public Text playerHp;

	void Start(){
		Instance = this;
	}

	void Update () {
		thePlayerHealth = PlayerHealth.Instance.playerHp;
		playerHp.text = thePlayerHealth.ToString();
		Debug.Log (thePlayerHealth);
	}

	public void GameOver(){
		
	}
}