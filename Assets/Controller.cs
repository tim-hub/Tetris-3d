using UnityEngine;
using System.Collections;

public class Controller : MonoBehaviour
{
    private float speed = 1.0f;
    // Use this for initialization
    void Start()
    {
    //Bajer, napisze sobie bo cos moge :D
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, -speed * Time.deltaTime, 0f);
    }
}
