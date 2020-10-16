using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTrigger : MonoBehaviour
{
    [SerializeField]
    public float _speed = 1;

    private SpawnManager _SpawnManager;

    // Start is called before the first frame update
    void Start()
    {
        _SpawnManager = GameObject.Find("Spawning_Manager").GetComponent<SpawnManager>();
    }

    // Update is called once per frame
    void Update()
    {
        CalculateMovement();
    }

    void CalculateMovement()
    {
        transform.Translate(Vector3.back * _speed * Time.deltaTime);

        if (transform.position.z < -10)
        {
           Destroy(this.gameObject);
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            _SpawnManager.StartSpawning();
        }
    }
}
