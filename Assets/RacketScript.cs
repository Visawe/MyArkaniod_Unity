using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RacketScript : MonoBehaviour {

    public static float speed = 200;
	// Update is called once per frame
	void Update () {
		
	}

    // Update is called once per frame после завершения цикла расчета физики
    void FixedUpdate()
    {
        float h = Input.GetAxisRaw("Horizontal"); //h < 0, h > 0
        #region Для тача на андроиде
        if (Input.touchCount > 0)
        {
            if (Input.GetTouch(0).phase == TouchPhase.Moved)
            {
                Vector2 tDelta = Input.GetTouch(0).deltaPosition;
                if (tDelta.x > 0)
                    h = 1;
                else
                    h = -1;
            }
        }
        #endregion
        GetComponent<Rigidbody2D>().velocity = h * speed * Vector2.right; //в результате операции умножения получаем вектор
        //GetComponent<Rigidbody2D>().velocity = new Vector2(h, speed); //в результате операции умножения получаем вектор
    }
}
