using UnityEngine;
using System.Collections;

public class Spawn_script : MonoBehaviour {
	private float spawnTime;
	public float ResetTime;
    public float endingTime;
    private float timerReset;
    public float timer;
    public Rigidbody spawnPoint;
	public Rigidbody2D upArrow;
	public Rigidbody2D downArrow;
	public Rigidbody2D leftArrow;
	public Rigidbody2D rightArrow;
    public AudioSource music;
    private arrow_movement_script Arrowspeed;
    public float pastTimer;

	// Use this for initialization
	void Start () {
		spawnTime = ResetTime;
        timerReset = timer;
        pastTimer = ResetTime;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		spawnTime = spawnTime - 1;
		timer = timer - 1;
        if (spawnTime == 0 && timer > 0)
        {
            float randomNumber = Random.Range(1, 5);
            if (randomNumber == 1)
            {
                Instantiate(upArrow, spawnPoint.position, spawnPoint.transform.rotation);
            }
            else if (randomNumber == 2)
            {
                Instantiate(downArrow, spawnPoint.position, spawnPoint.transform.rotation);
            }
            else if (randomNumber == 3)
            {
                Instantiate(leftArrow, spawnPoint.position, spawnPoint.transform.rotation);
            }
            else if (randomNumber == 4)
            {
                Instantiate(rightArrow, spawnPoint.position, spawnPoint.transform.rotation);
            }
            spawnTime = ResetTime;
        }
        if (timer < 0)
        {
            timer = timerReset;
            ResetTime = ResetTime - 1;
            if (ResetTime < pastTimer - 5)
            {
                pastTimer = ResetTime;
                Arrowspeed.speed = Arrowspeed.speed + 5;

            }
            /* endingTime--;
            if (endingTime == 0)
            {
                music.Stop();
            }
            */

        }	
	}
}
