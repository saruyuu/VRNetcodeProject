using Unity.Netcode;
using UnityEngine;

public class NetWorlButton : NetworkBehaviour
{
    public GameObject Mug;
    public void OnLocalPressed()
    {
        if (!IsOwner & !IsServer)
        {
            RequestPressServerRpc();
            return;
        }
        ApplyPress();
    }
    [ServerRpc(RequireOwnership = false)]
    void RequestPressServerRpc(ServerRpcParams p = default)
    {
        ApplyPress();
        NotifyPressedClientRpc();
    }
    void ApplyPress()
    {
        Mug.SetActive(false);
    }
    [ClientRpc]
    void NotifyPressedClientRpc() 
    {
        Mug.SetActive(false);
    }
}
