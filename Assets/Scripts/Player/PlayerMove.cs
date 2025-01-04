using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private Rigidbody2D rigid;
    private float h, v;
    [SerializeField] private float moveSpeed;
    void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        h = Input.GetAxisRaw("Horizontal");
        v = Input.GetAxisRaw("Vertical");
        PlayerMovement(h, v);
    }

    /// <summary>
    /// 조작 이동 함수
    /// </summary>
    /// <param name="x">horizontal</param>
    /// <param name="y">vertical</param>
    void PlayerMovement(float x, float y)
    {
        Vector2 moveVec = new Vector2(x, y).normalized;
        rigid.velocity = moveVec * moveSpeed;
    }
}
