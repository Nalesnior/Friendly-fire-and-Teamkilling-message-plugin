using Exiled.API.Features;
using Exiled.Events.EventArgs.Player;
using System;

namespace FriendlyFire___TK_warning
{
    public class Class : Plugin<Config>
    {
        public override string Name => "FriendlyFire & TK warning";
        public override string Author => "Naleśnior";
        public override Version Version => new Version(2, 0, 0);
        public override Version RequiredExiledVersion => new Version(9, 5, 1);
        // if plugin is enabled ↴
        public override void OnEnabled()
        {
            Exiled.Events.Handlers.Player.Hurting += OnHurting;
            Exiled.Events.Handlers.Player.Died += OnDied;
            base.OnEnabled();
        }
        //if plugin is disabled ↴
        public override void OnDisabled()
        {
            Exiled.Events.Handlers.Player.Hurting -= OnHurting;
            Exiled.Events.Handlers.Player.Died -= OnDied;
            base.OnDisabled();
        }
        // on player hurting event ↴
        private void OnHurting(HurtingEventArgs ev)
        {
            if (ev.Player == null || ev.Attacker == null || ev.Player == ev.Attacker)
                return;
            if (ev.Player.Role.Team == ev.Attacker.Role.Team)
            {
                if (Config.FriendlyFire)
                {
                    if (Config.ShowMessage)
                    {
                        ev.Attacker.ShowHint(Config.FriendlyFireMessage);
                        ev.Player.ShowHint(Config.FriendlyFireMessageForVictim);
                    }
                }
            }
        }
        // on player death event ↴
        private void OnDied(DiedEventArgs ev)
        {
            if (ev.Player == null || ev.Attacker == null || ev.Player == ev.Attacker)
                return;
            if (ev.Player.Role.Team == ev.Attacker.Role.Team)
            {
                if (Config.TeamKill)
                {
                    if (Config.ShowMessage)
                    {
                        ev.Attacker.ShowHint(Config.Message);
                        ev.Player.ShowHint(Config.MessageForVictim);
                    }
                }
            }
        }
    }
}
