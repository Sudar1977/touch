using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

[AddComponentMenu("Spawn/Spawn On Button")]
public class SpawnOnButton : MonoBehaviour
{
	public GameObject objectToSpawn;
	public string buttonName = "Fire1";

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		if(CrossPlatformInputManager.GetButtonDown(buttonName))
		{
			Instantiate(objectToSpawn,transform.position,transform.rotation);
		}
	}
}
