using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexators
{
    class BoundsArray
    {
        int[] array;
        public int Length;
        public bool ErrorBounds;

        public BoundsArray(int size)
        {
            array = new int[size];
            Length = size;
        }

        public int this[int index]
        {
            get
            {
                if(index >=0 && index < Length)
                {
                    ErrorBounds = false;
                    return array[index];
                }
                else
                {
                    ErrorBounds = true;
                    return 0;
                }
            }

            set
            {
                if(index >=0 && index < Length)
                {
                    ErrorBounds = false;
                    array[index] = value;
                }
                else
                {
                    ErrorBounds = true;
                }
            }
        }

        public int this[double index]
        {
            get
            {
                int newIndex;

                if ((index - (int)index) < 0.5)
                {
                    newIndex = (int)index;
                }
                else newIndex = (int)index + 1;

                if(newIndex >= 0 && newIndex < Length)
                {
                    ErrorBounds = false;
                    return array[newIndex];
                }
                else
                {
                    ErrorBounds = true;
                    return 0;
                }
            }

            set
            {
                int newIndex;

                if ((index - (int)index) < 0.5)
                {
                    newIndex = (int)index;
                }
                else newIndex = (int)index + 1;

                if(newIndex >= 0 && newIndex < Length)
                {
                    array[newIndex] = value;
                    ErrorBounds = false;
                }
                else
                {
                    ErrorBounds = true;
                }
            }


        }
    }
}
