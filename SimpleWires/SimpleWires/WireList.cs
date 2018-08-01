using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleWires
{
    class WireList
    {
        private List<String> contents;
        private int length;
        public WireList()
        {
            length = 0;
            contents = new List<string>();
        }
        public void addToList(String newWire)
        {
            //Called to add a new wire to the list. Preventing 7th wire will be implemented formside,
            //error is to help ensure complete coverage.
            if(length < 6)
            {
                contents.Add(newWire);
                length = contents.Count;
            }
            else
            {
                throw new NotSupportedException("Too many wires! How are you adding a 7th?");
            }
        }
        public void delLastWire()
        {
            //Called to remove last wire: Form will handle preventing negative wires
            //I'm having the form handle that to ensure the buttons are disabled at the right times
            if(length > 0)
            {
                contents.RemoveAt(length - 1);
                length = contents.Count;
            }
            else
            {
                throw new NotSupportedException("You can't remove a wire that isn't there! Did you disable the button?");
            }

        }
        public int getLength()
        {
            return length;
        }
        public List<String> getWires()
        {
            return contents;
        }
        public int howMany(String target)
        {
            int count = 0;
            foreach (String tester in contents)
            {
                if(tester == target)
                {
                    count++;
                }
            }
            return count;
        }
        public Boolean isLastWire(String target)
        {
            return (contents.Last<String>() == target);
        }
        public void resetList()
        {
            contents.Clear();
            length = contents.Count;
        }
        public int getLastIndexOf(String target)
        {
            //Lambda expressions are weird. Cool, but weird.
            return contents.FindLastIndex(wire => wire.Equals(target));
            /* After making this, I realized that it technically isn't necessary.
            * I could simply say "cut the last red wire" or equivalent.
            * However, I'll probably implement a redundancy later, something like:
            * "Cut the last red wire, which should be wire number: 2"
            */
        }
    }
}
