using System.Collections;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float _moveSpeed = 5f;
    public Transform movePoint;
    public LayerMask collisionSet;
    public LayerMask enemySet;
    public LayerMask itemSet;
    public LayerMask exitSet;
    public LayerMask puzzleSet;

    private Transform exitPoint;

    void Start()
    {
        movePoint.parent = null;
        exitPoint = GameObject.FindGameObjectWithTag("Exit").transform;

    }

    // Update is called once per frame
    void Update()
    {
        MoveToMovePoint();
        if (Vector3.Distance(transform.position, movePoint.position) <= .05f)
        {
            CheckIfCollidesWithWallAndMoveMovePoint();
            if (CheckIfCollidesWithEnemy())
            {
                transform.position = exitPoint.position;
                movePoint.position = transform.position;
            }

        }
    }
    

    void MoveToMovePoint()
    {
        transform.position = Vector3.MoveTowards(transform.position, movePoint.position, _moveSpeed * Time.deltaTime);
    }

    void CheckIfCollidesWithWallAndMoveMovePoint()
    {
        float xInput = Input.GetAxisRaw("Horizontal");
        float yInput = Input.GetAxisRaw("Vertical");

        if (Mathf.Abs(xInput) == 1f)
        {
            if (!Physics2D.OverlapCircle(movePoint.position + new Vector3(xInput, 0f, 0f), .2f, collisionSet))
            {
                movePoint.position += new Vector3(xInput, 0f, 0f);
            }
        }
        if (Mathf.Abs(yInput) == 1f)
        {
            if (!Physics2D.OverlapCircle(movePoint.position + new Vector3(0f, yInput, 0f), .2f, collisionSet))
            {
                if (xInput != 0)
                    yInput = 0;
                movePoint.position += new Vector3(0f, yInput, 0f);
            }
        }
    }


    bool CheckIfCollidesWithEnemy()
    {
        return Physics2D.OverlapCircle(movePoint.position, .2f, enemySet);
    }
}
