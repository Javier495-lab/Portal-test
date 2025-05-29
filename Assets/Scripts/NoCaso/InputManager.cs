using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections;

public class InputManager : MonoBehaviour
{
    private PlayerInput playerInput;
    
    void Awake()
    {
        playerInput = GetComponent<PlayerInput>();
    }

    void Update()
    {
        
    }

    private void OnEnable()
    {
        
    }

    private void OnDisable()
    {
        
    }
}
