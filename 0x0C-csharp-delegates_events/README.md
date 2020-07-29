# 0x0C-csharp-delegates_events

## This is a project from Holberton School

![N|Solid](https://upload.wikimedia.org/wikipedia/commons/thumb/4/4f/Csharp_Logo.png/245px-Csharp_Logo.png)

## Tasks

``Mandatory``
| Task | Description |
| ------ | ------ |
| 0. Universal health  | Create a public class called Player |
| 1. Damage delegation | Based on 0-universal_health, create a delegate CalculateHealth that takes a float amount. Write two methods that follow the prototype of the CalculateHealth delegate |
| 2. Validation | Based on 1-damage_delegation, inside the TakeDamage() and HealDamage() methods, calculate the new value of the Player’s hp but do not set the value of hp in these methods |
| 3. Modified behavior | Based on 2-validation, outside of the Player class, create an enum Modifier with the values Weak, Base, Strong |
| 4. Check yourself | Based on 3-modified_behavior, outside of the Player class, create a new class CurrentHPArgs that inherits from EventArgs |
| 5. Eventful | Based on 4-check_yourself, create a new method HPValueWarning inside the Player class |
