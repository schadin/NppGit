﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NppKate.Modules.GitRepositories.RepositoryExt
{
    public class Worktree
    {
        private string _rootRepo;

        public string Path { get; set; }

        public string Branch { get; set; }

        public string HeadSha { get; set; }

        public Worktree(string rootRepo)
        {
            _rootRepo = rootRepo;
        }

        public bool isRoot
        {
            get
            {
                var root = new System.IO.DirectoryInfo(_rootRepo);
                var cur = new System.IO.DirectoryInfo(Path);
                return root.FullName.Equals(cur.FullName);
            }
        }
    }
}
