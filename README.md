# LeetCodeSolutions-CSharp
Welcome to the LeetCodeSolutions-CSharp repository! 🚀 This repository contains solutions to various LeetCode problems implemented in C#.

You can find me on LeetCode at [SergeyUrv](https://leetcode.com/u/SergeyUrv/) 😊.

## Table of Contents

- [Structure](#structure)
- [Getting Started](#getting-started)
- [Usage](#usage)
- [Workflows](#workflows)
- [Problem Analyses and Comments](#problem-analyses-and-comments)
- [Contributing](#contributing)
- [License](#license)

## Structure

The project is structured into two main directories:

### `LeetCode.Solutions`

This directory contains my solutions to LeetCode problems, categorized by difficulty:
- `Easy`: Solutions to easy problems.
- `Medium`: Solutions to medium problems.
- `Hard`: Solutions to hard problems.

Each subdirectory contains individual C# files with solution implementations. 📁

### `LeetCode.Tests`

This directory contains corresponding unit tests for each solution, also organized by difficulty:
- `Easy`: Tests for easy problems.
- `Medium`: Tests for medium problems.
- `Hard`: Tests for hard problems.

Each subdirectory contains unit test files written using xUnit framework to test the solutions in the `LeetCode.Solutions` directory. 🧪

## Getting Started

To get started with the LeetCode Solutions project, follow these steps:

### Prerequisites

Make sure you have the following installed:
- [.NET SDK](https://dotnet.microsoft.com/download) for running the project and tests.

### Setup

1. Clone this repository to your local machine:

    ```bash
    git clone https://github.com/SergeyUrvantsev/LeetCodeSolutions-CSharp.git
    cd LeetCode
    ```

2. Navigate to the test project and add a reference to the solutions project:

    ```bash
    cd LeetCode.Tests
    dotnet add reference ../LeetCode.Solutions/LeetCode.Solutions.csproj
    ```

Now you're ready to explore the solutions and tests or add your own contributions! 🎉

## Usage

The LeetCode Solutions project can be used for several purposes:

### Exploring Solutions

Feel free to explore the solutions provided in the `LeetCode.Solutions` directory. Each solution is categorized by difficulty level, making it easy to find solutions to specific types of problems.

### Running Tests

You can run the unit tests provided in the `LeetCode.Tests` directory to verify the correctness of the solutions. Navigate to the `LeetCode.Tests` directory and execute the following command:

```bash
cd LeetCode.Tests
dotnet test
```

## Workflows

### dotnet.yml

The `dotnet.yml` file in the `.github/workflows` directory contains the GitHub Actions workflow configuration for building and testing the project. This workflow runs on every push to the `main` branch and every pull request into the `main` branch. It performs the following tasks:
- Restores dependencies for the LeetCode.Solutions project.
- Restores dependencies for the LeetCode.Tests project.
- Builds the LeetCode.Solutions project in Release configuration.
- Runs the tests for the LeetCode.Tests project in Release configuration.

For more information, please refer to the [dotnet.yml](.github/workflows/dotnet.yml) file.

## Problem Analyses and Comments

- [4. Median of Two Sorted Arrays](https://leetcode.com/problems/median-of-two-sorted-arrays/description/): [Efficient Median Calculation Using Binary Search](LeetCode.Solutions/Hard/4.%20Median%20of%20Two%20Sorted%20Arrays/Efficient_Median_Calculation_Using_Binary_Search.md)
- [1713. Minimum Operations to Make a Subsequence](https://leetcode.com/problems/minimum-operations-to-make-a-subsequence/description/): [Analyzing Complexity Operations for Subsequence Transformation](LeetCode.Solutions/Hard/1713.%20Minimum%20Operations%20to%20Make%20a%20Subsequence/Analyzing_Complexity_Operations_for_Subsequence_Transformation.md)
- [502. IPO](https://leetcode.com/problems/ipo/description/): [Efficient Project Selection for Maximizing Capital Before IPO](LeetCode.Solutions/Hard/502.%20IPO/Efficient_Project_Selection_for_Maximizing_Capital_Before_IPO.md)

## Contributing

While this repository primarily serves as a personal project, contributions are welcome via pull requests. If you have improvements to existing solutions or new solutions to add, feel free to submit a pull request. 🛠️
  
## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details. 📄
