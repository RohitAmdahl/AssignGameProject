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

        // Test 2: Is the new hero’s starting level correct?
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

        // Test 3: Is the new hero’s starting hero attributes correct?
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

        // Test 4: When the hero levels up, is the new level correct?
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

        // Test 5: When the hero levels up, are the new hero attributes correct?
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

        // Test 6: Can the hero equip a valid weapon successfully?
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

        // Test 7: Can the hero equip an invalid weapon - level too high?
        [Fact]
        public void Hero_EquipInvalidWeapon_LevelTooHigh_ThrowsException()
        {
            // Arrange
            var mage = new Mage("player");
            var invalidWeapon = new Weapon("Epic Wand", 10, WeaponTypes.Wands, 100);

            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => mage.Equip(invalidWeapon));
        }

        // Test 8: Can the hero equip an invalid weapon - wrong weapon type?
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
