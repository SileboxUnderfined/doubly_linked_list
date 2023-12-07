namespace doubly_linked_list
{
	public class LinkedList
	{
		private Node head { get; set; }

		public LinkedList()
		{
			head = new Node();
		}

		public void print()
		{
			Node? p = head;

			while (p.back is not null)
				p = p.back;

            while (p is not null)
			{
                p.print();
                p = p.next;
			}
		}

		public void addToEnd(int value)
		{
			Node p = head;

			while (p.next is not null)
				p = p.next;

			Node new_node = new Node(p.id+1, value);

			p.next = new_node;
			new_node.back = p;
		}

		public bool addToId(int id, int value)
		{
			Node new_node = new Node(id, value);
			Node p = head;

			if (new_node.id <= p.id)
			{
				while (p is not null)
				{
					if (p.id == id)
						return false;

					if (p.back is null || p.back.id < id)
					{
						if (p.back is not null && p.back.back is not null)
							new_node.back = p.back.back;
						new_node.next = p;

						if (p.back is not null)
							p.back.next = new_node;

						p.back = new_node;

						return true;
					}

					p = p.back;
				}
			}

			while (p is not null)
			{

				if (p.id == id)
					return false;

				if (p.next is null || p.next.id > id)
				{
					new_node.next = p.next;
					new_node.back = p;

					if (p.next is not null)
						p.next.back = new_node;

					p.next = new_node;

					return true;
				}

				p = p.next;
			}

			return false;
		}

		public void deleteById(int id)
		{
			Node p = head;

			while (p.back is not null)
				p = p.back;

			while (p.next is not null)
			{
				if (p.id == id)
				{
					if (p.back is not null)
						p.back.next = p.next;

					if (p.next is not null)
						p.next.back = p.back;
				}

				p = p.next;
			}

			if (p.id == id)
			{
				if (p.back is not null)
					p.back.next = null;
			}

		}

		public void createNew()
		{
			head = new Node();
		}
	}
}

