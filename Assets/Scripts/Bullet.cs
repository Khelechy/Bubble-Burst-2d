using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

	// Use this for initialization


	[HeaderAttribute("Bullet Attributes")]
	public float speed = 20f; // speed of the bullet
	public int damage = 1; // damage made by bullet
	public Rigidbody2D rb; //Rigidbody of the bullet

	public GameObject dieEffect; // Death Effect masw by the bullet

	void Start () {
		rb.velocity = transform.right * speed;

	}

	void OnTriggerEnter2D (Collider2D collider) {

		//On hitting the enemy
		EnemyAi enemy = collider.GetComponent<EnemyAi> ();
		if (enemy != null) {
			enemy.TakeDamage (damage);
			CameraShake.Instance.Shake ();
			Instantiate(dieEffect, transform.position, transform.rotation);
		}
		Destroy (gameObject);
	}

}