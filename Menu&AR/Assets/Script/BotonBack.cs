using UnityEngine;
using System.Collections;

public class BotonBack : MonoBehaviour {

	public RectTransform mainMenuPanel;
	public Animator mainMenuAnimator;

	public void Back(){
		if ((int)mainMenuPanel.localScale.x == 0) {
			mainMenuAnimator.Play("MainMenuFadeIN");
		}
	}

	public void Creditos(){
		Application.LoadLevel ("Creditos");
	}

	public void Marca(){
		Application.LoadLevel ("Marca");
	}

	public void Imagen(){
		Application.LoadLevel ("Imagen");
	}

	public void Botones(){
		Application.LoadLevel ("Botones");
	}
}
