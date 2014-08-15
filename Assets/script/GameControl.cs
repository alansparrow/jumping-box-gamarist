using UnityEngine;
using System.Collections;

public class GameControl : MonoBehaviour {
	public GameObject[] sample;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.position += new Vector3(GameManager.tocDoCamera*Time.deltaTime,0,0);
	}


}
