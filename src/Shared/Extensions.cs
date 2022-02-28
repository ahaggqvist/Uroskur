namespace Uroskur.Shared;

public static class Extensions
{
    public static IEnumerable<Tuple<T, T, T>> GetItems<T>(this IEnumerable<T>? source)
        where T : class
    {
        if (source == null)
        {
            yield break;
        }

        var skip = true;
        T? previous = default, current = default;
        T? next;
        foreach (var item in source)
        {
            next = item;
            if (!skip)
            {
                if (previous != null)
                {
                    if (current != null)
                    {
                        yield return new Tuple<T, T, T>(previous, current, next);
                    }
                }
            }

            if (current != null)
            {
                previous = current;
            }

            current = item;
            skip = false;
        }

        if (skip)
        {
            yield break;
        }

        next = default;
        if (previous == null)
        {
            yield break;
        }

        if (current == null)
        {
            yield break;
        }

        if (next != null)
        {
            yield return new Tuple<T, T, T>(previous, current, next);
        }
    }

    public static IEnumerable<(T item, int index)> WithIndex<T>(this IEnumerable<T> self)
    {
        return self.Select((item, index) => (item, index));
    }
}