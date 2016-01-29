using UnityEngine;
using System.Collections;

public class ChangerScript : MonoBehaviour {

	public enum PropType {Background, Prop1, Prop2}

	public PropType prop;

	public void ChangeProp()
	{
		switch (prop) 
		{
		case PropType.Background:
			//TO-DO Change background
			Debug.Log("true");
			gameObject.GetComponent<SpriteRenderer>().color = Color.green;

			break;
		case PropType.Prop1:
			//TO-DO Change prop1 sprite

			break;
		case PropType.Prop2:
			//TO-DO Change prop2 sprite

			break;
		}
	}
}
