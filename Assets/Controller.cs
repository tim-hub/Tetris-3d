using UnityEngine;
using System.Collections;

public class Controller : MonoBehaviour
{
    public float speed = 1.0f;
    protected int go = 1;
    // Use this for initialization
    void Start()
    {
    }
    void OnCollisionEnter()
    {
        go = 0;
    }
    // Update is called once per frame
    void Update()
    {
        if (go == 1)
        {
            transform.Translate(0, -speed * Time.deltaTime, 0f);
        }
    }
}
