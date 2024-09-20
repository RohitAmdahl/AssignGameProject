# GameProjectAssign![image](https://github.com/user-attachments/assets/a0982f0a-fcd6-40c3-9ae5-281d952d7b77)
- Various hero classes having attributes which increase at different rates as the character gains levels.
- Equipment, such as armor and weapons, that characters can equip. The equipped items will alter the power of
  the hero, causing it to deal more damage and be able to survive longer. Certain heroes can equip certain item
  types.
-  Custom exceptions. There are two custom exceptions you are required to write, as detailed in Appendix B.
-  Testing of the main functionality.

##Hero classes: the game there are currently four classes that a hero can be:
• Mage
• Ranger
• Rogue
• Warrior
##Each hero has the following shared fields:
-  Name
-  Level - all heroes start at level 1
-  LevelAttribtues - total from all levels
-  Equipment - holds currently equipped items
-  ValidWeaponTypes – a list of weapon types a hero can equip based on their subclass
-  ValidArmorTypes - a list of armor types a hero can equip based on their subclass 

##Heroes have the following public facing methods:
-  Constructor – each hero is created by passing just a name.
-  LevelUp – increases the level of a character by 1 and increases their LevelAttributes
-  Equip – two variants, for equipping armor and weapons
-  Damage – damage is calculated on the fly and not stored
-  TotalAttributes – calculated on the fly and not stored
-  Display – details of Hero to be displayed


## License

[MIT](https://choosealicense.com/licenses/mit/)
