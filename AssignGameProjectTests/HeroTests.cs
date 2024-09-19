using AssignGameProject;
using Xunit;

namespace AssignGameProjectTests
{
    public class HeroTests
    {
        
        [Fact]
        public void NewHero_NameIsCorrect()
        {
            // Arrange
            var mage = new Mage("player");

            // Act
            var name = mage.Name;

            // Assert
            Assert.Equal("player", name);
        }

        
        [Fact]
        public void NewHero_StartingLevelIsCorrect()
        {
            // Arrange
            var mage = new Mage("player");

            // Act
            var level = mage.Level;

            // Assert
            Assert.Equal(1, level);
        }

       
        [Fact]
        public void NewHero_StartingAttributesAreCorrect()
        {
            // Arrange
            var mage = new Mage("player");

            // Act
            var attributes = mage.BaseAttributes;

            // Assert
            Assert.Equal(1, attributes.Strength);
            Assert.Equal(1, attributes.Dexterity);
            Assert.Equal(8, attributes.Intelligence);
        }

       
        [Fact]
        public void Hero_LevelUp_NewLevelIsCorrect()
        {
            // Arrange
            var expected = 2;
            var mage = new Mage("player");

            // Act
            mage.LevelUp();

            // Assert
            Assert.Equal(2, mage.Level);
        }

       
        [Fact]
        public void Hero_LevelUp_NewAttributesAreCorrect()
        {
            // Arrange
            var mage = new Mage("player");

            // Act
            mage.LevelUp();
            var attributes = mage.BaseAttributes;

            // Assert
            Assert.Equal(2, attributes.Strength);
            Assert.Equal(2, attributes.Dexterity);
            Assert.Equal(13, attributes.Intelligence);
        }

        
        [Fact]
        public void Hero_EquipValidWeapon_SuccessfullyEquipped()
        {
            // Arrange
            var mage = new Mage("player");
            var validWeapon = new Weapon("Basic Wand", 1, WeaponTypes.Wands, 10);

            // Act
            mage.Equip(validWeapon);

            // Assert
            Assert.Equal(validWeapon, mage.Equipment[SlotEnumsTypes.Weapon]);
        }

        
        [Fact]
        public void Hero_EquipInvalidWeapon_LevelTooHigh_ThrowsException()
        {
            // Arrange
            var mage = new Mage("player");
            var invalidWeapon = new Weapon("Epic Wand", 10, WeaponTypes.Wands, 100);

            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => mage.Equip(invalidWeapon));
        }

        
        [Fact]
        public void Hero_EquipInvalidWeapon_WrongType_ThrowsException()
        {
            // Arrange
            var mage = new Mage("player");
            var invalidWeapon = new Weapon("Sword", 1, WeaponTypes.Swords, 10);

            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => mage.Equip(invalidWeapon));
        }

       

       
    }
}
