namespace SortingAlgorithms
{
    public static class EnumsAndConstants
    {
        public const string TerminationText = "Z";
        public const string FarewellMessage = "\r\n Press Any Key To Exit";
        public const string ApplicationHeaderText = "\r\n \t\t\t-- Sorting Algorithms --";
        public const string CountEntryText = "\r\n Enter the count of numbers to be inserted. Also you could use Z (caps) to exit the run";
        public const string ApplicationEntryText = ApplicationHeaderText + CountEntryText;
        public const string InvalidEntry = "\r\n Not a numeric value. Please enter valid count.";
        public const string SortedMessageText = "\r\n Sorted Number --> ";

        public enum SortingAlgorithm
        {
            SelectionSort = 1,
            BubbleSort,
            InsertionSort
        }
    }
}