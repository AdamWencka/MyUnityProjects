using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RollingBall : MonoBehaviour
{
    public Text progressUI;

    public GameObject gate;

    public int pointsThreshold = 7;
    public int points = 0;

    public float speed = 3f;

    public Rigidbody rb;
    public float horizontal;
    public float vertical;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        progressUI.text = "Points Taken: 0\nPoints Remaining: " +pointsThreshold;
    }

    // Update is called once per frame
    void Update()
    {
        
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        Vector3 direction = new Vector3(horizontal, 0.0f, vertical);

        rb.AddForce(direction*speed);
    }
    

    public void CheckThreshold()
    {
        progressUI.text = "Points Taken: " + points + "\nPoints Remaining: " + (pointsThreshold - points);
        if (points >= pointsThreshold)
        {
            gate.SetActive(false);
        }
    }


}
