using UnityEngine;
using System.Collections;

public class EnemyAI : MonoBehaviour {

	public string animation1;
	public string animation2;

	// Use this for initialization
	void Start () {
		transform.RotateAround (transform.position, transform.up, 180f);
	
	}
	
	// Update is called once per frame
	void Update () {
		GameObject player = GameObject.FindGameObjectWithTag("Player");
		float distance = transform.position.z - player.transform.position.z;
		if (Mathf.Abs (distance) < 8) {
			animation.Play (animation1);
			transform.Translate (0, 0, 4 * Time.deltaTime);

				} else {
			if (animation.IsPlaying (animation1))
				animation.Stop (animation1);
			animation.Play(animation2);
				}
						
	
	}
}
