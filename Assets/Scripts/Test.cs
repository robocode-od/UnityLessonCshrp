using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    [SerializeField] private float _value = 2.88f;

    private void Start()
    {
        Debug.Log(_value);
    }
}
