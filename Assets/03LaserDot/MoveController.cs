using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
//https://www.youtube.com/watch?v=wbn7kFVrM4g&list=PLv75qW_zhOpxGC6A5g-XAmb0NLonbSGYm&index=5
[RequireComponent(typeof(Rigidbody))]
public class MoveController : MonoBehaviour
{
    public Vector3 Speed;
    private Mouse_Look Cam;
    private Rigidbody Body;
    private void Start()
    {
        Cam = GameObject.FindWithTag("MainCamera").GetComponent<Mouse_Look>();
        Body = GetComponent<Rigidbody>();
    }
    void Update()
    {
        transform.rotation = Quaternion.Euler(0, Cam.CurrentCoord.y, 0);
        transform.Translate(Vector3.forward * CrossPlatformInputManager.GetAxis("Vertical") * Speed.x * Time.deltaTime);
        transform.Translate(Vector3.right * CrossPlatformInputManager.GetAxis("Horizontal") * Speed.y * Time.deltaTime);
#if false
        if (CrossPlatformInputManager.GetButtonDown("Jump"))
        {
            Body.AddRelativeForce(0, Speed.z * 100, 0);
            Debug.Log("Jump pressed");
        }
#endif
    }
}

