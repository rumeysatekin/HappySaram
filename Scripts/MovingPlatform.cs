using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public Transform firstPos, secondPos;
    public float speed;

    Vector3 nextPos;
    void Start()
    {
        nextPos = firstPos.position;
    }

    void Update()
    {
        if(transform.position == firstPos.position)
        {
            nextPos= secondPos.position;
        }

        else if(transform.position == secondPos.position)
        {
            nextPos= firstPos.position;
        }

        transform.position = Vector3.MoveTowards(transform.position, nextPos, speed * Time.deltaTime);
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawLine(firstPos.position, secondPos.position);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            collision.collider.transform.SetParent(transform);
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            collision.collider.transform.SetParent(null);
        }
    }
}
