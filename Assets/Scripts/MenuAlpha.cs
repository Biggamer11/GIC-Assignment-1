using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class MenuAlpha : MonoBehaviour
{
    public GameObject MenuObject;
    public float Alpha;

    public void ChangeAlpha()
    {
        MenuObject.GetComponent<CanvasGroup>().alpha = Alpha;
    }
}
