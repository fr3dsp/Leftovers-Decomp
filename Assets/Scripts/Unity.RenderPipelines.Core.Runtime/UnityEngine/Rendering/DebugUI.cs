using System;
using System.Runtime.CompilerServices;

namespace UnityEngine.Rendering
{
	public class DebugUI
	{
		public class Container : Widget, IContainer
		{
			public ObservableList<Widget> children { get; private set; }

			public override Panel panel
			{
				get
				{
					return null;
				}
				internal set
				{
				}
			}

			public Container()
			{
			}

			public Container(string displayName, ObservableList<Widget> children)
			{
			}

			internal override void GenerateQueryPath()
			{
			}

			protected virtual void OnItemAdded(ObservableList<Widget> sender, ListChangedEventArgs<Widget> e)
			{
			}

			protected virtual void OnItemRemoved(ObservableList<Widget> sender, ListChangedEventArgs<Widget> e)
			{
			}

			public override int GetHashCode()
			{
				return 0;
			}
		}

		public class Foldout : Container, IValueField
		{
			public bool opened;

			public bool isReadOnly => false;

			public string[] columnLabels { get; set; }

			public Foldout()
			{
			}

			public Foldout(string displayName, ObservableList<Widget> children, string[] columnLabels = null)
			{
			}

			public bool GetValue()
			{
				return false;
			}

			object IValueField.GetValue()
			{
				return null;
			}

			public void SetValue(object value)
			{
			}

			public object ValidateValue(object value)
			{
				return null;
			}

			public void SetValue(bool value)
			{
			}
		}

		public class HBox : Container
		{
		}

		public class VBox : Container
		{
		}

		public class Table : Container
		{
			public class Row : Foldout
			{
			}

			public bool isReadOnly;

			private bool[] m_Header;

			public bool[] VisibleColumns => null;

			public void SetColumnVisibility(int index, bool visible)
			{
			}

			public bool GetColumnVisibility(int index)
			{
				return false;
			}

			protected override void OnItemAdded(ObservableList<Widget> sender, ListChangedEventArgs<Widget> e)
			{
			}

			protected override void OnItemRemoved(ObservableList<Widget> sender, ListChangedEventArgs<Widget> e)
			{
			}
		}

		public abstract class Field<T> : Widget, IValueField
		{
			public Action<Field<T>, T> onValueChanged;

			public Func<T> getter { get; set; }

			public Action<T> setter { get; set; }

			object IValueField.ValidateValue(object value)
			{
				return null;
			}

			public virtual T ValidateValue(T value)
			{
				return default(T);
			}

			object IValueField.GetValue()
			{
				return null;
			}

			public T GetValue()
			{
				return default(T);
			}

			public void SetValue(object value)
			{
			}

			public void SetValue(T value)
			{
			}
		}

		public class BoolField : Field<bool>
		{
		}

		public class HistoryBoolField : BoolField
		{
			public Func<bool>[] historyGetter { get; set; }

			public int historyDepth => 0;

			public bool GetHistoryValue(int historyIndex)
			{
				return false;
			}
		}

		public class IntField : Field<int>
		{
			public Func<int> min;

			public Func<int> max;

			public int incStep;

			public int intStepMult;

			public override int ValidateValue(int value)
			{
				return 0;
			}
		}

		public class UIntField : Field<uint>
		{
			public Func<uint> min;

			public Func<uint> max;

			public uint incStep;

			public uint intStepMult;

			public override uint ValidateValue(uint value)
			{
				return 0u;
			}
		}

		public class FloatField : Field<float>
		{
			public Func<float> min;

			public Func<float> max;

			public float incStep;

			public float incStepMult;

			public int decimals;

			public override float ValidateValue(float value)
			{
				return 0f;
			}
		}

		public class EnumField : Field<int>
		{
			public GUIContent[] enumNames;

			public int[] enumValues;

			internal int[] quickSeparators;

			internal int[] indexes;

			public Func<int> getIndex { get; set; }

			public Action<int> setIndex { get; set; }

			public int currentIndex
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public Type autoEnum
			{
				set
				{
				}
			}

			internal void InitQuickSeparators()
			{
			}

			internal void InitIndexes()
			{
			}
		}

		public class HistoryEnumField : EnumField
		{
			public Func<int>[] historyIndexGetter { get; set; }

			public int historyDepth => 0;

			public int GetHistoryValue(int historyIndex)
			{
				return 0;
			}
		}

		public class BitField : Field<Enum>
		{
			internal Type m_EnumType;

			public GUIContent[] enumNames { get; private set; }

			public int[] enumValues { get; private set; }

			public Type enumType
			{
				get
				{
					return null;
				}
				set
				{
				}
			}
		}

		public class ColorField : Field<Color>
		{
			public bool hdr;

			public bool showAlpha;

			public bool showPicker;

			public float incStep;

			public float incStepMult;

			public int decimals;

			public override Color ValidateValue(Color value)
			{
				return default(Color);
			}
		}

		public class Vector2Field : Field<Vector2>
		{
			public float incStep;

			public float incStepMult;

			public int decimals;
		}

		public class Vector3Field : Field<Vector3>
		{
			public float incStep;

			public float incStepMult;

			public int decimals;
		}

		public class Vector4Field : Field<Vector4>
		{
			public float incStep;

			public float incStepMult;

			public int decimals;
		}

		public class Panel : IContainer, IComparable<Panel>
		{
			public Flags flags { get; set; }

			public string displayName { get; set; }

			public int groupIndex { get; set; }

			public string queryPath => null;

			public bool isEditorOnly => false;

			public bool isRuntimeOnly => false;

			public bool isInactiveInEditor => false;

			public bool editorForceUpdate => false;

			public ObservableList<Widget> children { get; private set; }

			public event Action<Panel> onSetDirty
			{
				[CompilerGenerated]
				add
				{
				}
				[CompilerGenerated]
				remove
				{
				}
			}

			protected virtual void OnItemAdded(ObservableList<Widget> sender, ListChangedEventArgs<Widget> e)
			{
			}

			protected virtual void OnItemRemoved(ObservableList<Widget> sender, ListChangedEventArgs<Widget> e)
			{
			}

			public void SetDirty()
			{
			}

			public override int GetHashCode()
			{
				return 0;
			}

			int IComparable<Panel>.CompareTo(Panel other)
			{
				return 0;
			}
		}

		[Flags]
		public enum Flags
		{
			None = 0,
			EditorOnly = 2,
			RuntimeOnly = 4,
			EditorForceUpdate = 8
		}

		public abstract class Widget
		{
			protected Panel m_Panel;

			protected IContainer m_Parent;

			public virtual Panel panel
			{
				get
				{
					return null;
				}
				internal set
				{
				}
			}

			public virtual IContainer parent
			{
				get
				{
					return null;
				}
				internal set
				{
				}
			}

			public Flags flags { get; set; }

			public string displayName { get; set; }

			public string queryPath { get; private set; }

			public bool isEditorOnly => false;

			public bool isRuntimeOnly => false;

			public bool isInactiveInEditor => false;

			internal virtual void GenerateQueryPath()
			{
			}

			public override int GetHashCode()
			{
				return 0;
			}
		}

		public interface IContainer
		{
			ObservableList<Widget> children { get; }

			string displayName { get; set; }

			string queryPath { get; }
		}

		public interface IValueField
		{
			object GetValue();

			void SetValue(object value);

			object ValidateValue(object value);
		}

		public class Button : Widget
		{
			public Action action { get; set; }
		}

		public class Value : Widget
		{
			public float refreshRate;

			public Func<object> getter { get; set; }

			public object GetValue()
			{
				return null;
			}
		}
	}
}
