using System.Collections;
using UnityEngine;

public class Vongdoi : MonoBehaviour
{
    private void Awake()
    {

    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(Demo());
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnDisable()
    {

    }

    private void OnDestroy()
    {

    }

    private IEnumerator Demo()
    {
        yield return new WaitForSeconds(1);
        Debug.Log("Hello");
    }
}
