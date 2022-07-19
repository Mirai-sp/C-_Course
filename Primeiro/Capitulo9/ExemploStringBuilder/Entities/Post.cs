using System;
using System.Collections.Generic;
using System.Text;

namespace Primeiro.Capitulo9.ExemploStringBuilder.Entities
{
    class Post
    {
        public DateTime Moment { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }
        public List<Comment> Comments { get; set; } = new List<Comment>();

        public Post()
        {

        }
        public Post(DateTime moment, string title, string content, int likes)
        {
            Moment = moment;
            Title = title;
            Content = content;
            Likes = likes;
        }

        public void AddComment(Comment comment)
        {
            Comments.Add(comment);
        }

        public void RemoveComment(Comment comment)
        {
            Comments.Remove(comment);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Title).
            Append(Likes).
            Append(" Likes - ").
            AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss")).
            AppendLine(Content).
            AppendLine("Comments");

            if (Comments.Count == 0)
                sb.AppendLine("Não há comentários.");
            else
                foreach (Comment c in Comments)
                    sb.AppendLine(c.Text);

            return sb.ToString();
        }
    }
}
