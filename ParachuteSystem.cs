using UnityEngine;

public class ParachuteSystem : MonoBehaviour
{
    public float fallSpeed = -20f;
    public float parachuteSpeed = -5f;
    public bool parachuteOpen = false;

    CharacterController controller;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            parachuteOpen = true;
        }

        float speed = parachuteOpen ? parachuteSpeed : fallSpeed;

        Vector3 move = new Vector3(0, speed, 0);
        controller.Move(move * Time.deltaTime);
    }
}
