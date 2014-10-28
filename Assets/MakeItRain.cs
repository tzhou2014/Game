using UnityEngine;
using System.Collections;

public class MakeItRain : MonoBehaviour {

	public Object littleEnemy;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {


	
	}

	void OnTriggerEnter(Collider other) {
		if (other.tag == "Player") {
			Vector3 spawnPoint = new Vector3(transform.position.x,transform.position.y+3,transform.position.z-5);
			Instantiate(littleEnemy, spawnPoint, transform.rotation);

			spawnPoint = new Vector3(transform.position.x,transform.position.y+3,transform.position.z-6);
			Instantiate(littleEnemy, spawnPoint, transform.rotation);

			spawnPoint = new Vector3(transform.position.x,transform.position.y+3,transform.position.z-7);
			Instantiate(littleEnemy, spawnPoint, transform.rotation);

			spawnPoint = new Vector3(transform.position.x,transform.position.y+3,transform.position.z-8);
			Instantiate(littleEnemy, spawnPoint, transform.rotation);

			Destroy (gameObject);
				}



	}
}
