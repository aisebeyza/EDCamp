using System;
using System.Linq;

namespace GenericsIntro
{
     class MyDictionary<TKey,TValue>
    {
        private TKey[] playersNum;
        private TValue[] players;
       

        public MyDictionary()
        {
            playersNum = new TKey[0];
            players = new TValue[0];
        }

        public void Add(TKey number,TValue player )
        {
            TKey[] tempTKey = playersNum;
            TValue[] tempTValue = players;

            playersNum = new TKey[playersNum.Length + 1];
            players = new TValue[players.Length + 1];

            for (int i = 0; i < tempTKey.Length; i++)
            {
                playersNum[i] = tempTKey[i];
                players[i] = tempTValue[i];

            }

            playersNum[playersNum.Length - 1] = number;
            players[players.Length - 1] = player;
            }

        public int Length
        {
            get { return players.Length; }
        }
        public TKey[] Numbers
        {
            get { return playersNum; }
        }
        public TValue[] Players
        {
            get { return players; }
        }

    }
}
