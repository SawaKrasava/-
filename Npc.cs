using UnityEngine;

public class Npc : MonoBehaviour
{
    //�������� Npc
    public int health = 5;

    //����� Nps
    public int level = 1;

    //�������� Nps
    public float speed = 1.2f;

   


    void Start()
    {
        health = health + level;
        print("������: " + health);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newposition = transform.position;
        newposition.z += speed * Time.deltaTime;
        transform.position = newposition;
    }
}
