namespace _07___Enumerables
{
    public class Employee : IEnumerable<PayItem>
    {
        private readonly List<PayItem> _payItems = new();
        public string Name { get; set; }


        public void AddPayItem(string name, int value)
        {
            if (string.IsNullOrEmpty(name))
                throw new ArgumentNullException("name");

            _payItems.Add(new PayItem
            {
                Name = name,
                Value = value
            });
        }

        //public IEnumerator<PayItem> GetPayItems()
        //{
        //    Console.WriteLine("GetPayItems called");
        //    return _payItems.GetEnumerator();
        //}

        //public PayItem GetPayItem(int index) => _payItems[index];

        public PayItem this[int index]
        {
            get => _payItems[index];
        }
    }

    public IEnumerator<PayItem> GetEnumerator()
    {
        Console.WriteLine("GetEnumerator called");
        foreach (var item in _payItems)
            yield return item;
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    //private class PayItemsEnumerator : IEnumerator<PayItem>
    //{
    //    private readonly List<PayItem> _payItems;
    //    private int _currentIndex = -1;

    //    public PayItemsEnumerator(List<PayItem> payItems)
    //    {
    //        _payItems = payItems;
    //    }

    //    public PayItem Current => _payItems[_currentIndex];

    //    object IEnumerator.Current => Current;

    //    public void Dispose()
    //    {

    //    }

    //    public bool MoveNext()
    //    {
    //        return ++_currentIndex < _payItems.Count;
    //        //_currentIndex++;
    //        //if (_currentIndex < _payItems.Count)
    //        //    return true;
    //        //else
    //        //    return false;
    //    }

    //    public void Reset()
    //    {
    //        throw new NotImplementedException();
    //    }

    //}
}

