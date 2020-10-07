using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fractal : MonoBehaviour
{
    public int recursions = 10;
    public int splitNumber = 2;
    public int angle = 30;
    public float scale = 0.667f;

    // Start is called before the first frame update
    void Start()
    {
        recursions -= 1;
        for (int i = 0; i < splitNumber; i++)
        {
            if (recursions > 0)
            {
                var obj = Instantiate(gameObject);
                var rec = obj.GetComponent<Fractal>();
                rec.MoveUp();
                rec.Rot(i);
                rec.Scale();
            }
        }
        
    }

    void MoveUp()
    {
        this.transform.position += this.transform.up * this.transform.localScale.y;
    }

    void Rot(int index)
    {
        this.transform.rotation *= Quaternion.Euler(angle * ((index * 2) - 1), 0, 0);
    }

    void Scale()
    {
        this.transform.localScale *= scale;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
