using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

	public GameObject Explosive;

	// Use this for initialization
	void Start () {
		
	}

	float mSpeed = 6f;

	// Update is called once per frame
	void Update () {
		transform.position += new Vector3 (-mSpeed * Time.deltaTime, 0, 0);
	}

	public void OnCollisionEnter2D(Collision2D col)
	{
		if (col.gameObject.tag == "Wall")
			Destroy (this.gameObject);
		if (col.gameObject.tag == "Player")
			Destroy (col.gameObject);
		if (col.gameObject.tag == "Bullet") {
			Destroy (this.gameObject);
			Instantiate (Explosive, transform.position, Quaternion.identity);
		}
	}
}
