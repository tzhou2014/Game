using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour {

	Animator anim;
	bool inAir = false;
	int count = 0;
	public Rigidbody bullet;
	public GameObject text1;
	public GameObject text2;
	RaycastHit hit;
	public float directionZ = 0;
	public float directionX = 0;
	public GameObject thecamera;

	// Use this for initialization
	void Start () {

		anim = GetComponent<Animator>();
	}
	

	// Update is called once per frame
	void Update () {
		float inputVert = Input.GetAxis ("Vertical");
		float inputHor = Input.GetAxis ("Horizontal");
		inputHor = -inputHor;


		float z = inputVert * Time.deltaTime * 7;
		float x = inputHor * Time.deltaTime * 7;
		anim.SetFloat("Speed", Mathf.Max(Mathf.Abs (inputVert),Mathf.Abs (inputHor)));

		if (z < 0 && directionZ != -1 && transform.position.y < 25) {
						transform.Rotate (0, 180, 0, Space.World);
						thecamera.transform.RotateAround (transform.position, Vector3.up, 180);
						directionZ = -1;
				} else if (z > 0 && directionZ != 1 && transform.position.y < 25) {
						transform.Rotate (0, 180, 0, Space.World);
						thecamera.transform.RotateAround (transform.position, Vector3.up, 180);
						directionZ = 1;
				} else if (z == 0) {
					//directionZ = 0;
				}


		if (x < 0 && directionX != -1 && transform.position.y < 25) {
						directionX = -1;
			xRotate ();
				} else if (x > 0 && directionX != 1 && transform.position.y < 25) {
						directionX = 1;
			xRotate ();
				} else if (x == 0) {
						//directionX = 0;
				}
						


			
		if (Input.GetKey ("space")) {
						if (inAir && count < 30)
						{
							transform.Translate (0, 8 * Time.deltaTime, 0);
							anim.SetBool("Jumping",true);
						}
						else if (!inAir){
									inAir = true;
									transform.Translate (0, 8 * Time.deltaTime, 0);
								}
								
						count += 1;
				} 

		if (z > 0 || z < 0 || x > 0|| x < 0 && transform.position.y < 25) {	
			transform.Translate (0, 0, z*directionZ);
			transform.Translate (x, 0, 0,Space.World);

				} 

		if (Input.GetMouseButton(0)) {
			Rigidbody clone;
			Vector3 bulletPlace = new Vector3(transform.position.x,transform.position.y+1.5f,transform.position.z-(0.7f*directionZ));
			clone = Instantiate(bullet, bulletPlace, transform.rotation) as Rigidbody;
			clone.transform.RotateAround (clone.transform.position, new Vector3(1,0,0), 90f);
			if (directionZ < 0)
			{
				clone.velocity = transform.TransformDirection(0,-10,-30);
			}
			else
			{
			}

				clone.velocity = transform.TransformDirection(0,0,30);
		}

	}

	void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.layer==8) {
						anim.SetBool("Jumping",false);
						inAir = false;
						count = 0;
				}
	}

	void xRotate()
	{
		if (directionX == directionZ) {
						transform.Rotate (0, -45, 0, Space.World);
						thecamera.transform.RotateAround (transform.position, Vector3.up, 45);
				} else if (directionX == -directionZ) {
						transform.Rotate (0, 45, 0, Space.World);
						thecamera.transform.RotateAround (transform.position, Vector3.up, -45);
		} 			else if (directionZ == 0) {
						transform.Rotate (0, -90*directionX, 0, Space.World);
						thecamera.transform.RotateAround (transform.position, Vector3.up, 90*directionX);
				}
	}

	
}

