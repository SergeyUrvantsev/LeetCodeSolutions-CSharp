# Efficient Project Selection for Maximizing Capital Before IPO

### Intuition

To maximize LeetCode's capital before its IPO, we need to select projects that provide the highest profit while ensuring we have enough initial capital to start them. By focusing on projects we can afford and that offer the best returns, we can increase our capital efficiently.

### Approach

1. **Initialization**:
   - Utilize two sorted sets:
     - `availableProjects`: Contains projects sorted by their required capital.
     - `profitableProjects`: Contains projects sorted by their potential profit in descending order.
   
2. **Project Selection**:
   - Iterate up to `numberOfProjects` times:
     - Move all projects from `availableProjects` to `profitableProjects` that can be started with the current capital.
     - If no profitable projects are available, terminate the selection process.
     - Select the most profitable project from `profitableProjects`, add its profit to the current capital, and remove it from the set.

3. **Return the Result**:
   - Output the final capital after selecting up to the specified number of projects.

### Complexity

- **Time complexity**: O(n log n + k log n), where `n` is the number of projects and `k` is the number of projects selected. This includes sorting and selecting projects based on profitability and capital.
- **Space complexity**: O(n), primarily due to storing projects in the sorted sets.

### Code

```csharp
public class FindMaximizedCapital
{
    public int Solve(int numberOfProjects, int initialCapital, int[] profits, int[] capitals)
    {
        // Create a sorted set to store available projects by capital required
        var availableProjects = new SortedSet<(int capital, int profit, int index)>();

        // Create a sorted set to store profitable projects by profit
        var profitableProjects = new SortedSet<(int profit, int index)>(
            Comparer<(int profit, int index)>
            .Create((a, b) => b.profit == a.profit ? a.index.CompareTo(b.index) : b.profit.CompareTo(a.profit)));

        // Add all projects to the available projects set
        for (int i = 0; i < profits.Length; i++)
        {
            availableProjects.Add((capitals[i], profits[i], i));
        }

        int currentCapital = initialCapital;

        // Iterate up to the maximum number of projects we can perform
        for (int i = 0; i < numberOfProjects; i++)
        {
            // Move projects that can be started with the current capital to the profitable projects set
            while (availableProjects.Count > 0 && availableProjects.Min.capital <= currentCapital)
            {
                var project = availableProjects.Min;
                availableProjects.Remove(project);
                profitableProjects.Add((project.profit, project.index));
            }

            // If no profitable projects are available, break the loop
            if (profitableProjects.Count == 0)
            {
                break;
            }

            // Select the most profitable project and increase current capital
            var bestProject = profitableProjects.Min;
            profitableProjects.Remove(bestProject);
            currentCapital += bestProject.profit;
        }

        return currentCapital;
    }
}
```