using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace solitare
{
    class TopStack
    {
        private Stack<Card> stack;

        public int NumberOfCards 
        {
            get
            {
                //TODO: return actual size of this stack
                return 0;
            }
        }
        
        public TopStack()
        {
            //TODO: initialize stack member variable
        }

        /// <summary>
        /// Check whether card c could be placed on top of the stack
        /// </summary>
        /// <param name="c">Card to be placed</param>
        /// <returns></returns>
        public bool CheckFeasible(Card c)
        {
            return false;
        }

        /// <summary>
        /// Pushes a new card on top of the stack or throws Exception if topCard is not suitable to be pushed
        /// </summary>
        /// <param name="topCard">a card to be pushed</param>
        public void Push(Card topCard)
        {
            //TODO: Implement push   
        }

        /// <summary>
        /// It pops the card on the top of the stack and returns it
        /// </summary>
        /// <returns></returns>
        public Card Pop()
        {
            //TODO: Implement pop
            return null;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>The top card without changing the size of the stack</returns>
        public Card Peek()
        {
            //TODO: Implement Peek
            return null;
        }

    }
}
