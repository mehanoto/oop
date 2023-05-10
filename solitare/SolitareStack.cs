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

        public Card TopCard 
        {
            get 
            {
                if (this.stack != null && this.stack.Count > 0 && this.pointer < this.stack.Count)
                {
                    return this.stack[this.stack.Count - 1];
                }
                else
                { 
                    return null;
                }
            }
        }

        public int VisibleCards
        {
            get
            {
                if (this.pointer >= 0 && this.pointer < this.stack.Count)
                {
                    return this.stack.Count - this.pointer;
                }
                else 
                {
                    return 0;
                }
            }
        }
        
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
        /// Adds new list of cards on top of the stack
        /// </summary>
        /// <param name="newCards"></param>
        public void AddToTop(Card c)
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
            return null;
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

        public bool IsEmpty()
        {
            return this.stack.Count == 0;
        }
    }
}
