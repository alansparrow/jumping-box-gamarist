using UnityEngine;
using System.Collections;

public class Box : MonoBehaviour {

	// Use this for initialization

	float moveCamera =0;

	void Start () {
		moveCamera = this.transform.position.x;
	}
	
	// Update is called once per frame
	void Update () {

		//Camera.main.transform.Translate (new Vector3(this.transform.position.x-moveCamera,0,0));
		//moveCamera = this.transform.position.x;

		this.transform.position += new Vector3(GameManager.tocDoCamera * Time.deltaTime * 2,0,0);

		if(this.transform.position.x - Camera.main.transform.position.x > 12f)
		{
			this.transform.position += new Vector3(-22f, 2f,0);
		}

		if (!GameManager.isSliding) {
			this.transform.Rotate(new Vector3(0,1,0),170*Time.deltaTime);

		}
	}


	void OnCollisionEnter(Collision collision) {
		if (collision.gameObject.tag == "Line") {
			print("Collison");
			GameManager.isSliding = true;
		}
	}
	void OnTouchDown() {
		print ("Down");
	}

	void OnTouchUp() {
		print ("Up");
	}

	void OnTouchStay() {
		print ("Stay");
	}

	void OnTouchExit() {
		print ("Exit");
	}
}
