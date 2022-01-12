using System;
using System.Collections.Generic;

namespace Test.Task_2
{
    class Program
    {
        private static int depthCurrent = 1;
        private static int depthMax = 0;

        static void Main(string[] args)
        {
            var mainBranch = new Branch();

            // tier 1
            AddBranch(mainBranch, count: 2);

            // tier 2
            AddBranch(mainBranch.branches[0]);
            AddBranch(mainBranch.branches[1], count: 3);

            // tier 3
            AddBranch(mainBranch.branches[1].branches[0]);
            AddBranch(mainBranch.branches[1].branches[1], count: 2);

            // tier 4
            AddBranch(mainBranch.branches[1].branches[1].branches[0]);

            GetTreeDepth(mainBranch);

            Console.WriteLine($"Tree depth: {depthMax}");
        }

        /// <summary>
        /// Creates child branch in received father branch.
        /// </summary>
        /// <param name="father">Branch to create child one inside.</param>
        /// <param name="count">Amount of child branches to create.</param>
        public static void AddBranch(Branch father, int count = 1)
        {
            father.branches = new List<Branch>();

            for (int i = 0; i < count; i++)
            {
                father.branches.Add(new Branch());
            }
        }

        /// <summary>
        /// Method to calculate tree depth.
        /// </summary>
        /// <param name="branch">Tree branch to start calculating from.</param>
        public static void GetTreeDepth(Branch branch)
        {
            if (branch.branches != null)
            {
                depthCurrent++;

                foreach (var child in branch.branches)
                {
                    GetTreeDepth(child);
                }
            }
            else
            {
                depthMax = depthCurrent > depthMax ? depthCurrent : depthMax;
                depthCurrent -= 1;
                return;
            }
        }
    }
}
