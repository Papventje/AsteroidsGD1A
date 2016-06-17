using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour
{

    NavMeshAgent _navMeshAgent;
    GameObject _playerGameObject;

    public static bool targeting = true;

    void Awake()
    {
        _navMeshAgent = GetComponent<NavMeshAgent>();
        _playerGameObject = GameObject.FindGameObjectWithTag("Player");
    }


    void Update()
    {
        {
            _navMeshAgent.SetDestination(_playerGameObject.transform.position);
        }
        if(targeting == false)
        {
            _navMeshAgent.enabled = false;
        }
        if(targeting == true)
        {
            _navMeshAgent.enabled = true;
        }
    }
}
