//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/CustomInput.inputactions
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

public partial class @CustomInput: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @CustomInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""CustomInput"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""8c58f1f0-9393-4e5e-8ec5-cf5261cb222a"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""2f75e5f9-033b-4f80-adac-d166ea81e92e"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""InventoryOne"",
                    ""type"": ""Button"",
                    ""id"": ""cc6ac38f-3fc1-4805-a830-b3edba869a07"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""InventoryTwo"",
                    ""type"": ""Button"",
                    ""id"": ""6f5b3306-fd64-4c15-a816-70ea09dfd843"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""InventoryThree"",
                    ""type"": ""Button"",
                    ""id"": ""acd09561-de88-4822-9a5c-87554efbc802"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""InventoryFour"",
                    ""type"": ""Button"",
                    ""id"": ""23398287-7678-4443-b663-7540398fe5c1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""InventoryFive"",
                    ""type"": ""Button"",
                    ""id"": ""5f70b4c7-6ee1-4f6c-9195-34256759f803"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""InventorySix"",
                    ""type"": ""Button"",
                    ""id"": ""61921be0-7032-4d30-89ef-2baa243c9341"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""InventoryUp"",
                    ""type"": ""Button"",
                    ""id"": ""249b1cf1-234b-41cf-b8c2-9643c0db25d4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""InventoryDown"",
                    ""type"": ""Button"",
                    ""id"": ""c5e0cf2a-f3f7-4659-bc28-29086dcd51cc"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""ea7b0600-9932-4de9-8e8b-54170ded28ff"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""000074ae-e692-4f5a-b1ad-5ccb7b1fde43"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""9f20671d-95e6-45bf-a734-100ba7f13e3c"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""a8b5030d-b3c3-44a9-8fdb-afa8883ca98a"",
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
                    ""id"": ""ee65d1ca-f261-4f60-a1d4-9b34b408abde"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Controller Left Analog"",
                    ""id"": ""c2dfafa2-c651-4793-b302-872acbce374b"",
                    ""path"": ""2DVector(mode=2)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""eff0f3ca-49b2-453b-8756-c2773b3b1545"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""9223c845-e681-45d0-b7a7-c8064ea9b6c4"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""f7d36b60-617a-4430-a362-16cce14958c2"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""65265946-7e80-441d-aab8-c4a2789380de"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""20df2b20-82aa-49fc-8fe2-77f24d8e9056"",
                    ""path"": ""<Keyboard>/1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""InventoryOne"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8bc1e112-3841-401b-bd6b-677f684f8c6a"",
                    ""path"": ""<Keyboard>/2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""InventoryTwo"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""728ff448-b203-45fd-a7cf-b4d50bae478e"",
                    ""path"": ""<Keyboard>/3"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""InventoryThree"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e62d3380-9ce1-4168-9678-f86dc1528f5b"",
                    ""path"": ""<Keyboard>/4"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""InventoryFour"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5296a4da-a4ed-4b99-86bf-a984e9f57f9c"",
                    ""path"": ""<Keyboard>/5"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""InventoryFive"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""dd54625a-5b49-42cc-9303-c5ae28d215d0"",
                    ""path"": ""<Keyboard>/6"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""InventorySix"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""41a51391-be9b-4475-9c46-84173a47e64f"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""InventoryUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7db4bdc9-e2a6-4525-823e-761036ae934a"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""InventoryDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_Movement = m_Player.FindAction("Movement", throwIfNotFound: true);
        m_Player_InventoryOne = m_Player.FindAction("InventoryOne", throwIfNotFound: true);
        m_Player_InventoryTwo = m_Player.FindAction("InventoryTwo", throwIfNotFound: true);
        m_Player_InventoryThree = m_Player.FindAction("InventoryThree", throwIfNotFound: true);
        m_Player_InventoryFour = m_Player.FindAction("InventoryFour", throwIfNotFound: true);
        m_Player_InventoryFive = m_Player.FindAction("InventoryFive", throwIfNotFound: true);
        m_Player_InventorySix = m_Player.FindAction("InventorySix", throwIfNotFound: true);
        m_Player_InventoryUp = m_Player.FindAction("InventoryUp", throwIfNotFound: true);
        m_Player_InventoryDown = m_Player.FindAction("InventoryDown", throwIfNotFound: true);
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
    private List<IPlayerActions> m_PlayerActionsCallbackInterfaces = new List<IPlayerActions>();
    private readonly InputAction m_Player_Movement;
    private readonly InputAction m_Player_InventoryOne;
    private readonly InputAction m_Player_InventoryTwo;
    private readonly InputAction m_Player_InventoryThree;
    private readonly InputAction m_Player_InventoryFour;
    private readonly InputAction m_Player_InventoryFive;
    private readonly InputAction m_Player_InventorySix;
    private readonly InputAction m_Player_InventoryUp;
    private readonly InputAction m_Player_InventoryDown;
    public struct PlayerActions
    {
        private @CustomInput m_Wrapper;
        public PlayerActions(@CustomInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_Player_Movement;
        public InputAction @InventoryOne => m_Wrapper.m_Player_InventoryOne;
        public InputAction @InventoryTwo => m_Wrapper.m_Player_InventoryTwo;
        public InputAction @InventoryThree => m_Wrapper.m_Player_InventoryThree;
        public InputAction @InventoryFour => m_Wrapper.m_Player_InventoryFour;
        public InputAction @InventoryFive => m_Wrapper.m_Player_InventoryFive;
        public InputAction @InventorySix => m_Wrapper.m_Player_InventorySix;
        public InputAction @InventoryUp => m_Wrapper.m_Player_InventoryUp;
        public InputAction @InventoryDown => m_Wrapper.m_Player_InventoryDown;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void AddCallbacks(IPlayerActions instance)
        {
            if (instance == null || m_Wrapper.m_PlayerActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_PlayerActionsCallbackInterfaces.Add(instance);
            @Movement.started += instance.OnMovement;
            @Movement.performed += instance.OnMovement;
            @Movement.canceled += instance.OnMovement;
            @InventoryOne.started += instance.OnInventoryOne;
            @InventoryOne.performed += instance.OnInventoryOne;
            @InventoryOne.canceled += instance.OnInventoryOne;
            @InventoryTwo.started += instance.OnInventoryTwo;
            @InventoryTwo.performed += instance.OnInventoryTwo;
            @InventoryTwo.canceled += instance.OnInventoryTwo;
            @InventoryThree.started += instance.OnInventoryThree;
            @InventoryThree.performed += instance.OnInventoryThree;
            @InventoryThree.canceled += instance.OnInventoryThree;
            @InventoryFour.started += instance.OnInventoryFour;
            @InventoryFour.performed += instance.OnInventoryFour;
            @InventoryFour.canceled += instance.OnInventoryFour;
            @InventoryFive.started += instance.OnInventoryFive;
            @InventoryFive.performed += instance.OnInventoryFive;
            @InventoryFive.canceled += instance.OnInventoryFive;
            @InventorySix.started += instance.OnInventorySix;
            @InventorySix.performed += instance.OnInventorySix;
            @InventorySix.canceled += instance.OnInventorySix;
            @InventoryUp.started += instance.OnInventoryUp;
            @InventoryUp.performed += instance.OnInventoryUp;
            @InventoryUp.canceled += instance.OnInventoryUp;
            @InventoryDown.started += instance.OnInventoryDown;
            @InventoryDown.performed += instance.OnInventoryDown;
            @InventoryDown.canceled += instance.OnInventoryDown;
        }

        private void UnregisterCallbacks(IPlayerActions instance)
        {
            @Movement.started -= instance.OnMovement;
            @Movement.performed -= instance.OnMovement;
            @Movement.canceled -= instance.OnMovement;
            @InventoryOne.started -= instance.OnInventoryOne;
            @InventoryOne.performed -= instance.OnInventoryOne;
            @InventoryOne.canceled -= instance.OnInventoryOne;
            @InventoryTwo.started -= instance.OnInventoryTwo;
            @InventoryTwo.performed -= instance.OnInventoryTwo;
            @InventoryTwo.canceled -= instance.OnInventoryTwo;
            @InventoryThree.started -= instance.OnInventoryThree;
            @InventoryThree.performed -= instance.OnInventoryThree;
            @InventoryThree.canceled -= instance.OnInventoryThree;
            @InventoryFour.started -= instance.OnInventoryFour;
            @InventoryFour.performed -= instance.OnInventoryFour;
            @InventoryFour.canceled -= instance.OnInventoryFour;
            @InventoryFive.started -= instance.OnInventoryFive;
            @InventoryFive.performed -= instance.OnInventoryFive;
            @InventoryFive.canceled -= instance.OnInventoryFive;
            @InventorySix.started -= instance.OnInventorySix;
            @InventorySix.performed -= instance.OnInventorySix;
            @InventorySix.canceled -= instance.OnInventorySix;
            @InventoryUp.started -= instance.OnInventoryUp;
            @InventoryUp.performed -= instance.OnInventoryUp;
            @InventoryUp.canceled -= instance.OnInventoryUp;
            @InventoryDown.started -= instance.OnInventoryDown;
            @InventoryDown.performed -= instance.OnInventoryDown;
            @InventoryDown.canceled -= instance.OnInventoryDown;
        }

        public void RemoveCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IPlayerActions instance)
        {
            foreach (var item in m_Wrapper.m_PlayerActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_PlayerActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    public interface IPlayerActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnInventoryOne(InputAction.CallbackContext context);
        void OnInventoryTwo(InputAction.CallbackContext context);
        void OnInventoryThree(InputAction.CallbackContext context);
        void OnInventoryFour(InputAction.CallbackContext context);
        void OnInventoryFive(InputAction.CallbackContext context);
        void OnInventorySix(InputAction.CallbackContext context);
        void OnInventoryUp(InputAction.CallbackContext context);
        void OnInventoryDown(InputAction.CallbackContext context);
    }
}