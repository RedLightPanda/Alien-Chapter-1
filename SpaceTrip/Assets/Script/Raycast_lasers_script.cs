using UnityEditor.VersionControl;
using UnityEngine;
using UnityEngine.Experimental.Rendering;

public class Raycast_lasers_script : MonoBehaviour
{

    [SerializeField]
    private Transform _target;

    public float damage = 10f;
    public float range = 100f;

    public Camera EnemyCam;

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        if(Physics.Raycast(EnemyCam.transform.position, EnemyCam.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);
        }
        
        
        //Debug that helps Targets player.
        Vector3 directionToFace = _target.position - transform.position;
        Debug.DrawRay(transform.position, directionToFace, Color.red);
       
      
    }
}
