using System;
using System.Collections.Generic;

namespace Koishi.BanBuff
{
	public static class Utils
	{
		public static List<string> BuffID;

		static Utils()
		{
			BuffID = new List<string>()
			{
				"",
				"Obsidian Skin",
				"Regeneration",
				"Swiftness",
				"Gills",
				"Ironskin",
				"Mana Regeneration",
				"Magic Power",
				"Featherfall",
				"Spelunker",
				"Invisibility",
				"Shine",
				"Night Owl",
				"Battle",
				"Thorns",
				"Water Walking",
				"Archery",
				"Hunter",
				"Gravitation",
				"Shadow Orb",
				"Poisoned",
				"Potion Sickness",
				"Darkness",
				"Cursed",
				"On Fire!",
				"Tipsy",
				"Well Fed",
				"Blue Fairy",
				"Werewolf",
				"Clairvoyance",
				"Bleeding",
				"Confused",
				"Slow",
				"Weak",
				"Merfolk",
				"Silenced",
				"Broken Armor",
				"Horrified",
				"The Tongue",
				"Cursed Inferno",
				"Pet Bunny",
				"Baby Penguin",
				"Pet Turtle",
				"Paladin's Shield",
				"Frostburn",
				"Baby Eater",
				"Chilled",
				"Frozen",
				"Honey",
				"Pygmies",
				"Baby Skeletron Head",
				"Baby Hornet",
				"Tiki Spirit",
				"Pet Lizard",
				"Pet Parrot",
				"Baby Truffle",
				"Pet Sapling",
				"Wisp",
				"Rapid Healing",
				"Shadow Dodge",
				"Leaf Crystal",
				"Baby Dinosaur",
				"Ice Barrier",
				"Panic!",
				"Baby Slime",
				"Eyeball Spring",
				"Baby Snowman",
				"Burning",
				"Suffocation",
				"Ichor",
				"Venom",
				"Weapon Imbue: Venom",
				"Midas",
				"Weapon Imbue: Cursed Flames",
				"Weapon Imbue: Fire",
				"Weapon Imbue: Gold",
				"Weapon Imbue: Ichor",
				"Weapon Imbue: Nanites",
				"Weapon Imbue: Confetti",
				"Weapon Imbue: Poison",
				"Blackout",
				"Pet Spider",
				"Squashling",
				"Ravens",
				"Black Cat",
				"Cursed Sapling",
				"Water Candle",
				"Cozy Fire",
				"Chaos State",
				"Heart Lamp",
				"Rudolph",
				"Puppy",
				"Baby Grinch",
				"Ammo Box",
				"Mana Sickness",
				"Beetle Endurance T1",
				"Beetle Endurance T2",
				"Beetle Endurance T3",
				"Beetle Might T1",
				"Beetle Might T2",
				"Beetle Might T3",
				"Red Fairy",
				"Green Fairy",
				"Wet",
				"Mining",
				"Heartreach",
				"Calm",
				"Builder",
				"Titan",
				"Flipper",
				"Summoning",
				"Dangersense",
				"Ammo Reservation",
				"Lifeforce",
				"Endurance",
				"Rage",
				"Inferno",
				"Wrath",
				"Minecart Left",
				"Lovestruck",
				"Stinky",
				"Fishing",
				"Sonar",
				"Crate",
				"Warmth",
				"Hornet",
				"Imp",
				"Zephyr Fish",
				"Bunny Mount",
				"Pigron Mount",
				"Slime Mount",
				"Turtle Mount",
				"Bee Mount",
				"Spider",
				"Twins",
				"Pirate",
				"Mini Minotaur",
				"Slime",
				"Minecart Right",
				"Sharknado",
				"UFO",
				"UFO Mount",
				"Drill Mount",
				"Scutlix Mount",
				"Electrified",
				"Moon Bite",
				"Happy!",
				"Banner",
				"Feral Bite",
				"Webbed",
				"Bewitched",
				"Life Drain",
				"Magic Lantern",
				"Shadowflame",
				"Baby Face Monster",
				"Crimson Heart",
				"Stoned",
				"Peace Candle",
				"Star in a Bottle",
				"Sharpened",
				"Dazed",
				"Deadly Sphere",
				"Unicorn Mount",
				"Obstructed",
				"Distorted",
				"Dryad's Blessing",
				"Mechanical Minecart Right",
				"Mechanical Minecart Left",
				"Cute Fishron Mount",
				"Penetrated",
				"Solar Blaze T1",
				"Solar Blaze T2",
				"Solar Blaze T3",
				"Life Nebula T1",
				"Life Nebula T2",
				"Life Nebula T3",
				"Mana Nebula T1",
				"Mana Nebula T2",
				"Mana Nebula T3",
				"Damage Nebula T1",
				"Damage Nebula T2",
				"Damage Nebula T3",
				"Stardust Cell",
				"Celled",
				"Wooden Minecart Right",
				"Wooden Minecart Left",
				"Dryad's Bane",
				"Stardust Guardian",
				"Stardust Dragon",
				"Daybroken",
				"Suspicious Looking Eye",
				"Companion Cube",
				"Sugar Rush",
				"Basilisk Mount",
				"Wind Pushed",
				"Withered Armor",
				"Withered Weapon",
				"Oozed",
				"Striking Moment",
				"Creative Shock",
				"Propeller Gato",
				"Flickerwick",
				"Hoardagron",
				"Plenty Satisfied",
				"Exquisitely Stuffed",
				"Desert Minecart Right",
				"Desert Minecart Left",
				"Minecarp Right",
				"Minecarp Left",
				"Golf Cart",
				"Sanguine Bat",
				"Vampire Frog",
				"The Bast Defense",
				"Baby Finch",
				"Estee",
				"Sugar Glider",
				"Shark Pup",
				"Bee Minecart Right",
				"Bee Minecart Left",
				"Ladybug Minecart Right",
				"Ladybug Minecart Left",
				"Pigron Minecart Right",
				"Pigron Minecart Left",
				"Sunflower Minecart Right",
				"Sunflower Minecart Left",
				"Demonic Hellcart Right",
				"Demonic Hellcart Left",
				"Witch's Broom",
				"Shroom Minecart Right",
				"Shroom Minecart Left",
				"Amethyst Minecart Right",
				"Amethyst Minecart Left",
				"Topaz Minecart Right",
				"Topaz Minecart Left",
				"Sapphire Minecart Right",
				"Sapphire Minecart Left",
				"Emerald Minecart Right",
				"Emerald Minecart Left",
				"Ruby Minecart Right",
				"Ruby Minecart Left",
				"Diamond Minecart Right",
				"Diamond Minecart Left",
				"Amber Minecart Right",
				"Amber Minecart Left",
				"Beetle Minecart Right",
				"Beetle Minecart Left",
				"Meowmere Minecart Right",
				"Meowmere Minecart Left",
				"Party Minecart Right",
				"Party Minecart Left",
				"The Dutchman Minecart Right",
				"The Dutchman Minecart Left",
				"Steampunk Minecart Right",
				"Steampunk Minecart Left",
				"Lucky",
				"Lil' Harpy",
				"Fennec Fox",
				"Glittery Butterfly",
				"Baby Imp",
				"Baby Red Panda",
				"Desert Tiger",
				"Plantero",
				"Flamingo",
				"Dynamite Kitten",
				"Baby Werewolf",
				"Shadow Mimic",
				"Coffin Minecart Right",
				"Coffin Minecart Left",
				"Enchanted Daggers",
				"Digging Molecart Left",
				"Digging Molecart Right",
				"Volt Bunny",
				"Painted Horse Mount",
				"Majestic Horse Mount",
				"Dark Horse Mount",
				"Pogo Stick Mount",
				"Pirate Ship Mount",
				"Tree Mount",
				"Santank Mount",
				"Goat Mount",
				"Book Mount",
				"Slime Prince",
				"Suspicious Eye",
				"Eater of Worms",
				"Spider Brain",
				"Skeletron Jr.",
				"Honey Bee",
				"Destroyer-Lite",
				"Rez and Spaz",
				"Mini Prime",
				"Plantera Seedling",
				"Toy Golem",
				"Tiny Fishron",
				"Phantasmal Dragon",
				"Moonling",
				"Fairy Princess",
				"Jack 'O Lantern",
				"Everscream Sapling",
				"Ice Queen",
				"Alien Skater",
				"Baby Ogre",
				"Itsy Betsy",
				"Lava Shark Mount",
				"Titanium Barrier",
				"BlandWhipEnemyDebuff",
				"Durendal's Blessing",
				"SwordWhipNPCDebuff",
				"ScytheWhipEnemyDebuff",
				"Harvest Time",
				"A Nice buff",
				"FlameWhipEnemyDebuff",
				"Jungle's Fury",
				"ThornWhipNPCDebuff",
				"RainbowWhipNPCDebuff",
				"Slime Princess",
				"Winged Slime Mount",
				"MaceWhipNPCDebuff",
				"Sparkle Slime",
				"Cerebral Mindtrick",
				"Terraprisma"

			};
		}

		public static BuffBan GetBuffBanById(int id)
		{
			for (int i = 0; i < Koishi.BanBuff.BanBuffPlugin.BuffManager.BuffBans.Count; i++)
			{
				if (Koishi.BanBuff.BanBuffPlugin.BuffManager.BuffBans[i].ID == id)
				{
					return Koishi.BanBuff.BanBuffPlugin.BuffManager.BuffBans[i];
				}
			}
			return null;
		}

		public static List<int> GetBuffByIdOrName(string text)
		{
			int num = -1;
			if (!int.TryParse(text, out num))
			{
				return Utils.GetBuffByName(text);
			}
			return new List<int>
			{
				num
			};
		}

		public static List<int> GetBuffByName(string name)
		{
			List<int> nums = new List<int>();
			string lower = name.ToLower();

			foreach (string current in Utils.BuffID)
			{
				if (string.IsNullOrEmpty(current))
				{
					continue;
				}

				if (current.ToLower() == lower)
				{
					return new List<int>()
						{
							Utils.BuffID.IndexOf(current)
						};
				}
				else
				{
					if (current.ToLower().StartsWith(lower))
					{
						nums.Add(Utils.BuffID.IndexOf(current));
					}
				}
			}

			return nums;
		}

		public static string Name(int id)
		{
			if (id < 1 || id >= BuffID.Count)
			{
				return string.Format("Unknown Buff ({0})", id);
			}
			return string.Format("{0} ({1})", BuffID[id], id);
		}
	}
}