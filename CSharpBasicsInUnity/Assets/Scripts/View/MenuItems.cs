using UnityEditor;

namespace Maze
{
    public class MenuItems
    {
        [MenuItem("Maze/Menu No0 ")]
        private static void MenuOption()
        {
            EditorWindow.GetWindow(typeof(MyWindow), false, "Maze");
        }
    }
}