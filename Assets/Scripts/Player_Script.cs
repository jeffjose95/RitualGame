using UnityEngine;
using System.Collections;

public class Player_Script : MonoBehaviour {
	private Animator animator;
	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (Input.GetKeyDown(KeyCode.LeftArrow)) 
		{
			animator.SetTrigger ("TriggerLeft");
		}
		else if (Input.GetKeyDown(KeyCode.RightArrow)) 
		{
			animator.SetTrigger ("TriggerRight");
		}
		else if (Input.GetKeyDown(KeyCode.UpArrow)) 
		{
			animator.SetTrigger ("TriggerBack");
		}
		else if (Input.GetKeyDown(KeyCode.DownArrow)) 
		{
			animator.SetTrigger ("TriggerFront");
		}
	}
}
