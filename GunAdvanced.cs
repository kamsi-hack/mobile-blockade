using UnityEngine;

public class GunAdvanced : MonoBehaviour
{
    public float recoilAmount = 2f;
    public Camera cam;
    public AudioSource audioSource;
    public AudioClip gunSound;

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        // Recoil
        cam.transform.localRotation *= Quaternion.Euler(-recoilAmount, 0, 0);

        // Sound
        audioSource.PlayOneShot(gunSound);

        // Shooting logic
        Debug.Log("Bang!");
    }
}
