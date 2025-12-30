using System;

namespace UnityEngine.Rendering
{
	public abstract class VolumeParameter
	{
		public const string k_DebuggerDisplay = "{m_Value} ({m_OverrideState})";

		[SerializeField]
		protected bool m_OverrideState;

		public virtual bool overrideState
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		internal abstract void Interp(VolumeParameter from, VolumeParameter to, float t);

		public T GetValue<T>()
		{
			return default(T);
		}

		public abstract void SetValue(VolumeParameter parameter);

		protected internal virtual void OnEnable()
		{
		}

		protected internal virtual void OnDisable()
		{
		}

		public static bool IsObjectParameter(Type type)
		{
			return false;
		}

		public virtual void Release()
		{
		}
	}
	[Serializable]
	public class VolumeParameter<T> : VolumeParameter, IEquatable<VolumeParameter<T>>
	{
		[SerializeField]
		protected T m_Value;

		public virtual T value
		{
			get
			{
				return default(T);
			}
			set
			{
			}
		}

		public VolumeParameter()
		{
		}

		protected VolumeParameter(T value, bool overrideState)
		{
		}

		internal override void Interp(VolumeParameter from, VolumeParameter to, float t)
		{
		}

		public virtual void Interp(T from, T to, float t)
		{
		}

		public void Override(T x)
		{
		}

		public override void SetValue(VolumeParameter parameter)
		{
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public override string ToString()
		{
			return null;
		}

		public static bool operator ==(VolumeParameter<T> lhs, T rhs)
		{
			return false;
		}

		public static bool operator !=(VolumeParameter<T> lhs, T rhs)
		{
			return false;
		}

		public bool Equals(VolumeParameter<T> other)
		{
			return false;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public static explicit operator T(VolumeParameter<T> prop)
		{
			return default(T);
		}
	}
}
