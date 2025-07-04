
int[] nums = { 0, 1 };

Console.WriteLine(MissingNumber(nums));




bool ContainsDuplicate(int[]nums)
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


int MissingNumber(int[]nums)
{
    Array.Sort(nums);

    for (global::System.Int32 i = 0; i < nums.Length; i++)
    {
        if (nums[i] != i)
            return i;

        if (i == nums.Length - 1)
            return i + 1;
    }

  
        return -1;
}