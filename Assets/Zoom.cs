using UnityEngine;
public class Zoom : MonoBehaviour
{
    float sensitivity = 0.0001f;
    Vector2 f0start;
    Vector2 f1start;
    void Update()
    {
        if (Input.touchCount < 2)
        {
            f0start = Vector2.zero;
            f1start = Vector2.zero;
        }
        if (Input.touchCount == 2) Zooming();
    }
    void Zooming()
    {
        if (f0start == Vector2.zero && f1start == Vector2.zero)
        {
            f0start = Input.GetTouch(0).position;
            f1start = Input.GetTouch(1).position;
        }
        Vector2 f0position = Input.GetTouch(0).position;
        Vector2 f1position = Input.GetTouch(1).position;
        float dir = Mathf.Sign(Vector2.Distance(f1start, f0start) - Vector2.Distance(f0position, f1position));
        transform.position = Vector3.MoveTowards(transform.position, transform.position + transform.forward, dir * sensitivity * Time.deltaTime * Vector3.Distance(f0position, f1position));
    }
}