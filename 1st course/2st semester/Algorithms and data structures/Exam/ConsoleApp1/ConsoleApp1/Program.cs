static void printArr(int[] arr)
{
  // foreach(int i in arr)
  //     Console.WriteLine(i);

  //Console.WriteLine(string.Join(", ", arr));

  for (int i = 0; i < arr.Length; i++)
    Console.WriteLine(arr[i]);
}

static int FindMaxNum(int[] arr)
{
  //  int maxEl = arr[0];

  //  foreach (int num in arr)
  //    if (num > maxEl)
  //      maxEl = num;
  //return maxEl;

  return arr.Max();
}

static int FindMinNum(int[] arr)
{
  //int minEl = arr[0];

  //foreach (int num in arr)
  //  if (num < minEl)
  //    minEl = num;
  //return minEl;

  return arr.Min();
}

static double FindAverage(int[] arr)
{
  //return arr.Average();

  double sum = 0;

  foreach (int num in arr)
    sum += num;

  return sum / arr.Length;
}

static List<int> FindClosestToAvg(int[] arr)
{
  List<int> closestEls = new List<int>();
  double avg = FindAverage(arr);
  int closestEl = arr[0];
  double minDiff = Math.Abs(avg - arr[0]);
  closestEls.Add(closestEl);

  foreach (int num in arr)

    if (minDiff == Math.Abs(avg - num))
      closestEls.Add(num);

    else if (minDiff > Math.Abs(avg - num))
    {
      closestEls.Clear();
      closestEl = num;
      minDiff = Math.Abs(avg - num);
      closestEls.Add(closestEl);
    }

  return closestEls;
}

static int[] Insert(int[] arr, int pos, int val)
{
  int[] newArr = new int[arr.Length + 1];
  int arrIndex = 0;

  for (int i = 0; i <= arr.Length; i++)
    if (i == pos)
      newArr[i] = val;
    else
    {
      newArr[i] = arr[arrIndex];
      arrIndex++;
    }

  return newArr;
}

static int[] DeleteAt(int[] arr, int pos)
{
  int[] newArr = new int[arr.Length - 1];
  int arrIndex = 0;

  for (int i = 0; i < arr.Length; i++)
    if (i != pos)
    {
      newArr[arrIndex] = arr[i];
      arrIndex++;
    }
  return newArr;
}

static List<int> Prime(int n)
{

  //int n;
  //vector<bool> is_prime(n+1, true);
  //is_prime[0] = is_prime[1] = false;
  //for (int i = 2; i <= n; i++)
  //{
  //  if (is_prime[i] && (long long)i* i <= n) {
  //    for (int j = i * i; j <= n; j += i)
  //      is_prime[j] = false;
  //  }
  //}




  bool[] arr = new bool[n + 1];
  Array.Fill(arr, true);

  for (int i = 2; i <= n; i++)
    if (arr[i] && i * i <= n)
      for (int j = i * i; j <= n; j += i)
        arr[j] = false;

  List<int> primes = new List<int>();
  for (int i = 2; i < arr.Length; i++)
    if (arr[i])
      primes.Add(i);

  return primes;
}

static int[] Merge(int[] arr1, int[] arr2)
{
  int n1 = arr1.Length;
  int n2 = arr2.Length;
  int[] result = new int[n1 + n2];

  int i = 0, j = 0, k = 0;
  while (i < n1 && j < n2)
  {
    if (arr1[i] <= arr2[j])
    {
      result[k++] = arr1[i++];
    }
    else
    {
      result[k++] = arr2[j++];
    }
  }

  while (i < n1)
    result[k++] = arr1[i++];

  while (j < n2)
    result[k++] = arr2[j++];

  return result;
}



//int[] arr = new int[10];
int[] arr = [5, 111, 3, 7, 4];
printArr(arr);
Console.WriteLine();

Console.WriteLine("Max el: " + FindMaxNum(arr));
Console.WriteLine("Min el: " + FindMinNum(arr));
Console.WriteLine("Average: " + FindAverage(arr));
Console.WriteLine("Closest element to avg: " + string.Join(", ", FindClosestToAvg(arr)));
Console.WriteLine("New arr: " + string.Join(", ", Insert(arr, 2, 5)));
Console.WriteLine("New arr: " + string.Join(", ", DeleteAt(arr, 2)));
Console.WriteLine("Primes, N = 50: " + string.Join(", ", Prime(50)));
Console.WriteLine("Merged arrays: " + string.Join(",", Merge(new int[] { 1, 3, 5 }, new int[] { 2, 4, 6 })));