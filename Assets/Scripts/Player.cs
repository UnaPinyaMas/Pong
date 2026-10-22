using UnityEngine;

public class Player : MonoBehaviour
{
    public KeyCode up;
    public KeyCode down;
    public float speedMovement;

    public bool isAI;
    public Transform ball;

    void Update()
    {
        Vector3 pos = transform.position;

        if (isAI)
        {
            if (ball.position.y > pos.y && pos.y < 3.31f)
            {
                pos.y += Time.deltaTime * speedMovement;
            }

            if (ball.position.y < pos.y && pos.y > -3.11f)
            {
                pos.y -= Time.deltaTime * speedMovement;
            }
        }
        else
        {
            if (Input.GetKey(up) && pos.y < 3.31f)
            {
                pos.y += Time.deltaTime * speedMovement;
            }

            if (Input.GetKey(down) && pos.y > -3.11f)
            {
                pos.y -= Time.deltaTime * speedMovement;
            }
        }

        transform.position = pos;
    }
}