using Unity.Netcode;
using UnityEngine;

public class NetWorkButton : NetworkBehaviour
{
    public MugMaterialChenger MugMaterialChenger;

    public void OnLocalPressed()
    {
        RequestPressServerRpc();
    }

    [ServerRpc(RequireOwnership = false)]
    void RequestPressServerRpc(ServerRpcParams p = default)
    {
        // サーバーで変更してから全員に通知
        NotifyPressedClientRpc();
    }

    [ClientRpc]
    void NotifyPressedClientRpc()
    {
        Debug.Log("押されました！");
        MugMaterialChenger.NextSetMaterials();
        Debug.Log(MugMaterialChenger.CurrentMugType);
    }
}