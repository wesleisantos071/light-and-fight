//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.2.0
//     from Assets/InputMaster.inputactions
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

public partial class @InputHandler : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputHandler()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputMaster"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""7f582a6c-610b-4034-bd27-8427e67169dd"",
            ""actions"": [
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""ad5130b5-fce0-4218-b96c-b9d326ab03df"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""MoveLeft"",
                    ""type"": ""Button"",
                    ""id"": ""bebae649-73e1-445f-b4a7-6025642982a8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""MoveRight"",
                    ""type"": ""Button"",
                    ""id"": ""a430d67d-621c-4fda-989b-47d310b7227f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Action"",
                    ""type"": ""Button"",
                    ""id"": ""721fc4ac-2f01-4956-a477-7b8ebf841dd3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""12522e8d-c770-4b3c-bbc4-693d7717e867"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox Control Scheme"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e206cdee-1e65-4916-93de-e58e12ea0b42"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox Control Scheme"",
                    ""action"": ""MoveLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""03d34202-8575-4245-a09c-648a0b4061f0"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox Control Scheme"",
                    ""action"": ""MoveLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""14b1d0ed-e764-4733-bc54-b815a560311b"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox Control Scheme"",
                    ""action"": ""MoveRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9163a23a-9bc5-41ac-8c6b-65b3133c3829"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox Control Scheme"",
                    ""action"": ""MoveRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3d54e5ba-3d64-4c89-9382-6a812ea63ea6"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox Control Scheme"",
                    ""action"": ""Action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""UniversalPlayer"",
            ""id"": ""505441a5-dffc-403d-8a39-a88e6d4e303e"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""524498ec-af92-4c06-99cf-e0e4bc8e6fad"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""aa02bbdd-0706-4cde-bc50-5ad77b4ab6da"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""f2cf9cc2-2e19-40ab-95eb-1886bd9ff2c4"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox Control Scheme"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7921933b-fba9-446a-83e2-a9881b5c62f1"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Xbox Control Scheme"",
            ""bindingGroup"": ""Xbox Control Scheme"",
            ""devices"": [
                {
                    ""devicePath"": ""<XInputController>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_Jump = m_Player.FindAction("Jump", throwIfNotFound: true);
        m_Player_MoveLeft = m_Player.FindAction("MoveLeft", throwIfNotFound: true);
        m_Player_MoveRight = m_Player.FindAction("MoveRight", throwIfNotFound: true);
        m_Player_Action = m_Player.FindAction("Action", throwIfNotFound: true);
        // UniversalPlayer
        m_UniversalPlayer = asset.FindActionMap("UniversalPlayer", throwIfNotFound: true);
        m_UniversalPlayer_Move = m_UniversalPlayer.FindAction("Move", throwIfNotFound: true);
        m_UniversalPlayer_Jump = m_UniversalPlayer.FindAction("Jump", throwIfNotFound: true);
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

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_Jump;
    private readonly InputAction m_Player_MoveLeft;
    private readonly InputAction m_Player_MoveRight;
    private readonly InputAction m_Player_Action;
    public struct PlayerActions
    {
        private @InputHandler m_Wrapper;
        public PlayerActions(@InputHandler wrapper) { m_Wrapper = wrapper; }
        public InputAction @Jump => m_Wrapper.m_Player_Jump;
        public InputAction @MoveLeft => m_Wrapper.m_Player_MoveLeft;
        public InputAction @MoveRight => m_Wrapper.m_Player_MoveRight;
        public InputAction @Action => m_Wrapper.m_Player_Action;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @Jump.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @MoveLeft.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMoveLeft;
                @MoveLeft.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMoveLeft;
                @MoveLeft.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMoveLeft;
                @MoveRight.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMoveRight;
                @MoveRight.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMoveRight;
                @MoveRight.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMoveRight;
                @Action.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAction;
                @Action.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAction;
                @Action.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAction;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @MoveLeft.started += instance.OnMoveLeft;
                @MoveLeft.performed += instance.OnMoveLeft;
                @MoveLeft.canceled += instance.OnMoveLeft;
                @MoveRight.started += instance.OnMoveRight;
                @MoveRight.performed += instance.OnMoveRight;
                @MoveRight.canceled += instance.OnMoveRight;
                @Action.started += instance.OnAction;
                @Action.performed += instance.OnAction;
                @Action.canceled += instance.OnAction;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);

    // UniversalPlayer
    private readonly InputActionMap m_UniversalPlayer;
    private IUniversalPlayerActions m_UniversalPlayerActionsCallbackInterface;
    private readonly InputAction m_UniversalPlayer_Move;
    private readonly InputAction m_UniversalPlayer_Jump;
    public struct UniversalPlayerActions
    {
        private @InputHandler m_Wrapper;
        public UniversalPlayerActions(@InputHandler wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_UniversalPlayer_Move;
        public InputAction @Jump => m_Wrapper.m_UniversalPlayer_Jump;
        public InputActionMap Get() { return m_Wrapper.m_UniversalPlayer; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(UniversalPlayerActions set) { return set.Get(); }
        public void SetCallbacks(IUniversalPlayerActions instance)
        {
            if (m_Wrapper.m_UniversalPlayerActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_UniversalPlayerActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_UniversalPlayerActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_UniversalPlayerActionsCallbackInterface.OnMove;
                @Jump.started -= m_Wrapper.m_UniversalPlayerActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_UniversalPlayerActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_UniversalPlayerActionsCallbackInterface.OnJump;
            }
            m_Wrapper.m_UniversalPlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
            }
        }
    }
    public UniversalPlayerActions @UniversalPlayer => new UniversalPlayerActions(this);
    private int m_XboxControlSchemeSchemeIndex = -1;
    public InputControlScheme XboxControlSchemeScheme
    {
        get
        {
            if (m_XboxControlSchemeSchemeIndex == -1) m_XboxControlSchemeSchemeIndex = asset.FindControlSchemeIndex("Xbox Control Scheme");
            return asset.controlSchemes[m_XboxControlSchemeSchemeIndex];
        }
    }
    public interface IPlayerActions
    {
        void OnJump(InputAction.CallbackContext context);
        void OnMoveLeft(InputAction.CallbackContext context);
        void OnMoveRight(InputAction.CallbackContext context);
        void OnAction(InputAction.CallbackContext context);
    }
    public interface IUniversalPlayerActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
    }
}
