using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _EnemyController : MonoBehaviour
{
    public float waitTime = .8f;
    public float moveSpeed = 2f;

    void Update()
    {
        StartCoroutine(Attack());
    }

    IEnumerator Attack()
    {
        yield return new WaitForSeconds(waitTime);
        transform.Translate(Vector2.up * moveSpeed * Time.deltaTime);
    }
}
