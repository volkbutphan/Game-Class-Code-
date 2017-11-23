using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour {

	public GameObject Enemy;
	public GameObject Bullet;

	// Use this for initialization
	void Start () {
		//InvokeRepeating()
		InvokeRepeating ("CreateEnemy", 4f, 1f);
		
	}

	float mSpeed = 3f;
	// Update is called once per frame
	void Update () {
		MoveControl ();
		Shoot ();
	}

	public void MoveControl(){
		if (Input.GetKey (KeyCode.A))
			transform.position += new Vector3 (-mSpeed * Time.deltaTime, 0, 0);
		if (Input.GetKey (KeyCode.D))
			transform.position += new Vector3 (mSpeed * Time.deltaTime, 0, 0);
		if (Input.GetKey (KeyCode.S))
			transform.position += new Vector3 (0, -mSpeed * Time.deltaTime, 0);
		if (Input.GetKey (KeyCode.W))
			transform.position += new Vector3 (0, mSpeed * Time.deltaTime, 0);
		
		}

	public void Shoot(){
		if (Input.GetKeyDown (KeyCode.J))
			
			//Instantiate (Object ,position that gonna create the objecy, Quaternion.identity);
			Instantiate (Bullet, transform.position, Quaternion.identity);
	}

		
	public void OnCollisionEnter2D(Collision2D col){
		if (col.gameObject.tag == "Hostile")
			Destroy (this.gameObject);
	}

	public void CreateEnemy(){
		float yRandom = Random.Range (-5f, 5f);

		//Instantiate (Object ,position that gonna create the objecy, Quaternion.identity);
		Instantiate (Enemy, new Vector3 (12, yRandom, 0), Quaternion.identity);
	}
}
