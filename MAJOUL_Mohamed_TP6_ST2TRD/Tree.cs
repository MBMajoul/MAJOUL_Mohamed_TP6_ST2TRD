using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAJOUL_Mohamed_TP6_ST2TRD
{
    public class Values
    {
        int value;
        // Constructor
        public Values(int value)
        {
            this.value = value;
        }
        public int Value
        {
            get { return value; }
        }
    }
    public abstract class AbstractCollection
    {
        public abstract Iterator CreateIterator();
    }
    public class Collection : AbstractCollection
    {
        List<Values> values = new List<Values>();
        public override Iterator CreateIterator()
        {
            return new Iterator(this);
        }
        public int Count
        {
            get { return values.Count; }
        }
        public Values this[int index]
        {
            get { return values[index]; }
            set { values.Add(value); }
        }
    }
    public interface IAbstractIterator
    {
        Values First();
        Values Next();
        bool IsDone { get; }
        Values CurrentValue { get; }
    }
    public class Iterator : IAbstractIterator
    {
        Collection collection;
        int current = 0;
        int step = 1;
        // Constructor
        public Iterator(Collection collection)
        {
            this.collection = collection;
        }
        public Values First()
        {
            current = 0;
            return collection[current] as Values;
        }
        public Values Next()
        {
            current += step;
            if (!IsDone)
                return collection[current] as Values;
            else
                return null;
        }
        public int Step
        {
            get { return step; }
            set { step = value; }
        }
        public Values CurrentValue
        {
            get { return collection[current] as Values; }
        }
        public bool IsDone
        {
            get { return current >= collection.Count; }
        }
    }
}
