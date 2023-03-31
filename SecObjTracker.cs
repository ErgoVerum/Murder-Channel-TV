using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SecObjTracker : MonoBehaviour
{
	public GameObject CheckMark;
	public Sprite GreenCheckmark,RedCheckmark;
	public float ObjID;
	public string DescriptionText;
	public bool IsConcluded;
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	public void SetObjFinished()
	{
		CheckMark.GetComponent<Image>().sprite = GreenCheckmark;
		IsConcluded = true;
		GameObject.FindGameObjectWithTag("MainObjTracker").GetComponent<ObjTrackerManager>().CheckSecObjs();
	}
}
