// GENERATED AUTOMATICALLY FROM 'Assets/PlayerInput.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerInput : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInput"",
    ""maps"": [
        {
            ""name"": ""Input"",
            ""id"": ""8023b160-55f2-48fb-8eb0-3b9b54ac69e0"",
            ""actions"": [
                {
                    ""name"": ""MovementForward"",
                    ""type"": ""Value"",
                    ""id"": ""708d40df-f189-459b-9f43-9d6cad2f89a3"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": ""Hold(duration=0.1)""
                },
                {
                    ""name"": ""MovementSides"",
                    ""type"": ""Value"",
                    ""id"": ""c8445c5a-01ec-4fda-a947-87b62a4f9736"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Hold(duration=0.1)""
                },
                {
                    ""name"": ""ForkUp"",
                    ""type"": ""Value"",
                    ""id"": ""ecbeecc2-768c-4c0c-94f4-a9e096acfe85"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": ""Hold(duration=0.1)""
                },
                {
                    ""name"": ""ForkDown"",
                    ""type"": ""PassThrough"",
                    ""id"": ""ed2a8aba-63ab-41bc-8040-767c80ed9590"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": ""Hold(duration=0.1)""
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""92fe226d-3b04-4dd1-840c-a11d3fe8f847"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MovementSides"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""12d17314-65f0-4a40-94f0-5d737e60690a"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MovementSides"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""c367d877-069a-400f-9c8b-306cab49ce17"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MovementSides"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""78410413-1974-4038-b165-0b834bca878b"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ForkUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ab5675a7-0941-428b-a617-89441f7189d0"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ForkDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""66165cf0-c2fd-45c8-bb65-3e75436154b0"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MovementForward"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""a3f3de23-68e9-48b1-bbe5-f35b48fea721"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MovementForward"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""8feb0b22-8c25-4624-9e73-cc7dfe9fe758"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MovementForward"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Input
        m_Input = asset.FindActionMap("Input", throwIfNotFound: true);
        m_Input_MovementForward = m_Input.FindAction("MovementForward", throwIfNotFound: true);
        m_Input_MovementSides = m_Input.FindAction("MovementSides", throwIfNotFound: true);
        m_Input_ForkUp = m_Input.FindAction("ForkUp", throwIfNotFound: true);
        m_Input_ForkDown = m_Input.FindAction("ForkDown", throwIfNotFound: true);
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

    // Input
    private readonly InputActionMap m_Input;
    private IInputActions m_InputActionsCallbackInterface;
    private readonly InputAction m_Input_MovementForward;
    private readonly InputAction m_Input_MovementSides;
    private readonly InputAction m_Input_ForkUp;
    private readonly InputAction m_Input_ForkDown;
    public struct InputActions
    {
        private @PlayerInput m_Wrapper;
        public InputActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @MovementForward => m_Wrapper.m_Input_MovementForward;
        public InputAction @MovementSides => m_Wrapper.m_Input_MovementSides;
        public InputAction @ForkUp => m_Wrapper.m_Input_ForkUp;
        public InputAction @ForkDown => m_Wrapper.m_Input_ForkDown;
        public InputActionMap Get() { return m_Wrapper.m_Input; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(InputActions set) { return set.Get(); }
        public void SetCallbacks(IInputActions instance)
        {
            if (m_Wrapper.m_InputActionsCallbackInterface != null)
            {
                @MovementForward.started -= m_Wrapper.m_InputActionsCallbackInterface.OnMovementForward;
                @MovementForward.performed -= m_Wrapper.m_InputActionsCallbackInterface.OnMovementForward;
                @MovementForward.canceled -= m_Wrapper.m_InputActionsCallbackInterface.OnMovementForward;
                @MovementSides.started -= m_Wrapper.m_InputActionsCallbackInterface.OnMovementSides;
                @MovementSides.performed -= m_Wrapper.m_InputActionsCallbackInterface.OnMovementSides;
                @MovementSides.canceled -= m_Wrapper.m_InputActionsCallbackInterface.OnMovementSides;
                @ForkUp.started -= m_Wrapper.m_InputActionsCallbackInterface.OnForkUp;
                @ForkUp.performed -= m_Wrapper.m_InputActionsCallbackInterface.OnForkUp;
                @ForkUp.canceled -= m_Wrapper.m_InputActionsCallbackInterface.OnForkUp;
                @ForkDown.started -= m_Wrapper.m_InputActionsCallbackInterface.OnForkDown;
                @ForkDown.performed -= m_Wrapper.m_InputActionsCallbackInterface.OnForkDown;
                @ForkDown.canceled -= m_Wrapper.m_InputActionsCallbackInterface.OnForkDown;
            }
            m_Wrapper.m_InputActionsCallbackInterface = instance;
            if (instance != null)
            {
                @MovementForward.started += instance.OnMovementForward;
                @MovementForward.performed += instance.OnMovementForward;
                @MovementForward.canceled += instance.OnMovementForward;
                @MovementSides.started += instance.OnMovementSides;
                @MovementSides.performed += instance.OnMovementSides;
                @MovementSides.canceled += instance.OnMovementSides;
                @ForkUp.started += instance.OnForkUp;
                @ForkUp.performed += instance.OnForkUp;
                @ForkUp.canceled += instance.OnForkUp;
                @ForkDown.started += instance.OnForkDown;
                @ForkDown.performed += instance.OnForkDown;
                @ForkDown.canceled += instance.OnForkDown;
            }
        }
    }
    public InputActions @Input => new InputActions(this);
    public interface IInputActions
    {
        void OnMovementForward(InputAction.CallbackContext context);
        void OnMovementSides(InputAction.CallbackContext context);
        void OnForkUp(InputAction.CallbackContext context);
        void OnForkDown(InputAction.CallbackContext context);
    }
}
