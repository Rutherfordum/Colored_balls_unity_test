//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/_Colored Balls Project/Scripts/UserInputServices/UserInputActions.inputactions
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

public partial class @UserInputActions: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @UserInputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""UserInputActions"",
    ""maps"": [
        {
            ""name"": ""UserInputActionMap"",
            ""id"": ""0c0a4663-eb66-4d5b-8bc0-23d9626b5f00"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""c7889ddb-4c22-44f8-96e7-18eebad9c0e9"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""f885bdef-09b4-47e4-909b-b549d1b1fef8"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""45a8c043-6b2d-4697-b7d6-079d7be01885"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""d86bbcdb-4436-4559-8e69-a42c2877863c"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""f8d47076-a5ee-4985-9208-f75cc897c08d"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""a3ad14dc-a113-476b-952d-8bb3f250a567"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // UserInputActionMap
        m_UserInputActionMap = asset.FindActionMap("UserInputActionMap", throwIfNotFound: true);
        m_UserInputActionMap_Move = m_UserInputActionMap.FindAction("Move", throwIfNotFound: true);
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

    // UserInputActionMap
    private readonly InputActionMap m_UserInputActionMap;
    private List<IUserInputActionMapActions> m_UserInputActionMapActionsCallbackInterfaces = new List<IUserInputActionMapActions>();
    private readonly InputAction m_UserInputActionMap_Move;
    public struct UserInputActionMapActions
    {
        private @UserInputActions m_Wrapper;
        public UserInputActionMapActions(@UserInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_UserInputActionMap_Move;
        public InputActionMap Get() { return m_Wrapper.m_UserInputActionMap; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(UserInputActionMapActions set) { return set.Get(); }
        public void AddCallbacks(IUserInputActionMapActions instance)
        {
            if (instance == null || m_Wrapper.m_UserInputActionMapActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_UserInputActionMapActionsCallbackInterfaces.Add(instance);
            @Move.started += instance.OnMove;
            @Move.performed += instance.OnMove;
            @Move.canceled += instance.OnMove;
        }

        private void UnregisterCallbacks(IUserInputActionMapActions instance)
        {
            @Move.started -= instance.OnMove;
            @Move.performed -= instance.OnMove;
            @Move.canceled -= instance.OnMove;
        }

        public void RemoveCallbacks(IUserInputActionMapActions instance)
        {
            if (m_Wrapper.m_UserInputActionMapActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IUserInputActionMapActions instance)
        {
            foreach (var item in m_Wrapper.m_UserInputActionMapActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_UserInputActionMapActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public UserInputActionMapActions @UserInputActionMap => new UserInputActionMapActions(this);
    public interface IUserInputActionMapActions
    {
        void OnMove(InputAction.CallbackContext context);
    }
}
