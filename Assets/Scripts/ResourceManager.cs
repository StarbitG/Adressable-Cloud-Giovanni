using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;
using System.Collections.Generic;

public class ResourceManager : MonoBehaviour
{
   public AssetReference AssetReference;
   public List<GameObject> prefab = new List<GameObject>();
   AsyncOperationHandle<GameObject> handle;

    public void LoadAsset()
    {
        handle = AssetReference.InstantiateAsync
            (transform.position, Quaternion.identity);

        handle.Completed += hande => { prefab.Add(handle.Result); };
    }

    public void UnloadAsset()
    {
        foreach (var prefab in prefab)
        {
            Addressables.ReleaseInstance(prefab);
        }
        prefab.Clear();
    }
}
