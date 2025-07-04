
int[] nums = {1,2,4,8,2 };

Console.WriteLine(ContainsDublicate(nums));




bool ContainsDublicate(int[]nums)
{
    HashSet<int> set = new HashSet<int>();

    foreach (var item in nums)
    {
        if (set.Contains(item))
            return true;

        set.Add(item);
    }

    return false;
}