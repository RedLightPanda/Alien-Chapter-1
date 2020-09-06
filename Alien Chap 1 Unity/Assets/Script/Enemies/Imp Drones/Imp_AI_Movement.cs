using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Imp_AI_Movement : MonoBehaviour
{
    [SerializeField]
    public float Speed;

    public Transform[] moveSpots;
    private int randomSpot;
    public float waitTime;
    public float startWaitTime;

    // Start is called before the first frame update
    void Start()
    {
        if(randomSpot != null)
        {
        randomSpot = Random.Range(0, moveSpots.Length);
        }
        else
        {
            //redoSpot
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        RandomSpot();
    }

    void RandomSpot()
    {
        transform.position = Vector3.MoveTowards(transform.position, moveSpots[randomSpot].position, Speed * Time.deltaTime);

        if (Vector3.Distance(transform.position, moveSpots[randomSpot].position) < 0.2f)
        {
            if (waitTime <= 0)
            {
                randomSpot = Random.Range(0, moveSpots.Length);
                waitTime = startWaitTime;
            }
            else
            {
                waitTime -= Time.deltaTime;
            }
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Imp Point")
        {
            Debug.Log("Hey");
        }
    }
}
