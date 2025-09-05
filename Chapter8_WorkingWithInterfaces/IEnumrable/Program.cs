// IEnumerable در واقع میگه که من یک مجموعه قابل پیمایش هستم و میتونی روی من foreach را اجرا کنی.

// IEnumerator میگه: این Enumerator چطور حرکت کنه و آیتم فعلی چی باشه.

// IEnumerable و IEnumerator باعث میشن هر چیزی شبیه Array بشه و قابل پیمایش باشه.

public interface IEnumerator
{
    bool MoveNext();
    object Current { get; }
    void Reset();
}

public interface IEnumerable
{
    IEnumerator GetEnumerator();
}   