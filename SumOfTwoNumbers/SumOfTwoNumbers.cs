public static class Kata
{
    public static int sumTwoSmallestNumbers(int[] numbers)
    {
        var sortedNumbers= numbers.OrderBy(num => num).ToArray();

        return sortedNumbers[0] + sortedNumbers[1];
    }
}
