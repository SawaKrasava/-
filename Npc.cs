using UnityEngine;

public class Npc : MonoBehaviour
{
    //здоровье Npc
    public int health = 5;

    //Левел Nps
    public int level = 1;

    //Скорость Nps
    public float speed = 1.2f;

    Vector3 newPosition = transform.position;
    //Не понял как деалть(((


    void Start()
    {
        print("int health = 5");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
