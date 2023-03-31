using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjTrackerManager : MonoBehaviour
{
	public GameObject MainObj,SecObjInstance;
	public Sprite Positive,Negative;
	public bool IsPositive;	

	private float YCanvasPos;
	private List<GameObject> SecObjList;
	
    void Start()
    {
		
    }
		public void ChangeStatusMainObj()
{
		Image CheckmarkSlot = GameObject.Find("M Obj Checkmark").GetComponent<Image>();
		if(IsPositive)
	{
		CheckmarkSlot.sprite = Positive;
	}
		else
	{
		CheckmarkSlot.sprite = Negative;
	}
	/*The script will be kept like this, in case the Main Objective can be set back to incomplete. If that's not the case, remove the "if" and "else" and enable this:
	CheckmarkSlot.sprite = Positive; And write whatever you want after
	*/
}

		public void AddSecObjs()
	{
		foreach(GameObject SecObjObject in GameObject.FindGameObjectsWithTag("SecondaryObj")) 
		{ 
             SecObjList.Add(SecObjObject);
        }
	}
		public void CheckSecObjs()
		{
				float TempFloat = 0;
				foreach(GameObject SecObjObject in SecObjList)
			{
				if(!SecObjObject.GetComponent<SecObjTracker>().IsConcluded)
				{
					TempFloat++;
				}
			}
				if(TempFloat == 0)
			{
				ChangeStatusMainObj();
			}
		}
}
