using UnityEngine;

public class LoadAssets : MonoBehaviour
{
    ResourceManager manager;

    private void Start()
    {  
        manager = GetComponentInParent<ResourceManager>(); 
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (manager.prefab.Count == 0) manager.LoadAsset();
        }
    }
}
