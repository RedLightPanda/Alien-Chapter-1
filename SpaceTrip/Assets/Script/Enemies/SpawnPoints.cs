using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoints : MonoBehaviour
{
    [SerializeField]
    private GameObject _EnemyShip;
    [SerializeField]
    private GameObject _enemyContainer;

    private SpawnManager _SpawnManager;
    
    [SerializeField]
    public GameObject _SpawnPoint;



    // Start is called before the first frame update
    void Start()
    {
        _SpawnManager = GameObject.Find("Spawning_Manager").GetComponent<SpawnManager>();
        //GetComponent()
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //private void Spawner()
    //{
       
    //    GameObject newEnemy = Instantiate(_EnemyShip, _SpawnPoint, Quaternion.identity);
    //    newEnemy.transform.parent = _enemyContainer.transform;
    //    yield return new WaitForSeconds(5.0f);
    //}
}
