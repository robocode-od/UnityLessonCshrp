using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{
    private float _speed = 0.05f;
    private void Update()
    {
        transform.Translate(Vector2.left * _speed * Time.deltaTime);
    }
}
