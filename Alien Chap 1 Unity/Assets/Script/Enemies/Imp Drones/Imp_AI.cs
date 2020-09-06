using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Imp_AI : MonoBehaviour
{
    public Transform Target;

    [SerializeField]
    private GameObject _LaserPrefab;

    private float _fireRate = 3.0f;
    private float _canFire = -1f;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(Target);
        EnemyLaser();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Laser")
        {
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }
    }

    public void EnemyLaser()
    {
        if (Time.time > _canFire)
        {
            _fireRate = Random.Range(3f, 7f);
            _canFire = Time.time + _fireRate;
            GameObject enemyLaser = Instantiate(_LaserPrefab, transform.position + new Vector3 (0,-2,0), Quaternion.identity);
            Laser[] lasers = enemyLaser.GetComponentsInChildren<Laser>();

            for (int i = 0; i < lasers.Length; i++)
            {
                lasers[i].AssignEnemyLaser();
            }
        }
    }
}
