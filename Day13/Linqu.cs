﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DaysCsharp.Day13
{
	public static class Linqu 
	{
		public static List<T> Where<T>(this List<T> source, Func<T, bool> predicate)
		{
			if (source == null || source.Count() == 0)
				return null;

			List<T> result = new List<T>();
			foreach (var item in source)
			{
				if (predicate(item))
				{
					result.Add(item);
				}
			}
			return result;
		}
		public static List<T> Where<T>(this List<T> source, Func<T,int, bool> predicate)
		{
			if (source == null || source.Count() == 0)
				return null;

			List<T> result = new List<T>();
			for (int i=0;i<source.Count();i++)
			{
				if (predicate(source[i],i))
				{
					result.Add(source[i]);
				}
			}
			return result;
		}
		public static List<T> Select<T>(this List<T> source,Func<T,T> prdicate)
		{
			if (source == null || source.Count() == 0)
				return null;

			List<T> result=new List<T>();
			foreach (var item in source) 
			{
			    result.Add(prdicate(item));
			}
			return result;
		}
		public static List<T> Select<T>(this List<T> source,Func<T,int,T> prdicate)
		{
			if (source == null || source.Count() == 0)
				return null;

			List<T> result = new List<T>();
			for (int i = 0; i < source.Count(); i++)
			{
				
					result.Add(prdicate(source[i], i));
				
			}
			return result;
		}
		public static List<T> Take<T>(this List<T> source,int NumElements) {
			if (source == null || source.Count() == 0 )
				return null;
			if (NumElements > source.Count())
				return source;
			List<T> result = new List<T>();
			
			
			
			for (int i = 0; i < NumElements; i++)
			{

				result.Add(source[i]);

			}
			return result;

		}
		public static List<T> TakeWhile<T>(this List<T> source, Func<T, bool> predicate)
		{
			if (source == null || source.Count() == 0)
				return null;

			List<T> result = new List<T>();
			for (int i = 0; i < source.Count(); i++)
			{
				if (predicate(source[i]))
				{
					result.Add(source[i]);
				}else return result;
			}
			return result;
		}
		public static List<T> TakeWhile<T>(this List<T> source, Func<T,int,bool> predicate)
		{
			if (source == null || source.Count() == 0)
				return null;

			List<T> result = new List<T>();
			for (int i = 0; i < source.Count(); i++)
			{
				if (predicate(source[i],i))
				result.Add(source[i]);
				else return result;

			}
			return result;

		}
		public static List<T> SkipWhile<T>(this List<T> source, Func<T, bool> predicate)
		{
			if (source == null || source.Count() == 0)
				return null;

			List<T> result = new List<T>();
			int count = 0;
			for (int i = 0; i < source.Count(); i++)
			{
				if (predicate(source[i]))
				{
					count++;
				}
				else break;
			}
			for (int i = count; i < source.Count(); i++)
			{
				result.Add(source[i]);
			}
			return result;
		}
		public static List<T> SkipWhile<T>(this List<T> source, Func<T, int, bool> predicate)
		{
			if (source == null || source.Count() == 0)
				return null;

			List<T> result = new List<T>();
			int count = 0;
			for (int i = 0; i < source.Count(); i++)
			{
				if (predicate(source[i],i))
				{
					count++;
				}
				else break;
			}
			for (int i = count; i < source.Count(); i++)
			{
				result.Add(source[i]);
			}
			return result;

		}
		public static List<T> Skip<T>(this List<T> source, int NumElements)
		{
			if (source == null || source.Count() == 0 )
				return null;
			
			if (NumElements > source.Count())
				return null;

			List<T> result = new List<T>();
			for (int i = NumElements; i < source.Count(); i++)
			{

				result.Add(source[i]);

			}
			return result;

		}
		public static List<T> TakeLast<T>(this List<T> source, int NumElements)
		{
			if (source == null || source.Count() == 0 )
				return null;
			if (NumElements > source.Count())
				return source;
			List<T> result = new List<T>();
			for (int i = source.Count()-1; i >= 0 && NumElements>0; i--)
			{

				result.Add(source[i]);
				NumElements--;
			}
			return result;
		}
		public static List<T> SkipLast<T>(this List<T> source, int NumElements)
		{
			if (source == null || source.Count() == 0 )
				return null;
			if (NumElements > source.Count())
				return source;
			List<T> result = new List<T>();
			for (int i = source.Count()-NumElements-1; i >= 0 ; i--)
			{

				result.Add(source[i]);
				
			}
			return result;
		}
		public static void insertionSortAsc<T>(ref List<T> source)
		{
			for (int i = 0; i < source.Count() - 1; i++)
			{
				for (int j = i + 1; j > 0; j--)
				{

					if ((dynamic)source[j] < (dynamic)source[j - 1])
					{
						T tmep = source[j];
						source[j] = source[j - 1];
						source[j - 1] = tmep;
						
					}
					else break;
				}
			}
			
		}
		public static void insertionSortDesc<T>(ref List<T> source)
		{
			for (int i = 0; i < source.Count() - 1; i++)
			{
				for (int j = i + 1; j > 0; j--)
				{

					if ((dynamic)source[j] > (dynamic)source[j - 1])
					{
						T tmep = source[j];
						source[j] = source[j - 1];
						source[j - 1] = tmep;

					}
					else break;
				}
			}

		}
		public static List<T> OrderBy<T>(this List<T>source)
		{
			if (source == null || source.Count() == 0)
				return null;

			insertionSortAsc<T>(ref source);
			return source;
			
		}
		public static List<T> OrderByDesc<T>(this List<T> source)
		{
			if (source == null || source.Count() == 0)
				return null;

			insertionSortDesc<T>(ref source); 
			return source;
		}
		public static T First<T>(this List<T> source) 
		{
			
			return source[0]; 
		}
		public static T Last<T>(this List<T> source)
		{

			return source[source.Count()];
		}
		public static T LastOrDefault<T>(this List<T> source)
		{
			if (source == null || source.Count == 0)
				return default(T);
			return source[source.Count()];
		}
		public static T FirstOrDefault<T>(this List<T> source)
		{
			if (source == null || source.Count == 0)
				return default(T);
			return source[0];
		}
		public static T Single<T>(this List<T> source)
		{
			if (source.Count == 1)
				return source[0];
			else
				throw new Exception("Exception ya man");
		}
		public static T SingleOrDefault<T>(this List<T> source)
		{
			if (source.Count == 1)
				return source[0];
			if (source.Count == 0)
				return default(T);

			else
				throw new Exception("Exception ya man");
		}
		public static List<T> Distinct<T>(this List<T> source)
			{
			if (source == null || source.Count() == 0)
				return null;

			List<T> result = new List<T>();
			  foreach (T item in source)
			{
				if (!result.Contains(item))
					result.Add(item);
			}
			  return result;
		    }
	}
}
