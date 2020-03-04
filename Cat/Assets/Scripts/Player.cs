using UnityEngine;
using UnityEngine.SceneManagement;


public class Player : MonoBehaviour
{
    private Rigidbody2D playerigidbody2D;
    private Animator ani; 

    private void Start()
    {
        playerigidbody2D = GetComponent<Rigidbody2D>();
        ani = GetComponent<Animator>();        
    }

    /// <summary>
    /// 腳色移動:左右
    /// </summary>
    public void Right(int v)
    {
        gameObject.transform.position += new Vector3(v * 0.05f, 0, 0);        //設定用按鈕去 左右 操作玩家
        ani.SetBool("向右", v == 1 && v != 0 ? true : false);                 //如果判斷 v 值為 1 時 就為 true 不是就 false
        ani.SetBool("向左", v == -1 && v != 0 ? true : false);                //如果判斷 v 值為 -1 時 就為 true 不是就 false

    }
    /// <summary>
    /// 腳色移動:上下
    /// </summary>    
    public void UP(int h)
    {   
        gameObject.transform.position += new Vector3(0, h * 0.05f, 0);        //設定用按鈕去 上下 操作玩家
        ani.SetBool("向後", h == 1 && h != 0 ? true : false);                 //如果判斷 h 值為 1 時 就為 true 不是就 false
        ani.SetBool("向前", h == -1 && h != 0 ? true : false);                //如果判斷 h 值為 -1 時 就為 true 不是就 false

    }


    /// <summary>
    /// 設定一個計時器並且到時間就跳到另一個畫面
    /// </summary>
    private float timer;
    private void OnTriggerStay2D(Collider2D collision)
    {
        timer += Time.deltaTime;
        if (timer>5)
        {
            SceneManager.LoadScene("戰鬥畫面");
            timer = 0;
        }
    }


    //private int R;
    //private bool open;
    //private void OnTriggerEnter2D(Collider2D collision)
    //{
    //    if (collision.name == "草叢")
    //    {
    //        open = true;
    //    }
    //}
    //private void Move()
    //{
    //    if (open==true)
    //    {
    //        R = Random.Range(0, 9);
    //        if (R < 4)
    //        {
    //            SceneManager.LoadScene("戰鬥畫面");
    //        }
    //    }
    //}


}
