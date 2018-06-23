using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;

    public class Test : MonoBehaviour
    {


    public class Boss
    {
        private int hp = 100;   //体力
        private int power = 25; // 攻撃力
        private int mp = 25;    //マジックポイント
        private int MP = 5;


        //攻撃用関数
        public void Attack()
        {
            Debug.Log(this.power + "のダメージを与えた");
        }
        //防御用
        public void Defence(int damage)
        {
            Debug.Log(damage + "のダメージを受けた");
            //残りhpを減らす
            this.hp -= damage;
        }
        //Magic関数
        public void Magic(int magic)
        {
            if (mp > 5)
            {
                //mpが足りない場合
                Debug.Log("MPが足りないため魔法が使えない。");
            }
            else
            {
                Debug.Log("魔法攻撃をした。残りMPは" + magic + "。");
                //残りmpを減らす
                this.mp - MP = magic;
            }
        }

    }

    public class Test : MonoBehaviour
    {

        void Start()
        {
            Boss lastboss = new Boss();

            // 攻撃用
            lastboss.Attack();
            // 防御用
            lastboss.Defence(3);
        }
        // Update is called once per frame
        void Update()
        {
        }
    }

    public class Test2
    {

        // Use this for initialization
        void Start()
        {
            // 要素数5の配列を初期化する
            int[] points = new int[5];

            // 配列の各要素に値を代入する
            points[0] = 30;
            points[1] = 20;
            points[2] = 50;
            points[3] = 10;
            points[4] = 80;

            // 配列の要素をすべて表示する
            for (int i = 0; i < 5; i++)
            {
                Debug.Log(points[i]);
            }
        }

        // Update is called once per frame
        void Update()
        {

        }
    }

}