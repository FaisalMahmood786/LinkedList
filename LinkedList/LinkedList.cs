using System.Text;

namespace LinkedList
{
    public class LinkedList<T>
    {
        private Node<T> head;

        public LinkedList()
        {
            head = null;
        }

        // Insert a node at a specific position (1-based index)
        public void Insert(int position, T data)
        {
            Node<T> newNode = new Node<T>(data);

            if (position < 1)
            {
                throw new ArgumentOutOfRangeException("Position must be >= 1");
            }

            if (position == 1)
            {
                newNode.Next = head;
                head = newNode;
                return;
            }

            Node<T> current = head;
            Node<T> previous = null;
            int index = 1;

            while (current != null && index < position)
            {
                previous = current;
                current = current.Next;
                index++;
            }

            if (index != position)
            {
                throw new ArgumentOutOfRangeException("Position is out of bounds");
            }

            newNode.Next = current;
            previous.Next = newNode;
        }
        // Print the string representation of the list
        public string PrintList()
        {
            if (head == null)
            {
                return string.Empty;
            }

            Node<T> current = head;
            StringBuilder result = new StringBuilder();
            while (current != null)
            {
                result.Append((current.Data));
                if (current.Next != null)
                {
                    result.Append(" -> ");
                }
                current = current.Next;
            }
            return result.ToString();
        }

    }
}