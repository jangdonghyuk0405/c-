using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace game개발
{
    internal class Player
    {

            public int hp=100;
            public int at=10;
        private object monster1;

        public void AddAt(int _at)
            {
            //공격력 증가를 위해 사용한 함수.
                at += _at;
            }

        public void Fight(int monsterAt)
        {
            hp -= monsterAt;
        }
        
    }
}
