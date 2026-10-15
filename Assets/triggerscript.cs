using UnityEngine;

public class changecolor : MonoBehaviour
{
    public GameObject Door;
    public GameObject win;
    public GameObject lose;
    public GameObject floor;
    public GameObject key;
    public Vector3 doormove;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter()
    {
        floor.GetComponent<MeshRenderer>().material.color = Color.orange;
        Door.GetComponent<Transform>().position = doormove;
        key.GetComponent<MeshRenderer>().material.color = Color.pink;
        Door.GetComponent<MeshRenderer>().material.color = Color.purple;
        lose.GetComponent<MeshRenderer>().material.color = Color.red;
        win.GetComponent<MeshRenderer>().material.color = Color.green;
    }
}