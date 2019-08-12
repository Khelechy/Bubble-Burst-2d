using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirePower : MonoBehaviour {

	[HeaderAttribute ("Player Gun Variables")]
	public Transform firePoint; //Point of emergence of the bullets
	public GameObject bulletPrefab; //Bullet prefab
	public ParticleSystem shootEffect; //Shoot Effect

	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Fire1")) {
			Shoot ();
		}

	}

	void Shoot () {

		Instantiate (bulletPrefab, firePoint.position, firePoint.rotation);
		shootEffect.Play ();

	}
}