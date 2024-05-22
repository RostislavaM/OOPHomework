using ArenaGameEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGameWinForms
{
    internal class WinFormsGameEventListener : GameEventListener
    {
        MainForm mainForm;

        public WinFormsGameEventListener(MainForm mainForm)
        {
            this.mainForm = mainForm;
        }

        public override void GameRound(
            Hero attacker, Hero defender, int attack)
        {
            string message = $"{attacker.Name} attacks for {attack}.";
            if (attacker is Knight)
            {
                mainForm.AddItemToListBoxKnight(message);
            }
            else
            {
                mainForm.AddItemToListBoxRogue(message);
            }
        }
    }
}
