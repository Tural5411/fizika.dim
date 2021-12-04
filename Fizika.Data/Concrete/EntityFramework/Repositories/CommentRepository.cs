﻿using Fizika.Data.Abstract;
using Fizika.Shared.Concrete.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Fizika.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fizika.Data.Concrete.EntityFramework.Repositories
{
    public class CommentRepository : EfEntityRepositoryBase<Comment>, ICommentRepository
    {
        public CommentRepository(DbContext Context) : base(Context)
        {
        }
    }
}
