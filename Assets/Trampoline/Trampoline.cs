using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampoline : MonoBehaviour {
	public Animator TrampolineAnimator;

	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.gameObject.tag == "Player") 
		{
			TrampolineAnimator.SetInteger ("States", 1);
		} 
	}
	void OnTriggerExit2D(Collider2D col2)
	{
		if (col2.gameObject.tag == "Player") 
		{
			TrampolineAnimator.SetInteger ("States", 0);
		}
	}
}
