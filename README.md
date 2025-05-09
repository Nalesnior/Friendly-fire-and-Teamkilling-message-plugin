# FF & TK plugin
It's a sample plugin for SCP:SL servers using Exiled.
***
> - **Plugin sends message to victim and attacker about Friendly fire or Teamkilling**.
>   - The attacker receives information that he has injured someone, and the victim also receives information about WHO injured him, but of course **you can freely edit messages** in **yaml configuration**.
`Yaml configuration ↴`
```yaml
friendly_fire_t_kwarning:
  is_enabled: true
  debug: false
  friendly_fire: true
  team_kill: true
  show_message: true
  message: 'Teamkilling is not allowed!'
  friendly_fire_message: 'Friendly fire is not allowed!'
  message_for_victim: 'You have been killed by your teammate! ({Attacker})'
  friendly_fire_message_for_victim: 'You have been hit by your teammate! ({Attacker})'
```
