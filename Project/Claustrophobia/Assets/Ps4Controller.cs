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
    public struct PlayerActions
    {
        private @Ps4Controller m_Wrapper;
        public PlayerActions(@Ps4Controller wrapper) { m_Wrapper = wrapper; }
        public InputAction @MovePlayer => m_Wrapper.m_Player_MovePlayer;
        public InputAction @RotatePlayer => m_Wrapper.m_Player_RotatePlayer;
        public InputAction @LightsOn => m_Wrapper.m_Player_LightsOn;
        public InputAction @LanternOn => m_Wrapper.m_Player_LanternOn;
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
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    public interface IPlayerActions
    {
        void OnMovePlayer(InputAction.CallbackContext context);
        void OnRotatePlayer(InputAction.CallbackContext context);
        void OnLightsOn(InputAction.CallbackContext context);
        void OnLanternOn(InputAction.CallbackContext context);
    }
}
