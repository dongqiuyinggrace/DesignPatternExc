using System.Collections.Generic;

namespace DesignPatternExc.src.CompositePattern
{
    public class Group : IComponent
    {
        private List<IComponent> components = new List<IComponent>();

        public void Add(IComponent component)
        {
            components.Add(component);
        }

        public void Move()
        {
            foreach(var component in components)
            {
                component.Move();
            }
        }

        public void Render()
        {
            foreach(var component in components)
            {
                component.Render();
            }
        }
    }
}