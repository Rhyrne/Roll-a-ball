using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallController : MonoBehaviour
{

    public Rigidbody body;
    public int counter;
    public int coinCounts;

    public Text coinCounterText;
    public Text gameOverText;
    void Start()
    {
        body = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        Vector3 vector = new Vector3(horizontal, 0, vertical);
        body.AddForce(vector*10);
    }
    
    void OnTriggerEnter(Collider other)
    {
        other.gameObject.SetActive(false);
        counter++;
        coinCounterText.text = "Puan:" + counter;
        if (counter == coinCounts) 
        {
            gameOverText.gameObject.SetActive(true);
        }
    }
}
