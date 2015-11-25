using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Mover : MonoBehaviour {

	public GameObject miCanvas;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void animacionMenu(){
		miCanvas.GetComponent<Animator> ().enabled = true;
	}
}
