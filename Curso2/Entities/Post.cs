using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso2.Entities
{
	public class Post
	{
		public string Title { get; set; }
		public string Content { get; set; }
		public DateTime Moment { get; set; }
		public int Likes { get; set; }
		public List<Comments> Comments { get; set; } = new List<Comments>();

		public Post() { }	
		public Post(string title, string content, DateTime moment, int likes)
		{
			Title = title;
			Content = content;
			Moment = moment;
			Likes = likes;
		}
		public void AddComment(Comments comment) 
		{ 
			Comments.Add(comment);
		}
		public void RemoveComment(Comments comment)
		{
			Comments.Remove(comment);
		}

		public override string ToString()
		{
			StringBuilder sb = new StringBuilder();
			sb.AppendLine(Title);
			sb.Append(Likes);
			sb.Append(" Likes - ");
			sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
			sb.AppendLine(Content);
			sb.AppendLine("Comment:");
			foreach (Comments comment in Comments) 
			{ 
				sb.AppendLine(comment.Text);
			}

			return sb.ToString();

		}
	}
}
