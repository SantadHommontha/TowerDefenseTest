using UnityEngine;

public class AArray : MonoBehaviour
{

    



    public float timer = 0;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= 1 && timer <= 2)
        {
            Debug.Log(message1);
        }
        else if (timer >= 2 && timer <= 3)
        {
            Debug.Log(message2);
        }
        else if (timer >= 3 && timer <= 4)
        {
            Debug.Log(message3);
        }
        else if (timer >= 4 && timer <= 5)
        {
            Debug.Log(message4);
        }
        else if (timer >= 5 && timer <= 6)
        {
            Debug.Log(message5);
        }

    }
}
