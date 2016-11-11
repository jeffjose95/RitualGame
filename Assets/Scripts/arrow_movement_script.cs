using UnityEngine;
using System.Collections;

public class arrow_movement_script : MonoBehaviour {
	public float speed;
	public Rigidbody2D playerRigidBody;
	

	// Use this for initialization
	void Start () {
        speed = playerRigidBody.transform.position.x;
        playerRigidBody.velocity = new Vector2(-speed,0);

    }

    // Update is called once per frame
    void Update () {
		
		
	
        }
	void OnTriggerEnter2D (Collider2D otherObj){
        if (otherObj.gameObject.tag == "BreakLine" && this.gameObject.tag == "UpArrow" && Input.GetKey(KeyCode.UpArrow))
        {

            Destroy(this.gameObject);
        }
        if (otherObj.gameObject.tag == "BreakLine" && this.gameObject.tag == "DownArrow" && Input.GetKey(KeyCode.DownArrow))
        {

            Destroy(this.gameObject);
        }
        if (otherObj.gameObject.tag == "BreakLine" && this.gameObject.tag == "LeftArrow" && Input.GetKey(KeyCode.LeftArrow))
        {

            Destroy(this.gameObject);
        }
        if (otherObj.gameObject.tag == "BreakLine" && this.gameObject.tag == "RightArrow" && Input.GetKey(KeyCode.RightArrow))
        {

            Destroy(this.gameObject);
        }
    
        if (otherObj.gameObject.tag == "Destroyer") {
			Destroy(this.gameObject);
		}
       
	}
}
