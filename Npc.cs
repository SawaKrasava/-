using UnityEngine;

public class Npc : MonoBehaviour
{
    //здоровье Npc
    public int health = 5;

    //Левел Nps
    public int level = 1;

    //Скорость Nps
    public float speed = 1.2f;

   


    void Start()
    {
        health = health + level;
        print("Жизней: " + health);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newposition = transform.position;
        newposition.z += speed * Time.deltaTime;
        transform.position = newposition;
    }
}
