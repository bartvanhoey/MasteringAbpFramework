using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities;

namespace FormsApp.Forms
{
    public class Form :  BasicAggregateRoot<Guid>
    {
        public string? Name { get; set; }
        public string? Description{ get; set; }

        public bool IsDraft { get; set; } = false;
        public ICollection<Question> Questions { get; set; } = [];
        public ICollection<FormManager> FormManagers { get; set; } = [];
    }

    public class FormManager :  Entity<Guid>
    {
        public Guid FormId { get; set; }
        public Guid UserId { get; set; }
        public bool IsOwner { get; set; } = false;

        public override object[] GetKeys() => [FormId, UserId];
    }

    public class Question : Entity<Guid>
    {
        public Guid FormId { get; set; }
        public string? Title { get; set; }
        public bool AllowMultiSelect { get; set; } = false;
        public ICollection<Option> Options { get; set; } = [];
    }

    public class Option
    {
    }
}