using UnityEngine;
using System.Collections;

public class PlayerCharacter : MonoBehaviour {

	public int health = 5;
	public GameObject text1;
	public GameObject text2;
	public GameObject heart;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (health <= 0 || transform.position.y <= -30) {	
			GameObject player = GameObject.FindGameObjectWithTag ("Player");
			GameObject spawn = GameObject.FindGameObjectWithTag ("Respawn");
			player.transform.position = (spawn.transform.position);
			GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
			for(int j=0;j<enemies.Length-1;j++)
				Destroy (enemies[j]);
			health=5;
			rigidbody.velocity = transform.TransformDirection(0,0,0);
			Instantiate (GameObject.FindGameObjectWithTag("Respawn"), new Vector3 (7.4f, 75, 20.4f), transform.rotation);
				}

		if (transform.position.y > 25 && transform.position.y <= 75)
						text1.renderer.enabled = true;
				else
						text1.renderer.enabled = false;
		if (transform.position.y > 25 && transform.position.y <= 55)
			text2.renderer.enabled = true;
		else
			text2.renderer.enabled = false;

		float displayHealth = 0;
		GameObject[] hearts = GameObject.FindGameObjectsWithTag("Heart");
		for(int j=0;j<hearts.Length-1;j++)
			Destroy(hearts[j]);

		for (int i=0;i<health; i++) {
			Instantiate(heart,new Vector3((0.5f+displayHealth),0.97f,0), transform.rotation);
			displayHealth += 0.05f;
		}
		
		
	}

	void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.layer==9) {
			health -= 1;
		}
	}

	void OnTriggerEnter(Collider other) {
		if (other.tag=="Finish") {
			if (Application.loadedLevelName == "Level1")
				Application.LoadLevel("Level2");
			else
				Application.LoadLevel("Level3");
				}

						
	}

}
