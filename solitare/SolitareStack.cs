using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace solitare
{
    class SolitareStack
    {
        public List<Card> stack;
        public int pointer;

        public SolitareStack()
        {
            this.stack = new List<Card>();
            this.pointer = -1;
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
        /// Adds new list of cards on top of the stack
        /// </summary>
        /// <param name="newCards"></param>
        public void AddToTop(List<Card> newCards)
        { 
            
        }


        /// <summary>
        /// Removes cards from top of the stack and returns them as a list.
        /// It throws exception if removal of the cards is not possible.
        /// </summary>
        /// <param name="cards">A number of cards to be removed</param>
        /// <returns>A list of removed cards</returns>
        public List<Card> Slice(int cards)
        { 
            
        }


        /// <summary>
        /// Increase number of visible cards, showing one additional card
        /// </summary>
        public void Flip()
        {
            bool isValidPointer = this.pointer >= 0 && this.pointer < stack.Count;
            if (!isValidPointer)
            {
                this.pointer = this.stack.Count;
            }
            else if(pointer > 0)
            {
                --pointer;
            }
        }

    }
}
