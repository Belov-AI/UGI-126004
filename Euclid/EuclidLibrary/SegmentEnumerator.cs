using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuclidLibrary
{
    public class SegmentEnumerator : IEnumerator<Point>
    {
        Point current;
        Segment segment;

        public SegmentEnumerator(Segment segment)
        {
            this.segment = segment;
        }

        public Point Current => current;

        object IEnumerator.Current => current;

        public void Dispose() {}

        public bool MoveNext()
        {
            if(current != null && current == segment.B)
                return false;

            if (current == null)
                current = segment.A;
            else
                current = segment.B;

            return true;
        }

        public void Reset()
        {
            current = null;
        }
    }
}
