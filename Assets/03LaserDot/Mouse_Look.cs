using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
public class Mouse_Look : MonoBehaviour
{
    public float Smoothness = 4; 
    public  Vector2 Sensitivity = new Vector2(4, 4); 
    private Vector2 NewCoord;
    [HideInInspector]
    public  Vector2 CiurentCoord;
    public  Vector2 Limit = new Vector2(-70, 80);
    private Vector2 vel;
    void Update()
    { 
        NewCoord.x = Mathf.Clamp(NewCoord.x, Limit.x,Limit.y);
        NewCoord.x -= CrossPlatformInputManager.GetAxis("Vertical") *Sensitivity.x;
        NewCoord.y += CrossPlatformInputManager.GetAxis("Horizontal") *Sensitivity.y;
        CiurentCoord.x = Mathf.SmoothDamp(CiurentCoord.x, NewCoord.x, ref vel.x, Smoothness/100);
        CiurentCoord.y = Mathf.SmoothDamp(CiurentCoord.y, NewCoord.y, ref vel.y, Smoothness/100); 
        transform.rotation=Quaternion.Euler(CiurentCoord.x, CiurentCoord.y, 0);
    }
}
