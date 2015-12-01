using UnityEngine;
using System.Collections.Generic;
using Vuforia;

public class Botones : MonoBehaviour, IVirtualButtonEventHandler {

	public GameObject Verde;
	public GameObject Rojo;
	public GameObject Azul;

	// Use this for initialization
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
		case "rojo":
			Rojo.active = true;
			Verde.active = false;
			Azul.active = false;
			break;
		case "verde":
			Rojo.active = false;
			Verde.active = true;
			Azul.active = false;
			break;
		case "azul":
			Rojo.active = false;
			Verde.active = false;
			Azul.active = true;
			break;
		}
	}
	public void OnButtonReleased(VirtualButtonAbstractBehaviour vb)
	{
		
	}
}
