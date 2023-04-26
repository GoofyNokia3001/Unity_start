using System.Collections;
using System.Collections.Generic;

using UnityEngine;
//Import to use pointer interface

using UnityEngine.EventSystems;

//Define interface

public class ObjectMovement : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IDragHandler, IEndDragHandler
{
	private RectTransform transformComponent;
	public Canvas canva;
	void Start()
	{
		transformComponent = GetComponent<RectTransform>();
	}

	public void OnPointerDown(PointerEventData eventData) 
	{
		Debug.Log("Lol Event OnPointerDown"); 
	}

	public void OnBeginDrag(PointerEventData eventData) 
	{
		Debug.Log("Lol Event OnBeginDrag"); 
	}

	public void OnDrag(PointerEventData eventData)
		{
		Debug.Log("Lol Event OnDrag");
		transformComponent.anchoredPosition += eventData.delta / canva.scaleFactor;
		}

    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("Lol Event OnEndDrag");
    }

}
