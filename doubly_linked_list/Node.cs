namespace doubly_linked_list
{
	public class Node
	{
		public int id { get; set; }
		public int value { get; set; }

		public Node? next { get; set; }
		public Node? back { get; set; }

		public Node()
		{
			id = 0;
			value = 0;
			next = null;
			back = null;
		}

		public Node(int id, int value)
		{
			this.id = id;
			this.value = value;

			next = null;
			back = null;
		}

		public void print()
		{
			string back_id;
			string next_id;

			if (back is null)
				back_id = "нету";
			else
				back_id = Convert.ToString(back.id);

			if (next is null)
				next_id = "нету";
			else
				next_id = Convert.ToString(next.id);

			Console.WriteLine($"{id}:{value}. Предыдущий: {back_id}, Следующий: {next_id}");
		}
	}
}

