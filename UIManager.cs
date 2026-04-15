using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Slider healthBar;

    public void UpdateHealth(float health)
    {
        healthBar.value = health;
    }
}
