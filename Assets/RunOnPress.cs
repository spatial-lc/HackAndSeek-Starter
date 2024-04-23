using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit.Samples.StarterAssets;

public class RunOnPress : MonoBehaviour
{
    [SerializeField]
    InputAction runAction;

    DynamicMoveProvider moveProvider;

    // Start is called before the first frame update
    void Start()
    {
        moveProvider = GetComponent<DynamicMoveProvider>(); 
    }

    // Update is called once per frame
    void Update()
    {
        InputAction action = runAction;
    }
}
