using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Engine.Classes
{
    public enum EventType
    {
        LoadMap,
        SetWindowTitle,
        SetWindowIcon,
        SetVisible,
        SetPosition,
        SetScale,
        SetRotation,
        SetCollision,
        EventTrigger,
        SetVariable
    }

    public enum EventNodeType
    {
        Auto,
        Trigger,
        Script,
        Logic,
        Dialog,
        Branch
    }

    public class NodeClass
    {
        public EventType EventType;
        public string Name, Value;

        public NodeClass(EventType eventType, string value = "")
        {
            EventType = eventType;
            Value = value;
        }

        public NodeClass(EventType eventType, string name = "", string value = "")
        {
            EventType = eventType;
            Name = name;
            Value = value;
        }
    }
}
