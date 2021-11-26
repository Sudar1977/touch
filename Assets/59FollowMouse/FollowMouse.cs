using UnityEngine;
using System.Collections;

//https://ru.stackoverflow.com/questions/1066971/screentoworldpoint-%D0%B2%D0%BE%D0%B7%D0%B2%D1%80%D0%B0%D1%89%D0%B0%D0%B5%D1%82-%D0%BA%D0%BE%D0%BE%D1%80%D0%B4%D0%B8%D0%BD%D0%B0%D1%82%D1%8B-%D0%BA%D0%B0%D0%BC%D0%B5%D1%80%D1%8B-%D0%BF%D1%80%D0%B8-%D0%BF%D0%B0%D1%80%D0%B0%D0%BC%D0%B5%D1%82%D1%80%D0%B5-input-mousepositio
//https://gamedevbeginner.com/how-to-convert-the-mouse-position-to-world-space-in-unity-2d-3d/#click_object_3d

public class FollowMouse : MonoBehaviour
{
	public float distance = 1.0f;
	public bool useInitalCameraDistance = false;

	private float actualDistance;

	// Use this for initialization
	void Start ()
	{
		if(useInitalCameraDistance)
		{
			Vector3 toObjectVector = transform.position - Camera.main.transform.position;
			Vector3 linearDistanceVector = Vector3.Project(toObjectVector,Camera.main.transform.forward);
			actualDistance = linearDistanceVector.magnitude;
		}
		else
		{
			actualDistance = distance;
		}
	}
	
	// Update is called once per frame
	void Update ()
	{

		Vector3 mousePosition = Input.mousePosition;
		mousePosition.z = actualDistance;
		transform.position = Camera.main.ScreenToWorldPoint(mousePosition);
	}
}
