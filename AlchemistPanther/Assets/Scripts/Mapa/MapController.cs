using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class MapController : MonoBehaviour {

	List<GameObject> propsInLevel = new List<GameObject>();

	void Awake()
	{
		GetPropsInLevel ();
	}

	void Update()
	{
		if (Input.GetKeyDown (KeyCode.H)) 
		{
			ChangePropsInLevel ();
		}
	}

	void GetPropsInLevel()
	{
		propsInLevel.Clear ();
		propsInLevel = GameObject.FindGameObjectsWithTag("Props").ToList();
	}

	void ChangePropsInLevel()
	{
		Debug.Log (propsInLevel);

		for(int i = 0; i < propsInLevel.Count; i++)
		{
			propsInLevel [i].GetComponent<ChangerScript>().ChangeProp();
		}
	}
}
