using UnityEngine;
using UnityEngine.SceneManagement;

public class MainCameraScript : MonoBehaviour {

	public static int score;
	public static int racket;
    public static int level = 1;
    public static int countInitBlock;
    public static bool testGame;
    // Use this for initialization
    void Start () {
		score = 0;
       
		racket = 5;
        countInitBlock = 0;
    }
	void OnGUI() //Для отладки игрового цикла
    {
        Scene scene = SceneManager.GetActiveScene();

        GUI.Label (new Rect(20, 15, 100, 25), "Уровень: " + level);
        GUI.Label (new Rect(20, 40, 100, 25),  "Счет: " + score);
		GUI.Label (new Rect(20, 65, 100, 25),  "Жизни: " + racket);
        GUI.Label(new Rect(20, 90, 150, 25), "Всего блоков: " + countInitBlock);
    }
}
