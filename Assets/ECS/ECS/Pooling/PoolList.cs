﻿namespace ME.ECS {

	using System.Collections.Generic;
	using ME.ECS.Collections;

	#if ECS_COMPILE_IL2CPP_OPTIONS
	[Unity.IL2CPP.CompilerServices.Il2CppSetOptionAttribute(Unity.IL2CPP.CompilerServices.Option.NullChecks, false),
	 Unity.IL2CPP.CompilerServices.Il2CppSetOptionAttribute(Unity.IL2CPP.CompilerServices.Option.ArrayBoundsChecks, false),
	 Unity.IL2CPP.CompilerServices.Il2CppSetOptionAttribute(Unity.IL2CPP.CompilerServices.Option.DivideByZeroChecks, false)]
	#endif
	public static class PoolHashSet<TValue> {

		private static PoolInternalBase pool = new PoolInternalBase(() => new HashSet<TValue>(), (x) => ((HashSet<TValue>)x).Clear());

		public static HashSet<TValue> Spawn(int capacity = 0) {

			return (HashSet<TValue>)PoolHashSet<TValue>.pool.Spawn();
		    
		}

		public static void Recycle(ref HashSet<TValue> dic) {

			PoolHashSet<TValue>.pool.Recycle(dic);
			dic = null;

		}

		public static void Recycle(HashSet<TValue> dic) {

			PoolHashSet<TValue>.pool.Recycle(dic);

		}

	}

	#if ECS_COMPILE_IL2CPP_OPTIONS
	[Unity.IL2CPP.CompilerServices.Il2CppSetOptionAttribute(Unity.IL2CPP.CompilerServices.Option.NullChecks, false),
	 Unity.IL2CPP.CompilerServices.Il2CppSetOptionAttribute(Unity.IL2CPP.CompilerServices.Option.ArrayBoundsChecks, false),
	 Unity.IL2CPP.CompilerServices.Il2CppSetOptionAttribute(Unity.IL2CPP.CompilerServices.Option.DivideByZeroChecks, false)]
	#endif
	public static class PoolHashSetCopyable<TValue> {

		private static PoolInternalBase pool = new PoolInternalBase(() => new HashSetCopyable<TValue>(), (x) => ((HashSetCopyable<TValue>)x).Clear());

		public static HashSetCopyable<TValue> Spawn(int capacity = 0) {

			return (HashSetCopyable<TValue>)PoolHashSetCopyable<TValue>.pool.Spawn();
		    
		}

		public static void Recycle(ref HashSetCopyable<TValue> dic) {

			PoolHashSetCopyable<TValue>.pool.Recycle(dic);
			dic = null;

		}

		public static void Recycle(HashSetCopyable<TValue> dic) {

			PoolHashSetCopyable<TValue>.pool.Recycle(dic);

		}

	}

	#if ECS_COMPILE_IL2CPP_OPTIONS
	[Unity.IL2CPP.CompilerServices.Il2CppSetOptionAttribute(Unity.IL2CPP.CompilerServices.Option.NullChecks, false),
	 Unity.IL2CPP.CompilerServices.Il2CppSetOptionAttribute(Unity.IL2CPP.CompilerServices.Option.ArrayBoundsChecks, false),
	 Unity.IL2CPP.CompilerServices.Il2CppSetOptionAttribute(Unity.IL2CPP.CompilerServices.Option.DivideByZeroChecks, false)]
	#endif
	public static class PoolQueueCopyable<TValue> where TValue : struct {

		private static int capacity;
		private static PoolInternalBase pool = new PoolInternalBase(() => new QueueCopyable<TValue>(PoolQueueCopyable<TValue>.capacity), (x) => ((QueueCopyable<TValue>)x).Clear());

		public static QueueCopyable<TValue> Spawn(int capacity) {

			PoolQueueCopyable<TValue>.capacity = capacity;
			return (QueueCopyable<TValue>)PoolQueueCopyable<TValue>.pool.Spawn();
		    
		}

		public static void Recycle(ref QueueCopyable<TValue> dic) {

			PoolQueueCopyable<TValue>.pool.Recycle(dic);
			dic = null;

		}

		public static void Recycle(QueueCopyable<TValue> dic) {

			PoolQueueCopyable<TValue>.pool.Recycle(dic);

		}

	}

	#if ECS_COMPILE_IL2CPP_OPTIONS
	[Unity.IL2CPP.CompilerServices.Il2CppSetOptionAttribute(Unity.IL2CPP.CompilerServices.Option.NullChecks, false),
	 Unity.IL2CPP.CompilerServices.Il2CppSetOptionAttribute(Unity.IL2CPP.CompilerServices.Option.ArrayBoundsChecks, false),
	 Unity.IL2CPP.CompilerServices.Il2CppSetOptionAttribute(Unity.IL2CPP.CompilerServices.Option.DivideByZeroChecks, false)]
	#endif
	public static class PoolQueue<TValue> {

		private static int capacity;
		private static PoolInternalBase pool = new PoolInternalBase(() => new Queue<TValue>(PoolQueue<TValue>.capacity), (x) => ((Queue<TValue>)x).Clear());

		public static Queue<TValue> Spawn(int capacity) {

			PoolQueue<TValue>.capacity = capacity;
			return (Queue<TValue>)PoolQueue<TValue>.pool.Spawn();
		    
		}

		public static void Recycle(ref Queue<TValue> dic) {

			PoolQueue<TValue>.pool.Recycle(dic);
			dic = null;

		}

		public static void Recycle(Queue<TValue> dic) {

			PoolQueue<TValue>.pool.Recycle(dic);

		}

	}

	#if ECS_COMPILE_IL2CPP_OPTIONS
    [Unity.IL2CPP.CompilerServices.Il2CppSetOptionAttribute(Unity.IL2CPP.CompilerServices.Option.NullChecks, false),
     Unity.IL2CPP.CompilerServices.Il2CppSetOptionAttribute(Unity.IL2CPP.CompilerServices.Option.ArrayBoundsChecks, false),
     Unity.IL2CPP.CompilerServices.Il2CppSetOptionAttribute(Unity.IL2CPP.CompilerServices.Option.DivideByZeroChecks, false)]
	#endif
	public static class PoolList<TValue> {

		private static int capacity;
		private static PoolInternalBase pool = new PoolInternalBase(() => new List<TValue>(PoolList<TValue>.capacity), (x) => ((List<TValue>)x).Clear());

		public static List<TValue> Spawn(int capacity) {

			PoolList<TValue>.capacity = capacity;
			return (List<TValue>)PoolList<TValue>.pool.Spawn();
		    
		}

		public static void Recycle(ref List<TValue> dic) {

			PoolList<TValue>.pool.Recycle(dic);
			dic = null;

		}

		public static void Recycle(List<TValue> dic) {

			PoolList<TValue>.pool.Recycle(dic);

		}

	}

	#if ECS_COMPILE_IL2CPP_OPTIONS
    [Unity.IL2CPP.CompilerServices.Il2CppSetOptionAttribute(Unity.IL2CPP.CompilerServices.Option.NullChecks, false),
     Unity.IL2CPP.CompilerServices.Il2CppSetOptionAttribute(Unity.IL2CPP.CompilerServices.Option.ArrayBoundsChecks, false),
     Unity.IL2CPP.CompilerServices.Il2CppSetOptionAttribute(Unity.IL2CPP.CompilerServices.Option.DivideByZeroChecks, false)]
	#endif
	public static class PoolSortedList<TKey, TValue> where TKey : struct, System.IComparable {
		
		private class DuplicateKeyComparer : IComparer<TKey> {
			
			public int Compare(TKey x, TKey y) {

				int result = Comparer<TKey>.Default.Compare(x, y);
				if (result == 0) {
					
					return 1;
					
				} else {
					
					return result;
					
				}
				
			}

		}
		
		private static int capacity;
		private static DuplicateKeyComparer duplicateComparer = new DuplicateKeyComparer();
		private static PoolInternalBase pool = new PoolInternalBase(() => new SortedList<TKey, TValue>(PoolSortedList<TKey, TValue>.capacity, PoolSortedList<TKey, TValue>.duplicateComparer), (x) => ((SortedList<TKey, TValue>)x).Clear());

		public static SortedList<TKey, TValue> Spawn(int capacity) {

			PoolSortedList<TKey, TValue>.capacity = capacity;
			return (SortedList<TKey, TValue>)PoolSortedList<TKey, TValue>.pool.Spawn();
		    
		}

		public static void Prewarm(int count, int capacity) {

			PoolSortedList<TKey, TValue>.capacity = capacity;
			PoolSortedList<TKey, TValue>.pool.Prewarm(count);

		}

		public static void Recycle(ref SortedList<TKey,TValue> dic) {

			PoolSortedList<TKey, TValue>.pool.Recycle(dic);
			dic = null;

		}

		public static void Recycle(SortedList<TKey,TValue> dic) {

			PoolSortedList<TKey, TValue>.pool.Recycle(dic);

		}

	}

}
