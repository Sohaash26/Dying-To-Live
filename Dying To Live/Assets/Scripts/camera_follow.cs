using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_follow : MonoBehaviour
{
    public Transform Target;
    public float cameraspeed;
    public float minx, maxx;
    public float miny, maxy;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void FixedUpdate()
    {

        if (Target != null)
        {
            Vector2 newCamPosition = Vector2.Lerp(transform.position, Target.position, Time.deltaTime * cameraspeed);

            float ClampX = Mathf.Clamp(newCamPosition.x, minx, maxx);
            float ClampY = Mathf.Clamp(newCamPosition.y, minx, minx);

            transform.position = new Vector3(ClampX, ClampY, -10f);

        }
    }
}
