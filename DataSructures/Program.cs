internal class Program
{

    public static void Main()
    {
        FindPairWithSum();//Two Pointers מציאת שני איברים השווים לסכום שהוגדר - עבודה על פי טכניקת 
        FindSequenceWithSum();//Two Pointers מציאת רצף מספרים לסכום שהוגדר - עבודה על פי טכניקת 
        RotateList();//Two Pointers שינוי סדר המערך - עבודה על פי טכניקת 
        FilterList();//Two Pointers סינון איברים ממערך - עבודה על פי טכניקת 
        Console.ReadKey();

    }

    static void FilterList()
    {
        int left = 0;
        int right = 0;
        int[] arr = { 1, 2, 3, 4, 5, 3, 6, 7, 8, 3 };
        int target = 3;

        Console.WriteLine("Original List:");
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();

        while (right < arr.Length)
        {
            // בדיקה אם האיבר עומד בתנאי הסינון
            if (arr[right] != target)
            {
                // העברת האיבר למקום הנכון ברשימה
                arr[left] = arr[right];
                left++;
            }
            // העברת נקודת הסיום קדימה
            right++;
        }

        // כתיבת האיברים שנשארו אחרי הסינון
        Console.WriteLine("Filtered List:");
        for (int i = 0; i < left; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
    }

    static void RotateList()
    {
        int[] arr = { 1, 2, 3, 4, 5 };
        Console.WriteLine("Original array:");
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();

        int left = 0;
        int right = arr.Length - 1;

        while (left < right)
        {
            // החלפת האיברים בין left ו-right
            int temp = arr[left];
            arr[left] = arr[right];
            arr[right] = temp;

            // מעבר לאיברים הבאים
            left++;
            right--;
        }
        Console.WriteLine("Rotated array:");
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
    private static void FindSequenceWithSum()
    {
        int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
        int targetSum = 12;

        int left = 0;
        int right = 0;
        int currentSum = arr[left];

        while (right < arr.Length)
        {
            if (currentSum == targetSum)
            {
                Console.WriteLine("Sequence found from index {0} to {1}", left, right);
                return;
            }
            else if (currentSum < targetSum)
            {
                right++;
                if (right < arr.Length)
                    currentSum += arr[right];
            }
            else
            {
                currentSum -= arr[left];
                left++;
            }
        }

        Console.WriteLine("Sequence not found");
        return;

    }


    public static void FindPairWithSum()
    {
        int[] numbers = { 1, 3, 7, 4, 2, 11, 6 }; // מערך ממוין
        int targetSum = 9;

        int start = 0; // מצביע לתחילת המערך
        int end = numbers.Length - 1; // מצביע לסוף המערך

        while (start < end)
        {
            int sum = numbers[start] + numbers[end];

            if (sum == targetSum)
            {
                Console.WriteLine("Pair found:{0} + {1} = {2} ", numbers[start], numbers[end], targetSum);
                return;
            }
            else if (sum < targetSum) // אם הסכום קטן מהמטרה, נניח שנצטרך להגדיל את הסכום, ולכן נזיז את האינדקס של האיבר השמאלי קדימה
            {
                start++; 
            }
            else // אם הסכום גדול מהמטרה, נניח שנצטרך להפחית את הסכום, ולכן נזיז את האינדקס של האיבר הימני לאחור
            {
                end--; 
            }
        }

        Console.WriteLine("No pair found."); // אם לא נמצא זוג שמסכומו שווה ליעד
        return;

    }
}