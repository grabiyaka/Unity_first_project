using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class СreateObject : MonoBehaviour
{
  public GameObject[] obj ;
  public float speed = 5f;

  private void Start() {
    // GameObject newGameObject = Instantiate(obj, new Vector3(0, 8, 0), Quaternion.Euler(5f, -13f, 6f)) as GameObject;
    // newGameObject.GetComponent<Transform>().position = new Vector3(4, 5, 0);
    for (int i = 0; i < 5; i++)
    {
        Instantiate(obj[Random.Range(0, obj.Length)], new Vector3(RandomInt(), RandomInt(), RandomInt()), Quaternion.Euler(RandomInt(), RandomInt(), RandomInt()));
    }
  }

  private int RandomInt(){
    return Random.Range(0, 10);
  }

  private void Update() {
    // obj.GetComponent<Transform>().Translate(new Vector3(1, 1, 0) * speed * Time.deltaTime);
  }
}
