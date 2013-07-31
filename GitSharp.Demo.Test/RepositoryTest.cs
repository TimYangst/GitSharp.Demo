using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GitSharp.Demo.Test
{
    [TestClass]
    public class RepositoryTest
    {
        [TestMethod]
        public void TestRoadRepostory()
        {
            string project_path = "D:\\workspace\\leetcode";
            var git_url = Repository.FindRepository(project_path);

            var repo = new Repository(git_url);

            Console.WriteLine(repo.Status.Untracked.Count);
            foreach (var untrack in repo.Status.Untracked)
            {
                Console.WriteLine(untrack);
            } 
            //var head = repo.Head.Name;

        }
    }
}
