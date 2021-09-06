using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _speed = 0.2f;
    private Vector2 _direction;

    private void Start()
    {
        Debug.Log("Hello, Unity!");
    }

    private void Update()
    {
        transform.Translate(Vector3.right * _speed * Time.deltaTime);
    }
}
