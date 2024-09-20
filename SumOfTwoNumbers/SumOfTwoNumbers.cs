public static class Kata
{
    public static int sumTwoSmallestNumbers(int[] numbers)
    {
        int[] numb = [1, 2, 3, 4];
        var sortedNumbers= numbers.OrderBy(numb => numb).ToArray();

        return sortedNumbers[0] + sortedNumbers[1];
    }
}