using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class ActivateMonoBehaviourOnButton : MonoBehaviour
{
	public Behaviour[] componentsToActivate;
	public string buttonName = "Fire1";

	private bool componentsActive = false;

	// Update is called once per frame
	void Update ()
	{
		if(CrossPlatformInputManager.GetButton(buttonName))
		{
			foreach(Behaviour com in componentsToActivate)
			{
				com.enabled = true;
			}
			componentsActive = true;
		}
		else if(componentsActive == true)
		{
			foreach(Behaviour com in componentsToActivate)
			{
				com.enabled = false;
			}
			componentsActive = false;
		}
	}
}
