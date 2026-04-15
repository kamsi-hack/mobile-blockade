using UnityEngine;

public class SkinSystem : MonoBehaviour
{
    public Material[] skins;

    public void ApplySkin(int index)
    {
        GetComponent<Renderer>().material = skins[index];
    }
}
