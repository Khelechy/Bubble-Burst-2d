using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour {

	public float speed; //Speed of enemy bullet

	private Transform player; //Transform of the target([player])
	private Vector2 target; //Player position

	public int PlayerDamage = 2;

	public GameObject dieEffect;

	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player").transform;

		target = new Vector2 (player.position.x, player.position.y);
	}

	void Update () {
		//Code to make bullet follow player until it gets to player initial position
		transform.position = Vector2.MoveTowards (transform.position, target, speed * Time.deltaTime);

		if (transform.position.x == target.x && transform.position.y == target.y) {
			DestroyBullet ();
		}
	}

	void OnTriggerEnter2D (Collider2D other) {
		PlayerHealth pHp = other.GetComponent<PlayerHealth> ();
		if (other.CompareTag ("Player") || other.CompareTag ("TileMap")) {
			if (other.CompareTag ("Player")) {
				pHp.playerTakeDamage(PlayerDamage);
			}
			Instantiate (dieEffect, transform.position, transform.rotation);
			DestroyBullet ();

		}

	}

	void DestroyBullet () {
		Destroy (gameObject);
	}
}