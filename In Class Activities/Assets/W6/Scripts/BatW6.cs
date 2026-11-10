using System;
using UnityEngine;
using UnityEngine.UIElements;

// Write the BatW6 class here.
public class BatW6 : MonoBehaviour
{
    [SerializeField] private float _speed = 1.0f;
    private Transform _playerTransform;

    public void startChasingPlayer(Transform player)
    {
        enabled = true;
        _playerTransform = player;
    }

    public void stopChasingPlayer()
    {
        enabled = false;
        
    }


    public void Update()
    {
        //Transform.MoveTowards(transform.position, _player.transform.position, _speed * );

        transform.position = Vector3.MoveTowards(
            transform.position,
            _playerTransform.position,
            _speed * Time.deltaTime
        );
    }
    

    // public void OnCollisionEnter2D(Collision2D collision)
    // {
    //     //starts displaying the text on screen from batmanager

    // }







}
