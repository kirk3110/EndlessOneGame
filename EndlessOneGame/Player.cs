using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndlessOneGame
{
    public class Player
    {
        private Player(bool isFirstPlayer)
        {
            Life = 20;
            Hand = 7;
            Library = 53;
            Graveyard = 0;
            EndlessOneList = new List<EndlessOne>();
            IslandList = new List<Island>();
            AlreadyPlayIsland = false;

            IsFirstPlayer = isFirstPlayer;
            IsTurnPlayer = IsFirstPlayer;

            mBouncerManaCost = IsFirstPlayer ? 2 : 1;
        }

        static public bool CreateTwoPlayers()
        {
            if (SFirstPlayer != null || SSecondPlayer != null)
            {
                return false;
            }
            SFirstPlayer = new Player(true);
            SSecondPlayer = new Player(false);

            SFirstPlayer.mOpponentPlayer = SSecondPlayer;
            SSecondPlayer.mOpponentPlayer = SFirstPlayer;

            return true;
        }

        static public void SwitchTurnPlayer()
        {
            if (SFirstPlayer.IsTurnPlayer)
            {
                SFirstPlayer.IsTurnPlayer = false;
                SSecondPlayer.IsTurnPlayer = true;
            }
            else
            {
                SFirstPlayer.IsTurnPlayer = true;
                SSecondPlayer.IsTurnPlayer = false;
            }
        }

        static public Player SFirstPlayer;

        static public Player SSecondPlayer;

        public int Life { get; private set; }

        public int Hand { get; private set; }

        public int Library { get; private set; }

        public int Graveyard { get; private set; }

        public List<EndlessOne> EndlessOneList { get; private set; }

        public List<Island> IslandList { get; private set; }

        public bool AlreadyPlayIsland { get; private set; }

        public bool IsFirstPlayer { get; }

        public bool IsTurnPlayer { get; private set; }

        public String BouncerName
        {
            get { return IsFirstPlayer ? "分散" : "送還"; }
        }

        private Player mOpponentPlayer;

        private int mBouncerManaCost;

        public List<EndlessOne> EnemyEndlessOneList
        {
            get { return mOpponentPlayer.EndlessOneList; }
        }

        public int PayableMana
        {
            get { return IslandList.Count(island => !island.Tapped); }
        }

        public void StartTurn()
        {
            AlreadyPlayIsland = false;
            UntapAllPermanents();
            if (CanDrawCard())
            {
                DrawCard();
            }
        }

        public bool CanDrawCard()
        {
            return Library >= 1;
        }

        public void DrawCard()
        {
            Library -= 1;
            AddHand();
        }

        public void UntapAllPermanents()
        {
            foreach (var island in IslandList)
            {
                island.Untap();
            }
            foreach (var endlessOne in EndlessOneList)
            {
                endlessOne.Untap();
            }
        }

        public bool CanPlayIsland()
        {
            return (IsTurnPlayer && !AlreadyPlayIsland && CanUseHand());
        }

        public void PlayIsland()
        {
            IslandList.Add(new Island());
            UseHand();
            AlreadyPlayIsland = true;
        }

        public bool CanPlayEndlessOne()
        {
            return (IsTurnPlayer && CanPayMana(1) && CanUseHand());
        }

        public void PlayEndlessOne(int powerToughness)
        {
            PayMana(powerToughness);
            EndlessOneList.Add(new EndlessOne(powerToughness));
            UseHand();
        }

        public bool CanPlayBouncer()
        {
            return (CanPayMana(mBouncerManaCost) && CanUseHand());
        }

        public void PlayBouncer(int targetIndex)
        {
            PayMana(mBouncerManaCost);
            mOpponentPlayer.BounceEndlessOne(targetIndex);
            UseHand();
        }

        public void BounceEndlessOne(int index)
        {
            EndlessOneList.RemoveAt(index);
            AddHand();
        }

        public bool CanEndTurn()
        {
            return IsTurnPlayer;
        }

        public void EndTurn()
        {
            SwitchTurnPlayer();
            mOpponentPlayer.StartTurn();
        }

        private bool CanPayMana(int mana)
        {
            return (mana <= PayableMana);
        }

        private void PayMana(int mana)
        {
            foreach (var island in IslandList)
            {
                if (mana <= 0)
                {
                    break;
                }
                if (!island.Tapped)
                {
                    island.Tap();
                    mana -= 1;
                }
            }
        }

        private bool CanUseHand()
        {
            return (Hand >= 1);
        }

        private void UseHand()
        {
            Hand -= 1;
        }

        private void AddHand()
        {
            Hand += 1;
        }
    }
}
