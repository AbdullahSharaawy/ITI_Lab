using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysCsharp.Day11
{
	public class DaynamicArray
	{
		private int[] _array;
		private int _size;
		private int _capacity;

		public DaynamicArray(int initialCapacity = 4)
		{
			_capacity = initialCapacity;
			_array = new int[_capacity];
			_size = 0;
		}

		public void Add(int value)
		{
			
			if (_size == _capacity)
			{
				_capacity *= 2;
				int[] newArray = new int[_capacity];
				for (int i = 0; i < _size; i++)
				{
					newArray[i] = _array[i];
				}
				_array = newArray;
			}
			_array[_size++] = value;
		}

		public void PrintAll()
		{
			for (int i = 0; i < _size; i++)
			{
				Console.Write(_array[i] + ", ");
			}
		}
		public double Average()
		{
			double sum = 0;
			for (int i = 0; i < _size; i++)
			{
				sum+=_array[i];
			}
			return _size == 0 ? 0 : sum / _size;
		}
		public int Count() => _size;
		public int? Pop()
		{
			if (_size == 0)
				return null;
			return _array[--_size];
		}
		public int? Peek()
		{
			if (_size == 0)
				return null;
		   return _array[_size - 1];
		}
		
	}
	public class MyStack
	{
		private DaynamicArray _array;
		public MyStack()
		{
			_array = new DaynamicArray();
		}
		public void Push(int value)
		{
			_array.Add(value);
		}
		public int? Pop()
		{ 
		    return _array.Pop();
		}
		public int? Peek()
		{
			return _array.Peek();
		}
	}
	}
