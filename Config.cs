using Exiled.API.Interfaces;
using System.Collections.Generic;

namespace FriendlyFire___TK_warning
{
    public class Config : IConfig
    {
        // is plugin enabled ↴
        public bool IsEnabled { get; set; } = true;
        // is debug string on or off ↴
        public bool Debug { get; set; } = false;
        // is ff string on or off ↴
        public bool FriendlyFire { get; set; } = true;
        // is TK string on or off ↴ 
        public bool TeamKill { get; set; } = true;
        // is TK & FF string on or off ↴
        public bool ShowMessage { get; set; } = true;
        // string on teamkill (to attacker) ↴
        public string Message { get; set; } = "Teamkilling is not allowed!";
        // string on FriendlyFire (to attacker) ↴
        public string FriendlyFireMessage { get; set; } = "Friendly fire is not allowed!";
        // string on FriendlyFire (to victim) ↴
        public string MessageForVictim { get; set; } = "You have been killed by your teammate! ({Attacker})";
        // string on teamkill (to victim) ↴
        public string FriendlyFireMessageForVictim { get; set; } = "You have been hit by your teammate! ({Attacker})";
    }
}
