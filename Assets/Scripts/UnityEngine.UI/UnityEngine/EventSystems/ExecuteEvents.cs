using System.Collections.Generic;
using UnityEngine.UI;

namespace UnityEngine.EventSystems
{
	public static class ExecuteEvents
	{
		public delegate void EventFunction<T1>(T1 handler, BaseEventData eventData);

		private static readonly EventFunction<IPointerEnterHandler> s_PointerEnterHandler;

		private static readonly EventFunction<IPointerExitHandler> s_PointerExitHandler;

		private static readonly EventFunction<IPointerDownHandler> s_PointerDownHandler;

		private static readonly EventFunction<IPointerUpHandler> s_PointerUpHandler;

		private static readonly EventFunction<IPointerClickHandler> s_PointerClickHandler;

		private static readonly EventFunction<IInitializePotentialDragHandler> s_InitializePotentialDragHandler;

		private static readonly EventFunction<IBeginDragHandler> s_BeginDragHandler;

		private static readonly EventFunction<IDragHandler> s_DragHandler;

		private static readonly EventFunction<IEndDragHandler> s_EndDragHandler;

		private static readonly EventFunction<IDropHandler> s_DropHandler;

		private static readonly EventFunction<IScrollHandler> s_ScrollHandler;

		private static readonly EventFunction<IUpdateSelectedHandler> s_UpdateSelectedHandler;

		private static readonly EventFunction<ISelectHandler> s_SelectHandler;

		private static readonly EventFunction<IDeselectHandler> s_DeselectHandler;

		private static readonly EventFunction<IMoveHandler> s_MoveHandler;

		private static readonly EventFunction<ISubmitHandler> s_SubmitHandler;

		private static readonly EventFunction<ICancelHandler> s_CancelHandler;

		private static readonly ObjectPool<List<IEventSystemHandler>> s_HandlerListPool;

		private static readonly List<Transform> s_InternalTransformList;

		public static EventFunction<IPointerEnterHandler> pointerEnterHandler => null;

		public static EventFunction<IPointerExitHandler> pointerExitHandler => null;

		public static EventFunction<IPointerDownHandler> pointerDownHandler => null;

		public static EventFunction<IPointerUpHandler> pointerUpHandler => null;

		public static EventFunction<IPointerClickHandler> pointerClickHandler => null;

		public static EventFunction<IInitializePotentialDragHandler> initializePotentialDrag => null;

		public static EventFunction<IBeginDragHandler> beginDragHandler => null;

		public static EventFunction<IDragHandler> dragHandler => null;

		public static EventFunction<IEndDragHandler> endDragHandler => null;

		public static EventFunction<IDropHandler> dropHandler => null;

		public static EventFunction<IScrollHandler> scrollHandler => null;

		public static EventFunction<IUpdateSelectedHandler> updateSelectedHandler => null;

		public static EventFunction<ISelectHandler> selectHandler => null;

		public static EventFunction<IDeselectHandler> deselectHandler => null;

		public static EventFunction<IMoveHandler> moveHandler => null;

		public static EventFunction<ISubmitHandler> submitHandler => null;

		public static EventFunction<ICancelHandler> cancelHandler => null;

		public static T ValidateEventData<T>(BaseEventData data) where T : class
		{
			return null;
		}

		private static void Execute(IPointerEnterHandler handler, BaseEventData eventData)
		{
		}

		private static void Execute(IPointerExitHandler handler, BaseEventData eventData)
		{
		}

		private static void Execute(IPointerDownHandler handler, BaseEventData eventData)
		{
		}

		private static void Execute(IPointerUpHandler handler, BaseEventData eventData)
		{
		}

		private static void Execute(IPointerClickHandler handler, BaseEventData eventData)
		{
		}

		private static void Execute(IInitializePotentialDragHandler handler, BaseEventData eventData)
		{
		}

		private static void Execute(IBeginDragHandler handler, BaseEventData eventData)
		{
		}

		private static void Execute(IDragHandler handler, BaseEventData eventData)
		{
		}

		private static void Execute(IEndDragHandler handler, BaseEventData eventData)
		{
		}

		private static void Execute(IDropHandler handler, BaseEventData eventData)
		{
		}

		private static void Execute(IScrollHandler handler, BaseEventData eventData)
		{
		}

		private static void Execute(IUpdateSelectedHandler handler, BaseEventData eventData)
		{
		}

		private static void Execute(ISelectHandler handler, BaseEventData eventData)
		{
		}

		private static void Execute(IDeselectHandler handler, BaseEventData eventData)
		{
		}

		private static void Execute(IMoveHandler handler, BaseEventData eventData)
		{
		}

		private static void Execute(ISubmitHandler handler, BaseEventData eventData)
		{
		}

		private static void Execute(ICancelHandler handler, BaseEventData eventData)
		{
		}

		private static void GetEventChain(GameObject root, IList<Transform> eventChain)
		{
		}

		public static bool Execute<T>(GameObject target, BaseEventData eventData, EventFunction<T> functor) where T : IEventSystemHandler
		{
			return false;
		}

		public static GameObject ExecuteHierarchy<T>(GameObject root, BaseEventData eventData, EventFunction<T> callbackFunction) where T : IEventSystemHandler
		{
			return null;
		}

		private static bool ShouldSendToComponent<T>(Component component) where T : IEventSystemHandler
		{
			return false;
		}

		private static void GetEventList<T>(GameObject go, IList<IEventSystemHandler> results) where T : IEventSystemHandler
		{
		}

		public static bool CanHandleEvent<T>(GameObject go) where T : IEventSystemHandler
		{
			return false;
		}

		public static GameObject GetEventHandler<T>(GameObject root) where T : IEventSystemHandler
		{
			return null;
		}
	}
}
