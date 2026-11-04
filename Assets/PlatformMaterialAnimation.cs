using UnityEngine;

public class PlatformMaterialAnimation : MonoBehaviour
{

    [SerializeField] private Renderer platformRenderer;

    [SerializeField] private Material lowestMaterial;
    [SerializeField] private Material highestMaterial;

    public void SetLowestMaterial()
    {
        platformRenderer.material = lowestMaterial;
    }

    public void SetHighestMaterial()
    {
        platformRenderer.material = highestMaterial;
    }

    
}
