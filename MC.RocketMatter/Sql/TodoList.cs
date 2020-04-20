using System.ComponentModel.DataAnnotations.Schema;

namespace MC.RocketMatter.Sql {
    public class TodoList {
        public int ID { get; set; }
        public int GroupId { get; set; }
        
        [ForeignKey(nameof(User))]
        public int UserId { get; set; }
        public User User { get; set; }

        public bool IsDeleted { get; set; }
        public string Title { get; set; }
    }

}
