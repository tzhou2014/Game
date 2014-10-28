using UnityEngine;
using System.Collections;

public class Look : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	public Transform straight;
	
	// Update is called once per frame
	void Update () {
		this.transform.LookAt( straight ) ;
	
	}
}
