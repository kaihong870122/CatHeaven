using UnityEngine;


public class Player : MonoBehaviour
{
    public enum Direction {DOWN = 0,UP = 1,LEFT = 2,RIGHT = 3};
    private Direction mDir = Direction.DOWN;
    private bool mWalking = false;
    private Rigidbody2D playerigidbody2D;
    private Animator ani;        
    
    //腳色移動:左右
    public void Right(int v)
    {        
        gameObject.transform.position += new Vector3(v * 0.05f, 0, 0);        
    }
    //腳色移動:上下
    public void UP(int h)
    {
        gameObject.transform.position += new Vector3(0, h * 0.05f, 0);
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        print("a");
        
    }

    private void Move()
    {
        
    }
    //以下測試
    private void Start()
    {
        playerigidbody2D = GetComponent<Rigidbody2D>();
        ani = GetComponent<Animator>();
        this.Dir = mDir;
    }

    public Direction Dir
    {
        get
        {
            return mDir;
        }
        set
        {
            mDir = value;

            ani.SetInteger("向後", (int)mDir);
        }
    }

    public bool IsWalking
    {
        get
        {
            return mWalking;
        }
        set
        {
            mWalking = value;

            ani.SetBool("向前", mWalking);
        }
    }

    public void UpdateWithMoveVector(Vector2 moveVec)
    {

        if (moveVec == Vector2.zero)
        {
            this.IsWalking = false;
            return;
        }

        this.IsWalking = true;
        // X vector has something
        if (moveVec.x > 0)
        {
            this.Dir = Direction.RIGHT;
        }
        else if (moveVec.x < 0)
        {
            this.Dir = Direction.LEFT;
        }

        // X vector = 0
        if (moveVec.y > 0)
        {
            this.Dir = Direction.UP;
        }
        else if (moveVec.y < 0)
        {
            this.Dir = Direction.DOWN;
        }
    }

}
