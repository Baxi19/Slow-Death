// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/PlayerControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""PlayerMain"",
            ""id"": ""f5ab71cd-ae02-4105-ac33-c60ad0385ff1"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""82c89137-ec56-46b1-8a47-78cc093a763c"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""9e5d9894-427c-46b9-a9e2-5d93b072de01"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Look"",
                    ""type"": ""Value"",
                    ""id"": ""9edeeb95-b6f3-4ca8-a6b1-aa46126a7d14"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Attack-1"",
                    ""type"": ""Button"",
                    ""id"": ""fdcdc59e-8a5f-4ad8-9b4f-47a61ff365c1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Attack-2"",
                    ""type"": ""Button"",
                    ""id"": ""4433de9a-78a6-4f23-8e58-87a6b4b5f25a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Attack-3"",
                    ""type"": ""Button"",
                    ""id"": ""1679efdf-77c9-4f45-b9e2-eab9c94f592b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Attack-4"",
                    ""type"": ""Button"",
                    ""id"": ""e7989c8a-0075-410f-961a-45f68825af89"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Emote-1"",
                    ""type"": ""Button"",
                    ""id"": ""aaa86f9e-cd3a-4e43-85e2-e66a4549b0fe"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Emote-2"",
                    ""type"": ""Button"",
                    ""id"": ""13d303b0-7acf-4cf2-b62c-fa28ba4f2dbb"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Emote-3"",
                    ""type"": ""Button"",
                    ""id"": ""88a59a12-46b1-42a9-b8ae-191c50e3aaa8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Emote-4"",
                    ""type"": ""Button"",
                    ""id"": ""eadd1db1-3595-4fbd-a89b-6b25d84fc363"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""518080df-9229-426d-b529-ff62420555b2"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""4717abf5-12d1-4b4e-a341-582c23ef2b43"",
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
                    ""id"": ""097724d0-6f28-44b3-b4c5-089ecf491e3c"",
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
                    ""id"": ""853ad453-a203-4753-8fa2-19e721a9f846"",
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
                    ""id"": ""6cffa02d-1907-44b1-9d29-be5f1708e8af"",
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
                    ""id"": ""3b0e1af6-6665-471d-bad2-5dca86a81b27"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""087df421-529a-43bd-83d9-7e44e6eced3a"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""866af9e8-9f45-4e5f-bf91-1231a92fe322"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""382a0549-a7ce-45b5-88bc-9dcf7acb1347"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""336c3707-b1f1-4533-8648-c5eea55a19eb"",
                    ""path"": ""<Keyboard>/1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Attack-1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""849a9b72-7b14-4863-af28-48e3914ceac0"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Attack-1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2214a522-6e70-4cd9-bebd-7c85a7e55e3a"",
                    ""path"": ""<Keyboard>/2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Attack-2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""621236c4-1451-4a6b-8d7e-382ae2b391c3"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Attack-2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f950d3f4-2042-48e4-ac51-39c88a868eca"",
                    ""path"": ""<Keyboard>/3"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Attack-3"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""52ca5601-7b45-46a4-bf14-e8cfdb993cf1"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Attack-3"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""19121db0-1f1c-4bd2-85dd-fab6a10f80d5"",
                    ""path"": ""<Keyboard>/4"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Attack-4"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d9a7129a-841b-4919-82e4-dbb3f43f26ab"",
                    ""path"": ""<Keyboard>/5"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Emote-1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""92aca029-a734-4690-8fc6-609c8c4a6a91"",
                    ""path"": ""<Keyboard>/6"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Emote-2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""628d3c71-24c3-493d-99b1-9266bfee7183"",
                    ""path"": ""<Keyboard>/7"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Emote-3"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""db62c7ec-4e91-4988-bc46-b7d73622e5d1"",
                    ""path"": ""<Keyboard>/8"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Emote-4"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // PlayerMain
        m_PlayerMain = asset.FindActionMap("PlayerMain", throwIfNotFound: true);
        m_PlayerMain_Move = m_PlayerMain.FindAction("Move", throwIfNotFound: true);
        m_PlayerMain_Jump = m_PlayerMain.FindAction("Jump", throwIfNotFound: true);
        m_PlayerMain_Look = m_PlayerMain.FindAction("Look", throwIfNotFound: true);
        m_PlayerMain_Attack1 = m_PlayerMain.FindAction("Attack-1", throwIfNotFound: true);
        m_PlayerMain_Attack2 = m_PlayerMain.FindAction("Attack-2", throwIfNotFound: true);
        m_PlayerMain_Attack3 = m_PlayerMain.FindAction("Attack-3", throwIfNotFound: true);
        m_PlayerMain_Attack4 = m_PlayerMain.FindAction("Attack-4", throwIfNotFound: true);
        m_PlayerMain_Emote1 = m_PlayerMain.FindAction("Emote-1", throwIfNotFound: true);
        m_PlayerMain_Emote2 = m_PlayerMain.FindAction("Emote-2", throwIfNotFound: true);
        m_PlayerMain_Emote3 = m_PlayerMain.FindAction("Emote-3", throwIfNotFound: true);
        m_PlayerMain_Emote4 = m_PlayerMain.FindAction("Emote-4", throwIfNotFound: true);
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

    // PlayerMain
    private readonly InputActionMap m_PlayerMain;
    private IPlayerMainActions m_PlayerMainActionsCallbackInterface;
    private readonly InputAction m_PlayerMain_Move;
    private readonly InputAction m_PlayerMain_Jump;
    private readonly InputAction m_PlayerMain_Look;
    private readonly InputAction m_PlayerMain_Attack1;
    private readonly InputAction m_PlayerMain_Attack2;
    private readonly InputAction m_PlayerMain_Attack3;
    private readonly InputAction m_PlayerMain_Attack4;
    private readonly InputAction m_PlayerMain_Emote1;
    private readonly InputAction m_PlayerMain_Emote2;
    private readonly InputAction m_PlayerMain_Emote3;
    private readonly InputAction m_PlayerMain_Emote4;
    public struct PlayerMainActions
    {
        private @PlayerControls m_Wrapper;
        public PlayerMainActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_PlayerMain_Move;
        public InputAction @Jump => m_Wrapper.m_PlayerMain_Jump;
        public InputAction @Look => m_Wrapper.m_PlayerMain_Look;
        public InputAction @Attack1 => m_Wrapper.m_PlayerMain_Attack1;
        public InputAction @Attack2 => m_Wrapper.m_PlayerMain_Attack2;
        public InputAction @Attack3 => m_Wrapper.m_PlayerMain_Attack3;
        public InputAction @Attack4 => m_Wrapper.m_PlayerMain_Attack4;
        public InputAction @Emote1 => m_Wrapper.m_PlayerMain_Emote1;
        public InputAction @Emote2 => m_Wrapper.m_PlayerMain_Emote2;
        public InputAction @Emote3 => m_Wrapper.m_PlayerMain_Emote3;
        public InputAction @Emote4 => m_Wrapper.m_PlayerMain_Emote4;
        public InputActionMap Get() { return m_Wrapper.m_PlayerMain; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerMainActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerMainActions instance)
        {
            if (m_Wrapper.m_PlayerMainActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_PlayerMainActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_PlayerMainActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_PlayerMainActionsCallbackInterface.OnMove;
                @Jump.started -= m_Wrapper.m_PlayerMainActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_PlayerMainActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_PlayerMainActionsCallbackInterface.OnJump;
                @Look.started -= m_Wrapper.m_PlayerMainActionsCallbackInterface.OnLook;
                @Look.performed -= m_Wrapper.m_PlayerMainActionsCallbackInterface.OnLook;
                @Look.canceled -= m_Wrapper.m_PlayerMainActionsCallbackInterface.OnLook;
                @Attack1.started -= m_Wrapper.m_PlayerMainActionsCallbackInterface.OnAttack1;
                @Attack1.performed -= m_Wrapper.m_PlayerMainActionsCallbackInterface.OnAttack1;
                @Attack1.canceled -= m_Wrapper.m_PlayerMainActionsCallbackInterface.OnAttack1;
                @Attack2.started -= m_Wrapper.m_PlayerMainActionsCallbackInterface.OnAttack2;
                @Attack2.performed -= m_Wrapper.m_PlayerMainActionsCallbackInterface.OnAttack2;
                @Attack2.canceled -= m_Wrapper.m_PlayerMainActionsCallbackInterface.OnAttack2;
                @Attack3.started -= m_Wrapper.m_PlayerMainActionsCallbackInterface.OnAttack3;
                @Attack3.performed -= m_Wrapper.m_PlayerMainActionsCallbackInterface.OnAttack3;
                @Attack3.canceled -= m_Wrapper.m_PlayerMainActionsCallbackInterface.OnAttack3;
                @Attack4.started -= m_Wrapper.m_PlayerMainActionsCallbackInterface.OnAttack4;
                @Attack4.performed -= m_Wrapper.m_PlayerMainActionsCallbackInterface.OnAttack4;
                @Attack4.canceled -= m_Wrapper.m_PlayerMainActionsCallbackInterface.OnAttack4;
                @Emote1.started -= m_Wrapper.m_PlayerMainActionsCallbackInterface.OnEmote1;
                @Emote1.performed -= m_Wrapper.m_PlayerMainActionsCallbackInterface.OnEmote1;
                @Emote1.canceled -= m_Wrapper.m_PlayerMainActionsCallbackInterface.OnEmote1;
                @Emote2.started -= m_Wrapper.m_PlayerMainActionsCallbackInterface.OnEmote2;
                @Emote2.performed -= m_Wrapper.m_PlayerMainActionsCallbackInterface.OnEmote2;
                @Emote2.canceled -= m_Wrapper.m_PlayerMainActionsCallbackInterface.OnEmote2;
                @Emote3.started -= m_Wrapper.m_PlayerMainActionsCallbackInterface.OnEmote3;
                @Emote3.performed -= m_Wrapper.m_PlayerMainActionsCallbackInterface.OnEmote3;
                @Emote3.canceled -= m_Wrapper.m_PlayerMainActionsCallbackInterface.OnEmote3;
                @Emote4.started -= m_Wrapper.m_PlayerMainActionsCallbackInterface.OnEmote4;
                @Emote4.performed -= m_Wrapper.m_PlayerMainActionsCallbackInterface.OnEmote4;
                @Emote4.canceled -= m_Wrapper.m_PlayerMainActionsCallbackInterface.OnEmote4;
            }
            m_Wrapper.m_PlayerMainActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Look.started += instance.OnLook;
                @Look.performed += instance.OnLook;
                @Look.canceled += instance.OnLook;
                @Attack1.started += instance.OnAttack1;
                @Attack1.performed += instance.OnAttack1;
                @Attack1.canceled += instance.OnAttack1;
                @Attack2.started += instance.OnAttack2;
                @Attack2.performed += instance.OnAttack2;
                @Attack2.canceled += instance.OnAttack2;
                @Attack3.started += instance.OnAttack3;
                @Attack3.performed += instance.OnAttack3;
                @Attack3.canceled += instance.OnAttack3;
                @Attack4.started += instance.OnAttack4;
                @Attack4.performed += instance.OnAttack4;
                @Attack4.canceled += instance.OnAttack4;
                @Emote1.started += instance.OnEmote1;
                @Emote1.performed += instance.OnEmote1;
                @Emote1.canceled += instance.OnEmote1;
                @Emote2.started += instance.OnEmote2;
                @Emote2.performed += instance.OnEmote2;
                @Emote2.canceled += instance.OnEmote2;
                @Emote3.started += instance.OnEmote3;
                @Emote3.performed += instance.OnEmote3;
                @Emote3.canceled += instance.OnEmote3;
                @Emote4.started += instance.OnEmote4;
                @Emote4.performed += instance.OnEmote4;
                @Emote4.canceled += instance.OnEmote4;
            }
        }
    }
    public PlayerMainActions @PlayerMain => new PlayerMainActions(this);
    public interface IPlayerMainActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnLook(InputAction.CallbackContext context);
        void OnAttack1(InputAction.CallbackContext context);
        void OnAttack2(InputAction.CallbackContext context);
        void OnAttack3(InputAction.CallbackContext context);
        void OnAttack4(InputAction.CallbackContext context);
        void OnEmote1(InputAction.CallbackContext context);
        void OnEmote2(InputAction.CallbackContext context);
        void OnEmote3(InputAction.CallbackContext context);
        void OnEmote4(InputAction.CallbackContext context);
    }
}
