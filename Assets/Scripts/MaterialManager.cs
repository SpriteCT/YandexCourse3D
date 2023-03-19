using UnityEngine;

public class MaterialManager : MonoBehaviour
{
    private Renderer _renderer;

    public void SetMaterial(Material material)
    {
        foreach (Transform child in transform)
        {
            _renderer = child.gameObject.GetComponent<Renderer>();
            _renderer.material = material;
        }
    }

}
