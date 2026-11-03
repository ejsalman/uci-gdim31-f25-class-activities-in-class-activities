using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UIElements;

// Write your DeerW5 class in here :)
// Hint: if you don't remember what a class is supposed to look like,
//      maybe check out CatW5...
// If you copied the class declaration from CatW5, you'd only need to change one thing...

public class DeerW5 : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private float _moveSpeed = 1.0f;
    [SerializeField] private float _turnSpeed = 1.0f;
    [SerializeField] private Animator _animator;

    NavMeshAgent myNavMeshAgent;
    
    private void Start()
    {
        myNavMeshAgent = GetComponent<NavMeshAgent>();
        Vector3 position = new Vector3(target.position.x, target.position.y, target.position.z);
        myNavMeshAgent.SetDestination(position);
    }
}