using UnityEngine;
using System.Collections;

public class street : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Camera.main.transform.position.x - this.transform.position.x > 13f)
		{
			this.transform.position += new Vector3(30.0f,0,0);
		}
	}
}
