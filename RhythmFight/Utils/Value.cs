using System;

namespace RhythmFight
{
    public class Value<T>
    {
        public event Action<T, T> changed;
        
        public T Val
        {
            get => val;
            set
            {
                if (val.Equals(value))
                    return;

                var oldValue = val;
                val = value;
                changed?.Invoke(val, oldValue);
            }
        }

        private T val;
        
        public Value(T val = default(T))
        {
            this.val = val;
        }
        
        public static implicit operator T(Value<T> d)
        {
            return d.Val;
        }
        
        public static implicit operator Value<T>(T d)
        {
            return new Value<T>(d);
        }
    }
}