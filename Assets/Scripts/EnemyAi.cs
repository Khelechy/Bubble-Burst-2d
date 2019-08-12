using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAi : MonoBehaviour {

	[HeaderAttribute ("Enemy Variables")]
	public float speed; //speed of the enemy
	public int health = 5; //healh of the enemy

	[HeaderAttribute ("Enemy AI Variables")]
	public float stoppingDistance;  //distance before enemy stops coming to player
	public float retreatDistance; //Distance for enemy to retreat when player coming close

	[HeaderAttribute ("Enemy Shooting Variables")]
	private float timeBtwShots; //time between each shot made
	public float startTimeBtwShots; //Initial start shooting to reset back to 0
	public GameObject bullet;  // Game object of the bullet prefab
	public Transform firePoint; //point at which the bullet emerges from
	public Transform player; //Transform of the player


	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player").transform;

		timeBtwShots = startTimeBtwShots;

	}

	void Update () {
		//Code to Make Enemy Retreat or follow player
		if (Vector2.Distance (transform.position, player.position) > stoppingDistance) {
			transform.position = Vector2.MoveTowards (transform.position, player.position, speed * Time.deltaTime);
		} else if (Vector2.Distance (transform.position, player.position) < stoppingDistance && Vector2.Distance (transform.position, player.position) > retreatDistance) {
			transform.position = this.transform.position;
		} else if (Vector2.Distance (transform.position, player.position) < retreatDistance) {
			transform.position = Vector2.MoveTowards (transform.position, player.position, -speed * Time.deltaTime);
		}
		
		//Code to Shoot Player at intervals
		if (timeBtwShots <= 0) {

			Instantiate (bullet, firePoint.position, Quaternion.identity);
			timeBtwShots = startTimeBtwShots;

		} else {
			timeBtwShots -= Time.deltaTime;
		}
	}

	public void TakeDamage (int damage) {
		health -= damage;

		if (health <= 0) {
			Die ();
		}
	}

	void Die () {
		Destroy (gameObject);

	}
}