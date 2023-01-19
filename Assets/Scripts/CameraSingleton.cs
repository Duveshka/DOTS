// There are many ways of getting access to the main camera, but the approach using
// a singleton (as we use here) works for any kind of MonoBehaviour.

using System;
using Unity.VisualScripting;
using UnityEngine;

class CameraSingleton : UnityEngine.MonoBehaviour
{
    [SerializeField]
    public static UnityEngine.Camera Instance;

    void Awake()
    {
        Instance = GetComponent<UnityEngine.Camera>();
    }
}