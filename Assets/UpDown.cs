using UnityEngine;
using System.Collections;

public class UpDown : MonoBehaviour {

	public int up;
	public int max;
	public int min;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (transform.position.y <= min) 
				up = 5;
		else if (transform.position.y >= max)
				up = -5;

		transform.Translate(0,up*Time.deltaTime,0);

	
	}
}
