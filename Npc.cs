using UnityEngine;

public class Npc : MonoBehaviour
{
    //�������� Npc
    public int health = 5;

    //����� Nps
    public int level = 1;

    //�������� Nps
    public float speed = 1.2f;

    Vector3 newPosition = transform.position;
    //�� ����� ��� ������(((


    void Start()
    {
        print("int health = 5");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
