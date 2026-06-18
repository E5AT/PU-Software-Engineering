using System;
using System.Collections.Generic;

/// <summary>
/// Sieve of Atkin — an optimized prime number sieve with O(N / log log N) complexity.
/// Faster asymptotically than the classical Sieve of Eratosthenes.
/// </summary>
public static class SieveOfAtkin
{
  /// <summary>
  /// Returns all prime numbers up to and including <paramref name="limit"/>.
  /// </summary>
  public static List<int> GeneratePrimes(int limit)
  {
    if (limit < 2)
      return new List<int>();

    // Step 1 — initialise a boolean sieve, all false
    bool[] isPrime = new bool[limit + 1];

    // 2 and 3 are known primes
    if (limit >= 2) isPrime[2] = true;
    if (limit >= 3) isPrime[3] = true;

    // Step 2 — apply the three quadratic forms from the Atkin algorithm
    for (int x = 1; (long)x * x <= limit; x++)
    {
      for (int y = 1; (long)y * y <= limit; y++)
      {
        // Form 1: n = 4x² + y²  →  prime candidate if n ≡ 1 or 5 (mod 12)
        int n = 4 * x * x + y * y;
        if (n <= limit && (n % 12 == 1 || n % 12 == 5))
          isPrime[n] ^= true;

        // Form 2: n = 3x² + y²  →  prime candidate if n ≡ 7 (mod 12)
        n = 3 * x * x + y * y;
        if (n <= limit && n % 12 == 7)
          isPrime[n] ^= true;

        // Form 3: n = 3x² − y²  →  prime candidate if x > y and n ≡ 11 (mod 12)
        n = 3 * x * x - y * y;
        if (x > y && n <= limit && n % 12 == 11)
          isPrime[n] ^= true;
      }
    }

    // Step 3 — eliminate composites by sieving out multiples of squares
    for (int r = 5; (long)r * r <= limit; r++)
    {
      if (isPrime[r])
      {
        int rSquared = r * r;
        for (int k = rSquared; k <= limit; k += rSquared)
          isPrime[k] = false;
      }
    }

    // Step 4 — collect results
    var primes = new List<int> { 2, 3 };
    for (int i = 5; i <= limit; i++)
    {
      if (isPrime[i])
        primes.Add(i);
    }

    return primes;
  }

  // ── Demo ────────────────────────────────────────────────────────────────

  //public static void Main()
  //{
  //  const int Limit = 100;

  //  List<int> primes = GeneratePrimes(Limit);

  //  Console.WriteLine($"Sieve of Atkin — primes up to {Limit}");
  //  Console.WriteLine(new string('─', 50));
  //  Console.WriteLine(string.Join(", ", primes));
  //  Console.WriteLine($"\nFound {primes.Count} primes.");

  //  // --- Larger benchmark ---
  //  const int BigLimit = 1_000_000;
  //  var sw = System.Diagnostics.Stopwatch.StartNew();
  //  List<int> bigPrimes = GeneratePrimes(BigLimit);
  //  sw.Stop();

  //  Console.WriteLine($"\nBenchmark: {bigPrimes.Count} primes up to {BigLimit:N0} " +
  //                    $"found in {sw.ElapsedMilliseconds} ms.");
  //}
}