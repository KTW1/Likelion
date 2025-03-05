using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static ShootingGame.Player;

namespace ShootingGame
{
    public class Bullet //미사일을 만들어보자. 클래스 bullet을 만든다
    {
        public int x;
        public int y;
        public bool fire; //잘 날아갔는지 체크
    }
    public class Player //플레이어를 만든다.
    {
        //getch 키입력 c언어함수. 냅다 가져다 쓰기
        [DllImport("msvcrt.dll")]
        static extern int _getch();

        public int playerX; //플레이어 X좌표고
        public int playerY; //플레이어 Y좌표
        public Bullet[] playerBullet = new Bullet[20]; //총알
        public Bullet[] playerBullet2 = new Bullet[20]; //총알
        public Bullet[] playerBullet3 = new Bullet[20]; //총알
        public int Score = 100;
        public Item item = new Item();
        public int itemCount = 0;

        public Player() //플레이어는 생성자로 초기화하자. 기본세팅
        {
            playerX = 0; //좌표값
            playerY = 12;
            for (int y = 0; y < 20; y++) //20번 반복하면서,
            {
                playerBullet[y] = new Bullet();
                playerBullet[y].x = 0;
                playerBullet[y].y = 0;
                playerBullet[y].fire = false;

                playerBullet2[y] = new Bullet();
                playerBullet2[y].x = 0;
                playerBullet2[y].y = 0;
                playerBullet2[y].fire = false;

                playerBullet3[y] = new Bullet();
                playerBullet3[y].x = 0;
                playerBullet3[y].y = 0;
                playerBullet3[y].fire = false;
            }
        }
        public void GameMain() //메인메뉴 모음
        {
            KeyControl(); //키입력을 한다.
            PlayerDraw(); //플레이어를 그리기
            UIscore();
            if (item.ItemLife)
            {
                item.ItemMove();
                item.ItemDraw();
                CrashItem();
            }
        }

        const int UPKEY = 72;
        const int DOWNKEY = 80;
        const int LEFTKEY = 75;
        const int RIGHTKEY = 77;
        const int SPACEBAR = 32;
        private void KeyControl()
        {
            int pressKey; //정수형 변수선언 키값을 받겠다.
            if (Console.KeyAvailable) //키가 눌리면 true를 return
            {
                pressKey = _getch(); //아스키값이 들어온다. 왼/오
                switch (pressKey)
                {
                    case UPKEY: //상단 막기
                        {
                            playerY--;
                            if (playerY < 1)
                                playerY = 1;
                            break;
                        }
                    case LEFTKEY: //왼쪽 막기
                        {
                            playerX--;
                            if (playerX < 0)
                                playerX = 0;
                            break;
                        }
                    case RIGHTKEY: //오른쪽 막기
                        {
                            playerX++;
                            if (playerX > 75)
                                playerX = 75;
                            break;
                        }
                    case DOWNKEY: //하단 막기
                        {
                            playerY++;
                            if (playerY > 21)
                                playerY = 21;
                            break;
                        }
                    case SPACEBAR: //스페이스바를 누르면
                        for (int y = 0; y < 20; y++) //총알을 발사한다.
                        {
                            if (playerBullet[y].fire == false) //미사일이 false면 발사한다.
                            {
                                playerBullet[y].fire = true; //플레이어 앞 미사일
                                playerBullet[y].x = playerX + 5; //플레이어 앞 미사일
                                playerBullet[y].y = playerY + 1; //한발씩
                                break;
                            }
                        }
                        for (int i = 0; i < 20; i++)
                        {
                            //미사일이 false 발사가능
                            if (playerBullet2[i].fire == false)
                            {
                                playerBullet2[i].fire = true;
                                //플레이어 앞에서 미사일 쏘기 + 5
                                playerBullet2[i].x = playerX + 5;
                                playerBullet2[i].y = playerY;
                                //한발씩 쏘겠다.
                                break;
                            }
                        }
                        for (int i = 0; i < 20; i++)
                        {
                            //미사일이 false 발사가능
                            if (playerBullet3[i].fire == false)
                            {
                                playerBullet3[i].fire = true;
                                //플레이어 앞에서 미사일 쏘기 + 5
                                playerBullet3[i].x = playerX + 5;
                                playerBullet3[i].y = playerY + 2;
                                //한발씩 쏘겠다.
                                break;
                            }
                        }
                        break;
                }
            }
        }
        public class Item
        {
            public string ItemName;
            public string ItemSprite;
            public int itemX = 0;
            public int itemY = 0;
            public bool ItemLife = false;

            public void ItemDraw()
            {
                Console.SetCursorPosition(itemX, itemY);
                ItemSprite = "Item♧";
                Console.Write(ItemSprite);
            }
            public void ItemMove()
            {
                //if(itemX <=1 || itemY <=1)
                //{
                //    ItemLife = false;
                //}
            }
        }
        public void BulletDraw() //미사일 디자인
        {
            string bullet = "->"; //미사일이 충돌하는데 콘솔이라 이상하게 보여서 x-1로 수정해준다.
            for (int y = 0; y < 20; y++)
            {
                if (playerBullet[y].fire == true) //미사일이 형상화되어 있는 중
                {
                    Console.SetCursorPosition(playerBullet[y].x - 1, playerBullet[y].y);
                    Console.Write(bullet);
                    playerBullet[y].x++; //미사일 오른쪽으로 날아간다
                    if (playerBullet[y].x > 78)
                    {
                        playerBullet[y].fire = false; //미사일false 재장전
                    }
                }
            }
        }
        public void BulletDraw2() //미사일 디자인
        {
            string bullet = "->"; //미사일이 충돌하는데 콘솔이라 이상하게 보여서 x-1로 수정해준다.
            for (int y = 0; y < 20; y++)
            {
                if (playerBullet2[y].fire == true) //미사일이 형상화되어 있는 중
                {
                    Console.SetCursorPosition(playerBullet2[y].x - 1, playerBullet2[y].y);
                    Console.Write(bullet);
                    playerBullet2[y].x++; //미사일 오른쪽으로 날아간다
                    if (playerBullet2[y].x > 78)
                    {
                        playerBullet2[y].fire = false; //미사일false 재장전
                    }
                }
            }
        }
        public void BulletDraw3() //미사일 디자인
        {
            string bullet = "->"; //미사일이 충돌하는데 콘솔이라 이상하게 보여서 x-1로 수정해준다.
            for (int y = 0; y < 20; y++)
            {
                if (playerBullet3[y].fire == true) //미사일이 형상화되어 있는 중
                {
                    Console.SetCursorPosition(playerBullet3[y].x - 1, playerBullet3[y].y);
                    Console.Write(bullet);
                    playerBullet3[y].x++; //미사일 오른쪽으로 날아간다
                    if (playerBullet3[y].x > 78)
                    {
                        playerBullet3[y].fire = false; //미사일false 재장전
                    }
                }
            }
        }
        public void PlayerDraw()
        {
            String[] player = new string[] //문자열배열 
            {
                ">->",
                ">===>",
                ">->"
            };
            for (int y = 0; y < player.Length; y++)
            {
                Console.SetCursorPosition(playerX, playerY + y); //콘솔좌표 설정
                Console.WriteLine(player[y]); //문자열배열 출력한다.
            }
        }
        public void ClashEnemyAndBullet(Enemy enemy) //충돌을 구현한다.
        {
            for (int y = 0; y < 20; y++)
            {
                if (playerBullet[y].fire == true) //미사일이 살아있으면
                {
                    //미사일과 적의 y값이 같을때 
                    if (playerBullet[y].y == enemy.enemyY)
                    {
                        if (playerBullet[y].x >= (enemy.enemyX - 1)
                            && playerBullet[y].x <= (enemy.enemyX + 1)) //충돌
                        {
                            item.ItemLife = true;
                            //item.ItemX = enemy.enemyX;
                            //item.ItemY = enemy.enemyY;
                            Random rand = new Random();
                            enemy.enemyX = 75;
                            enemy.enemyY = rand.Next(2, 22);
                            playerBullet[y].fire = false; //미사일도 준비상태로 만들어주기
                        }
                    }
                }
            }
        }
        public void UIscore()
        {
            Console.SetCursorPosition(63, 0);
            Console.Write("┏━━━━━━━━━━━━━━┓");
            Console.SetCursorPosition(63, 1);
            Console.Write("┃              ┃");
            Console.SetCursorPosition(65, 1);
            Console.Write("Score : " + Score);
            Console.SetCursorPosition(63, 2);
            Console.Write("┗━━━━━━━━━━━━━━┛");
        }
        public void CrashItem()
        {
            if (playerY + 1 == item.itemY)
            {
                if (playerX >= item.itemX - 2 && playerX <= item.itemX + 2)
                {
                    item.ItemLife = false;
                    if (itemCount < 3)
                        itemCount++;
                    for (int i = 0; i < 20; i++) //총알 초기화
                    {
                        playerBullet[i] = new Bullet();
                        playerBullet[i].x = 0;
                        playerBullet[i].y = 0;
                        playerBullet[i].fire = false;

                        playerBullet2[i] = new Bullet();
                        playerBullet2[i].x = 0;
                        playerBullet2[i].y = 0;
                        playerBullet2[i].fire = false;

                        playerBullet3[i] = new Bullet();
                        playerBullet3[i].x = 0;
                        playerBullet3[i].y = 0;
                        playerBullet3[i].fire = false;
                    }
                }
            }
        }
        public class Enemy //적을 만든다.
        {
            public int enemyX; //좌표
            public int enemyY;

            public Enemy()
            {
                enemyX = 72;
                enemyY = 12;
            }
            public void EnemyDraw() //적을 그린다.
            {
                string enemy = "<ㅇqㅇ>";
                Console.SetCursorPosition(enemyX, enemyY);
                Console.Write(enemy);
            }
            public void EnemyMove()
            {
                Random rand = new Random();
                enemyX--; //왼쪽으로 움직이게 한다.
                if (enemyX == 2) //왼쪽화면을 넘어가면 좌표를 새로 잡는다.
                {
                    enemyX = 77;
                    enemyY = rand.Next(2, 22);
                }
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                Console.CursorVisible = false; //커서는 안보이게
                Console.SetWindowSize(80, 25);
                Console.SetBufferSize(80, 25);
                Player player = new Player(); //플레이어Instance를 생성한다.
                Enemy enemy = new Enemy(); //적도 생성한다.

                int dwTime = Environment.TickCount; //유니티 구현. 프레임속도 0.001초
                while (true) //무한반복을 시킨다.
                {
                    if (dwTime + 43 < Environment.TickCount) // 0.05초 지연. 50/1000
                    {
                        dwTime = Environment.TickCount; //현재시간 세팅
                        Console.Clear();
                        player.GameMain(); //플레이어 그리기
                        if(player.itemCount == 0)
                        {
                            player.BulletDraw();
                        }
                        else if (player.itemCount ==1)
                        {
                            player.BulletDraw();
                            player.BulletDraw2();
                        }
                        else
                        {
                            player.BulletDraw();
                            player.BulletDraw2();
                            player.BulletDraw3();
                        }
                        enemy.EnemyMove(); //적의 움직임.
                        enemy.EnemyDraw(); //적 그리기.
                        player.ClashEnemyAndBullet(enemy); //충돌처리 사전에 선언했던 것.
                    }
                }
            }
        }
    }
}
