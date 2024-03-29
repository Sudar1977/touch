using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
//https://www.youtube.com/watch?v=wbn7kFVrM4g
public class Mouse_Look : MonoBehaviour
{
    public float Smoothness = 4; 
    public  Vector2 Sensitivity = new Vector2(4, 4); 
    private Vector2 NewCoord;
    [HideInInspector]
    public  Vector2 CurrentCoord;
    public  Vector2 Limit = new Vector2(-70, 80);
    private Vector2 vel;

    public string AxisNameY = "Mouse Y";
    public string AxisNameX = "Mouse X";
    public string CameraName = "MainCamera";


    private void Awake()
    {
        gameObject.tag = CameraName;
    }
    void Update()
    { 
        NewCoord.x = Mathf.Clamp(NewCoord.x, Limit.x,Limit.y);
        NewCoord.x -= CrossPlatformInputManager.GetAxis(AxisNameY) *Sensitivity.x;
        NewCoord.y += CrossPlatformInputManager.GetAxis(AxisNameX) *Sensitivity.y;
        CurrentCoord.x = Mathf.SmoothDamp(CurrentCoord.x, NewCoord.x, ref vel.x, Smoothness/100);
        CurrentCoord.y = Mathf.SmoothDamp(CurrentCoord.y, NewCoord.y, ref vel.y, Smoothness/100); 
        transform.rotation=Quaternion.Euler(CurrentCoord.x, CurrentCoord.y, 0);
    }
}
