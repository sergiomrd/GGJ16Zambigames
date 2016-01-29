using UnityEngine;
using System.Collections;

public class ChangerScript : MonoBehaviour {

	public enum PropType {Background, Prop1, Prop2}

	public PropType prop;

	private SpriteRenderer spriteRender;

	public void ChangeProp(bool transformed)
	{
		switch (prop) 
		{
		case PropType.Background:
			//TO-DO Change background
			if (!transformed) {
				gameObject.GetComponent<SpriteRenderer> ().color = Color.green;
			} else {
				gameObject.GetComponent<SpriteRenderer> ().color = Color.white;
			}


			break;
		case PropType.Prop1:
			//TO-DO Change prop1 sprite

			if (!transformed) {
				gameObject.GetComponent<SpriteRenderer>().color = Color.blue;
			} else {
				gameObject.GetComponent<SpriteRenderer> ().color = Color.white;
			}

			break;
		case PropType.Prop2:
			//TO-DO Change prop2 sprite
			if (!transformed) {
				gameObject.GetComponent<SpriteRenderer>().color = Color.cyan;
			} else {
				gameObject.GetComponent<SpriteRenderer> ().color = Color.white;
			}

			break;
		}
	}
}
