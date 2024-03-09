//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.4
//     from Assets/Scripts/PlayerInputActions.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @PlayerInputActions : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInputActions"",
    ""maps"": [
        {
            ""name"": ""BasicMovement"",
            ""id"": ""cfcc9d0a-4e6b-44e8-b9e9-4b9e460a150b"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""68dc19e8-3616-42b0-8c2d-99e93f2c8026"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Shooting"",
                    ""type"": ""Value"",
                    ""id"": ""28532b3c-23ab-407e-b205-d5a5181103bb"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Keyboard"",
                    ""id"": ""5030bcae-8a20-4484-941f-619012d4934c"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""left"",
                    ""id"": ""5cfd9da1-4ed2-4052-b9f5-2b14dfb215f9"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""ee291f7d-7550-4f49-a3e0-d90552d80017"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Shoot"",
                    ""id"": ""42cc4e36-f053-4086-ae81-05dc8a21686c"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shooting"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""2a45b015-bc12-4d20-a00b-4fa864710ab6"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shooting"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""33492f1c-9d81-41d3-b0eb-3c5218bb862e"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shooting"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""ece05106-1f88-4fd2-bf04-36bdd5af180f"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shooting"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""61176b91-fcd7-4311-a72c-12f0f91fe879"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shooting"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""Standard"",
            ""id"": ""5c8de7fe-02ab-422f-8df0-5166f6d8d029"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""c5af8d16-fb78-4e3a-ba91-bc481d5e7e68"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Fire"",
                    ""type"": ""Button"",
                    ""id"": ""91a74138-cff3-4144-9d54-7722a5c9ac62"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""MousePossition"",
                    ""type"": ""Value"",
                    ""id"": ""ac0669cb-d7db-4d5a-852c-5964d2e33b32"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Keyboard"",
                    ""id"": ""64fffc2d-7381-49dc-a3ac-2ef41add2d60"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""left"",
                    ""id"": ""a41e97be-2c02-48b4-a98e-b0cd477be8d2"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""054a7690-32a5-4d86-aa8e-c3f068593471"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""15dcf846-2eb2-479f-8ca2-9694ad7003f2"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7fd9b974-5418-4ad5-9b4f-b975e87e3f48"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MousePossition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // BasicMovement
        m_BasicMovement = asset.FindActionMap("BasicMovement", throwIfNotFound: true);
        m_BasicMovement_Movement = m_BasicMovement.FindAction("Movement", throwIfNotFound: true);
        m_BasicMovement_Shooting = m_BasicMovement.FindAction("Shooting", throwIfNotFound: true);
        // Standard
        m_Standard = asset.FindActionMap("Standard", throwIfNotFound: true);
        m_Standard_Movement = m_Standard.FindAction("Movement", throwIfNotFound: true);
        m_Standard_Fire = m_Standard.FindAction("Fire", throwIfNotFound: true);
        m_Standard_MousePossition = m_Standard.FindAction("MousePossition", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }
    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }
    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // BasicMovement
    private readonly InputActionMap m_BasicMovement;
    private IBasicMovementActions m_BasicMovementActionsCallbackInterface;
    private readonly InputAction m_BasicMovement_Movement;
    private readonly InputAction m_BasicMovement_Shooting;
    public struct BasicMovementActions
    {
        private @PlayerInputActions m_Wrapper;
        public BasicMovementActions(@PlayerInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_BasicMovement_Movement;
        public InputAction @Shooting => m_Wrapper.m_BasicMovement_Shooting;
        public InputActionMap Get() { return m_Wrapper.m_BasicMovement; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(BasicMovementActions set) { return set.Get(); }
        public void SetCallbacks(IBasicMovementActions instance)
        {
            if (m_Wrapper.m_BasicMovementActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_BasicMovementActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_BasicMovementActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_BasicMovementActionsCallbackInterface.OnMovement;
                @Shooting.started -= m_Wrapper.m_BasicMovementActionsCallbackInterface.OnShooting;
                @Shooting.performed -= m_Wrapper.m_BasicMovementActionsCallbackInterface.OnShooting;
                @Shooting.canceled -= m_Wrapper.m_BasicMovementActionsCallbackInterface.OnShooting;
            }
            m_Wrapper.m_BasicMovementActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Shooting.started += instance.OnShooting;
                @Shooting.performed += instance.OnShooting;
                @Shooting.canceled += instance.OnShooting;
            }
        }
    }
    public BasicMovementActions @BasicMovement => new BasicMovementActions(this);

    // Standard
    private readonly InputActionMap m_Standard;
    private IStandardActions m_StandardActionsCallbackInterface;
    private readonly InputAction m_Standard_Movement;
    private readonly InputAction m_Standard_Fire;
    private readonly InputAction m_Standard_MousePossition;
    public struct StandardActions
    {
        private @PlayerInputActions m_Wrapper;
        public StandardActions(@PlayerInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_Standard_Movement;
        public InputAction @Fire => m_Wrapper.m_Standard_Fire;
        public InputAction @MousePossition => m_Wrapper.m_Standard_MousePossition;
        public InputActionMap Get() { return m_Wrapper.m_Standard; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(StandardActions set) { return set.Get(); }
        public void SetCallbacks(IStandardActions instance)
        {
            if (m_Wrapper.m_StandardActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_StandardActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_StandardActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_StandardActionsCallbackInterface.OnMovement;
                @Fire.started -= m_Wrapper.m_StandardActionsCallbackInterface.OnFire;
                @Fire.performed -= m_Wrapper.m_StandardActionsCallbackInterface.OnFire;
                @Fire.canceled -= m_Wrapper.m_StandardActionsCallbackInterface.OnFire;
                @MousePossition.started -= m_Wrapper.m_StandardActionsCallbackInterface.OnMousePossition;
                @MousePossition.performed -= m_Wrapper.m_StandardActionsCallbackInterface.OnMousePossition;
                @MousePossition.canceled -= m_Wrapper.m_StandardActionsCallbackInterface.OnMousePossition;
            }
            m_Wrapper.m_StandardActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Fire.started += instance.OnFire;
                @Fire.performed += instance.OnFire;
                @Fire.canceled += instance.OnFire;
                @MousePossition.started += instance.OnMousePossition;
                @MousePossition.performed += instance.OnMousePossition;
                @MousePossition.canceled += instance.OnMousePossition;
            }
        }
    }
    public StandardActions @Standard => new StandardActions(this);
    public interface IBasicMovementActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnShooting(InputAction.CallbackContext context);
    }
    public interface IStandardActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnFire(InputAction.CallbackContext context);
        void OnMousePossition(InputAction.CallbackContext context);
    }
}