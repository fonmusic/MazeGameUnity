using UnityEditor;

namespace Maze
{
    public class MenuItems
    {
        [MenuItem("Maze/Create Bonuses")]
        private static void MenuOption()
        {
            EditorWindow.GetWindow(typeof(MyWindow), false, "Maze");
        }
    }
}