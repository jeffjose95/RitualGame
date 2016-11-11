using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class button_Script : MonoBehaviour {
    public Button theButton;
    
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update ()
    {

	}
    public void LoadScene(int level)
    {
        Application.LoadLevel(level);
    }
}
