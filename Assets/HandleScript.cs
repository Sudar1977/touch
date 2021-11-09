using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

//public class HandleScript : MonoBehaviour, IPointerDownHandler
public class HandleScript : MonoBehaviour, IDragHandler, IBeginDragHandler
{
    private float speed = 0.01f;
    public void OnBeginDrag(PointerEventData eventData)
    {
        if (Mathf.Abs(eventData.delta.x) > Mathf.Abs(eventData.delta.y))
        {
            if (eventData.delta.x > 0) Debug.Log("Right");
            else Debug.Log("Left");
            transform.position += new Vector3(eventData.delta.x*speed, 0, 0);
        }
        else
        {
            if (eventData.delta.y > 0) Debug.Log("Up");
            else Debug.Log("Down");
            transform.position += new Vector3(0, eventData.delta.y*speed, 0);
        }
    }

    public void OnDrag(PointerEventData eventData)
    {
    }


    // Update is called once per frame
    void Update()
    {
        //if (Input.touchCount > 0)
        //{
        //    Debug.Log("Global touch!");
        //    transform.localScale *= 1.001f;
        //}
    }
    //void OnMouseDown()
    //{
    //    Debug.Log("Global touch!");
    //    transform.localScale *= 1.1f;
    //}
    //public void OnPointerDown(PointerEventData eventData)
    //{
    //    Debug.Log(eventData.position);
    //    transform.localScale *= 1.1f;
    //}
}
