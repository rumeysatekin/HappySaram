using UnityEngine;
using DG.Tweening;

public class MovingObstacle : MonoBehaviour
{
    public Transform  secondPos;
    //public float speed;

    //Vector3 nextPos;
    //void Start()
    //{
    //    nextPos = firstPos.position;
    //}

    //void Update()
    //{
    //    if (transform.position == firstPos.position)
    //    {
    //        nextPos = secondPos.position;
    //    }

    //    else if (transform.position == secondPos.position)
    //    {
    //        nextPos = firstPos.position;
    //    }

    //    transform.position = Vector3.MoveTowards(transform.position, nextPos, speed * Time.deltaTime);
    //}

    //private void OnDrawGizmos()
    //{
    //    Gizmos.DrawLine(firstPos.position, secondPos.position);
    //}

    private void Start()
    {
        transform.DOMove(secondPos.position, 2).SetEase(Ease.InOutSine).SetLoops(-1, LoopType.Yoyo);
    }
}