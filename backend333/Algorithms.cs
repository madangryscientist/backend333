namespace backend333;

// write function that returns a specific number from a list -list is a ordered set of numbers 
// 
public class Algorithms
{
    public bool FindInList(int num)
    {
        int[] list = new int[] { 1, 2, 5, 10, 15, 20, 23, 27, 49, 200 };
        foreach (var element in list)
        {
            if (element == num)
            {
                return true;
            }
        }

        return false;
    }

    public void InsertToList(int num)
    {
        List<int> smallList = new List<int>();
        List<int> largeList = new List<int>();
        List<int> list = new List<int> { 1, 2, 5, 10, 15, 20, 23, 27, 49, 200 };
        foreach (var element in list)
        {
            if (num > element)
            {
                smallList.Add(element);
            }
            else if (num < element)
            {
                largeList.Add(element);
            }
            else
            {
                return;
            }
        }

        smallList.Add(num);
        smallList.AddRange(largeList);
        list = smallList;
    }

    public static bool BinarySearch(int num)
    {
        List<int> list = new List<int> { 1, 2, 5, 10, 15, 20, 23, 27, 49 };
        var start = 0;
        var end = list.Count; // 8
        var middle = (end - start) / 2; // 4 
        return SearchInner(num, list, start, middle, end);
    }

    public static bool SearchInner(int num, List<int> list, int start, int middle, int end)
    {
        if (end - start == 1)
        {
            return false;
        }

        if (num > list[middle])
        {
            start = middle; // 4 
            end = end; // 8
            middle = start + (end - start) / 2; // 6
            return SearchInner(num, list, start, middle, end);
        }

        if (num < list[middle])
        {
            start = start; // 0
            end = middle; //4
            middle = start + (end - start) / 2; // 2 
            return SearchInner(num, list, start, middle, end);
        }

        return true;
    }

    public class Person
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public int Age { get; set; }
    }
    public bool DicLookUp(int num)
    {
        var dict = new Dictionary<string, Person>();
        var p1 = new Person()
        {
            Name = "Erin",
            Age = 21,
            
        };
        dict.Add(p1.Name+p1.Age,p1);
        var list = dict.Values;
        return false;
    }
}