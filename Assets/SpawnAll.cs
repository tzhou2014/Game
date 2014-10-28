using UnityEngine;
using System.Collections;

public class SpawnAll : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Instantiate (GameObject.FindGameObjectWithTag("LittleGuySpawn"), new Vector3 (transform.position.x, transform.position.y - 64.5f, transform.position.z - 5.5f), transform.rotation);
		Instantiate (GameObject.FindGameObjectWithTag("LittleGuySpawn"), new Vector3 (transform.position.x, transform.position.y - 57.7f, transform.position.z - 50.9f), transform.rotation);	
		Instantiate (GameObject.FindGameObjectWithTag("LittleGuySpawn"), new Vector3 (transform.position.x, transform.position.y - 57.7f, transform.position.z - 55.1f), transform.rotation);	
	
		Instantiate (GameObject.Find("BigEnemy"), new Vector3 (transform.position.x+0.3f, transform.position.y - 66.1f, transform.position.z - 23.4f), transform.rotation);
		Instantiate (GameObject.Find("BigEnemy"), new Vector3 (transform.position.x+0.3f, transform.position.y - 60f, transform.position.z - 30.4f), transform.rotation);
		Instantiate (GameObject.Find("BigEnemy"), new Vector3 (transform.position.x+0.3f, transform.position.y - 66.1f, transform.position.z - 26.4f), transform.rotation);
		Instantiate (GameObject.Find("BigEnemy"), new Vector3 (transform.position.x+0.3f, transform.position.y - 46.1f, transform.position.z - 38.4f), transform.rotation);
		Instantiate (GameObject.Find("BigEnemy"), new Vector3 (transform.position.x+0.3f, transform.position.y - 46.1f, transform.position.z - 51.4f), transform.rotation);
		Instantiate (GameObject.Find("BigEnemy"), new Vector3 (transform.position.x+0.3f, transform.position.y - 46.1f, transform.position.z - 71.4f), transform.rotation);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
