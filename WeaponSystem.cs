using UnityEngine;

public class WeaponSystem : MonoBehaviour
{
    public int ammo = 30;
    public int maxAmmo = 30;
    public Animator animator;

    void Update()
    {
        if (Input.GetButtonDown("Fire1") && ammo > 0)
        {
            Shoot();
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            Reload();
        }
    }

    void Shoot()
    {
        ammo--;
        animator.SetTrigger("Shoot");
    }

    void Reload()
    {
        ammo = maxAmmo;
        animator.SetTrigger("Reload");
    }
}
