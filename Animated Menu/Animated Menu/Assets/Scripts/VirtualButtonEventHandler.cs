using UnityEngine;
using System.Collections.Generic;
using Vuforia;

public class VirtualButtonEventHandler : MonoBehaviour, IVirtualButtonEventHandler {
	

	// Use this for initialization
	public GameObject bulbashur;
	public GameObject charmander;
	private GameObject pokemon;
	void Start () {
		VirtualButtonBehaviour[] vbs = GetComponentsInChildren<VirtualButtonBehaviour> ();
		for (int i = 0; i < vbs.Length; ++i) {
			vbs [i].RegisterEventHandler (this);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnButtonPressed(VirtualButtonAbstractBehaviour vb)
	{
		Debug.Log("OnButtonPressed::" + vb.VirtualButtonName);
		switch (vb.VirtualButtonName) {
		case "Rojo":
			bulbashur.transform.position = new Vector3(-5000,160,21);
			charmander.transform.position = new Vector3(134,160,21);
			charmander.transform.localScale = new Vector3(40,40,40);
			break;
		case "Verde":
			charmander.transform.position = new Vector3(-5000,160,21);
			bulbashur.transform.position = new Vector3(134,160,21);
			bulbashur.transform.localScale = new Vector3(40,40,40);
			break;
		}



	}

	public void OnButtonReleased(VirtualButtonAbstractBehaviour vb)
	{

	}
}
