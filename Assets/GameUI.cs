using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class GameUI : MonoBehaviour
{
    
    public InputActionAsset _playerControls;

    [SerializeField] 
    public TextMeshProUGUI _text;
 
    private InputAction movement;
    private InputAction fire;
 
    private void Awake()
    {
        string instructions = "How to move\n\n";
        foreach (var actionMap in _playerControls.actionMaps)
        {
            Debug.Log(actionMap.ToJson());
            foreach (var action in actionMap.actions)
            {
                instructions += " " + action.name + " ";
                
                Debug.Log(action.name);
                foreach (var binding in action.bindings)
                {
                    instructions.Concat(binding.ToDisplayString());
                    Debug.Log(binding.ToDisplayString());
                }
                
            }

            
            _text.text = instructions;

        }

        foreach (var device in _playerControls.devices)
        {
            // Debug.Log(device.ToString());
            // instructions += $" Device {device.ToString()}";
        }

        // var gameplayActionMap = playerControls.FindActionMap("Gameplay");
        //
        // movement = gameplayActionMap.FindAction("Movement");
        // movement.performed += OnMovementChanged;
        // movement.canceled += OnMovementChanged;
        // movement.Enable();
 
        // fire = gameplayActionMap.GetAction("Fire");
        // fire.performed += OnFireChanged;
        // fire.Enable();
    }
 
    private void OnMovementChanged(InputAction.CallbackContext context)
    {
        var direction = context.ReadValue<Vector2>();
 
        // Code that moves the player based on the direction
    }

    private void OnFireChanged(InputAction.CallbackContext context)
    {
        // Code 
    }

}
