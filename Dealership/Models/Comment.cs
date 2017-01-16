
namespace Dealership.Models

{
    using Common;
    using Contracts;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Comment : IComment
    {
        private string content;
        public Comment(string content)
        {
            this.content = content;
            ValidateFied();
        }

        private void ValidateFied()
        {
            Validator.ValidateNull(this.content, string.Format(Constants.CommentCannotBeNull, "Content"));
            Validator.ValidateIntRange(this.content.Length, Constants.MinCommentLength, Constants.MaxCommentLength, string.Format(Constants.StringMustBeBetweenMinAndMax, "Content", Constants.MinCommentLength, Constants.MaxCommentLength));
        }

        public string Author { get; set; }
    

        public string Content
        {
            get
            {
                return this.content;
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine("  ----------");
            sb.AppendLine(string.Format("  {0}", this.content));
            sb.AppendLine(string.Format("  User: {0}", this.Author));
            sb.AppendLine("  ----------");
            return sb.ToString();
        }
    }
}
