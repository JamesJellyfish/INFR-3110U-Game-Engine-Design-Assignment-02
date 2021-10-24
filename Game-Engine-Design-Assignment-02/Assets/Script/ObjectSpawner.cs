using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject Spawning;
    public GameObject parent;
    public int SpawnAmount;
    public int limit;
    public float rate;
    float Timer;
    // Start is called before the first frame update
    void Start()
    {
        Timer = rate;
    }

    // Update is called once per frame
    void Update()
    {
        if (parent.transform.childCount < limit)
        {
            Timer -= Time.fixedDeltaTime;
            if (Timer <= 0f)
            {
                for (int i = 0; i < SpawnAmount; i++)
                {
                    Instantiate(Spawning, new Vector3(this.transform.position.x + GetModifier(), this.transform.position.y + GetModifier(), this.transform.position.z + GetModifier())
                        , Quaternion.identity, parent.transform);
                }
                Timer = rate;
            }
        }
    }

    float GetModifier()
    {
        float modifier = Random.Range(0f, 5f);
        if (Random.Range(0, 2) > 0)
            return -modifier;
        else
            return modifier;
    }
}
