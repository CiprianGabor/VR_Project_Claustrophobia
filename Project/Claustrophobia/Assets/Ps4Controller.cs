// GENERATED AUTOMATICALLY FROM 'Assets/Ps4Controller.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Ps4Controller : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Ps4Controller()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Ps4Controller"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""0472afa9-9440-4089-9613-a31e5d5ce2d7"",
            ""actions"": [
                {
                    ""name"": ""MovePlayer"",
                    ""type"": ""Value"",
                    ""id"": ""9c05799a-bcdc-4137-9210-3036aa8aa6d0"",
                    ""expectedControlType"": ""Stick"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RotatePlayer"",
                    ""type"": ""Value"",
                    ""id"": ""a096c89f-37fe-4ffe-95d5-1ac656e4692b"",
                    ""expectedControlType"": ""Stick"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""LightsOn"",
                    ""type"": ""Button"",
                    ""id"": ""c1a3f177-b026-4151-ae92-5f624252c2d6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""LanternOn"",
                    ""type"": ""Button"",
                    ""id"": ""deffd06e-0808-4b35-a310-fdbfa228573f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Shrink"",
                    ""type"": ""Button"",
                    ""id"": ""318b0281-f105-463f-a2dd-97714ca9ae60"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Expand"",
                    ""type"": ""Button"",
                    ""id"": ""fb069b67-6486-4d91-ad9b-e1c7640dbc5f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Escape"",
                    ""type"": ""Button"",
                    ""id"": ""f6ad2bb3-f856-4b4d-b728-10bdb1f63096"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Reset"",
                    ""type"": ""Button"",
                    ""id"": ""39238f76-123d-42d4-ada5-676686a2f5ba"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""88245057-a40d-489c-a64b-8b63ddec8d72"",
                    ""path"": ""<DualShockGamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MovePlayer"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""dd6a2665-4dde-4e5e-96f7-2b908ddb1ba1"",
                    ""path"": ""<DualShockGamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RotatePlayer"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d632eb74-7bbe-4473-9080-0b07e32072e2"",
                    ""path"": ""<DualShockGamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LightsOn"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""066aead5-5964-44ca-a100-288c150b027a"",
                    ""path"": ""<DualShockGamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LanternOn"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2d03a77e-c856-420b-be42-80c64750a0e3"",
                    ""path"": ""<DualShockGamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shrink"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fbf058de-31c1-4895-b57d-cd49e05f1661"",
                    ""path"": ""<DualShockGamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Expand"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6b1914f4-4f86-4ece-84c8-23132fdaf43d"",
                    ""path"": ""<DualShockGamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Escape"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""070c6f23-c469-40bf-85eb-8fe0c5af776d"",
                    ""path"": ""<DualShockGamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Reset"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""LookTo"",
            ""id"": ""7c48754d-9f4a-4b55-931d-d225081452ad"",
            ""actions"": [
                {
                    ""name"": ""lookAt"",
                    ""type"": ""Value"",
                    ""id"": ""86f07bdb-dda8-4e95-aff6-250f083f8e35"",
                    ""expectedControlType"": ""Stick"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""f2c178ab-c729-43bc-ad12-a92d0af9b7ed"",
                    ""path"": ""<DualShockGamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""lookAt"",
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
        m_Player_MovePlayer = m_Player.FindAction("MovePlayer", throwIfNotFound: true);
        m_Player_RotatePlayer = m_Player.FindAction("RotatePlayer", throwIfNotFound: true);
        m_Player_LightsOn = m_Player.FindAction("LightsOn", throwIfNotFound: true);
        m_Player_LanternOn = m_Player.FindAction("LanternOn", throwIfNotFound: true);
        m_Player_Shrink = m_Player.FindAction("Shrink", throwIfNotFound: true);
        m_Player_Expand = m_Player.FindAction("Expand", throwIfNotFound: true);
        m_Player_Escape = m_Player.FindAction("Escape", throwIfNotFound: true);
        m_Player_Reset = m_Player.FindAction("Reset", throwIfNotFound: true);
        // LookTo
        m_LookTo = asset.FindActionMap("LookTo", throwIfNotFound: true);
        m_LookTo_lookAt = m_LookTo.FindAction("lookAt", throwIfNotFound: true);
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

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_MovePlayer;
    private readonly InputAction m_Player_RotatePlayer;
    private readonly InputAction m_Player_LightsOn;
    private readonly InputAction m_Player_LanternOn;
    private readonly InputAction m_Player_Shrink;
    private readonly InputAction m_Player_Expand;
    private readonly InputAction m_Player_Escape;
    private readonly InputAction m_Player_Reset;
    public struct PlayerActions
    {
        private @Ps4Controller m_Wrapper;
        public PlayerActions(@Ps4Controller wrapper) { m_Wrapper = wrapper; }
        public InputAction @MovePlayer => m_Wrapper.m_Player_MovePlayer;
        public InputAction @RotatePlayer => m_Wrapper.m_Player_RotatePlayer;
        public InputAction @LightsOn => m_Wrapper.m_Player_LightsOn;
        public InputAction @LanternOn => m_Wrapper.m_Player_LanternOn;
        public InputAction @Shrink => m_Wrapper.m_Player_Shrink;
        public InputAction @Expand => m_Wrapper.m_Player_Expand;
        public InputAction @Escape => m_Wrapper.m_Player_Escape;
        public InputAction @Reset => m_Wrapper.m_Player_Reset;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @MovePlayer.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovePlayer;
                @MovePlayer.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovePlayer;
                @MovePlayer.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovePlayer;
                @RotatePlayer.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRotatePlayer;
                @RotatePlayer.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRotatePlayer;
                @RotatePlayer.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRotatePlayer;
                @LightsOn.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLightsOn;
                @LightsOn.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLightsOn;
                @LightsOn.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLightsOn;
                @LanternOn.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLanternOn;
                @LanternOn.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLanternOn;
                @LanternOn.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLanternOn;
                @Shrink.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnShrink;
                @Shrink.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnShrink;
                @Shrink.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnShrink;
                @Expand.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnExpand;
                @Expand.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnExpand;
                @Expand.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnExpand;
                @Escape.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnEscape;
                @Escape.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnEscape;
                @Escape.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnEscape;
                @Reset.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnReset;
                @Reset.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnReset;
                @Reset.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnReset;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @MovePlayer.started += instance.OnMovePlayer;
                @MovePlayer.performed += instance.OnMovePlayer;
                @MovePlayer.canceled += instance.OnMovePlayer;
                @RotatePlayer.started += instance.OnRotatePlayer;
                @RotatePlayer.performed += instance.OnRotatePlayer;
                @RotatePlayer.canceled += instance.OnRotatePlayer;
                @LightsOn.started += instance.OnLightsOn;
                @LightsOn.performed += instance.OnLightsOn;
                @LightsOn.canceled += instance.OnLightsOn;
                @LanternOn.started += instance.OnLanternOn;
                @LanternOn.performed += instance.OnLanternOn;
                @LanternOn.canceled += instance.OnLanternOn;
                @Shrink.started += instance.OnShrink;
                @Shrink.performed += instance.OnShrink;
                @Shrink.canceled += instance.OnShrink;
                @Expand.started += instance.OnExpand;
                @Expand.performed += instance.OnExpand;
                @Expand.canceled += instance.OnExpand;
                @Escape.started += instance.OnEscape;
                @Escape.performed += instance.OnEscape;
                @Escape.canceled += instance.OnEscape;
                @Reset.started += instance.OnReset;
                @Reset.performed += instance.OnReset;
                @Reset.canceled += instance.OnReset;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);

    // LookTo
    private readonly InputActionMap m_LookTo;
    private ILookToActions m_LookToActionsCallbackInterface;
    private readonly InputAction m_LookTo_lookAt;
    public struct LookToActions
    {
        private @Ps4Controller m_Wrapper;
        public LookToActions(@Ps4Controller wrapper) { m_Wrapper = wrapper; }
        public InputAction @lookAt => m_Wrapper.m_LookTo_lookAt;
        public InputActionMap Get() { return m_Wrapper.m_LookTo; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(LookToActions set) { return set.Get(); }
        public void SetCallbacks(ILookToActions instance)
        {
            if (m_Wrapper.m_LookToActionsCallbackInterface != null)
            {
                @lookAt.started -= m_Wrapper.m_LookToActionsCallbackInterface.OnLookAt;
                @lookAt.performed -= m_Wrapper.m_LookToActionsCallbackInterface.OnLookAt;
                @lookAt.canceled -= m_Wrapper.m_LookToActionsCallbackInterface.OnLookAt;
            }
            m_Wrapper.m_LookToActionsCallbackInterface = instance;
            if (instance != null)
            {
                @lookAt.started += instance.OnLookAt;
                @lookAt.performed += instance.OnLookAt;
                @lookAt.canceled += instance.OnLookAt;
            }
        }
    }
    public LookToActions @LookTo => new LookToActions(this);
    public interface IPlayerActions
    {
        void OnMovePlayer(InputAction.CallbackContext context);
        void OnRotatePlayer(InputAction.CallbackContext context);
        void OnLightsOn(InputAction.CallbackContext context);
        void OnLanternOn(InputAction.CallbackContext context);
        void OnShrink(InputAction.CallbackContext context);
        void OnExpand(InputAction.CallbackContext context);
        void OnEscape(InputAction.CallbackContext context);
        void OnReset(InputAction.CallbackContext context);
    }
    public interface ILookToActions
    {
        void OnLookAt(InputAction.CallbackContext context);
    }
}
