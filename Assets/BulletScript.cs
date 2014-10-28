using UnityEngine;
using System.Collections;

public class BulletScript : MonoBehaviour {

	public float start; 

	// Use this for initialization
	void Start () {
		start = Time.time;
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Time.time-start > 5)
			Destroy (gameObject);
	
	}

	void OnCollisionEnter(Collision collision)
	{
		Destroy (gameObject);
	}

	void OnTriggerEnter(Collider other) {
		Destroy(other.gameObject);
		Destroy (gameObject);
	}
}
