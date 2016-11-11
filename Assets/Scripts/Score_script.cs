using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;

public class Score_script : MonoBehaviour
{
    public string output;
    public int score;
    public int maxScore;
    public int rainScore;
    public Text panel;
    public Text winlose;
    public Score_script breakLine;
    public Score_script Destroyer;
    public GameObject Clouds;
    public int maxDarkness;
    private SpriteRenderer CloudsRenderer;
    public ParticleSystem CloudParticles;
    // Use this for initialization
    void Awake()
    {
        CloudParticles.Stop();
    }
    void Start()
    {
       CloudsRenderer =  Clouds.GetComponent<SpriteRenderer>();
        score = 1;
        maxScore = 1;
     //   UpdateScore();
        maxDarkness = 255;
    }
    void Update()
    {
        CloudsRenderer.color = new Color(maxDarkness, maxDarkness, maxDarkness);
    }
    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D otherObj)
    {
        if (this.gameObject.tag == "BreakLine" && otherObj.gameObject.tag == "UpArrow" && Input.GetKey(KeyCode.UpArrow))
        {
            addScore();
            Destroyer.score = breakLine.score;
            Destroyer.maxScore = breakLine.maxScore;
        }
        if (this.gameObject.tag == "BreakLine" && otherObj.gameObject.tag == "DownArrow" && Input.GetKey(KeyCode.DownArrow))
        {
            addScore();
            Destroyer.score = breakLine.score;
            Destroyer.maxScore = breakLine.maxScore;
        }
        if (this.gameObject.tag == "BreakLine" && otherObj.gameObject.tag == "LeftArrow" && Input.GetKey(KeyCode.LeftArrow))
        {
            addScore();
            Destroyer.score = breakLine.score;
            Destroyer.maxScore = breakLine.maxScore;
        }
        if (this.gameObject.tag == "BreakLine" && otherObj.gameObject.tag == "RightArrow" && Input.GetKey(KeyCode.RightArrow))
        {
            addScore();
            Destroyer.score = breakLine.score;
            Destroyer.maxScore = breakLine.maxScore;
        }





        if (this.gameObject.tag == "Destroyer" && otherObj.gameObject.tag == "UpArrow")
        {
            minusScore();
            breakLine.score = Destroyer.score;
        }
        if (this.gameObject.tag == "Destroyer" && otherObj.gameObject.tag == "DownArrow" )
        {
            minusScore();
            breakLine.score = Destroyer.score;

        }
        if (this.gameObject.tag == "Destroyer" && otherObj.gameObject.tag == "LeftArrow" )
        {
            minusScore();
            breakLine.score = Destroyer.score;

        }
        if (this.gameObject.tag == "Destroyer" && otherObj.gameObject.tag == "RightArrow" )
        {
            minusScore();
            breakLine.score = Destroyer.score;

        }

        if (score > (rainScore / 2))
        {
            Clouds.transform.position.Set(1, 3, 0);
        }
        if (score > rainScore)
        {
           
            CloudParticles.Play();
        }
        else
        {
            CloudParticles.Stop();
        }
    }
    public void minusScore()
    {
        if (score > 5)
        {
        //    maxScore = maxScore;
            score = score - 5;
        }
        else
        {
        Application.LoadLevel(2);
    
}
        UpdateScore();
    }
    public void addScore()
    {
        score++;
        if (score > maxScore)
        {
            maxScore = score;
        }
        UpdateScore();
    }
    void UpdateScore()
    {
        maxDarkness = 255 - (50 * score);
        output = "Score: " + score +"\n"+ "MaxScore: " + maxScore;
                    ;
        panel.text = output;
    }
}
