using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MenuNavigationScript : MonoBehaviour {
	
	public RectTransform mainMenuPanel;    //reference for MainMenupanel
	public Animator mainMenuAnimator;   //Animator reference
	
	// Update is called once per frame
	public void Back () {
		if((int)mainMenuPanel.localScale.x==0){ //check if scale of MainMenu Panel is 0
			mainMenuAnimator.Play("MainMenuFadeIn"); //play fade in animation
		}
	}
}