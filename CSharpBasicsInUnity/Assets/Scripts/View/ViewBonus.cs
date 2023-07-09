using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Maze
{
    public class ViewBonus
    {
        private Text _bonusLabel;

        public ViewBonus(GameObject bonusLabelPrefab)
        {
            _bonusLabel = bonusLabelPrefab.GetComponent<Text>();
            _bonusLabel.text = string.Empty;
        }

        public void Display(string name, int value)
        {
            
            _bonusLabel.text = $"Bonus \"{name}\": {value}";
        }
    }
}