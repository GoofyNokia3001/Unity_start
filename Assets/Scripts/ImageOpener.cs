using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageOpener : MonoBehaviour {
    public GameObject beanImg;
    public GameObject omeImg;
    public GameObject lacisImg;
    public GameObject masinaImg;
    public GameObject RightToggle;
    public GameObject LeftToggle;
    public GameObject ImageChanger;
    public Sprite[] ImageArray;
    public void beanImagener(bool On)
    {
        beanImg.SetActive(On);
        LeftToggle.GetComponent<Toggle>().interactable = On;
        RightToggle.GetComponent<Toggle>().interactable = On;
    }
    public void omeImagener(bool On)
    {
        omeImg.SetActive(On);
    }
    public void lacisImagener(bool On)
    {
        lacisImg.SetActive(On);
    }
    public void masinaImagener(bool On)
    {
        masinaImg.SetActive(On);
    }
    public void Left()
    {
        beanImg.transform.localScale = new Vector2(1, 1);
    }
    public void Right()
    {
        beanImg.transform.localScale = new Vector2(-1, 1);
    }
    public void Number(int num) 
    {
        if (num == 0)
        {
            ImageChanger.GetComponent<Image>().sprite = ImageArray[0];
        }
        else if (num == 1)
        {
            ImageChanger.GetComponent<Image>().sprite = ImageArray[1];
        }
        else if (num == 2)
        {
            ImageChanger.GetComponent<Image>().sprite = ImageArray[2];
        }
        else { Debug.Log("No images"); }
    }
}
