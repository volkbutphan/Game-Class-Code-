using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

	float bSpeed = 8f;

	// Update is called once per frame
	void Update () {
		Move ();
	}

	public void Move(){
		transform.Translate (bSpeed * Time.deltaTime, 0, 0);
	}

	public void OnCollisionEnter2D(Collision2D col)
	{
		if (col.gameObject.tag == "Wall")
			Destroy (this.gameObject);
		if (col.gameObject.tag == "Hostile")
			Destroy (col.gameObject);
	}


}
