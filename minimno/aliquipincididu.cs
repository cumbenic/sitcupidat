string[] strings = { "apple", "banana", "cherry", "dog", "elephant" };

// Optimize by using StringComparison for case-insensitive comparison
var result = strings.Where(s => s.StartsWith("a", StringComparison.OrdinalIgnoreCase))
                    .Select(s => s.ToUpper());
