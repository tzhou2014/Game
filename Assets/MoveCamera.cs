using UnityEngine;
using System.Collections;

public class MoveCamera : MonoBehaviour {

		float lerpTime = 0.1f;
		float currentLerpTime;
		Vector3 startPos;
		Vector3 endPos;
		public GameObject player;
		bool fps;
		float rotationY = 0F;

		/*Taken from standard assets for mouselook*/
		public enum RotationAxes { MouseXAndY = 0, MouseX = 1, MouseY = 2 }
		public RotationAxes axes = RotationAxes.MouseXAndY;
		public float sensitivityX = 15F;
		public float sensitivityY = 15F;
		
		public float minimumX = -360F;
		public float maximumX = 360F;
		
		public float minimumY = -60F;
		public float maximumY = 60F;

		/**/

	
		protected void Start() {
			startPos = transform.position;
			endPos = player.transform.position + new Vector3(0,1.0f,5.0f);
			fps = false;

		/*Taken from standard assets for mouselook*/	
		// Make the rigid body not change rotation
			if (rigidbody)
				rigidbody.freezeRotation = true;
		}
		/**/
		
		protected void Update() {
			
			//reset when we press spacebar
		if (Input.GetMouseButton(1)) {
				startPos = transform.position;
				endPos = player.transform.position+ new Vector3(-0.7f,1.9f,1.3f);
				currentLerpTime = 0f;

				/*Taken from standard assets for mouselook*/
				if (axes == RotationAxes.MouseXAndY)
				{
					float rotationX = transform.localEulerAngles.y + Input.GetAxis("Mouse X") * sensitivityX;
					
					rotationY += Input.GetAxis("Mouse Y") * sensitivityY;
					rotationY = Mathf.Clamp (rotationY, minimumY, maximumY);
					
					transform.localEulerAngles = new Vector3(-rotationY, rotationX, 0);
				}
				else if (axes == RotationAxes.MouseX)
				{
					transform.Rotate(0, Input.GetAxis("Mouse X") * sensitivityX, 0);
				}
				else
				{
					rotationY += Input.GetAxis("Mouse Y") * sensitivityY;
					rotationY = Mathf.Clamp (rotationY, minimumY, maximumY);
					
					transform.localEulerAngles = new Vector3(-rotationY, transform.localEulerAngles.y, 0);
				}
				
				/**/
				}
		else{
				startPos = transform.position;
				endPos =  player.transform.position + new Vector3(0,3.0f,5.0f);
			currentLerpTime = 0f;
			}
				
			currentLerpTime += Time.deltaTime;
			if (currentLerpTime > lerpTime) {
				currentLerpTime = lerpTime;
			}
			
			//lerp!
			float perc = currentLerpTime / lerpTime;
			transform.position = Vector3.Lerp(startPos, endPos, perc);
			
		}
	}
