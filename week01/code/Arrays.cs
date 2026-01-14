public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    /// This is the first step the function, it is already created!
    public static double[] MultiplesOf(double number, int length)
    {
        //I have created an array which name is "doubles". Also I use "lenght" to determine the number of items in the array! 
        double [] doubles = new double [length];

        //Then, I use a for bucle using the length paremeter and also i for the indexes of each element.
        for (int i = 0; i < length; i++)
        {
            //We add items into the array, and also we make some modifications in order to do not include 0 in our array.
            doubles[i] = number * (i + 1);
        }

        //Finally we return the array
        return doubles; 
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        //Save the last "amount" element in a temporary list
        List <int> temp = data.GetRange(data.Count - amount, amount);

        //Remove those elements from the end of the original list
        data.RemoveRange(data.Count - amount, amount);

        //Insert the saved elements from the end of the original list
        data.InsertRange(0, temp);
    }
}
