using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FaceCollision : MonoBehaviour
{
    public float powerAmount = 10.0f;
    public float addPowerTime = 2.0f;

    private int points = 0;
    private float timer = 0;
    private Rigidbody2D myRB;
    
    public Text score;

    void Start()
    {
        myRB = GetComponent<Rigidbody2D>();
        timer = addPowerTime;
     
    }

    void Update()
    {
        TimerUpdate();
    }

    void OnCollisionEnter2D(Collision2D colleisson)
    {
        if (colleisson.gameObject.layer == 8)
        {
            AddPower();
            AddPoint();
            timer = addPowerTime;
        }
    }

    private void TimerUpdate()
    {
        if (timer <= 0)
        {
            AddPowerInWorld();
            timer = addPowerTime;
        }
        timer -= Time.deltaTime;
    }

    private void AddPower()
    {
        myRB.AddForce(transform.up * powerAmount, ForceMode2D.Impulse);
    }

    private void AddPowerInWorld()
    {
        myRB.AddForce((Vector2.right + Vector2.up) * powerAmount, ForceMode2D.Impulse);
    }

    private void AddPoint()
    {
        points++;
        score.text = points.ToString();
    }
}
