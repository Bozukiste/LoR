using Microsoft.EntityFrameworkCore.Migrations;

namespace LoRAPI.Migrations
{
    public partial class LorAPIDataCardContextSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "RegionRef",
                table: "Cards",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "Rarity",
                table: "Cards",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "CardId", "Attack", "CardVisualLink", "Collectable", "Cost", "Description", "FlavorText", "FullArtworkLink", "Health", "KeywordsRefs", "Legacy", "Name", "Rarity", "RegionRef", "RiotId", "SpellSpeed", "SubType", "SuperType", "Type" },
                values: new object[,]
                {
                    { 1L, 0, "http://dd.b.pvp.net/Set1/en_us/img/cards/01IO012T2.png", false, 3, "Give an ally +0|+3 this round.", "", "http://dd.b.pvp.net/Set1/en_us/img/cards/01IO012T2-full.png", 0, "Burst", false, "Discipline of Fortitude", 4, 5, "01IO012T2", 1, null, null, null },
                    { 287L, 0, "http://dd.b.pvp.net/Set1/en_us/img/cards/01IO011.png", true, 1, "<link=keyword.Recall><style=Keyword>Recall</style></link> an ally.", "The wise combatant knows not only tenacity, but restraint. A successful retreat guarantees a chance to fight a better fight.", "http://dd.b.pvp.net/Set1/en_us/img/cards/01IO011-full.png", 0, "Fast", false, "Recall", 0, 5, "01IO011", 2, null, null, null },
                    { 286L, 0, "http://dd.b.pvp.net/Set1/en_us/img/cards/01IO015T2.png", false, 3, @"<link=keyword.Stun><sprite name=Stunned><style=Keyword>Stun</style></link> an attacking enemy.
                Shuffle a <link=card.level1><style=AssociatedCard>Yasuo</style></link> into your deck.", "\"Hasagi!\"- Yasuo", "http://dd.b.pvp.net/Set1/en_us/img/cards/01IO015T2-full.png", 0, "Fast", false, "Yasuo's Steel Tempest", 4, 5, "01IO015T2", 2, null, null, null },
                    { 285L, 0, "http://dd.b.pvp.net/Set1/en_us/img/cards/01SI025.png", true, 6, "Kill an ally to deal damage equal to its Power to anything.", "Killing means nothing to those who cannot know death.", "http://dd.b.pvp.net/Set1/en_us/img/cards/01SI025-full.png", 0, "Fast", false, "Atrocity", 1, 4, "01SI025", 2, null, null, null },
                    { 284L, 0, "http://dd.b.pvp.net/Set1/en_us/img/cards/01SI028.png", true, 3, "Summon an exact copy of an ally. It's <link=keyword.Ephemeral><sprite name=Ephemeral><style=Keyword>Ephemeral</style></link> and 1|1.", "\"I lifted the body from the water to identify the poor soul. As I laid my hand upon its shoulder, it turned and showed its face. It was... me?\" - Arie Wrence, Demacian Soldier", "http://dd.b.pvp.net/Set1/en_us/img/cards/01SI028-full.png", 0, "Slow", false, "Splinter Soul", 1, 4, "01SI028", 0, null, null, null },
                    { 283L, 2, "http://dd.b.pvp.net/Set1/en_us/img/cards/01PZ051.png", true, 5, "All of your spells and skills deal 1 extra damage.", "\"You want extra boom, do ya? Well, you've come to the right place!\"", "http://dd.b.pvp.net/Set1/en_us/img/cards/01PZ051-full.png", 3, null, false, "Funsmith", 1, 6, "01PZ051", null, null, null, null },
                    { 282L, 0, "http://dd.b.pvp.net/Set1/en_us/img/cards/01SI033T1.png", false, 0, "Cut the enemy Nexus Health in half.", "Half a blade for half a man. A weapon broken as its wielder's vow, broken as the king it was sworn to protect, broken as the kingdom of shadow that once was blessed.", "http://dd.b.pvp.net/Set1/en_us/img/cards/01SI033T1-full.png", 0, "Skill", false, "Blade of Ledros", 4, 4, "01SI033T1", null, null, null, null },
                    { 281L, 0, "http://dd.b.pvp.net/Set1/en_us/img/cards/01PZ033.png", true, 5, "If you've played <style=Variable>20</style> cards with different names this game, summon <link=card.summon><style=AssociatedCard>Cataclysm</style></link>. <style=Variable></style>", "\"In the end, all of us who worked toward von Yipp's vision were deceived. We knew not what we wrought--what terrible power we would unleash.\" - Piltovan Project Engineer", "http://dd.b.pvp.net/Set1/en_us/img/cards/01PZ033-full.png", 0, "Slow", false, "Purrsuit of Perfection", 2, 6, "01PZ033", 0, null, null, null },
                    { 280L, 0, "http://dd.b.pvp.net/Set1/en_us/img/cards/01FR023.png", true, 12, "Summon the top unit from our deck now and EACH Start of Round.", "There will come a day when an unmistakable call will resound through the Freljord. On that day, all will rise to answer it, for it announces that our ancient enemies have emerged once again.", "http://dd.b.pvp.net/Set1/en_us/img/cards/01FR023-full.png", 0, "Slow", false, "Warmother's Call", 2, 3, "01FR023", 0, null, null, null },
                    { 279L, 2, "http://dd.b.pvp.net/Set1/en_us/img/cards/01DE003.png", true, 4, "<link=vocab.Play><style=Vocab>Play</style></link>: Grant an ally +2|+2.", "\"Yes, they are beautiful. But like any fine instrument, they only reveal their true beauty in the hands of a master.\" ", "http://dd.b.pvp.net/Set1/en_us/img/cards/01DE003-full.png", 3, null, false, "Laurent Bladekeeper", 1, 2, "01DE003", null, null, null, null },
                    { 278L, 3, "http://dd.b.pvp.net/Set1/en_us/img/cards/01IO031.png", true, 6, @"Your <link=keyword.Burst><sprite name=Burst><style=Keyword>Burst</style></link> spells cost 1 less.
                <link=keyword.Enlightened><style=Keyword>Enlightened</style></link>: They cost 2 less instead.", "Its songs could be heard from the villages--long, low waves of sound rippling from sky to hillside, each as formless and strange as the afternoon clouds.", "http://dd.b.pvp.net/Set1/en_us/img/cards/01IO031-full.png", 7, null, false, "Cloud Drinker", 1, 5, "01IO031", null, null, null, null },
                    { 288L, 3, "http://dd.b.pvp.net/Set1/en_us/img/cards/01IO009T1.png", false, 3, "", "A blade of shadow is as sharp as one of steel.", "http://dd.b.pvp.net/Set1/en_us/img/cards/01IO009T1-full.png", 2, "Ephemeral", false, "Living Shadow", 4, 5, "01IO009T1", null, null, null, null },
                    { 277L, 0, "http://dd.b.pvp.net/Set1/en_us/img/cards/01PZ056T1.png", false, 0, "<link=keyword.Fleeting><sprite name=Fleeting><style=Keyword>Fleeting</style></link>.", "\"TODAY I EMBARK UPON A NEW SCIENTIFIC ADVENTURE: AUTOMATONS! As the saying goes, it takes a great mind to create great things! Who said that, you ask? Why, ME!\" - Heimerdinger's Lab Notes, Preface", "http://dd.b.pvp.net/Set1/en_us/img/cards/01PZ056T1-full.png", 1, "Challenger", false, "Mk0: Windup Shredder", 4, 6, "01PZ056T1", null, null, null, null },
                    { 275L, 3, "http://dd.b.pvp.net/Set1/en_us/img/cards/01PZ029.png", true, 4, "<link=keyword.Last Breath><sprite name=LastBreath><style=Keyword>Last Breath</style></link>: Create a random Epic in hand.", "\"I was an angry man, then, and broke my competitors as I accrued money and fame. I now direct my fortune toward altruism, and hope that my penitent winter will absolve me of my misdeeds.\"", "http://dd.b.pvp.net/Set1/en_us/img/cards/01PZ029-full.png", 3, null, false, "Eminent Benefactor", 1, 6, "01PZ029", null, null, null, null },
                    { 274L, 5, "http://dd.b.pvp.net/Set1/en_us/img/cards/01DE015.png", true, 5, "When I'm summoned, grant me <link=keyword.Lifesteal><sprite name=Lifesteal><style=Keyword>Lifesteal</style></link> and <link=keyword.Tough><sprite name=Tough><style=Keyword>Tough</style></link> if an ally died this round.", "\"Waves of cold undead hands pulled down her companions. Only she remained, a gleaming beacon of justice whose blade seemed to sing the names of the fallen with every swing.\" - Demacian Ensign", "http://dd.b.pvp.net/Set1/en_us/img/cards/01DE015-full.png", 5, null, false, "Radiant Guardian", 1, 2, "01DE015", null, null, null, null },
                    { 273L, 0, "http://dd.b.pvp.net/Set1/en_us/img/cards/01SI006.png", true, 5, "Steal an enemy follower this round.", "He woke to find his hands glistening red and the camp unusually quiet. ", "http://dd.b.pvp.net/Set1/en_us/img/cards/01SI006-full.png", 0, "Slow", false, "Possession", 1, 4, "01SI006", 0, null, null, null },
                    { 272L, 4, "http://dd.b.pvp.net/Set1/en_us/img/cards/01IO041.png", true, 5, "End of Round: Create a random spell in hand.", "\"We'll bring peace to Ionia, whatever the cost.\"", "http://dd.b.pvp.net/Set1/en_us/img/cards/01IO041-full.png", 3, null, false, "Karma", 3, 5, "01IO041", null, null, null, null },
                    { 271L, 1, "http://dd.b.pvp.net/Set1/en_us/img/cards/01FR008.png", true, 1, "When I'm summoned, create in hand a random 1 cost Poro from any faction.", "\"A lifetime in the Freljord, and still nothin's more chillin' than the sight of this sad little fellow.\" - Poro Herder", "http://dd.b.pvp.net/Set1/en_us/img/cards/01FR008-full.png", 1, null, false, "Lonely Poro", 0, 3, "01FR008", null, null, null, null },
                    { 270L, 4, "http://dd.b.pvp.net/Set1/en_us/img/cards/01PZ044.png", true, 5, "<link=vocab.Play><style=Vocab>Play</style></link>: Deal 1 to all enemies.", "\"...his solo quickly plunges through a harmonic minor scale before arpeggiating--yes that's a word--into the bridge's transposition. You likely can't even comprehend his work.\" - Max Bliff, Gatekeeper", "http://dd.b.pvp.net/Set1/en_us/img/cards/01PZ044-full.png", 2, null, false, "Chempunk Shredder", 1, 6, "01PZ044", null, null, null, null },
                    { 269L, 0, "http://dd.b.pvp.net/Set1/en_us/img/cards/01SI054.png", true, 5, "<link=keyword.Drain><style=Keyword>Drain</style></link> 3 from an enemy unit.", "The dead want nothing more than to silence the ceaseless pulse of the living.", "http://dd.b.pvp.net/Set1/en_us/img/cards/01SI054-full.png", 0, "Fast", false, "Grasp of the Undying", 0, 4, "01SI054", 2, null, null, null },
                    { 268L, 2, "http://dd.b.pvp.net/Set1/en_us/img/cards/01NX015.png", true, 1, "When I'm summoned, <link=keyword.Stun><sprite name=Stunned><style=Keyword>Stun</style></link> the next enemy unit summoned this round. ", "She loves them all. She just loves this one more.", "http://dd.b.pvp.net/Set1/en_us/img/cards/01NX015-full.png", 1, null, false, "Precious Pet", 0, 1, "01NX015", null, null, null, null },
                    { 267L, 2, "http://dd.b.pvp.net/Set1/en_us/img/cards/01IO032.png", true, 4, "<link=vocab.Support><style=Vocab>Support</style></link>: Give my supported ally <link=keyword.Barrier><sprite name=Barrier><style=Keyword>Barrier</style></link>.", "\"Like hands clasped, the mortal and spirit realms intertwine. Their actions exist in harmony, and under my watch, neither shall overtake the other.\"", "http://dd.b.pvp.net/Set1/en_us/img/cards/01IO032-full.png", 6, null, false, "Shen", 3, 5, "01IO032", null, null, null, null },
                    { 266L, 0, "http://dd.b.pvp.net/Set1/en_us/img/cards/01SI022.png", true, 1, "Grant an ally +3|+3 and <link=keyword.Ephemeral><sprite name=Ephemeral><style=Keyword>Ephemeral</style></link>.", "Power, but at what cost?", "http://dd.b.pvp.net/Set1/en_us/img/cards/01SI022-full.png", 0, "Burst", false, "Mark of the Isles", 0, 4, "01SI022", 1, null, null, null },
                    { 276L, 0, "http://dd.b.pvp.net/Set1/en_us/img/cards/01NX050.png", true, 2, "Deal 1 to ALL battling units.", "\"Dance with me!\" - Katarina", "http://dd.b.pvp.net/Set1/en_us/img/cards/01NX050-full.png", 0, "Fast", false, "Death Lotus", 1, 1, "01NX050", 2, null, null, null },
                    { 265L, 0, "http://dd.b.pvp.net/Set1/en_us/img/cards/01SI007.png", true, 2, "Summon 3 <link=card.summon><style=AssociatedCard>Unleashed Spirit</style></link>.", "These ancient artifacts are treasured both by the living hungry to claim them, and the dead desperate to retain them.", "http://dd.b.pvp.net/Set1/en_us/img/cards/01SI007-full.png", 0, "Slow", false, "Haunted Relic", 0, 4, "01SI007", 0, null, null, null },
                    { 289L, 0, "http://dd.b.pvp.net/Set1/en_us/img/cards/01IO002.png", true, 4, "<link=keyword.Recall><style=Keyword>Recall</style></link> a unit.", "When invaders first set foot on Ionian soil, they found that conquering the land's inhabitants alone would not be enough.", "http://dd.b.pvp.net/Set1/en_us/img/cards/01IO002-full.png", 0, "Fast", false, "Will of Ionia", 0, 5, "01IO002", 2, null, null, null },
                    { 291L, 2, "http://dd.b.pvp.net/Set1/en_us/img/cards/01FR047.png", true, 2, "<link=keyword.Enlightened><style=Keyword>Enlightened</style></link>: I have +4|+4.", "“Those who learn to roar as beasts soon forget their native tongue.” - Anivia", "http://dd.b.pvp.net/Set1/en_us/img/cards/01FR047-full.png", 2, "Overwhelm", false, "Feral Mystic", 0, 3, "01FR047", null, null, null, null },
                    { 313L, 5, "http://dd.b.pvp.net/Set1/en_us/img/cards/01FR021.png", true, 5, "<style=VocabNoTooltip>Attack</style>: Deal 1 to ALL battling units.", "\"Tarkaz fought harder and better than most. He took his defeat gracefully, I thought. Well, mostly...\" - Tryndamere", "http://dd.b.pvp.net/Set1/en_us/img/cards/01FR021-full.png", 8, null, false, "Tarkaz the Tribeless", 2, 3, "01FR021", null, null, null, null },
                    { 312L, 0, "http://dd.b.pvp.net/Set1/en_us/img/cards/01FR038T1.png", false, 3, @"<link=keyword.Frostbite><sprite name=Frostbite><style=Keyword>Frostbite</style></link> an enemy.
                Shuffle an <link=card.level1><style=AssociatedCard>Ashe</style></link> into your deck.", "The cold strikes without warning, rendering even the strongest warrior helpless.", "http://dd.b.pvp.net/Set1/en_us/img/cards/01FR038T1-full.png", 0, "Burst", false, "Ashe's Flash Freeze", 4, 3, "01FR038T1", 1, null, null, null },
                    { 311L, 1, "http://dd.b.pvp.net/Set1/en_us/img/cards/01IO042.png", true, 1, "When you summon an ally, give me +1|+1 this round.", "\"What's the point of fighting if there's no one to see your moves?\"", "http://dd.b.pvp.net/Set1/en_us/img/cards/01IO042-full.png", 1, null, false, "Sparring Student", 0, 5, "01IO042", null, null, null, null },
                    { 310L, 4, "http://dd.b.pvp.net/Set1/en_us/img/cards/01SI016.png", true, 4, "<link=vocab.Allegiance><style=Vocab>Allegiance</style></link>: Summon a <link=card.create><style=AssociatedCard>Mistwraith</style></link>.", "She appears without a sound. The terrors that follow her are far less subtle.", "http://dd.b.pvp.net/Set1/en_us/img/cards/01SI016-full.png", 2, null, false, "Wraithcaller", 1, 4, "01SI016", null, null, null, null },
                    { 309L, 4, "http://dd.b.pvp.net/Set1/en_us/img/cards/01PZ024.png", true, 5, "When I'm summoned, grant me +4|+0 and <link=keyword.Quick Strike><sprite name=QuickStrike><style=Keyword>Quick Attack</style></link> if you've cast a 6+ cost spell this game.", "Name: Klas Henwick, Age: 51, License Type: Class 2 Conditional, Status: Revoked, Comments: Ignored repeated warnings to reduce output following lab explosion (Case 13X764NM). DO NOT PERMIT ENTRY.", "http://dd.b.pvp.net/Set1/en_us/img/cards/01PZ024-full.png", 4, null, false, "Unstable Voltician", 1, 6, "01PZ024", null, null, null, null },
                    { 308L, 0, "http://dd.b.pvp.net/Set1/en_us/img/cards/01FR057.png", true, 7, "Give an ally and all other allies of its group +3|+3 and <link=keyword.Overwhelm><sprite name=Overwhelm><style=Keyword>Overwhelm</style></link> this round.", "A lone howl echoed through the night, followed by another, then another. Within moments, the pack howled as one--a chorus of frenzied voices calling out for blood.", "http://dd.b.pvp.net/Set1/en_us/img/cards/01FR057-full.png", 0, "Slow", false, "Pack Mentality", 1, 3, "01FR057", 0, null, null, null },
                    { 307L, 0, "http://dd.b.pvp.net/Set1/en_us/img/cards/01SI050.png", true, 5, "Summon 3 <link=card.summon><style=AssociatedCard>Spiderling</style></link>, then grant Spider allies +1|+0. ", "They're hungriest when they hatch.", "http://dd.b.pvp.net/Set1/en_us/img/cards/01SI050-full.png", 0, "Slow", false, "Brood Awakening", 1, 4, "01SI050", 0, null, null, null },
                    { 306L, 4, "http://dd.b.pvp.net/Set1/en_us/img/cards/01FR027.png", true, 4, "", "Avarosan folk tales speak of \"Old Uncle Elnuk\", a stubborn old grouch who wanted nothing more than a warm patch of grass and an argument to dig his heel into. ", "http://dd.b.pvp.net/Set1/en_us/img/cards/01FR027-full.png", 5, null, false, "Bull Elnuk", 0, 3, "01FR027", null, null, null, null },
                    { 305L, 8, "http://dd.b.pvp.net/Set1/en_us/img/cards/01FR039.png", true, 8, "", "\"Do not die for your cause. Live for it.\"", "http://dd.b.pvp.net/Set1/en_us/img/cards/01FR039-full.png", 4, "Overwhelm", false, "Tryndamere", 3, 3, "01FR039", null, null, null, null },
                    { 304L, 1, "http://dd.b.pvp.net/Set1/en_us/img/cards/01PZ056T4.png", false, 1, "<link=keyword.Fleeting><sprite name=Fleeting><style=Keyword>Fleeting</style></link>.", "\"It occurred to me earlier that--with only two hands--I can only maximally operate two wrenches! My solution: MORE HANDS. Oho! I jest. A WRENCHBOT!\" - Heimerdinger's Lab Notes, Vol. 1", "http://dd.b.pvp.net/Set1/en_us/img/cards/01PZ056T4-full.png", 1, null, false, "Mk1: Wrenchbot", 4, 6, "01PZ056T4", null, null, null, null },
                    { 290L, 0, "http://dd.b.pvp.net/Set1/en_us/img/cards/01IO007T1.png", false, 0, "If you have an attacking <link=keyword.Ephemeral><sprite name=Ephemeral><style=Keyword>Ephemeral</style></link> ally, kill <link=card.Kalgren><style=AssociatedCard>Ren Shadowblade</style></link>'s blocker.", "\"As darkness falls, shadows lengthen and lives are cut short...\"", "http://dd.b.pvp.net/Set1/en_us/img/cards/01IO007T1-full.png", 0, "Skill", false, "Fatal Strike", 4, 5, "01IO007T1", null, null, null, null },
                    { 303L, 2, "http://dd.b.pvp.net/Set1/en_us/img/cards/01PZ023.png", true, 4, "When you summon a 1 cost ally, grant it +2|+2.", "\"Today I present to the committee my newest invention, as demonstrated by my esteemed colleague...\"", "http://dd.b.pvp.net/Set1/en_us/img/cards/01PZ023-full.png", 3, null, false, "Professor von Yipp", 1, 6, "01PZ023", null, null, null, null },
                    { 301L, 0, "http://dd.b.pvp.net/Set1/en_us/img/cards/01DE032.png", true, 3, "Give an ally <link=keyword.Barrier><sprite name=Barrier><style=Keyword>Barrier</style></link> this round.", "\"The world can turn its back on you when you're different. People say your differences make you weak--but they make us strong, compassionate. Even in the darkest times, I'll protect you!\" - Lux", "http://dd.b.pvp.net/Set1/en_us/img/cards/01DE032-full.png", 0, "Burst", false, "Prismatic Barrier", 0, 2, "01DE032", 1, null, null, null },
                    { 300L, 4, "http://dd.b.pvp.net/Set1/en_us/img/cards/01NX033.png", true, 4, "<link=vocab.Play><style=Vocab>Play</style></link>: Draw 1 for each 5+ Power ally you have.", "\"It takes a ruthlessly discerning eye to select those worthy enough to become part of the Trifarian Legion, but she can sort the sheep from the wolves a mile away.\" - Legion General", "http://dd.b.pvp.net/Set1/en_us/img/cards/01NX033-full.png", 3, null, false, "Trifarian Assessor", 1, 1, "01NX033", null, null, null, null },
                    { 299L, 30, "http://dd.b.pvp.net/Set1/en_us/img/cards/01PZ033T1.png", false, 1, "", "Your end is MEOW.", "http://dd.b.pvp.net/Set1/en_us/img/cards/01PZ033T1-full.png", 30, "Overwhelm", false, "Cataclysm", 4, 6, "01PZ033T1", null, null, null, null },
                    { 298L, 0, "http://dd.b.pvp.net/Set1/en_us/img/cards/01SI046.png", true, 3, "Revive a random ally that died this round.", "\"The Mist severs spirit from flesh, leaving behind a foul parody of life. I have seen it corrupt my lands, so I go now to those cursed isles, to end this.\" - Arie Wrence, Dauntless Vindicator", "http://dd.b.pvp.net/Set1/en_us/img/cards/01SI046-full.png", 0, "Fast", false, "Mist's Call", 0, 4, "01SI046", 2, null, null, null },
                    { 297L, 0, "http://dd.b.pvp.net/Set1/en_us/img/cards/01PZ044T2.png", false, 0, "Deal 1 to all enemies.", "\"Let the show begin!\" - Chempunk Shredder", "http://dd.b.pvp.net/Set1/en_us/img/cards/01PZ044T2-full.png", 0, "Skill", false, "Face-Melter", 4, 6, "01PZ044T2", null, null, null, null },
                    { 296L, 0, "http://dd.b.pvp.net/Set1/en_us/img/cards/01PZ022.png", false, 0, "Deal 1 to your Nexus.", @"""Pop goes the puffcap, pop goes the puffcap,
                Ow ow ow, ow ow ow!
                Pop goes the puffcap, pop goes the puffcap,
                Down we go, down we go!"" - Zaunite nursery rhyme", "http://dd.b.pvp.net/Set1/en_us/img/cards/01PZ022-full.png", 0, "AutoPlay", false, "Poison Puffcap", 4, 6, "01PZ022", null, null, null, null },
                    { 295L, 0, "http://dd.b.pvp.net/Set1/en_us/img/cards/01NX056.png", true, 5, "Deal 2 to an enemy unit, then ready your attack.", "By the time you've seen the blade, it's far too late.", "http://dd.b.pvp.net/Set1/en_us/img/cards/01NX056-full.png", 0, "Slow", false, "Shunpo", 0, 1, "01NX056", 0, null, null, null },
                    { 294L, 5, "http://dd.b.pvp.net/Set1/en_us/img/cards/01FR056.png", true, 7, "When I'm summoned, <link=keyword.Frostbite><sprite name=Frostbite><style=Keyword>Frostbite</style></link> enemies with 3 or less Health.", "\"AaaaaaaAAaaaAaaaaah!\" - Bjerg the Wanderer", "http://dd.b.pvp.net/Set1/en_us/img/cards/01FR056-full.png", 5, null, false, "Icy Yeti", 1, 3, "01FR056", null, null, null, null },
                    { 293L, 1, "http://dd.b.pvp.net/Set1/en_us/img/cards/01IO017.png", true, 1, "When I'm summoned, give me +2|+0 and <link=keyword.Elusive><sprite name=Elusive><style=Keyword>Elusive</style></link> this round.", "\"I'll get the drop on him, no problem. Get me outta there and I'll split the loot with you, make it more than worth your while!\"", "http://dd.b.pvp.net/Set1/en_us/img/cards/01IO017-full.png", 1, null, false, "Navori Bladescout", 0, 5, "01IO017", null, null, null, null },
                    { 292L, 0, "http://dd.b.pvp.net/Set1/en_us/img/cards/01IO033T1.png", false, 0, "<link=keyword.Recall><style=Keyword>Recall</style></link> 3 enemies.", "\"We go FLYING and next thing I know I'm flat on my back!\" - Navori Brigand", "http://dd.b.pvp.net/Set1/en_us/img/cards/01IO033T1-full.png", 0, "Skill", false, "Skyward Strikes", 4, 5, "01IO033T1", null, null, null, null },
                    { 302L, 6, "http://dd.b.pvp.net/Set1/en_us/img/cards/01NX006T1.png", false, 5, "<style=VocabNoTooltip>Attack</style>: For each other attacking ally, deal 1 to it and 1 to the enemy Nexus.", @"Vicious. Cold. Cruel. Intriguing. Perceptive. Charming.
                Irresistible...", "http://dd.b.pvp.net/Set1/en_us/img/cards/01NX006T1-full.png", 6, "Regeneration", false, "Vladimir", 4, 1, "01NX006T1", null, null, null, null },
                    { 264L, 3, "http://dd.b.pvp.net/Set1/en_us/img/cards/01IO027.png", true, 2, "<link=vocab.Nexus Strike><style=Vocab>Nexus Strike</style></link>: Create a copy of me in hand.", "\"Flesh is untrustworthy. Fragile. Delicate as the borders between light and shadow.\"", "http://dd.b.pvp.net/Set1/en_us/img/cards/01IO027-full.png", 1, "Elusive;Ephemeral", false, "Silent Shadowseer", 2, 5, "01IO027", null, null, null, null },
                    { 263L, 0, "http://dd.b.pvp.net/Set1/en_us/img/cards/01NX027.png", true, 1, "Give an ally +3|+0 this round.", "\"When the open hand is declined, there's always the fist.\" - Noxian Axiom", "http://dd.b.pvp.net/Set1/en_us/img/cards/01NX027-full.png", 0, "Burst", false, "Elixir of Wrath", 0, 1, "01NX027", 1, null, null, null },
                    { 262L, 2, "http://dd.b.pvp.net/Set1/en_us/img/cards/01SI014.png", true, 2, "When I'm summoned, grant other allied Mistwraiths EVERYWHERE +1|+0.", "These specters of the Isles shed their identities long ago to become amalgamations of pure, unappeasable hunger.", "http://dd.b.pvp.net/Set1/en_us/img/cards/01SI014-full.png", 2, "Fearsome", false, "Mistwraith", 0, 4, "01SI014", null, null, null, null },
                    { 234L, 4, "http://dd.b.pvp.net/Set1/en_us/img/cards/01IO015.png", true, 4, "When you <link=keyword.Stun><sprite name=Stunned><style=Keyword>Stun</style></link> or <link=keyword.Recall><style=Keyword>Recall</style></link> an enemy, I deal 2 to it.", "\"Death is like the wind... always by my side.\"", "http://dd.b.pvp.net/Set1/en_us/img/cards/01IO015-full.png", 3, null, false, "Yasuo", 3, 5, "01IO015", null, null, null, null },
                    { 233L, 0, "http://dd.b.pvp.net/Set1/en_us/img/cards/01PZ060.png", false, 5, "This game, if you've resolved <style=Variable>15</style> cards with different names, create <link=card.cat><style=AssociatedCard>Cataclysm</style></link>. <style=Variable></style>", "", "http://dd.b.pvp.net/Set1/en_us/img/cards/01PZ060-full.png", 0, "Slow", false, "Accelerated Purrsuit", 2, 6, "01PZ060", 0, null, null, null },
                    { 232L, 6, "http://dd.b.pvp.net/Set1/en_us/img/cards/01FR038T2.png", false, 4, @"<style=VocabNoTooltip>Attack</style>: <link=keyword.Frostbite><sprite name=Frostbite><style=Keyword>Frostbite</style></link> the <link=vocab.Strongest><style=Vocab>Strongest</style></link> enemy.
                Enemies with 0 Power can't block.", "\"You are not our enemy. Our true foe is the long, lawless winter. We are all people of the Freljord, and this land belongs to all of us!\" ", "http://dd.b.pvp.net/Set1/en_us/img/cards/01FR038T2-full.png", 4, null, false, "Ashe", 4, 3, "01FR038T2", null, null, null, null },
                    { 231L, 9, "http://dd.b.pvp.net/Set1/en_us/img/cards/01FR039T2.png", false, 8, "", "\"Do not die for your cause. Live for it.\"", "http://dd.b.pvp.net/Set1/en_us/img/cards/01FR039T2-full.png", 9, "Overwhelm;Fearsome;Tough", false, "Tryndamere", 4, 3, "01FR039T2", null, null, null, null },
                    { 230L, 6, "http://dd.b.pvp.net/Set1/en_us/img/cards/01NX041.png", true, 5, "", "\"I don't have the patience for a siege. Send the Shieldbreakers.\" - Darius", "http://dd.b.pvp.net/Set1/en_us/img/cards/01NX041-full.png", 5, "Fearsome", false, "Trifarian Shieldbreaker", 0, 1, "01NX041", null, null, null, null },
                    { 229L, 5, "http://dd.b.pvp.net/Set1/en_us/img/cards/01PZ014T1.png", false, 6, "", "\"Absolutely NOT regulation hardware.\" - Safety Inspections Officer, Piltovan Bureau of Safety Inspections", "http://dd.b.pvp.net/Set1/en_us/img/cards/01PZ014T1-full.png", 5, null, false, "Illegal Contraption", 4, 6, "01PZ014T1", null, null, null, null },
                    { 228L, 2, "http://dd.b.pvp.net/Set1/en_us/img/cards/01FR050.png", true, 3, "<link=vocab.Play><style=Vocab>Play</style></link>: Heal anything 3.", "\"This fine old establishment's the Tipsy Owl! We've got stews and brews a'plenty to chase away the chill. Hurry on inside!\"", "http://dd.b.pvp.net/Set1/en_us/img/cards/01FR050-full.png", 3, null, false, "Kindly Tavernkeeper", 0, 3, "01FR050", null, null, null, null },
                    { 227L, 0, "http://dd.b.pvp.net/Set1/en_us/img/cards/01FR004.png", true, 1, "Give an ally +0|+2 this round.", "\"Rough out there, eh? Not to worry, the 'Owl serves up a special brew so strong it'll pull the chill outta y'bones 'n grow hair on the chest of a newborn!\" - Kindly Tavernkeeper", "http://dd.b.pvp.net/Set1/en_us/img/cards/01FR004-full.png", 0, "Burst", false, "Elixir of Iron", 0, 3, "01FR004", 1, null, null, null },
                    { 226L, 4, "http://dd.b.pvp.net/Set1/en_us/img/cards/01PZ034.png", true, 4, "<link=vocab.Allegiance><style=Vocab>Allegiance</style></link>: Create a <link=card.create><style=AssociatedCard>Sumpworks Map</style></link> in hand. It costs 0 this round.", @"The Zaunite kids soon started exploring the old mining tunnels and deeper levels of the Lanes. What a world they discovered. What friends they found.
                ", "http://dd.b.pvp.net/Set1/en_us/img/cards/01PZ034-full.png", 2, null, false, "Sumpsnipe Scavenger", 1, 6, "01PZ034", null, null, null, null },
                    { 225L, 3, "http://dd.b.pvp.net/Set1/en_us/img/cards/01FR011.png", true, 2, "<link=vocab.Play><style=Vocab>Play</style></link>: <link=keyword.Frostbite><sprite name=Frostbite><style=Keyword>Frostbite</style></link> an enemy.", "Avarosans take pride in their harsh seasons and icy lands. Their keen-eyed defenders even take it a step further. ", "http://dd.b.pvp.net/Set1/en_us/img/cards/01FR011-full.png", 1, null, false, "Icevale Archer", 0, 3, "01FR011", null, null, null, null },
                    { 235L, 0, "http://dd.b.pvp.net/Set1/en_us/img/cards/01IO001.png", true, 7, "Heal anything 7. Draw 1.", "\"Only when the mind is elevated can the body be made whole.\" - Karma", "http://dd.b.pvp.net/Set1/en_us/img/cards/01IO001-full.png", 0, "Slow", false, "Ritual of Renewal", 1, 5, "01IO001", 0, null, null, null },
                    { 224L, 0, "http://dd.b.pvp.net/Set1/en_us/img/cards/01NX039.png", true, 3, "When cast or discarded, grant allies +1|+0.", "\"Those who cannot see the future have no place in it.\" - Jericho Swain.", "http://dd.b.pvp.net/Set1/en_us/img/cards/01NX039-full.png", 0, "Burst", false, "Vision", 1, 1, "01NX039", 1, null, null, null },
                    { 222L, 0, "http://dd.b.pvp.net/Set1/en_us/img/cards/01DE042T3.png", false, 6, "Deal 6 to an enemy unit. <link=keyword.Fleeting><sprite name=Fleeting><style=Keyword>Fleeting</style></link>.", "\"I've hidden my light for my whole life. What would happen if they knew... if *I* knew what I could really do?\" - Lux", "http://dd.b.pvp.net/Set1/en_us/img/cards/01DE042T3-full.png", 0, "Fast;SpellOverwhelm;Fleeting", false, "Final Spark", 4, 2, "01DE042T3", 2, null, null, null },
                    { 221L, 0, "http://dd.b.pvp.net/Set1/en_us/img/cards/01SI019.png", true, 4, "Enemies have -1|-0 this round. When the enemy summons a unit this round, deal 4 to it.", "\"Nobody escapes.\" - Thresh", "http://dd.b.pvp.net/Set1/en_us/img/cards/01SI019-full.png", 0, "Burst", false, "The Box", 1, 4, "01SI019", 1, null, null, null },
                    { 220L, 0, "http://dd.b.pvp.net/Set1/en_us/img/cards/01FR033.png", true, 2, "Start of Round: Get an extra mana gem this round.", "\"These ancient cairns are reminders that we are but the latest in a long line of tribes to brave these untamed lands.\" - Ashe", "http://dd.b.pvp.net/Set1/en_us/img/cards/01FR033-full.png", 3, null, false, "Wyrding Stones", 0, 3, "01FR033", null, null, null, null },
                    { 219L, 1, "http://dd.b.pvp.net/Set1/en_us/img/cards/01FR049T1.png", false, 1, "", "\"Wolf or hare, winter makes prey of us all.\"  - Avarosan proverb", "http://dd.b.pvp.net/Set1/en_us/img/cards/01FR049T1-full.png", 1, null, false, "Snow Hare", 4, 3, "01FR049T1", null, null, null, null },
                    { 218L, 4, "http://dd.b.pvp.net/Set1/en_us/img/cards/01FR043.png", true, 5, "<link=vocab.Play><style=Vocab>Play</style></link> Combine all of our Poros into a <link=card.transform><style=AssociatedCard>Fluft of Poros</style></link>, it gains their stats and keywords.", @"""One more story, but keep quiet or mother will come!
                Long ago, raiders attacked Avarosa's village. Her forces were few--all seemed lost. But a poro appeared and offered Avarosa its help...""", "http://dd.b.pvp.net/Set1/en_us/img/cards/01FR043-full.png", 4, null, false, "Heart of the Fluft", 1, 3, "01FR043", null, null, null, null },
                    { 217L, 0, "http://dd.b.pvp.net/Set1/en_us/img/cards/01FR021T1.png", false, 0, "Deal 1 to ALL battling units.", "\"... Maybe not that gracefully after all.\" - Tryndamere", "http://dd.b.pvp.net/Set1/en_us/img/cards/01FR021T1-full.png", 0, "Skill", false, "Tarkaz's Fury", 4, 3, "01FR021T1", null, null, null, null },
                    { 216L, 0, "http://dd.b.pvp.net/Set1/en_us/img/cards/01DE050.png", true, 2, "Remove all text and keywords from a follower.", "\"Your petricite Graymark is your primary safeguard against magic, a symbol of our responsibilities, and a reminder to others of our authority. Honor it above all else.\" - The Mageseekers' Handbook", "http://dd.b.pvp.net/Set1/en_us/img/cards/01DE050-full.png", 0, "Burst", false, "Purify", 0, 2, "01DE050", 1, null, null, null },
                    { 215L, 4, "http://dd.b.pvp.net/Set1/en_us/img/cards/01FR054.png", true, 5, "", "\"The weak harvest, but the strong take. The little Avarosans will learn which they are!\"", "http://dd.b.pvp.net/Set1/en_us/img/cards/01FR054-full.png", 6, "Overwhelm;Regeneration", false, "Scarmaiden Reaver", 1, 3, "01FR054", null, null, null, null },
                    { 214L, 0, "http://dd.b.pvp.net/Set1/en_us/img/cards/01NX011.png", true, 3, "A battling ally strikes a battling enemy.", "\"I have the best job.\" - Draven", "http://dd.b.pvp.net/Set1/en_us/img/cards/01NX011-full.png", 0, "Fast", false, "Whirling Death", 0, 1, "01NX011", 2, null, null, null },
                    { 213L, 2, "http://dd.b.pvp.net/Set1/en_us/img/cards/01NX003.png", true, 3, "Start of Round: Discard your lowest cost card to draw 1.", "\"...you bet on Shiraza as SOLE SURVIVOR, and that Ionian kid--sure he's missing an arm--but he ain't dead. Makes him a survivor, see? 'Course, you could always double down...\"", "http://dd.b.pvp.net/Set1/en_us/img/cards/01NX003-full.png", 1, null, false, "Arena Bookie", 1, 1, "01NX003", null, null, null, null },
                    { 223L, 6, "http://dd.b.pvp.net/Set1/en_us/img/cards/01IO033.png", true, 9, "<link=vocab.Play><style=Vocab>Play</style></link>: <link=keyword.Recall><style=Keyword>Recall</style></link> 3 enemies.", "\"There we were, tearing across the meadow and suddenly, this KID just leaps out from nowhere and BAM, BAM, BAM--knocks the wind right outta us!\" - Navori Brigand", "http://dd.b.pvp.net/Set1/en_us/img/cards/01IO033-full.png", 5, null, false, "Minah Swiftfoot", 2, 5, "01IO033", null, null, null, null },
                    { 236L, 3, "http://dd.b.pvp.net/Set1/en_us/img/cards/01DE016.png", false, 3, "", "The Dauntless Vanguard are Demacia's most elite warriors, each a legend in their village or shire. But all of them seek to have their names known throughout the realm.", "http://dd.b.pvp.net/Set1/en_us/img/cards/01DE016-full.png", 3, null, false, "Dauntless Vanguard", 4, 2, "01DE016", null, null, null, null },
                    { 237L, 0, "http://dd.b.pvp.net/Set1/en_us/img/cards/01IO010.png", true, 6, "Swap two allies. Give them <link=keyword.Barrier><sprite name=Barrier><style=Keyword>Barrier</style></link>.", @"""With balanced steps, I go."" - Shen
                ", "http://dd.b.pvp.net/Set1/en_us/img/cards/01IO010-full.png", 0, "Burst", false, "Stand United", 1, 5, "01IO010", 1, null, null, null },
                    { 238L, 0, "http://dd.b.pvp.net/Set1/en_us/img/cards/01IO012.png", true, 3, "Give an ally +3|+0 or +0|+3 this round.", "\"Never fear change. It will question you, test your limits. It is our greatest teacher.\" - Karma", "http://dd.b.pvp.net/Set1/en_us/img/cards/01IO012-full.png", 0, "Burst", false, "Twin Disciplines", 0, 5, "01IO012", 1, null, null, null },
                    { 261L, 0, "http://dd.b.pvp.net/Set1/en_us/img/cards/01FR009T2.png", false, 3, @"Grant a damaged ally +3|+3.
                Shuffle a <link=card.level1><style=AssociatedCard>Braum</style></link> into your deck.", "\"... Though his wounds were great, Braum threw back his head and laughed. For he knew that dire times are when heroes are made!\" -  The Tale of Braum", "http://dd.b.pvp.net/Set1/en_us/img/cards/01FR009T2-full.png", 0, "Burst", false, "Braum's Take Heart", 4, 3, "01FR009T2", 1, null, null, null },
                    { 260L, 3, "http://dd.b.pvp.net/Set1/en_us/img/cards/01NX016.png", true, 2, "When I'm summoned, grant me +2|+0 if you have another Noxus ally.", "\"You'll earn the title when your axe is blunt with battle and your boots're sopped with blood.\" - Legion Veteran", "http://dd.b.pvp.net/Set1/en_us/img/cards/01NX016-full.png", 2, null, false, "Trifarian Hopeful", 0, 1, "01NX016", null, null, null, null },
                    { 259L, 0, "http://dd.b.pvp.net/Set1/en_us/img/cards/01NX042T1.png", false, 2, @"Deal 1 to ALL battling units.
                Shuffle a <link=card.level1><style=AssociatedCard>Katarina</style></link> into your deck.", "\"Dance with me!\" - Katarina", "http://dd.b.pvp.net/Set1/en_us/img/cards/01NX042T1-full.png", 0, "Fast", false, "Katarina's Death Lotus", 4, 1, "01NX042T1", 2, null, null, null },
                    { 258L, 3, "http://dd.b.pvp.net/Set1/en_us/img/cards/01IO009.png", true, 3, "<style=VocabNoTooltip>Attack</style>: Create an attacking <link=card.summon><style=AssociatedCard>Living Shadow</style></link> with my stats.", "\"Balance is a fool's master. The shadows have shown me true power.\"", "http://dd.b.pvp.net/Set1/en_us/img/cards/01IO009-full.png", 2, null, false, "Zed", 3, 5, "01IO009", null, null, null, null },
                    { 257L, 0, "http://dd.b.pvp.net/Set1/en_us/img/cards/01DE013.png", true, 1, "Grant an ally <link=keyword.Tough><sprite name=Tough><style=Keyword>Tough</style></link>.", "Demacian steel is known throughout the world for its superior strength. Its forging requires smiths of equal strength and repute.", "http://dd.b.pvp.net/Set1/en_us/img/cards/01DE013-full.png", 0, "Burst", false, "Chain Vest", 0, 2, "01DE013", 1, null, null, null },
                    { 256L, 0, "http://dd.b.pvp.net/Set1/en_us/img/cards/01DE014.png", true, 8, "Summon 2 <link=card.summon><style=AssociatedCard>Dauntless Vanguard</style></link>, then grant Elite allies +1|+1.", @"""Our rivals know that to strike at any of us is to strike at all of us."" - The Vanguard's Code
                ", "http://dd.b.pvp.net/Set1/en_us/img/cards/01DE014-full.png", 0, "Slow", false, "Reinforcements", 1, 2, "01DE014", 0, null, null, null },
                    { 255L, 0, "http://dd.b.pvp.net/Set1/en_us/img/cards/01FR005.png", true, 8, "Grant an ally +8|+4.", "“I've been told I have a... temper.” - Tryndamere", "http://dd.b.pvp.net/Set1/en_us/img/cards/01FR005-full.png", 0, "Burst", false, "Battle Fury", 1, 3, "01FR005", 1, null, null, null },
                    { 254L, 5, "http://dd.b.pvp.net/Set1/en_us/img/cards/01PZ040T1.png", false, 4, @"Start of Round: Draw 1.
                The first time you empty your hand each round, create a <link=keyword.Fleeting><sprite name=Fleeting><style=Keyword>Fleeting</style></link> <link=card.create><style=AssociatedCard>Super Mega Death Rocket!</style></link> in hand.", "\"It's all just fun and games until something gets blown up - then it's a PARTY!\"", "http://dd.b.pvp.net/Set1/en_us/img/cards/01PZ040T1-full.png", 4, null, false, "Jinx", 4, 6, "01PZ040T1", null, null, null, null },
                    { 253L, 2, "http://dd.b.pvp.net/Set1/en_us/img/cards/01NX005.png", true, 2, "<link=vocab.Play><style=Vocab>Play</style></link>: Deal 1 to an ally and grant it +2|+0.", "\"Ah, you too? To the Reveler's B--\" \"How am I to tolerate mine?\" \"Respectfully, my dear, my father would disown me. ...perhaps we should wear matching dresses.\"", "http://dd.b.pvp.net/Set1/en_us/img/cards/01NX005-full.png", 2, null, false, "Crimson Aristocrat", 0, 1, "01NX005", null, null, null, null },
                    { 252L, 0, "http://dd.b.pvp.net/Set1/en_us/img/cards/01FR016.png", true, 4, "Grant Poro allies EVERYWHERE +1|+1.", "\"They gobble 'em up, then look at you, tongues out, happy as sheared 'nuks in the thaw askin' for more! You try sayin' no.\" - Avarosan Treatmaker", "http://dd.b.pvp.net/Set1/en_us/img/cards/01FR016-full.png", 0, "Burst", false, "Poro Snax", 0, 3, "01FR016", 1, null, null, null },
                    { 251L, 4, "http://dd.b.pvp.net/Set1/en_us/img/cards/01IO021.png", true, 7, "When I'm summoned, give other allies +2|+2 this round.", "\"Spring blooms first on Ionia's cliffsides, where the beating of newly formed wings bathes the land in the season's gentle breezes.\" - Saga of the First Lands", "http://dd.b.pvp.net/Set1/en_us/img/cards/01IO021-full.png", 2, "Elusive", false, "Windfarer Hatchling", 2, 5, "01IO021", null, null, null, null },
                    { 250L, 2, "http://dd.b.pvp.net/Set1/en_us/img/cards/01PZ003.png", true, 3, "When you cast a 6+ cost spell, create a copy of me in hand, then grant allied Assembly Bots EVERYWHERE +1|+1.", "It's important to make friends.", "http://dd.b.pvp.net/Set1/en_us/img/cards/01PZ003-full.png", 2, "Imbue", false, "Assembly Bot", 1, 6, "01PZ003", null, null, null, null },
                    { 249L, 0, "http://dd.b.pvp.net/Set1/en_us/img/cards/01SI027.png", true, 3, @"If 3+ allies have died this round, summon <link=card.summon><style=AssociatedCard>Vilemaw</style></link>.
                <style=Variable></style>", "\"Kneel before your fanged god. Better yet, die before it.\" - Elise", "http://dd.b.pvp.net/Set1/en_us/img/cards/01SI027-full.png", 0, "Slow", false, "Fresh Offerings", 1, 4, "01SI027", 0, null, null, null },
                    { 248L, 7, "http://dd.b.pvp.net/Set1/en_us/img/cards/01PZ056T5.png", false, 7, "<link=keyword.Fleeting><sprite name=Fleeting><style=Keyword>Fleeting</style></link>.", "\"I dreamed of a great mechanical beast, obeying my every command! I MUST realize this vision. First, stability tests, then ordinance and armor evaluation...\" - Heimerdinger's Lab Notes, Vol. 7", "http://dd.b.pvp.net/Set1/en_us/img/cards/01PZ056T5-full.png", 1, "Barrier", false, "Mk7: Armored Stomper", 4, 6, "01PZ056T5", null, null, null, null },
                    { 247L, 0, "http://dd.b.pvp.net/Set1/en_us/img/cards/01DE037.png", true, 4, "Give an ally +3|+0 and <link=keyword.Barrier><sprite name=Barrier><style=Keyword>Barrier</style></link> this round.", "\"How appropriate--you fight like a poro!\" - Fiora", "http://dd.b.pvp.net/Set1/en_us/img/cards/01DE037-full.png", 0, "Burst", false, "Riposte", 1, 2, "01DE037", 1, null, null, null },
                    { 246L, 0, "http://dd.b.pvp.net/Set1/en_us/img/cards/01SI042T2.png", false, 3, @"Summon 2 <link=card.summon><style=AssociatedCard>Spectral Rider</style></link>.
                Shuffle a <link=card.level1><style=AssociatedCard>Hecarim</style></link> into deck.", "They live now as they died then: loyal 'til the very end.", "http://dd.b.pvp.net/Set1/en_us/img/cards/01SI042T2-full.png", 0, "Slow", false, "Hecarim's Onslaught of Shadows", 4, 4, "01SI042T2", 0, null, null, null },
                    { 245L, 0, "http://dd.b.pvp.net/Set1/en_us/img/cards/01IO009T3.png", false, 3, @"<link=keyword.Recall><style=Keyword>Recall</style></link> an ally to summon a <link=card.create><style=AssociatedCard>Living Shadow</style></link> in its place.
                Shuffle a <link=card.level1><style=AssociatedCard>Zed</style></link> into your deck.", "Do you face the enemy that you believe you see? Or is it a trick of the shadows?", "http://dd.b.pvp.net/Set1/en_us/img/cards/01IO009T3-full.png", 0, "Fast", false, "Zed's Shadowshift", 4, 5, "01IO009T3", 2, null, null, null },
                    { 244L, 3, "http://dd.b.pvp.net/Set1/en_us/img/cards/01SI011.png", true, 0, "To play me, kill an ally.", "You are what you eat.", "http://dd.b.pvp.net/Set1/en_us/img/cards/01SI011-full.png", 2, null, false, "Ravenous Butcher", 0, 4, "01SI011", null, null, null, null },
                    { 243L, 3, "http://dd.b.pvp.net/Set1/en_us/img/cards/01DE036.png", true, 4, "When you summon an Elite, reduce my cost by 1.", @"""Everyone I met, every journey I took taught me something new. But the more I learned and the stronger I became, the more I realized I had much further to go..."" - Cithria, Vanguard Squire
                ", "http://dd.b.pvp.net/Set1/en_us/img/cards/01DE036-full.png", 3, null, false, "Vanguard Squire", 0, 2, "01DE036", null, null, null, null },
                    { 242L, 0, "http://dd.b.pvp.net/Set1/en_us/img/cards/01NX044.png", true, 6, "<style=VocabNoTooltip>Attack</style>: Grant me +4|+0.", @"""Sir, they're refusing to open their gates. They've demanded to speak with Darius, but he's two days' ride away. Should we send riders?""
                ""Oh, that won't be necessary.""", "http://dd.b.pvp.net/Set1/en_us/img/cards/01NX044-full.png", 12, "Overwhelm", false, "Battering Ram", 2, 1, "01NX044", null, null, null, null },
                    { 241L, 6, "http://dd.b.pvp.net/Set1/en_us/img/cards/01NX036.png", true, 6, "Start of Round: <link=keyword.Stun><sprite name=Stunned><style=Keyword>Stun</style></link> the <link=keyword.Weakest><style=Keyword>Weakest</style></link> enemy.", "\"I don't care who wronged you or what they did. You need me to make it right in the pit, you pay up front. There's no discount for sad stories.\"", "http://dd.b.pvp.net/Set1/en_us/img/cards/01NX036-full.png", 6, null, false, "Minotaur Reckoner", 1, 1, "01NX036", null, null, null, null },
                    { 240L, 4, "http://dd.b.pvp.net/Set1/en_us/img/cards/01DE040.png", true, 6, "<link=vocab.Play><style=Vocab>Play</style></link>: Discard a spell to grant me Health equal to its cost.", @"""Citizens of Demacia, it is my honor to keep you safe. But we must demand your unwavering support, for even within our high walls, mages still walk among us!""
                ", "http://dd.b.pvp.net/Set1/en_us/img/cards/01DE040-full.png", 1, "Challenger", false, "Mageseeker Persuader", 1, 2, "01DE040", null, null, null, null },
                    { 239L, 0, "http://dd.b.pvp.net/Set1/en_us/img/cards/01FR052T1.png", false, 0, "<link=keyword.Obliterate><style=Keyword>Obliterate</style></link> ALL units with 4 or less Power in play and in hands.", "“Unearthly light flooded the valley as a piercing wail rattled the rocks from the cliffs, my sinews from their bones, the very thoughts from my mind! Then... silence.” - Bjerg the Wanderer", "http://dd.b.pvp.net/Set1/en_us/img/cards/01FR052T1-full.png", 0, "Skill", false, "Balesight", 4, 3, "01FR052T1", null, null, null, null },
                    { 314L, 2, "http://dd.b.pvp.net/Set1/en_us/img/cards/01IO006.png", true, 2, "When you summon an ally, give me +1|+0 this round.", @"""Hey, watch those branches! Left, LEFT!"" 
                ""When I'm on YOUR shoulders, Fuzzball, we can go wherever you want. 'Til then, I got this!""", "http://dd.b.pvp.net/Set1/en_us/img/cards/01IO006-full.png", 1, "Elusive", false, "Greenglade Duo", 1, 5, "01IO006", null, null, null, null },
                    { 212L, 0, "http://dd.b.pvp.net/Set1/en_us/img/cards/01DE047.png", true, 3, "Summon a <link=card.summon><style=AssociatedCard>Dauntless Vanguard</style></link>.", "Vestments of the Dauntless Vanguard are handed down from one soldier to the next, so that new recruits may feel the weight and pride of their responsibilities.", "http://dd.b.pvp.net/Set1/en_us/img/cards/01DE047-full.png", 0, "Slow", false, "Succession", 0, 2, "01DE047", 0, null, null, null },
                    { 315L, 0, "http://dd.b.pvp.net/Set1/en_us/img/cards/01NX052.png", true, 3, "Deal 1 to an allied follower. If it survives, create a copy of it in hand.", "Nothing is messier than a hemomancer's first lesson.", "http://dd.b.pvp.net/Set1/en_us/img/cards/01NX052-full.png", 0, "Fast", false, "Blood for Blood", 0, 1, "01NX052", 2, null, null, null },
                    { 317L, 0, "http://dd.b.pvp.net/Set1/en_us/img/cards/01DE026.png", true, 2, "An ally and an enemy strike each other.", "\"Save your words; we speak with blades.\" - Fiora", "http://dd.b.pvp.net/Set1/en_us/img/cards/01DE026-full.png", 0, "Fast", false, "Single Combat", 0, 2, "01DE026", 2, null, null, null },
                    { 392L, 2, "http://dd.b.pvp.net/Set1/en_us/img/cards/01FR032.png", true, 2, "When you cast a spell, grant the top ally in your deck +1|+1.", "\"Grant them keen ears to hear the wind's approach, light feet to cross the coming snows, and sharp eyes to see beyond the veil of winter.\"", "http://dd.b.pvp.net/Set1/en_us/img/cards/01FR032-full.png", 2, "Imbue", false, "Starlit Seer", 1, 3, "01FR032", null, null, null, null },
                    { 391L, 2, "http://dd.b.pvp.net/Set1/en_us/img/cards/01PZ043.png", true, 2, "<link=vocab.Nexus Strike><style=Vocab>Nexus Strike</style></link>: Create in hand an exact copy of a random spell from the enemy's deck.", "Those cast below the City of Progress were expected to turn on each other. But instead they bonded, found their feet as one, and created a new home. It wasn't much, but it was theirs. Zaun.", "http://dd.b.pvp.net/Set1/en_us/img/cards/01PZ043-full.png", 2, null, false, "Chempunk Pickpocket", 1, 6, "01PZ043", null, null, null, null },
                    { 390L, 2, "http://dd.b.pvp.net/Set1/en_us/img/cards/01IO043.png", true, 3, "<link=vocab.Strike><style=Vocab>Strike</style></link>: Draw a spell.", "\"We are proud children of the First Lands, and the streams of her magic flow through our vastayan blood as they do through our realm.\"", "http://dd.b.pvp.net/Set1/en_us/img/cards/01IO043-full.png", 1, null, false, "Rivershaper", 1, 5, "01IO043", null, null, null, null },
                    { 389L, 5, "http://dd.b.pvp.net/Set1/en_us/img/cards/01DE028.png", true, 5, "", "The Vanguard needed no drums, no music to keep time in their advance. Only the steady, even beat of hooves against soil.", "http://dd.b.pvp.net/Set1/en_us/img/cards/01DE028-full.png", 5, "Tough", false, "Vanguard Cavalry", 0, 2, "01DE028", null, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "CardId", "Attack", "CardVisualLink", "Collectable", "Cost", "Description", "FlavorText", "FullArtworkLink", "Health", "KeywordsRefs", "Legacy", "Name", "Rarity", "RegionRef", "RiotId", "SpellSpeed", "SubType", "SuperType", "Type" },
                values: new object[,]
                {
                    { 388L, 0, "http://dd.b.pvp.net/Set1/en_us/img/cards/01NX019.png", true, 3, "Give an ally +3|+0 and <link=keyword.Overwhelm><sprite name=Overwhelm><style=Keyword>Overwhelm</style></link> this round.", "\"When I say subtlety is overrated, that doesn't mean it isn't good. It's just overrated.\" - Darius", "http://dd.b.pvp.net/Set1/en_us/img/cards/01NX019-full.png", 0, "Burst", false, "Might", 0, 1, "01NX019", 1, null, null, null },
                    { 387L, 0, "http://dd.b.pvp.net/Set1/en_us/img/cards/01PZ026.png", true, 2, "Grant an ally <link=keyword.Elusive><sprite name=Elusive><style=Keyword>Elusive</style></link>.", "\"Pilties always think they know everything, but their maps only show the places we told 'em about! Nothing like local knowledge. Which you can have... for a price.\" - Lem, Sumpsnipe Scavenger", "http://dd.b.pvp.net/Set1/en_us/img/cards/01PZ026-full.png", 0, "Burst", false, "Sumpworks Map", 0, 6, "01PZ026", 1, null, null, null },
                    { 386L, 0, "http://dd.b.pvp.net/Set1/en_us/img/cards/01FR024T4.png", false, 1, "", "In the depths of winter's cold embrace, the Freljord's guardian awaits the hour of her return.", "http://dd.b.pvp.net/Set1/en_us/img/cards/01FR024T4-full.png", 1, "CantBlock", false, "Eggnivia", 4, 3, "01FR024T4", null, null, null, null },
                    { 385L, 4, "http://dd.b.pvp.net/Set1/en_us/img/cards/01PZ056T8.png", false, 4, "<link=keyword.Fleeting><sprite name=Fleeting><style=Keyword>Fleeting</style></link>.", "\"Ah, the sweet smell of science! I have successfully upgraded my turrets! I must say... this model's appearance sends hypothermic waves through my vertebrae! Brr!\" - Heimerdinger's Lab Notes, Vol. 4", "http://dd.b.pvp.net/Set1/en_us/img/cards/01PZ056T8-full.png", 1, "Fearsome", false, "Mk4: Apex Turret", 4, 6, "01PZ056T8", null, null, null, null },
                    { 384L, 0, "http://dd.b.pvp.net/Set1/en_us/img/cards/01IO037.png", true, 4, "Give an ally <link=keyword.Barrier><sprite name=Barrier><style=Keyword>Barrier</style></link> and <link=keyword.Lifesteal><sprite name=Lifesteal><style=Keyword>Lifesteal</style></link> this round.", "\"This blade was once my father's. May it bring you the strength that I once lacked.\" - Shen", "http://dd.b.pvp.net/Set1/en_us/img/cards/01IO037-full.png", 0, "Burst", false, "Spirit's Refuge", 0, 5, "01IO037", 1, null, null, null },
                    { 383L, 2, "http://dd.b.pvp.net/Set1/en_us/img/cards/01DE029.png", true, 1, "", "These relatives of the silverwing raptors have the predatory instincts of their cousins alongside a dogged unfamiliarity with their own comparatively diminutive size.", "http://dd.b.pvp.net/Set1/en_us/img/cards/01DE029-full.png", 1, "Challenger", false, "Fleetfeather Tracker", 0, 2, "01DE029", null, null, null, null },
                    { 393L, 4, "http://dd.b.pvp.net/Set1/en_us/img/cards/01IO038.png", true, 3, "When I'm summoned, <link=keyword.Recall><style=Keyword>Recall</style></link> all other allies.", "\"Reflex and instinct are the only company I desire.\"", "http://dd.b.pvp.net/Set1/en_us/img/cards/01IO038-full.png", 3, "Elusive", false, "Solitary Monk", 1, 5, "01IO038", null, null, null, null },
                    { 382L, 4, "http://dd.b.pvp.net/Set1/en_us/img/cards/01FR043T1.png", false, 5, "<link=keyword.Last Breath><sprite name=LastBreath><style=Keyword>Last Breath</style></link>: Summon a <link=card.summon><style=AssociatedCard>Heart of the Fluft</style></link>.", @"""... At first she didn't know what the little ones could do. But then another appeared, and another, 'til the hall was full of them! And every poro gathered--"" 
                ""Bedtime! If you two aren't asleep in five minutes...!""", "http://dd.b.pvp.net/Set1/en_us/img/cards/01FR043T1-full.png", 4, null, false, "Fluft of Poros", 4, 3, "01FR043T1", null, null, null, null },
                    { 380L, 2, "http://dd.b.pvp.net/Set1/en_us/img/cards/01DE039.png", true, 1, "", "\"Each night before bed, my mother would tell me stories of Demacia's greatest heroes as she sharpened her sword. My dreams were full of adventures, and today I'll begin a story all my own.\"", "http://dd.b.pvp.net/Set1/en_us/img/cards/01DE039-full.png", 2, null, false, "Cithria of Cloudfield", 0, 2, "01DE039", null, null, null, null },
                    { 379L, 0, "http://dd.b.pvp.net/Set1/en_us/img/cards/01IO046.png", true, 3, "<link=keyword.Stun><sprite name=Stunned><style=Keyword>Stun</style></link> an attacking enemy.", "\"Hasagi!\"- Yasuo", "http://dd.b.pvp.net/Set1/en_us/img/cards/01IO046-full.png", 0, "Fast", false, "Steel Tempest", 1, 5, "01IO046", 2, null, null, null },
                    { 378L, 5, "http://dd.b.pvp.net/Set1/en_us/img/cards/01SI004.png", true, 3, "", "Some fleeing the Ruination tried diving beneath the waves, believing the corruption wouldn't seep into the depths. They were wrong.", "http://dd.b.pvp.net/Set1/en_us/img/cards/01SI004-full.png", 5, "Ephemeral;Lifesteal", false, "Darkwater Scourge", 0, 4, "01SI004", null, null, null, null },
                    { 377L, 5, "http://dd.b.pvp.net/Set1/en_us/img/cards/01NX026.png", true, 3, "", "\"Recklessness is a fault. Tempered by the Legion, it becomes a tool.\" - Jericho Swain", "http://dd.b.pvp.net/Set1/en_us/img/cards/01NX026-full.png", 4, "CantBlock", false, "Reckless Trifarian", 0, 1, "01NX026", null, null, null, null },
                    { 376L, 0, "http://dd.b.pvp.net/Set1/en_us/img/cards/01FR024T5.png", false, 0, "Deal 2 to all enemies.", "The storm that comes before the calm.", "http://dd.b.pvp.net/Set1/en_us/img/cards/01FR024T5-full.png", 0, "Skill", false, "Glacial Storm2", 0, 3, "01FR024T5", null, null, null, null },
                    { 375L, 2, "http://dd.b.pvp.net/Set1/en_us/img/cards/01NX035.png", true, 1, "When I'm summoned, move <link=card.dravenRef><style=AssociatedCard>Draven</style></link> to the top of your deck if you don't already have him.", "\"You want an autograph? Get... Get in line, pal!\"", "http://dd.b.pvp.net/Set1/en_us/img/cards/01NX035-full.png", 1, null, false, "Draven's Biggest Fan", 0, 1, "01NX035", null, null, null, null },
                    { 374L, 0, "http://dd.b.pvp.net/Set1/en_us/img/cards/01DE045T2.png", false, 4, @"Give an ally +3|+0 and <link=keyword.Barrier><sprite name=Barrier><style=Keyword>Barrier</style></link> this round.
                Shuffle a <link=card.level1><style=AssociatedCard>Fiora</style></link> into your deck.", "\"How appropriate--you fight like a poro!\" - Fiora", "http://dd.b.pvp.net/Set1/en_us/img/cards/01DE045T2-full.png", 0, "Burst", false, "Fiora's Riposte", 4, 2, "01DE045T2", 1, null, null, null },
                    { 373L, 5, "http://dd.b.pvp.net/Set1/en_us/img/cards/01DE042.png", true, 5, "", "\"I've always known there's something different about me... a light from within. I'm not sure what is it, but I have to find out!\" ", "http://dd.b.pvp.net/Set1/en_us/img/cards/01DE042-full.png", 3, "Barrier", false, "Lux", 3, 2, "01DE042", null, null, null, null },
                    { 372L, 1, "http://dd.b.pvp.net/Set1/en_us/img/cards/01PZ042.png", true, 2, "<link=vocab.Support><style=Vocab>Support</style></link>: Give my supported ally <link=keyword.Elusive><sprite name=Elusive><style=Keyword>Elusive</style></link> this round.", "For many Piltovans, the great unknown is explored through science and invention, safe within their City of Progress. But a handful embark for the horizon to discover a much greater unknown: the world.", "http://dd.b.pvp.net/Set1/en_us/img/cards/01PZ042-full.png", 3, null, false, "Intrepid Mariner", 1, 6, "01PZ042", null, null, null, null },
                    { 371L, 1, "http://dd.b.pvp.net/Set1/en_us/img/cards/01NX034.png", true, 1, "", "\"Noxus has no room for... for weakn--Will someone get this DAMNED THING OFF ME?!\" - Darius", "http://dd.b.pvp.net/Set1/en_us/img/cards/01NX034-full.png", 1, "Challenger", false, "Affectionate Poro", 0, 1, "01NX034", null, null, null, null },
                    { 381L, 0, "http://dd.b.pvp.net/Set1/en_us/img/cards/01NX006T3.png", false, 2, @"Deal 1 to an ally and give another ally +2|+2 this round.
                Shuffle a <link=card.level1><style=AssociatedCard>Vladimir</style></link> into deck.", "\"It's give and take, my dear. You give, and I take.\" - Vladimir", "http://dd.b.pvp.net/Set1/en_us/img/cards/01NX006T3-full.png", 0, "Burst", false, "Vladimir's Transfusion", 4, 1, "01NX006T3", 1, null, null, null },
                    { 370L, 4, "http://dd.b.pvp.net/Set1/en_us/img/cards/01FR024.png", true, 6, "<style=VocabNoTooltip>Attack</style>: Deal 1 to all enemies.", "\"I was born from this hard land, and it is mine to safeguard. Time, war, even death itself will not stop my vigil.\"", "http://dd.b.pvp.net/Set1/en_us/img/cards/01FR024-full.png", 3, "CantBlock", false, "Anivia", 3, 3, "01FR024", null, null, null, null },
                    { 394L, 10, "http://dd.b.pvp.net/Set1/en_us/img/cards/01FR052.png", true, 9, "<link=vocab.Play><style=Vocab>Play</style></link>: <link=keyword.Obliterate><style=Keyword>Obliterate</style></link> ALL units with 4 or less Power in play and in hands.", "\"I dug myself out from the rubble to find a scar seared into the land around me. Smoldering ash lay where my companions had stood, and in the distance a looming form moved on...\" - Bjerg the Wanderer", "http://dd.b.pvp.net/Set1/en_us/img/cards/01FR052-full.png", 10, "Regeneration", false, "She Who Wanders", 2, 3, "01FR052", null, null, null, null },
                    { 396L, 0, "http://dd.b.pvp.net/Set1/en_us/img/cards/01NX022.png", true, 3, @"Kill a damaged unit. 
                You can cast this again this round.", "To Darius, mercy is a deft blow.", "http://dd.b.pvp.net/Set1/en_us/img/cards/01NX022-full.png", 0, "Fast", false, "Noxian Guillotine", 1, 1, "01NX022", 2, null, null, null },
                    { 418L, 2, "http://dd.b.pvp.net/Set1/en_us/img/cards/01FR003.png", true, 2, "<link=keyword.Last Breath><sprite name=LastBreath><style=Keyword>Last Breath</style></link>: Draw 1.", "\"Once I sought my place on distant battlefields. Now, I've found it beside my kin, my homestead. My eyes are theirs, and their safety is in my hands.\"", "http://dd.b.pvp.net/Set1/en_us/img/cards/01FR003-full.png", 1, null, false, "Avarosan Sentry", 0, 3, "01FR003", null, null, null, null },
                    { 417L, 0, "http://dd.b.pvp.net/Set1/en_us/img/cards/01NX020T1.png", false, 0, @"To play, discard 1.
                Give an ally +1|+0 this round.", "\"Yeah, his brother'd win one-on-one, but you see those axes spiraling... it's art, it is. Art.\" - Arena Regular", "http://dd.b.pvp.net/Set1/en_us/img/cards/01NX020T1-full.png", 0, "Burst", false, "Spinning Axe", 4, 1, "01NX020T1", 1, null, null, null },
                    { 416L, 6, "http://dd.b.pvp.net/Set1/en_us/img/cards/01DE012.png", true, 6, "", "\"You think me rigid. Single-minded. Predictable. I am rigid, for nothing can sway me. I am single-minded, for I believe in Demacia. And I am predictable, for I will surely defeat you.”", "http://dd.b.pvp.net/Set1/en_us/img/cards/01DE012-full.png", 6, "Regeneration", false, "Garen", 3, 2, "01DE012", null, null, null, null },
                    { 415L, 3, "http://dd.b.pvp.net/Set1/en_us/img/cards/01FR007.png", true, 4, "When I'm summoned, draw a unit with 5+ Power.", "\"Y-You've gotta believe me! It was huge, I tell you, HUUUGE!\"", "http://dd.b.pvp.net/Set1/en_us/img/cards/01FR007-full.png", 3, null, false, "Babbling Bjerg", 0, 3, "01FR007", null, null, null, null },
                    { 414L, 0, "http://dd.b.pvp.net/Set1/en_us/img/cards/01NX049.png", true, 1, "<link=keyword.Stun><sprite name=Stunned><style=Keyword>Stun</style></link> an enemy.", "\"Allow your enemies enough rope to hang themselves and you'll save yourself the effort.\" - LeBlanc", "http://dd.b.pvp.net/Set1/en_us/img/cards/01NX049-full.png", 0, "Slow", false, "Guile", 0, 1, "01NX049", 0, null, null, null },
                    { 413L, 4, "http://dd.b.pvp.net/Set1/en_us/img/cards/01SI052T1.png", false, 5, @"When an enemy dies, heal me 1.
                The first time I attack this game, summon an attacking champion from your deck or hand.", @"Cling clang, go the chains, someone's out to find you,
                Cling clang, oh the chains, the Warden's right behind you...", "http://dd.b.pvp.net/Set1/en_us/img/cards/01SI052T1-full.png", 6, "Challenger", false, "Thresh", 4, 4, "01SI052T1", null, null, null, null },
                    { 412L, 0, "http://dd.b.pvp.net/Set1/en_us/img/cards/01SI015.png", true, 9, "Kill ALL units.", "To think something so pure as love could cause something so cruel and inescapable. ", "http://dd.b.pvp.net/Set1/en_us/img/cards/01SI015-full.png", 0, "Slow", false, "The Ruination", 2, 4, "01SI015", 0, null, null, null },
                    { 411L, 0, "http://dd.b.pvp.net/Set1/en_us/img/cards/01DE044.png", true, 6, "Fully heal an ally, then double its Power and Health.", "In Demacia, to be as good as two of the enemy isn't just a boast.", "http://dd.b.pvp.net/Set1/en_us/img/cards/01DE044-full.png", 0, "Slow", false, "Redoubled Valor", 1, 2, "01DE044", 0, null, null, null },
                    { 410L, 0, "http://dd.b.pvp.net/Set1/en_us/img/cards/01IO055.png", true, 2, @"Grant <link=keyword.Barrier><sprite name=Barrier><style=Keyword>Barrier</style></link> to an ally in hand. 
                Draw 1.", @"""Those who keep the balance shall know the protection of the Kinkou."" - Shen
                ", "http://dd.b.pvp.net/Set1/en_us/img/cards/01IO055-full.png", 0, "Burst", false, "Ki Guardian", 0, 5, "01IO055", 1, null, null, null },
                    { 409L, 6, "http://dd.b.pvp.net/Set1/en_us/img/cards/01IO056.png", true, 7, "<link=vocab.Play><style=Vocab>Play</style></link>: <link=keyword.Stun><sprite name=Stunned><style=Keyword>Stun</style></link> 2 enemies.", @"""When I was a child, I asked my brother: 'Does the wind flee, or does it follow?' He followed me then for guidance. I follow him now for justice.""
                ", "http://dd.b.pvp.net/Set1/en_us/img/cards/01IO056-full.png", 6, null, false, "Yone, Windchaser", 1, 5, "01IO056", null, null, null, null },
                    { 395L, 0, "http://dd.b.pvp.net/Set1/en_us/img/cards/01FR051.png", true, 3, "If you have a Yeti, summon an <link=card.create><style=AssociatedCard>Enraged Yeti</style></link>. Otherwise, create one on top of your deck.", "\"... and this one has a mouth fulla big jagged teeths an' smashy fists an super an-ger-y eyes an a HUUUGE TREE-SHAKING ROAR! Uncle Bjerg told me so!\" - Ingvar the Younger", "http://dd.b.pvp.net/Set1/en_us/img/cards/01FR051-full.png", 0, "Slow", false, "Tall Tales", 0, 3, "01FR051", 0, null, null, null },
                    { 408L, 6, "http://dd.b.pvp.net/Set1/en_us/img/cards/01DE051.png", true, 6, "<style=VocabNoTooltip>Attack</style>: Give other battling allies +1|+1 and <link=keyword.Fearsome><sprite name=Fearsome><style=Keyword>Fearsome</style></link> this round.", @"""Legends, tales--they were never just fiction to me. They were adventure calling my name. I left Cloudfield to discover my own adventure, only to find I would have many. And they’re just beginning.”
                ", "http://dd.b.pvp.net/Set1/en_us/img/cards/01DE051-full.png", 6, null, false, "Cithria the Bold", 2, 2, "01DE051", null, null, null, null },
                    { 406L, 0, "http://dd.b.pvp.net/Set1/en_us/img/cards/01SI040.png", true, 2, "<link=keyword.Drain><style=Keyword>Drain</style></link> 1 from a unit to summon a <link=card.create><style=AssociatedCard>Spiderling</style></link>.", "\"My... my lady! I didn't realize you were such an... an arachnophile! Could you perhaps call them away from me? L-Lady Elise? Please?\" - Lord Sassen, Hapless Aristocrat", "http://dd.b.pvp.net/Set1/en_us/img/cards/01SI040-full.png", 0, "Fast", false, "Vile Feast", 0, 4, "01SI040", 2, null, null, null },
                    { 405L, 5, "http://dd.b.pvp.net/Set1/en_us/img/cards/01NX024.png", true, 5, "<link=vocab.Support><style=Vocab>Support</style></link>: Give my supported ally +3|+0 and <link=keyword.Overwhelm><sprite name=Overwhelm><style=Keyword>Overwhelm</style></link> this round.", "\"Shiraza is a great girlfriend--I mean friend--and we are in no way dating. But if we were, I would like her to know that I wish her a happy anniversary. Thank you, no more questions.\"", "http://dd.b.pvp.net/Set1/en_us/img/cards/01NX024-full.png", 3, null, false, "Kato The Arm", 2, 1, "01NX024", null, null, null, null },
                    { 404L, 2, "http://dd.b.pvp.net/Set1/en_us/img/cards/01DE023.png", true, 2, "<link=vocab.Play><style=Vocab>Play</style></link>: Discard a spell to create a <link=card.create><style=AssociatedCard>Detain</style></link> in hand.", "\"Forgive the intrusion, but we will require your full cooperation. We have been notified of some... 'unusual happenings'....\"", "http://dd.b.pvp.net/Set1/en_us/img/cards/01DE023-full.png", 2, null, false, "Mageseeker Investigator", 0, 2, "01DE023", null, null, null, null },
                    { 403L, 5, "http://dd.b.pvp.net/Set1/en_us/img/cards/01NX032.png", true, 4, "When I'm summoned, deal 1 to all other allies.", "\"Even if I said 'no', you'd drag me along. So... sure.\"", "http://dd.b.pvp.net/Set1/en_us/img/cards/01NX032-full.png", 5, null, false, "Crimson Awakener", 1, 1, "01NX032", null, null, null, null },
                    { 402L, 0, "http://dd.b.pvp.net/Set1/en_us/img/cards/01IO039.png", true, 3, "<link=keyword.Recall><style=Keyword>Recall</style></link> an ally to summon a <link=card.create><style=AssociatedCard>Living Shadow</style></link> in its place.", "Do you face the enemy that you believe you see? Or is it a trick of the shadows?", "http://dd.b.pvp.net/Set1/en_us/img/cards/01IO039-full.png", 0, "Fast", false, "Shadowshift", 0, 5, "01IO039", 2, null, null, null },
                    { 401L, 0, "http://dd.b.pvp.net/Set1/en_us/img/cards/01IO041T2.png", false, 2, @"Create a random spell in hand.
                <link=keyword.Enlightened><style=Keyword>Enlightened</style></link>: Create 2 instead.
                Shuffle a <link=card.level1><style=AssociatedCard>Karma</style></link> into your deck.", "“When your hope wavers, know that you are never alone. The past is always by our side. It has known myriad tomorrows and all the hope that they bring.” - Karma", "http://dd.b.pvp.net/Set1/en_us/img/cards/01IO041T2-full.png", 0, "Burst", false, "Karma's Insight of Ages", 4, 5, "01IO041T2", 1, null, null, null },
                    { 400L, 3, "http://dd.b.pvp.net/Set1/en_us/img/cards/01DE054.png", true, 3, "When I'm summoned, draw a unit if an ally died this round.", "\"Our fallen shall be remembered in every battle cry, in every swing of our swords, and every crash of our shields! Today, we shall be victorious!\"", "http://dd.b.pvp.net/Set1/en_us/img/cards/01DE054-full.png", 3, null, false, "Vanguard Redeemer", 0, 2, "01DE054", null, null, null, null },
                    { 399L, 0, "http://dd.b.pvp.net/Set1/en_us/img/cards/01IO012T1.png", false, 3, "Give an ally +3|+0 this round.", "", "http://dd.b.pvp.net/Set1/en_us/img/cards/01IO012T1-full.png", 0, "Burst", false, "Discipline of Force", 4, 5, "01IO012T1", 1, null, null, null },
                    { 398L, 1, "http://dd.b.pvp.net/Set1/en_us/img/cards/01SI026.png", true, 1, "<link=keyword.Last Breath><sprite name=LastBreath><style=Keyword>Last Breath</style></link>: <link=keyword.Drain><style=Keyword>Drain</style></link> 1 from the enemy Nexus.", "He held his breath as best he could, praying the warden would move on. Little did he know, this pursuit would just be the beginning of Thresh's delighted torments…", "http://dd.b.pvp.net/Set1/en_us/img/cards/01SI026-full.png", 1, null, false, "Warden's Prey", 0, 4, "01SI026", null, null, null, null },
                    { 397L, 0, "http://dd.b.pvp.net/Set1/en_us/img/cards/01PZ047.png", true, 0, "<link=keyword.Last Breath><sprite name=LastBreath><style=Keyword>Last Breath</style></link>: Deal 1 to EACH Nexus.", "“I’d tell ya to wear a suit, but it gets muggy as a whump’s armpit down there. Gloves though, eh? An’ if you get that gunk on ya’, pray it don’t touch nothin’ important.” - Ziel, Zaunite Foreman", "http://dd.b.pvp.net/Set1/en_us/img/cards/01PZ047-full.png", 1, "Ephemeral", false, "Caustic Cask", 0, 6, "01PZ047", null, null, null, null },
                    { 407L, 1, "http://dd.b.pvp.net/Set1/en_us/img/cards/01FR034.png", true, 6, "When I'm summoned, grant me +1|+1 for each ally that has died.", "\"Ah, old Bjerg's been through a bit. Lost his crew up north, returned pale an' gibberin' months later. Now, it's just \"giant beasts\" this and \"huge claws\" that. That poor man...\" - Tavernkeeper", "http://dd.b.pvp.net/Set1/en_us/img/cards/01FR034-full.png", 1, "Overwhelm", false, "They Who Endure", 1, 3, "01FR034", null, null, null, null },
                    { 369L, 7, "http://dd.b.pvp.net/Set1/en_us/img/cards/01SI035.png", true, 7, "<link=vocab.Play><style=Vocab>Play</style></link>: Kill the 2 lowest Power enemies if an ally died this round.", "\"We were told... they called it a legend's journey. We were going to... for Demacia's future. We sailed with such hope. But all... all those lives... for what?\" - Arie Wrence, Demacian Soldier", "http://dd.b.pvp.net/Set1/en_us/img/cards/01SI035-full.png", 5, "Fearsome", false, "Rhasa the Sunderer", 2, 4, "01SI035", null, null, null, null },
                    { 368L, 0, "http://dd.b.pvp.net/Set1/en_us/img/cards/01IO032T2.png", false, 6, @"Swap two allies. Give them <link=keyword.Barrier><sprite name=Barrier><style=Keyword>Barrier</style></link>.
                Shuffle a <link=card.level1><style=AssociatedCard>Shen</style></link> into your deck.", @"""With balanced steps, I go."" - Shen
                ", "http://dd.b.pvp.net/Set1/en_us/img/cards/01IO032T2-full.png", 0, "Burst", false, "Shen's Stand United", 4, 5, "01IO032T2", 1, null, null, null },
                    { 367L, 2, "http://dd.b.pvp.net/Set1/en_us/img/cards/01PZ009.png", true, 3, "", "\"Personal flying machines? A pipe dream! I just had my apprentice throw the latest prototype out, in fact. Now, where is he?\" - Piltovan Engineer", "http://dd.b.pvp.net/Set1/en_us/img/cards/01PZ009-full.png", 3, "Elusive", false, "Amateur Aeronaut", 0, 6, "01PZ009", null, null, null, null },
                    { 339L, 0, "http://dd.b.pvp.net/Set1/en_us/img/cards/01PZ012.png", true, 2, "When I'm discarded, summon me.", "\"GET 'EM, CHOMPIES!\" - Jinx", "http://dd.b.pvp.net/Set1/en_us/img/cards/01PZ012-full.png", 3, "Challenger", false, "Flame Chompers!", 0, 6, "01PZ012", null, null, null, null },
                    { 338L, 5, "http://dd.b.pvp.net/Set1/en_us/img/cards/01NX031.png", true, 2, "", "Earning a place in the Trifarian Legion is good enough for most, but not all.", "http://dd.b.pvp.net/Set1/en_us/img/cards/01NX031-full.png", 1, "Challenger;CantBlock", false, "Trifarian Gloryseeker", 1, 1, "01NX031", null, null, null, null },
                    { 337L, 0, "http://dd.b.pvp.net/Set1/en_us/img/cards/01IO049.png", true, 3, "Stop a fast spell, slow spell, or skill.", "No.", "http://dd.b.pvp.net/Set1/en_us/img/cards/01IO049-full.png", 0, "Fast", false, "Deny", 1, 5, "01IO049", 2, null, null, null },
                    { 336L, 3, "http://dd.b.pvp.net/Set1/en_us/img/cards/01FR040.png", true, 5, "Start of Round: <link=keyword.Frostbite><sprite name=Frostbite><style=Keyword>Frostbite</style></link> the <link=vocab.Strongest><style=Vocab>Strongest</style></link> enemy.", "\"To become one with the wild we must not hide from the cold, but revel in its savagery.\"", "http://dd.b.pvp.net/Set1/en_us/img/cards/01FR040-full.png", 3, null, false, "Rimetusk Shaman", 1, 3, "01FR040", null, null, null, null },
                    { 335L, 6, "http://dd.b.pvp.net/Set1/en_us/img/cards/01SI044.png", true, 8, "<link=vocab.Play><style=Vocab>Play</style></link>: Pick an ally in hand. Summon an exact copy of it. It's <link=keyword.Ephemeral><sprite name=Ephemeral><style=Keyword>Ephemeral</style></link>.", "The Ruination corrupted all those caught in its path. The kind became cruel. The brave became brutal. Reason gave way to resentment.", "http://dd.b.pvp.net/Set1/en_us/img/cards/01SI044-full.png", 6, "Fearsome", false, "Spectral Matron", 2, 4, "01SI044", null, null, null, null },
                    { 334L, 0, "http://dd.b.pvp.net/Set1/en_us/img/cards/01DE027.png", true, 3, "Give allies <link=keyword.Challenger><sprite name=Challenger><style=Keyword>Challenger</style></link> this round.", "\"There's not a Demacian alive who would refuse a Laurent's lesson in swordsmanship. Or survived one, for that matter.\" - Fiora", "http://dd.b.pvp.net/Set1/en_us/img/cards/01DE027-full.png", 0, "Burst", false, "En Garde", 1, 2, "01DE027", 1, null, null, null },
                    { 333L, 7, "http://dd.b.pvp.net/Set1/en_us/img/cards/01NX045.png", true, 7, "", "\"Next up, CLAWS! Last time was a BLOODY takedown versus the Psycho Five... now the Psycho Three. Allllright! Takin' bets on today's victim! Four to one!\" - Karl, Arena Bookie", "http://dd.b.pvp.net/Set1/en_us/img/cards/01NX045-full.png", 4, "Overwhelm;Challenger", false, "Savage Reckoner", 1, 1, "01NX045", null, null, null, null },
                    { 332L, 0, "http://dd.b.pvp.net/Set1/en_us/img/cards/01FR046.png", true, 3, "Grant a damaged ally +3|+3.", "\"... Though his wounds were great, Braum threw back his head and laughed. For he knew that dire times are when heroes are made!\" -  The Tale of Braum", "http://dd.b.pvp.net/Set1/en_us/img/cards/01FR046-full.png", 0, "Burst", false, "Take Heart", 1, 3, "01FR046", 1, null, null, null },
                    { 331L, 2, "http://dd.b.pvp.net/Set1/en_us/img/cards/01IO053.png", true, 3, "<link=keyword.Enlightened><style=Keyword>Enlightened</style></link>: I have +4|+4.", "\"War is fostered by our basest instincts. But instinct has no power over our highest virtues: trust, patience, and contemplation.\"", "http://dd.b.pvp.net/Set1/en_us/img/cards/01IO053-full.png", 2, "Lifesteal", false, "Emerald Awakener", 0, 5, "01IO053", null, null, null, null },
                    { 330L, 2, "http://dd.b.pvp.net/Set1/en_us/img/cards/01PZ053.png", true, 2, "When I'm summoned, create a <link=card.create><style=AssociatedCard>Mushroom Cloud</style></link> in hand.", "\"Mhm, that's right! Clumps of 'em, sneakin' around! They SEEM crazy, but you just don't see. Not like me! They've big plans! Big plans. Puffcaps. Cheese... sorbet. Where was I?\" - Puffcap Peddler", "http://dd.b.pvp.net/Set1/en_us/img/cards/01PZ053-full.png", 2, null, false, "Clump of Whumps", 0, 6, "01PZ053", null, null, null, null },
                    { 340L, 5, "http://dd.b.pvp.net/Set1/en_us/img/cards/01FR031.png", true, 7, "End of Round: Reduce my cost by 1.", @"""What was that? Sounded like a sneeze. Do glaciers... sneeze?"" - Bjerg the Wanderer
                ", "http://dd.b.pvp.net/Set1/en_us/img/cards/01FR031-full.png", 5, "Overwhelm", false, "Ancient Yeti", 1, 3, "01FR031", null, null, null, null },
                    { 329L, 4, "http://dd.b.pvp.net/Set1/en_us/img/cards/01SI058.png", true, 5, "<link=vocab.Play><style=Vocab>Play</style></link>: Kill an ally to summon a random follower from any faction that costs 2 more.", "Spirits, lend your voices to mine! Together, we will call down a darkness unending!", "http://dd.b.pvp.net/Set1/en_us/img/cards/01SI058-full.png", 3, null, false, "Ethereal Remitter", 1, 4, "01SI058", null, null, null, null },
                    { 327L, 6, "http://dd.b.pvp.net/Set1/en_us/img/cards/01IO007.png", true, 8, "When the enemy summons a follower, grant it <link=keyword.Ephemeral><sprite name=Ephemeral><style=Keyword>Ephemeral</style></link>.", "“Run. Fight. Cower. It matters not, the shadows have come for you.”", "http://dd.b.pvp.net/Set1/en_us/img/cards/01IO007-full.png", 4, null, false, "Ren Shadowblade", 2, 5, "01IO007", null, null, null, null },
                    { 326L, 5, "http://dd.b.pvp.net/Set1/en_us/img/cards/01PZ006.png", true, 10, "Reduce my cost by 1 for each spell you've cast this game.", "You have twenty seconds to comply.", "http://dd.b.pvp.net/Set1/en_us/img/cards/01PZ006-full.png", 5, null, false, "Plaza Guardian", 1, 6, "01PZ006", null, null, null, null },
                    { 325L, 3, "http://dd.b.pvp.net/Set1/en_us/img/cards/01SI032.png", true, 4, "<link=vocab.Play><style=Vocab>Play</style></link>: Kill an ally, then revive it.", "There was a time when she sat with her father--a lord curator--as he studied the dusty tomes. He hoped one day she would take on the mantle. But not like this.", "http://dd.b.pvp.net/Set1/en_us/img/cards/01SI032-full.png", 3, null, false, "Chronicler of Ruin", 0, 4, "01SI032", null, null, null, null },
                    { 324L, 0, "http://dd.b.pvp.net/Set1/en_us/img/cards/01IO004.png", true, 1, "Heal anything 3.", "Every generation, region, and family has its own home remedy--though some are undeniably more effective than others.", "http://dd.b.pvp.net/Set1/en_us/img/cards/01IO004-full.png", 0, "Burst", false, "Health Potion", 0, 5, "01IO004", 1, null, null, null },
                    { 323L, 3, "http://dd.b.pvp.net/Set1/en_us/img/cards/01FR017.png", true, 5, "<link=vocab.Play><style=Vocab>Play</style></link>: Summon each Elnuk in the top 10 cards of your deck.", "\"Avarosans are like elnuks--dull-eyed grass-eaters easily felled by the unscarred. It is by numbers alone that they stay alive.\" - Vrynna, Scarmother", "http://dd.b.pvp.net/Set1/en_us/img/cards/01FR017-full.png", 3, null, false, "Troop of Elnuks", 0, 3, "01FR017", null, null, null, null },
                    { 322L, 4, "http://dd.b.pvp.net/Set1/en_us/img/cards/01IO048.png", true, 5, "", "\"Your order has thrust us from our lands. You've proved your power, Master Zed. Now let me prove that I too am worthy of your teachings.\"", "http://dd.b.pvp.net/Set1/en_us/img/cards/01IO048-full.png", 3, "Challenger;Elusive", false, "Yusari", 1, 5, "01IO048", null, null, null, null },
                    { 321L, 0, "http://dd.b.pvp.net/Set1/en_us/img/cards/01PZ049.png", true, 8, "Draw 3, then reduce their cost by 1.", @"PROGRESS DAY!
                Celebrate at the PLAZA OF THE SUN GATES!
                See HEXTECH WONDERS!
                Gasp at the DARING PORO!
                Hear the MAN OF TOMORROW speak on the STATE OF TODAY!
                FREE entry! 
                Piltovan children welcome!", "http://dd.b.pvp.net/Set1/en_us/img/cards/01PZ049-full.png", 0, "Burst", false, "Progress Day!", 2, 6, "01PZ049", 1, null, null, null },
                    { 320L, 2, "http://dd.b.pvp.net/Set1/en_us/img/cards/01FR048.png", true, 3, "When I'm summoned, create an <link=card.create><style=AssociatedCard>Enraged Yeti</style></link> in the top 3 cards of your deck.", "\"Caught nothing all week! Either those beasts are onto me, or something's scaring 'em off...\"", "http://dd.b.pvp.net/Set1/en_us/img/cards/01FR048-full.png", 2, null, false, "Avarosan Trapper", 0, 3, "01FR048", null, null, null, null },
                    { 319L, 3, "http://dd.b.pvp.net/Set1/en_us/img/cards/01SI021.png", true, 2, "When an <link=keyword.Ephemeral><sprite name=Ephemeral><style=Keyword>Ephemeral</style></link> ally attacks, revive me attacking.", "\"She saw what? I see. Madness is a cruel mistress, apothecary. At least the others make some degree of sense.\" - Demacian surgeon", "http://dd.b.pvp.net/Set1/en_us/img/cards/01SI021-full.png", 1, "CantBlock;Ephemeral", false, "Shark Chariot", 1, 4, "01SI021", null, null, null, null },
                    { 318L, 3, "http://dd.b.pvp.net/Set1/en_us/img/cards/01NX042.png", true, 3, "", "\"No sir! Just a flash of red. Next thing I know, I look up and it... it was like a slaughterhouse in there.\" - Demacian Border Guard", "http://dd.b.pvp.net/Set1/en_us/img/cards/01NX042-full.png", 2, null, false, "Katarina", 3, 1, "01NX042", null, null, null, null },
                    { 328L, 5, "http://dd.b.pvp.net/Set1/en_us/img/cards/01FR024T3.png", false, 6, @"<style=VocabNoTooltip>Attack</style>: Deal 2 to all enemies.
                <link=keyword.Last Breath><sprite name=LastBreath><style=Keyword>Last Breath</style></link>: Revive me transformed into <link=card.transform><style=AssociatedCard>Eggnivia</style></link>.", "\"I was born from this hard land, and it is mine to safeguard. Time, war, even death itself will not stop my vigil.\"", "http://dd.b.pvp.net/Set1/en_us/img/cards/01FR024T3-full.png", 4, "CantBlock", false, "Anivia", 4, 3, "01FR024T3", null, null, null, null },
                    { 341L, 3, "http://dd.b.pvp.net/Set1/en_us/img/cards/01DE006.png", true, 3, "When I'm summoned, create a <link=card.create><style=AssociatedCard>For Demacia!</style></link> in hand.", "\"He leads our drills from morning to night, and he's the first to head into the fray. Hard as steel, steady as stone--couldn't choose a finer leader.\" - Demacian Ensign", "http://dd.b.pvp.net/Set1/en_us/img/cards/01DE006-full.png", 3, null, false, "Vanguard Sergeant", 1, 2, "01DE006", null, null, null, null },
                    { 342L, 0, "http://dd.b.pvp.net/Set1/en_us/img/cards/01FR036T1.png", false, 0, "Deal 1 to an enemy unit.", "Gotcha.", "http://dd.b.pvp.net/Set1/en_us/img/cards/01FR036T1-full.png", 0, "Skill", false, "Bullseye", 4, 3, "01FR036T1", null, null, null, null },
                    { 343L, 3, "http://dd.b.pvp.net/Set1/en_us/img/cards/01FR053.png", true, 3, "", @"""Ol' Longhorn here lost an eye defending the Poro King himself from an ornery wildclaw! After all, it's not the size of the hammer but the size of the heart that matters."" - Poro Herder
                ", "http://dd.b.pvp.net/Set1/en_us/img/cards/01FR053-full.png", 3, "Overwhelm", false, "Mighty Poro", 0, 3, "01FR053", null, null, null, null },
                    { 366L, 0, "http://dd.b.pvp.net/Set1/en_us/img/cards/01SI029.png", true, 5, "<link=keyword.Drain><style=Keyword>Drain</style></link> 1 from all enemy units.", "The Black Mist does not distinguish between friend or foe. All fall before it.", "http://dd.b.pvp.net/Set1/en_us/img/cards/01SI029-full.png", 0, "Fast", false, "Withering Wail", 0, 4, "01SI029", 2, null, null, null },
                    { 365L, 3, "http://dd.b.pvp.net/Set1/en_us/img/cards/01DE009.png", true, 2, "<link=vocab.Play><style=Vocab>Play</style></link>: Give an ally <link=keyword.Barrier><sprite name=Barrier><style=Keyword>Barrier</style></link>.", "\"We are a prosperous nation because each warrior's fate is a coin we will never be content to spend.\" - King Jarvan III", "http://dd.b.pvp.net/Set1/en_us/img/cards/01DE009-full.png", 2, null, false, "Brightsteel Protector", 0, 2, "01DE009", null, null, null, null },
                    { 364L, 4, "http://dd.b.pvp.net/Set1/en_us/img/cards/01SI042.png", true, 6, "<style=VocabNoTooltip>Attack</style>: Summon 2 attacking <link=card.summon><style=AssociatedCard>Spectral Rider</style></link>.", "That's not thunder. The Shadow of War is on the horizon.", "http://dd.b.pvp.net/Set1/en_us/img/cards/01SI042-full.png", 6, "Overwhelm", false, "Hecarim", 3, 4, "01SI042", null, null, null, null },
                    { 363L, 4, "http://dd.b.pvp.net/Set1/en_us/img/cards/01PZ058.png", true, 4, "When I'm summoned, create two <link=card.create><style=AssociatedCard>Mushroom Cloud</style></link> in hand.", "\"Seen a big 'un, mmhmm! She's heavy as a horse and crafty as a krug. Gotta keep yer eye on her, I tells ya. That ol’ tomato’s the queen of the clump for a reason!\" - Puffcap Peddler", "http://dd.b.pvp.net/Set1/en_us/img/cards/01PZ058-full.png", 4, null, false, "Chump Whump", 1, 6, "01PZ058", null, null, null, null },
                    { 362L, 0, "http://dd.b.pvp.net/Set1/en_us/img/cards/01FR001.png", true, 3, "<link=keyword.Frostbite><sprite name=Frostbite><style=Keyword>Frostbite</style></link> an enemy.", "The cold strikes without warning, rendering even the strongest warrior helpless.", "http://dd.b.pvp.net/Set1/en_us/img/cards/01FR001-full.png", 0, "Burst", false, "Flash Freeze", 1, 3, "01FR001", 1, null, null, null },
                    { 361L, 5, "http://dd.b.pvp.net/Set1/en_us/img/cards/01SI020.png", true, 6, "When I'm summoned, revive a random allied champion with the highest Power.", "What use does a dying candle have, other than to light its successor?", "http://dd.b.pvp.net/Set1/en_us/img/cards/01SI020-full.png", 5, null, false, "The Rekindler", 1, 4, "01SI020", null, null, null, null },
                    { 360L, 0, "http://dd.b.pvp.net/Set1/en_us/img/cards/01IO054.png", true, 2, @"Create a random spell in hand.
                <link=keyword.Enlightened><style=Keyword>Enlightened</style></link>: Create 2 instead.", "“When your hope wavers, know that you are never alone. The past is always by our side. It has known myriad tomorrows and all the hope that they bring.” - Karma", "http://dd.b.pvp.net/Set1/en_us/img/cards/01IO054-full.png", 0, "Burst", false, "Insight of Ages", 1, 5, "01IO054", 1, null, null, null },
                    { 359L, 0, "http://dd.b.pvp.net/Set1/en_us/img/cards/01DE018.png", true, 1, "Give an ally +1|+1 this round.", @"""Undead fight like they've got no tomorrow. We'll make sure they won’t get one."" - Lucian

                ", "http://dd.b.pvp.net/Set1/en_us/img/cards/01DE018-full.png", 0, "Burst", false, "Radiant Strike", 0, 2, "01DE018", 1, null, null, null },
                    { 358L, 1, "http://dd.b.pvp.net/Set1/en_us/img/cards/01IO019.png", true, 1, "When an ally gets <link=keyword.Barrier><sprite name=Barrier><style=Keyword>Barrier</style></link>, grant me +2|+0.", "\"The glade protects its own. And you--you are not from here...\"", "http://dd.b.pvp.net/Set1/en_us/img/cards/01IO019-full.png", 2, null, false, "Greenglade Caretaker", 0, 5, "01IO019", null, null, null, null },
                    { 357L, 4, "http://dd.b.pvp.net/Set1/en_us/img/cards/01NX008.png", true, 4, "<link=vocab.Allegiance><style=Vocab>Allegiance</style></link>: Grant me +2|+2 and <link=keyword.Overwhelm><sprite name=Overwhelm><style=Keyword>Overwhelm</style></link>.", "This particular unit does use horses, just not for riding. The beasts find them delicious.", "http://dd.b.pvp.net/Set1/en_us/img/cards/01NX008-full.png", 2, null, false, "Basilisk Rider", 1, 1, "01NX008", null, null, null, null },
                    { 356L, 0, "http://dd.b.pvp.net/Set1/en_us/img/cards/01DE035.png", true, 6, "Give allies +3|+3 this round.", "“It is our homes, our families, our comrades in arms. It is our pride, our honor, our strength. And so, today, as we fight for its defense and its very existence, let us shout its name: DEMACIA!\"", "http://dd.b.pvp.net/Set1/en_us/img/cards/01DE035-full.png", 0, "Slow", false, "For Demacia!", 1, 2, "01DE035", 0, null, null, null },
                    { 355L, 0, "http://dd.b.pvp.net/Set1/en_us/img/cards/01PZ036T2.png", false, 2, @"Deal 2 to anything.
                Shuffle an <link=card.level1><style=AssociatedCard>Ezreal</style></link> into your deck.", "\"I. Never. Miss. But I have been known to fire a warning shot or two...\" - Ezreal", "http://dd.b.pvp.net/Set1/en_us/img/cards/01PZ036T2-full.png", 0, "Fast", false, "Ezreal's Mystic Shot", 4, 6, "01PZ036T2", 2, null, null, null },
                    { 354L, 0, "http://dd.b.pvp.net/Set1/en_us/img/cards/01PZ016.png", true, 6, @"Create a 6+ cost spell in hand.
                Refill your spell mana.", "It only takes one epiphany to launch a legacy.", "http://dd.b.pvp.net/Set1/en_us/img/cards/01PZ016-full.png", 0, "Burst", false, "Flash of Brilliance", 0, 6, "01PZ016", 1, null, null, null },
                    { 353L, 5, "http://dd.b.pvp.net/Set1/en_us/img/cards/01NX006.png", true, 5, "<style=VocabNoTooltip>Attack</style>: For each other attacking ally, deal 1 to it and 1 to the enemy Nexus.", @"Vicious. Cold. Cruel. Intriguing. Perceptive. Charming.
                Irresistible...", "http://dd.b.pvp.net/Set1/en_us/img/cards/01NX006-full.png", 5, null, false, "Vladimir", 3, 1, "01NX006", null, null, null, null },
                    { 352L, 0, "http://dd.b.pvp.net/Set1/en_us/img/cards/01DE041.png", true, 5, "Give two allies +3|+3 this round.", @"""Cover me, I'm going in!""
                ""Funny, I was about to say the same to you.""
                - Lorn and Dax of the Eastern Battalion", "http://dd.b.pvp.net/Set1/en_us/img/cards/01DE041-full.png", 0, "Burst", false, "Back to Back", 1, 2, "01DE041", 1, null, null, null },
                    { 351L, 6, "http://dd.b.pvp.net/Set1/en_us/img/cards/01IO030.png", true, 7, "", "\"The sky itself heaved as coils of clouds and powerful winds flattened our brigade. We tried to follow it, but who can chase the wind?\" - Legion General", "http://dd.b.pvp.net/Set1/en_us/img/cards/01IO030-full.png", 5, "Elusive", false, "The Empyrean", 2, 5, "01IO030", null, null, null, null },
                    { 350L, 1, "http://dd.b.pvp.net/Set1/en_us/img/cards/01IO052.png", true, 2, "When I'm summoned, summon a <link=card.summon><style=AssociatedCard>Navori Brigand</style></link> with my stats.", "“I was a traveling musician, known in every village 'ere to the Placidium--until the Noxians came. Now I'm scraping by on stolen coin. Mother was right, should've been a healer... ”", "http://dd.b.pvp.net/Set1/en_us/img/cards/01IO052-full.png", 2, null, false, "Navori Highwayman", 0, 5, "01IO052", null, null, null, null },
                    { 349L, 0, "http://dd.b.pvp.net/Set1/en_us/img/cards/01FR010.png", true, 4, "Grant two allies +0|+3.", "\"I will be a torch in your heart, a shield at your side. Let me find strength to protect us and our kin, and may our lives flow together as the blood that seals this oath.\" - Tryndamere", "http://dd.b.pvp.net/Set1/en_us/img/cards/01FR010-full.png", 0, "Burst", false, "Bloodsworn Pledge", 1, 3, "01FR010", 1, null, null, null },
                    { 348L, 4, "http://dd.b.pvp.net/Set1/en_us/img/cards/01DE038.png", true, 3, "The first time an allied <link=card.luc1><style=AssociatedCard>Lucian</style></link> dies this game, grant me +1|+1 and <link=keyword.Double Strike><sprite name=DoubleStrike><style=Keyword>Double Attack</style></link>.", "\"Our Sentinels are the first line of defense between the tide of restless undead and the realms of man. We hit first, hit hard, and NEVER back down when the lives of our companions are on the line.\"", "http://dd.b.pvp.net/Set1/en_us/img/cards/01DE038-full.png", 2, null, false, "Senna, Sentinel of Light", 1, 2, "01DE038", null, null, null, null },
                    { 347L, 6, "http://dd.b.pvp.net/Set1/en_us/img/cards/01PZ056T9.png", false, 6, "<link=keyword.Fleeting><sprite name=Fleeting><style=Keyword>Fleeting</style></link>.", "\"PROGRESS CONTINUES! I have finally found a way to combine the raw power of hexenergy with my ball tosser! I present, the STORMLOBBER! Now to sleep.\" - Heimerdinger's Lab Notes, Vol. 6", "http://dd.b.pvp.net/Set1/en_us/img/cards/01PZ056T9-full.png", 1, "Overwhelm", false, "Mk6: Stormlobber", 4, 6, "01PZ056T9", null, null, null, null },
                    { 346L, 0, "http://dd.b.pvp.net/Set1/en_us/img/cards/01PZ039.png", true, 3, @"To play, discard 1.
                Deal 3 to anything.", "\"FIRE IN THE CABOODLE!\" - Jinx", "http://dd.b.pvp.net/Set1/en_us/img/cards/01PZ039-full.png", 0, "Fast", false, "Get Excited!", 1, 6, "01PZ039", 2, null, null, null },
                    { 345L, 3, "http://dd.b.pvp.net/Set1/en_us/img/cards/01SI039.png", true, 2, "", "Some malevolent spirits take inspiration from local fauna, twisting the familiar into the nightmarish.", "http://dd.b.pvp.net/Set1/en_us/img/cards/01SI039-full.png", 2, "Fearsome", false, "Arachnoid Horror", 0, 4, "01SI039", null, null, null, null },
                    { 344L, 1, "http://dd.b.pvp.net/Set1/en_us/img/cards/01IO052T1.png", false, 2, "", "A bandit on the road means more in the brush.", "http://dd.b.pvp.net/Set1/en_us/img/cards/01IO052T1-full.png", 2, null, false, "Navori Brigand", 4, 5, "01IO052T1", null, null, null, null },
                    { 316L, 2, "http://dd.b.pvp.net/Set1/en_us/img/cards/01IO050.png", true, 4, "<link=vocab.Allegiance><style=Vocab>Allegiance</style></link>: Summon two 1 cost allies from our deck.", "Wherever she goes, she ensures that others can follow.", "http://dd.b.pvp.net/Set1/en_us/img/cards/01IO050-full.png", 3, null, false, "Kinkou Wayfinder", 1, 5, "01IO050", null, null, null, null },
                    { 211L, 0, "http://dd.b.pvp.net/Set1/en_us/img/cards/01PZ014.png", true, 6, "Summon an <link=card.summon><style=AssociatedCard>Illegal Contraption</style></link>.", "\"Their mishaps come in countless flavors: tremors from distant explosions, putrid fumes from the fissures. Soon enough, one of those fools will tear our city down.\" - Piltovan Philanthropist", "http://dd.b.pvp.net/Set1/en_us/img/cards/01PZ014-full.png", 0, "Slow", false, "Unlicensed Innovation", 0, 6, "01PZ014", 0, null, null, null },
                    { 210L, 5, "http://dd.b.pvp.net/Set1/en_us/img/cards/01PZ056T2.png", false, 5, "<link=keyword.Fleeting><sprite name=Fleeting><style=Keyword>Fleeting</style></link>.", "\"After a few production issues--propulsion and guidance, predominantly--I am ready to unveil my PROPELLED COMBUSTIBLES! ...must work on a better name.\" - Heimerdinger's Lab Notes, Vol. 5", "http://dd.b.pvp.net/Set1/en_us/img/cards/01PZ056T2-full.png", 1, null, false, "Mk5: Rocket Blaster", 4, 6, "01PZ056T2", null, null, null, null },
                    { 209L, 1, "http://dd.b.pvp.net/Set1/en_us/img/cards/01PZ008.png", true, 1, "<link=vocab.Nexus Strike><style=Vocab>Nexus Strike</style></link>: Plant 5 <link=card.shuffle><style=AssociatedCard>Poison Puffcap</style></link>s on random cards in the enemy deck.", "\"Bandle Scout Rule 154: Never fear the unknown! Rule 276: Denizens of the woodlands are our friends! Rule 354: If it's fuzzy, it might be safe to pet but certainly isn't safe to eat! Rule 417...\"", "http://dd.b.pvp.net/Set1/en_us/img/cards/01PZ008-full.png", 1, "Elusive", false, "Teemo", 3, 6, "01PZ008", null, null, null, null },
                    { 76L, 3, "http://dd.b.pvp.net/Set1/en_us/img/cards/01PZ056T6.png", false, 3, "<link=keyword.Fleeting><sprite name=Fleeting><style=Keyword>Fleeting</style></link>.", "\"I seem to have misplaced my latest work. And my mezzanine. I'm concerned about my bot, but the shrieking from the ceramics research laboratory gives me hope!\" - Heimerdinger's Lab Notes, Vol. 3", "http://dd.b.pvp.net/Set1/en_us/img/cards/01PZ056T6-full.png", 1, "Elusive", false, "Mk3: Floor-B-Gone", 4, 6, "01PZ056T6", null, null, null, null },
                    { 75L, 0, "http://dd.b.pvp.net/Set1/en_us/img/cards/01PZ050.png", true, 3, "Give a unit +4|+0 and <link=keyword.Quick Strike><sprite name=QuickStrike><style=Keyword>Quick Attack</style></link> this round.", "\"It kinda tickles when it starts to glow. That's normal... right?\" - Ezreal", "http://dd.b.pvp.net/Set1/en_us/img/cards/01PZ050-full.png", 0, "Burst", false, "Rising Spell Force", 0, 6, "01PZ050", 1, null, null, null },
                    { 74L, 3, "http://dd.b.pvp.net/Set1/en_us/img/cards/01NX046.png", true, 3, "<link=vocab.Play><style=Vocab>Play</style></link>: <link=keyword.Stun><sprite name=Stunned><style=Keyword>Stun</style></link> an enemy.", "\"Oh, how she captivates me! Her endless legs, voice of paralyzing sweetness, and eyes red as the rose. To think, she chose to dine with me tonight!\" - Hapless Aristocrat", "http://dd.b.pvp.net/Set1/en_us/img/cards/01NX046-full.png", 2, null, false, "Arachnoid Sentry", 0, 1, "01NX046", null, null, null, null },
                    { 73L, 0, "http://dd.b.pvp.net/Set1/en_us/img/cards/01FR038T3.png", false, 2, "<link=keyword.Frostbite><sprite name=Frostbite><style=Keyword>Frostbite</style></link> an enemy, then <link=keyword.Frostbite><sprite name=Frostbite><style=Keyword>Frostbite</style></link> enemies with 3 or less Health. Draw 1.", "\"All the world on one arrow.\" - Ashe", "http://dd.b.pvp.net/Set1/en_us/img/cards/01FR038T3-full.png", 0, "Slow", false, "Crystal Arrow", 4, 3, "01FR038T3", 0, null, null, null },
                    { 72L, 0, "http://dd.b.pvp.net/Set1/en_us/img/cards/01FR055.png", true, 2, "Deal 4 to an enemy unit if it has 0 Power. Otherwise, <link=keyword.Frostbite><sprite name=Frostbite><style=Keyword>Frostbite</style></link> it.", "\"When Winter rides across the land, she humbles the strong and fells the weak.\" - Scarthane Steffen", "http://dd.b.pvp.net/Set1/en_us/img/cards/01FR055-full.png", 0, "Slow", false, "Shatter", 0, 3, "01FR055", 0, null, null, null },
                    { 71L, 1, "http://dd.b.pvp.net/Set1/en_us/img/cards/01FR008T1.png", false, 1, "When I'm summoned, create in hand a random 1 cost Poro from any faction.", "", "http://dd.b.pvp.net/Set1/en_us/img/cards/01FR008T1-full.png", 1, null, false, "Jubilant Poro", 4, 3, "01FR008T1", null, null, null, null },
                    { 70L, 3, "http://dd.b.pvp.net/Set1/en_us/img/cards/01IO044.png", true, 2, "To play me, <link=keyword.Recall><style=Keyword>Recall</style></link> an ally.", "\"C'mon, we gotta get out of here! My name? I'll explain on the way, I promise....\"", "http://dd.b.pvp.net/Set1/en_us/img/cards/01IO044-full.png", 2, "Elusive", false, "Navori Conspirator", 0, 5, "01IO044", null, null, null, null },
                    { 69L, 2, "http://dd.b.pvp.net/Set1/en_us/img/cards/01FR045.png", true, 3, "When I survive damage, grant me +3|+0.", "\"I sealed my oath to the Winter's Claw when Sejuani gave me my first scar. Every scar since has been earned in her service.\"", "http://dd.b.pvp.net/Set1/en_us/img/cards/01FR045-full.png", 4, null, false, "Scarthane Steffen", 0, 3, "01FR045", null, null, null, null },
                    { 68L, 1, "http://dd.b.pvp.net/Set1/en_us/img/cards/01IO005.png", true, 1, "", "\"This might sound crazy, but the last thing I remember was a... fuzzy sensation...?\" - Navori Brigand", "http://dd.b.pvp.net/Set1/en_us/img/cards/01IO005-full.png", 1, null, false, "Nimble Poro", 0, 5, "01IO005", null, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "CardId", "Attack", "CardVisualLink", "Collectable", "Cost", "Description", "FlavorText", "FullArtworkLink", "Health", "KeywordsRefs", "Legacy", "Name", "Rarity", "RegionRef", "RiotId", "SpellSpeed", "SubType", "SuperType", "Type" },
                values: new object[,]
                {
                    { 67L, 3, "http://dd.b.pvp.net/Set1/en_us/img/cards/01FR036.png", true, 3, "<link=vocab.Play><style=Vocab>Play</style></link>: Deal 1 to an enemy unit.", "In the Freljord you can hunt, or you can starve.", "http://dd.b.pvp.net/Set1/en_us/img/cards/01FR036-full.png", 1, null, false, "Avarosan Marksman", 0, 3, "01FR036", null, null, null, null },
                    { 77L, 3, "http://dd.b.pvp.net/Set1/en_us/img/cards/01IO023.png", true, 5, "<link=vocab.Play><style=Vocab>Play</style></link>: Grant an ally in hand +3|+3.", "\"In times of conflict, villagers sought the ancient guardian of Autumn Valley. Those who swayed her heart were granted blessings that could turn the tide of battle.\" - Saga of the First Lands", "http://dd.b.pvp.net/Set1/en_us/img/cards/01IO023-full.png", 3, null, false, "Jeweled Protector", 1, 5, "01IO023", null, null, null, null },
                    { 66L, 0, "http://dd.b.pvp.net/Set1/en_us/img/cards/01DE025.png", true, 6, "An ally <link=keyword.Capture><style=Keyword>Captures</style></link> a unit.", "\"Submit to us. We are the law and you are its subject. There is nothing more.\" - Mageseeker Persuader", "http://dd.b.pvp.net/Set1/en_us/img/cards/01DE025-full.png", 0, "Fast", false, "Detain", 0, 2, "01DE025", 2, null, null, null },
                    { 64L, 0, "http://dd.b.pvp.net/Set1/en_us/img/cards/01DE022T2.png", false, 3, @"Ready your attack.
                Shuffle a <link=card.level1><style=AssociatedCard>Lucian</style></link> into your deck.", "\"You cannot outrun my vengeance.\" - Lucian", "http://dd.b.pvp.net/Set1/en_us/img/cards/01DE022T2-full.png", 0, "Fast", false, "Lucian's Relentless Pursuit", 4, 2, "01DE022T2", 2, null, null, null },
                    { 63L, 10, "http://dd.b.pvp.net/Set1/en_us/img/cards/01NX038T2.png", false, 6, "", "\"An iron will and a titan's strength. There is no finer general to lead the Trifarian Legion.\" - Jericho Swain", "http://dd.b.pvp.net/Set1/en_us/img/cards/01NX038T2-full.png", 5, "Overwhelm", false, "Darius", 4, 1, "01NX038T2", null, null, null, null },
                    { 62L, 1, "http://dd.b.pvp.net/Set1/en_us/img/cards/01IO014.png", true, 3, "<link=vocab.Play><style=Vocab>Play</style></link>: Grant allies in hand +1|+1.", "Ionian knowledge is outlined in the written word, but it is the tales and teachings of Ionia's venerated elders that give ancient text new life.", "http://dd.b.pvp.net/Set1/en_us/img/cards/01IO014-full.png", 1, null, false, "Greenglade Elder", 0, 5, "01IO014", null, null, null, null },
                    { 61L, 6, "http://dd.b.pvp.net/Set1/en_us/img/cards/01SI027T1.png", false, 3, "", "\"Who is your god? What can your god do? Will he let you wither and die defending him? Or will he give you life and vitality like no mortal has ever known? Why serve a god who won't serve you?\" - Elise", "http://dd.b.pvp.net/Set1/en_us/img/cards/01SI027T1-full.png", 6, "Fearsome", false, "Vilemaw", 4, 4, "01SI027T1", null, null, null, null },
                    { 60L, 4, "http://dd.b.pvp.net/Set1/en_us/img/cards/01IO009T2.png", false, 3, "<style=VocabNoTooltip>Attack</style>: Create an attacking <link=card.summon><style=AssociatedCard>Living Shadow</style></link> with my stats and keywords.", "\"Balance is a fool's master. The shadows have shown me true power.\"", "http://dd.b.pvp.net/Set1/en_us/img/cards/01IO009T2-full.png", 3, null, false, "Zed", 4, 5, "01IO009T2", null, null, null, null },
                    { 59L, 1, "http://dd.b.pvp.net/Set1/en_us/img/cards/01PZ032.png", false, 1, "", "Everyone tries to chase it down. Poor little thing just wants to play in puddles!", "http://dd.b.pvp.net/Set1/en_us/img/cards/01PZ032-full.png", 1, null, false, "Scrap Scuttler", 4, 6, "01PZ032", null, null, null, null },
                    { 58L, 5, "http://dd.b.pvp.net/Set1/en_us/img/cards/01SI042T1.png", false, 6, @"<link=keyword.Ephemeral><sprite name=Ephemeral><style=Keyword>Ephemeral</style></link> allies have +2|+0.
                <style=VocabNoTooltip>Attack</style>: Summon 2 attacking <link=card.summon><style=AssociatedCard>Spectral Rider</style></link>.", "That's not thunder. The Shadow of War is on the horizon.", "http://dd.b.pvp.net/Set1/en_us/img/cards/01SI042T1-full.png", 7, "Overwhelm", false, "Hecarim", 4, 4, "01SI042T1", null, null, null, null },
                    { 57L, 2, "http://dd.b.pvp.net/Set1/en_us/img/cards/01NX040.png", true, 1, "<style=VocabNoTooltip>Attack</style>: Deal 1 to the enemy Nexus.", "\"Our Shieldbreakers can split a man in two. But the Legion has other talents at its disposal when it requires a more... discreet touch.\" - Jericho Swain", "http://dd.b.pvp.net/Set1/en_us/img/cards/01NX040-full.png", 1, null, false, "Legion Saboteur", 0, 1, "01NX040", null, null, null, null },
                    { 56L, 0, "http://dd.b.pvp.net/Set1/en_us/img/cards/01SI010.png", true, 3, "Summon 2 <link=card.summon><style=AssociatedCard>Spectral Rider</style></link>.", "They live now as they died then: loyal 'til the very end.", "http://dd.b.pvp.net/Set1/en_us/img/cards/01SI010-full.png", 0, "Slow", false, "Onslaught of Shadows", 0, 4, "01SI010", 0, null, null, null },
                    { 55L, 0, "http://dd.b.pvp.net/Set1/en_us/img/cards/01NX047.png", true, 2, "Deal 1 to an ally to give another ally +2|+2 this round.", "\"It's give and take, my dear. You give, and I take.\" - Vladimir", "http://dd.b.pvp.net/Set1/en_us/img/cards/01NX047-full.png", 0, "Burst", false, "Transfusion", 0, 1, "01NX047", 1, null, null, null },
                    { 65L, 0, "http://dd.b.pvp.net/Set1/en_us/img/cards/01PZ028.png", true, 1, "When cast or discarded, summon a <link=card.summon><style=AssociatedCard>Scrap Scuttler</style></link>.", "With a handful of scrap and mere moments left, the young inventor recalled an unusual source of inspiration: a creature she once saw scuttling along the rivers of a distant jungle.", "http://dd.b.pvp.net/Set1/en_us/img/cards/01PZ028-full.png", 0, "Burst", false, "Jury-Rig", 0, 6, "01PZ028", 1, null, null, null },
                    { 54L, 0, "http://dd.b.pvp.net/Set1/en_us/img/cards/01NX046T1.png", false, 0, "<link=keyword.Stun><sprite name=Stunned><style=Keyword>Stun</style></link> an enemy.", "It was not the kiss he had in mind.", "http://dd.b.pvp.net/Set1/en_us/img/cards/01NX046T1-full.png", 0, "Skill", false, "Paralyzing Bite", 4, 1, "01NX046T1", null, null, null, null },
                    { 78L, 1, "http://dd.b.pvp.net/Set1/en_us/img/cards/01SI048.png", true, 2, "<link=keyword.Last Breath><sprite name=LastBreath><style=Keyword>Last Breath</style></link>: Summon an <link=card.summon><style=AssociatedCard>Escaped Abomination</style></link>.", "Madness and time. Never was there a more terrible pair.", "http://dd.b.pvp.net/Set1/en_us/img/cards/01SI048-full.png", 1, "CantBlock", false, "Cursed Keeper", 0, 4, "01SI048", null, null, null, null },
                    { 80L, 0, "http://dd.b.pvp.net/Set1/en_us/img/cards/01PZ030T1.png", false, 0, "Pick a follower. Transform me into an exact copy of it.", "Definitely not a pair of yordles in a suit.", "http://dd.b.pvp.net/Set1/en_us/img/cards/01PZ030T1-full.png", 0, "Skill", false, "Impersonate", 1, 6, "01PZ030T1", null, null, null, null },
                    { 102L, 0, "http://dd.b.pvp.net/Set1/en_us/img/cards/01NX020T2.png", false, 3, @"A battling ally strikes a battling enemy.
                Shuffle a <link=card.level1><style=AssociatedCard>Draven</style></link> into your deck.", "\"I have the best job.\" - Draven", "http://dd.b.pvp.net/Set1/en_us/img/cards/01NX020T2-full.png", 0, "Fast", false, "Draven's Whirling Death", 4, 1, "01NX020T2", 2, null, null, null },
                    { 101L, 0, "http://dd.b.pvp.net/Set1/en_us/img/cards/01FR012.png", true, 4, "Get an empty mana gem and heal your Nexus 3.", "Neither ruby nor sapphire surpass the luster of the aeon stone--a brilliant gem with legendary restorative properties. ", "http://dd.b.pvp.net/Set1/en_us/img/cards/01FR012-full.png", 0, "Burst", false, "Catalyst of Aeons", 0, 3, "01FR012", 1, null, null, null },
                    { 100L, 7, "http://dd.b.pvp.net/Set1/en_us/img/cards/01PZ048.png", true, 8, "<link=vocab.Play><style=Vocab>Play</style></link>: Discard the top 5 cards of your deck to deal 1 to all enemies for each spell discarded.", "\"The narrow-minded Piltovans know only gears and metal, and cannot appreciate the delicate art in every stem, every petal, every cell of my cultivair. I will craft them an undeservedly graceful doom.\"", "http://dd.b.pvp.net/Set1/en_us/img/cards/01PZ048-full.png", 7, null, false, "Corina Veraza", 2, 6, "01PZ048", null, null, null, null },
                    { 99L, 0, "http://dd.b.pvp.net/Set1/en_us/img/cards/01IO047.png", true, 6, "Grant ALL battling followers <link=keyword.Ephemeral><sprite name=Ephemeral><style=Keyword>Ephemeral</style></link>.", "When the flows of magic are diverted from their balanced state, they surge from the spirit world into the mortal realm--often with startling results.", "http://dd.b.pvp.net/Set1/en_us/img/cards/01IO047-full.png", 0, "Fast", false, "Shadow Flare", 2, 5, "01IO047", 2, null, null, null },
                    { 98L, 1, "http://dd.b.pvp.net/Set1/en_us/img/cards/01PZ030.png", true, 4, "<link=vocab.Play><style=Vocab>Play</style></link>: Pick a follower. Transform me into an exact copy of it.", "\"Hello, fellow Chem-Barons!\"", "http://dd.b.pvp.net/Set1/en_us/img/cards/01PZ030-full.png", 1, null, false, "Shady Character", 1, 6, "01PZ030", null, null, null, null },
                    { 97L, 6, "http://dd.b.pvp.net/Set1/en_us/img/cards/01PZ035.png", true, 8, "When I'm targeted, draw 1.", "Heir apparent to Piltover's prestigious Clan Medarda, Jae preferred hunting ancient artifacts over managing the family business... much to his father's chagrin.", "http://dd.b.pvp.net/Set1/en_us/img/cards/01PZ035-full.png", 6, "Elusive", false, "Jae Medarda", 2, 6, "01PZ035", null, null, null, null },
                    { 96L, 0, "http://dd.b.pvp.net/Set1/en_us/img/cards/01IO003.png", true, 3, "Remove <link=keyword.Ephemeral><sprite name=Ephemeral><style=Keyword>Ephemeral</style></link> from an ally to grant it to an enemy.", @"""I am the blade in the darkness."" - Zed

                ", "http://dd.b.pvp.net/Set1/en_us/img/cards/01IO003-full.png", 0, "Fast", false, "Death Mark", 1, 5, "01IO003", 2, null, null, null },
                    { 95L, 0, "http://dd.b.pvp.net/Set1/en_us/img/cards/01FR035.png", true, 1, "When I survive damage, grant me +3|+0.", @"""Avarosans nurture their young to grow old, soft, and unprepared for the heat of battle. Ours are born in the fires of war itself."" - Vrynna, Scarmother
                ", "http://dd.b.pvp.net/Set1/en_us/img/cards/01FR035-full.png", 3, null, false, "Unscarred Reaver", 0, 3, "01FR035", null, null, null, null },
                    { 94L, 2, "http://dd.b.pvp.net/Set1/en_us/img/cards/01PZ036T1.png", false, 3, @"<link=vocab.Nexus Strike><style=Vocab>Nexus Strike</style></link>: Create a <link=keyword.Fleeting><sprite name=Fleeting><style=Keyword>Fleeting</style></link> 0 cost <link=card.create><style=AssociatedCard>Mystic Shot</style></link>.
                When you cast a spell, deal 2 to the enemy Nexus.", "\"Impossible is my favorite kind of possible!\"", "http://dd.b.pvp.net/Set1/en_us/img/cards/01PZ036T1-full.png", 4, "Elusive;Imbue", false, "Ezreal", 4, 6, "01PZ036T1", null, null, null, null },
                    { 93L, 0, "http://dd.b.pvp.net/Set1/en_us/img/cards/01IO029.png", true, 3, "Grant allies in hand +2|+0.", "\"Not just seeds, younglings. The legacy of the land itself, promises for our prosperous future.\" - Karma", "http://dd.b.pvp.net/Set1/en_us/img/cards/01IO029-full.png", 0, "Burst", false, "Sown Seeds", 1, 5, "01IO029", 1, null, null, null },
                    { 79L, 0, "http://dd.b.pvp.net/Set1/en_us/img/cards/01PZ054T1.png", false, 0, "Deal 2 to the enemy Nexus.", "\"Time to go!\" - Boomcrew Rookie", "http://dd.b.pvp.net/Set1/en_us/img/cards/01PZ054T1-full.png", 0, "Skill", false, "Undermine", 4, 6, "01PZ054T1", null, null, null, null },
                    { 92L, 4, "http://dd.b.pvp.net/Set1/en_us/img/cards/01SI030.png", true, 3, "<link=vocab.Play><style=Vocab>Play</style></link>: I bond with an ally. It takes all damage for me.", "In life, she was a general, a protector, a hero. But as flesh gave way, she was left with naught but the blazing fires of retribution--an undying spirit of vengeance.", "http://dd.b.pvp.net/Set1/en_us/img/cards/01SI030-full.png", 2, null, false, "Kalista", 3, 4, "01SI030", null, null, null, null },
                    { 90L, 0, "http://dd.b.pvp.net/Set1/en_us/img/cards/01FR029.png", true, 2, "Draw a Champion.", "\"Reavers approach! Sound the call and light the fires, we'll need all the help we can muster!\" - Avarosan Sentry", "http://dd.b.pvp.net/Set1/en_us/img/cards/01FR029-full.png", 0, "Burst", false, "Entreat", 1, 3, "01FR029", 1, null, null, null },
                    { 89L, 5, "http://dd.b.pvp.net/Set1/en_us/img/cards/01SI030T2.png", false, 3, @"<link=vocab.Play><style=Vocab>Play</style></link>: I bond with an ally. It takes all damage for me.
                <style=VocabNoTooltip>Attack</style>: Revive that ally attacking and reforge our bond.", "In life, she was a general, a protector, a hero. But as flesh gave way, she was left with naught but the blazing fires of retribution--an undying spirit of vengeance.", "http://dd.b.pvp.net/Set1/en_us/img/cards/01SI030T2-full.png", 3, null, false, "Kalista", 4, 4, "01SI030T2", null, null, null, null },
                    { 88L, 0, "http://dd.b.pvp.net/Set1/en_us/img/cards/01PZ008T1.png", false, 1, @"Plant 5 <link=card.shuffle><style=AssociatedCard>Poison Puffcap</style></link> on random cards in the enemy deck.
                Shuffle a <link=card.level1><style=AssociatedCard>Teemo</style></link> into your deck.", "First, the soft thump as the puffcap pops. Next, searing, debilitating pain. Finally, the distant sound of giggles...", "http://dd.b.pvp.net/Set1/en_us/img/cards/01PZ008T1-full.png", 0, "Burst", false, "Teemo's Mushroom Cloud", 4, 6, "01PZ008T1", 1, null, null, null },
                    { 87L, 2, "http://dd.b.pvp.net/Set1/en_us/img/cards/01SI018.png", true, 3, "When I'm summoned, create a copy in hand of an ally that died this game.", "\"Little did our author know that soon the Ruinatio--the Ruin--no, no, no, that's not right, the ink's spilled again! Little did our author--no, no, no!\"", "http://dd.b.pvp.net/Set1/en_us/img/cards/01SI018-full.png", 3, null, false, "Scribe of Sorrows", 0, 4, "01SI018", null, null, null, null },
                    { 86L, 2, "http://dd.b.pvp.net/Set1/en_us/img/cards/01PZ056T7.png", false, 2, "<link=keyword.Fleeting><sprite name=Fleeting><style=Keyword>Fleeting</style></link>.", "\"Safety precautions for the laboratory! Recent postings have mentioned young Jayce's workshop was raided by thieves. Ha--local intruders, beware!\" - Heimerdinger's Lab Notes, Vol. 2", "http://dd.b.pvp.net/Set1/en_us/img/cards/01PZ056T7-full.png", 1, "Tough", false, "Mk2: Evolution Turret", 4, 6, "01PZ056T7", null, null, null, null },
                    { 85L, 4, "http://dd.b.pvp.net/Set1/en_us/img/cards/01PZ038.png", true, 2, "To play me, discard 1.", "In the Sump, waste is never wasted.", "http://dd.b.pvp.net/Set1/en_us/img/cards/01PZ038-full.png", 3, null, false, "Sump Dredger", 0, 6, "01PZ038", null, null, null, null },
                    { 84L, 2, "http://dd.b.pvp.net/Set1/en_us/img/cards/01PZ017.png", true, 3, "When I'm summoned, summon 2 <link=card.create><style=AssociatedCard>Caustic Cask</style></link>.", "\"Ziel sent ya? I told him, what's his is his. Can't refund somethin' I ain't ever seen before, can I? But, as it happens, I just received a batch of new casks I could be persuaded to part with...\"", "http://dd.b.pvp.net/Set1/en_us/img/cards/01PZ017-full.png", 2, null, false, "Used Cask Salesman", 0, 6, "01PZ017", null, null, null, null },
                    { 83L, 0, "http://dd.b.pvp.net/Set1/en_us/img/cards/01DE007.png", true, 8, "A battling ally strikes all battling enemies.", "Justice always comes full circle.", "http://dd.b.pvp.net/Set1/en_us/img/cards/01DE007-full.png", 0, "Fast", false, "Judgment", 2, 2, "01DE007", 2, null, null, null },
                    { 82L, 2, "http://dd.b.pvp.net/Set1/en_us/img/cards/01NX055.png", true, 2, "When I'm summoned, summon a <link=card.summon><style=AssociatedCard>Spiderling</style></link>.", "\"My spiders love company. Shame that company never feels the same.\" - Elise", "http://dd.b.pvp.net/Set1/en_us/img/cards/01NX055-full.png", 2, null, false, "House Spider", 0, 1, "01NX055", null, null, null, null },
                    { 81L, 0, "http://dd.b.pvp.net/Set1/en_us/img/cards/01NX025.png", true, 2, "Grant two allies +2|+0.", "\"Bonds forged in war are just as strong as those of kinship. Indeed, blood is shared in both.\" - Legion Veteran", "http://dd.b.pvp.net/Set1/en_us/img/cards/01NX025-full.png", 0, "Burst", false, "Brothers' Bond", 0, 1, "01NX025", 1, null, null, null },
                    { 91L, 0, "http://dd.b.pvp.net/Set1/en_us/img/cards/01SI035T1.png", false, 0, "Kill the 2 lowest Power enemies if an ally died this round.", "Thin the herd.", "http://dd.b.pvp.net/Set1/en_us/img/cards/01SI035T1-full.png", 0, "Skill", false, "Night Harvest", 4, 4, "01SI035T1", null, null, null, null },
                    { 53L, 0, "http://dd.b.pvp.net/Set1/en_us/img/cards/01PZ048T1.png", false, 0, "Discard the top 5 cards of your deck to deal 1 to all enemies for each spell discarded.", "\"I told them that every achievement had its cost. I didn't tell them who would pay it.\" - Corina Veraza", "http://dd.b.pvp.net/Set1/en_us/img/cards/01PZ048T1-full.png", 0, "Skill", false, "Magnum Opus", 4, 6, "01PZ048T1", null, null, null, null },
                    { 52L, 0, "http://dd.b.pvp.net/Set1/en_us/img/cards/01DE021.png", true, 3, "Ready your attack.", @" ""Everyone's gotta face their fears. Lucky you, here I am."" - Lucian
                ", "http://dd.b.pvp.net/Set1/en_us/img/cards/01DE021-full.png", 0, "Fast", false, "Relentless Pursuit", 0, 2, "01DE021", 2, null, null, null },
                    { 51L, 2, "http://dd.b.pvp.net/Set1/en_us/img/cards/01SI053.png", true, 2, "<style=VocabNoTooltip>Attack</style>: Summon an attacking <link=card.summon><style=AssociatedCard>Spiderling</style></link>.", "Once the head of a powerful Noxian house, Elise's dark ties to the Shadow Isles granted her unnatural youth and beauty in exchange for a few unwitting souls offered in sacrifice. An easy decision.", "http://dd.b.pvp.net/Set1/en_us/img/cards/01SI053-full.png", 3, "Fearsome", false, "Elise", 3, 4, "01SI053", null, null, null, null },
                    { 23L, 3, "http://dd.b.pvp.net/Set1/en_us/img/cards/01NX048.png", true, 3, "When I survive damage, create a random Crimson unit in your hand.", "\"Beloved companions!\" \"Were you? Well I received an invitation.\" \"--Reveler's Ball! Yes!\" \"Then we must! I shall present my family.\" \"Starters before dessert, my dear. And you, Kye? Will you attend?\"", "http://dd.b.pvp.net/Set1/en_us/img/cards/01NX048-full.png", 2, null, false, "Crimson Curator", 0, 1, "01NX048", null, null, null, null },
                    { 22L, 1, "http://dd.b.pvp.net/Set1/en_us/img/cards/01IO008.png", true, 2, "When you <link=keyword.Stun><sprite name=Stunned><style=Keyword>Stun</style></link> or <link=keyword.Recall><style=Keyword>Recall</style></link> a unit, grant me +2|+0.", "\"Oh, so you think I'm 'cute'? 'Fuzzy'?? Let's see how 'adorable' you find THIS!\"", "http://dd.b.pvp.net/Set1/en_us/img/cards/01IO008-full.png", 3, null, false, "Fae Bladetwirler", 1, 5, "01IO008", null, null, null, null },
                    { 21L, 2, "http://dd.b.pvp.net/Set1/en_us/img/cards/01IO045.png", true, 2, "<link=vocab.Support><style=Vocab>Support</style></link>: Give my supported ally <link=keyword.Lifesteal><sprite name=Lifesteal><style=Keyword>Lifesteal</style></link> this round.", @"""During winter's reign, we heard the tread of
                Footsteps 'cross the snowy floor. 
                In its wake, new vine and leaf emerged to rearrange
                The forest floor and herald season's change.""
                - Shon-Xan poem", "http://dd.b.pvp.net/Set1/en_us/img/cards/01IO045-full.png", 2, null, false, "Herald of Spring", 0, 5, "01IO045", null, null, null, null },
                    { 20L, 3, "http://dd.b.pvp.net/Set1/en_us/img/cards/01PZ018.png", true, 2, "", "How does she aim? That's an excellent question.", "http://dd.b.pvp.net/Set1/en_us/img/cards/01PZ018-full.png", 1, null, false, "Academy Prodigy", 0, 6, "01PZ018", null, null, null, null },
                    { 19L, 0, "http://dd.b.pvp.net/Set1/en_us/img/cards/01DE042T1.png", false, 3, @"Give an ally <link=keyword.Barrier><sprite name=Barrier><style=Keyword>Barrier</style></link> this round.
                Shuffle a <link=card.level1><style=AssociatedCard>Lux</style></link> into your deck.", "\"The world can turn its back on you when you're different. People say your differences make you weak--but they make us strong, compassionate. Even in the darkest times, I'll protect you!\" - Lux", "http://dd.b.pvp.net/Set1/en_us/img/cards/01DE042T1-full.png", 0, "Burst", false, "Lux's Prismatic Barrier", 4, 2, "01DE042T1", 1, null, null, null },
                    { 18L, 0, "http://dd.b.pvp.net/Set1/en_us/img/cards/01SI038.png", true, 3, "When another ally dies, deal 1 to the enemy Nexus.", "Her cruelest trick wasn't slaughtering the soldiers who trusted the cries of a little girl, but sowing doubt in the survivors  so they were sure to ignore the cries of their own daughters...", "http://dd.b.pvp.net/Set1/en_us/img/cards/01SI038-full.png", 3, null, false, "Phantom Prankster", 1, 4, "01SI038", null, null, null, null },
                    { 17L, 2, "http://dd.b.pvp.net/Set1/en_us/img/cards/01PZ056T10.png", false, 5, "When you cast a spell, create a <link=keyword.Fleeting><sprite name=Fleeting><style=Keyword>Fleeting</style></link> Upgraded Turret in hand.", "\"Mad scientist? Pft! I'm clearly a very-stable-if-slightly-disorganized-and-eclectic scientist, thank you very much!\"", "http://dd.b.pvp.net/Set1/en_us/img/cards/01PZ056T10-full.png", 4, "Imbue", false, "Heimerdinger", 4, 6, "01PZ056T10", null, null, null, null },
                    { 16L, 3, "http://dd.b.pvp.net/Set1/en_us/img/cards/01PZ007.png", true, 3, "<link=vocab.Support><style=Vocab>Support</style></link>: Shuffle 4 copies of the supported ally into your deck.", "The boom of the cannons drew crowds toward the plaza, eager to see the show. It would take them weeks to wash the last of the confetti from their hair.", "http://dd.b.pvp.net/Set1/en_us/img/cards/01PZ007-full.png", 3, null, false, "Parade Electrorig", 0, 6, "01PZ007", null, null, null, null },
                    { 15L, 0, "http://dd.b.pvp.net/Set1/en_us/img/cards/01NX004.png", true, 3, "Kill a unit with 3 or less Power.", "Everyone dies. The weak just die faster.", "http://dd.b.pvp.net/Set1/en_us/img/cards/01NX004-full.png", 0, "Fast", false, "Culling Strike", 1, 1, "01NX004", 2, null, null, null },
                    { 14L, 0, "http://dd.b.pvp.net/Set1/en_us/img/cards/01DE019.png", true, 2, "Reduce the cost of allies in hand by 1.", "\"From the fields to the front in a fortnight. This is what we expect from each and every able body in Demacia.\" - Garen", "http://dd.b.pvp.net/Set1/en_us/img/cards/01DE019-full.png", 0, "Burst", false, "Mobilize", 1, 2, "01DE019", 1, null, null, null },
                    { 24L, 0, "http://dd.b.pvp.net/Set1/en_us/img/cards/01FR006.png", true, 3, "Grant an ally and all allied copies of it EVERYWHERE +1|+1.", "\"We few are Iceborn, our bloodlines infused with the Freljord's magic. Our ancestors locked away an ancient evil, and now we few stand guard to defend against its return.\" - Gregor the Guardian", "http://dd.b.pvp.net/Set1/en_us/img/cards/01FR006-full.png", 0, "Burst", false, "Iceborn Legacy", 0, 3, "01FR006", 1, null, null, null },
                    { 13L, 3, "http://dd.b.pvp.net/Set1/en_us/img/cards/01PZ013.png", true, 6, "<link=vocab.Play><style=Vocab>Play</style></link>: Discard your hand. Draw 3. Deal 3 to anything.", "His dreams cost him his hands, yet he persisted. Nothing would stand in his way.", "http://dd.b.pvp.net/Set1/en_us/img/cards/01PZ013-full.png", 3, null, false, "Augmented Experimenter", 2, 6, "01PZ013", null, null, null, null },
                    { 11L, 2, "http://dd.b.pvp.net/Set1/en_us/img/cards/01IO020.png", true, 2, "When I'm summoned, give other allies +1|+0 this round.", "\"On this day, yours will become the face of discipline, training, humility, and balance. Today, you become Kinkou.\"", "http://dd.b.pvp.net/Set1/en_us/img/cards/01IO020-full.png", 3, null, false, "Keeper of Masks", 0, 5, "01IO020", null, null, null, null },
                    { 10L, 1, "http://dd.b.pvp.net/Set1/en_us/img/cards/01PZ056.png", true, 5, "When you cast a spell, create a <link=keyword.Fleeting><sprite name=Fleeting><style=Keyword>Fleeting</style></link> Turret in hand.", "\"Mad scientist? Pft! I'm clearly a very-stable-if-slightly-disorganized-and-eclectic scientist, thank you very much!\"", "http://dd.b.pvp.net/Set1/en_us/img/cards/01PZ056-full.png", 3, "Imbue", false, "Heimerdinger", 3, 6, "01PZ056", null, null, null, null },
                    { 9L, 5, "http://dd.b.pvp.net/Set1/en_us/img/cards/01IO015T1.png", false, 4, "When you <link=keyword.Stun><sprite name=Stunned><style=Keyword>Stun</style></link> or <link=keyword.Recall><style=Keyword>Recall</style></link> an enemy, I strike it.", "\"Death is like the wind... always by my side.\"", "http://dd.b.pvp.net/Set1/en_us/img/cards/01IO015T1-full.png", 4, null, false, "Yasuo", 4, 5, "01IO015T1", null, null, null, null },
                    { 8L, 3, "http://dd.b.pvp.net/Set1/en_us/img/cards/01DE022.png", true, 2, "", "\"World's full of monsters. If you're lucky, they're the ones you can see. The worst are the ones that stay under your skin.\"", "http://dd.b.pvp.net/Set1/en_us/img/cards/01DE022-full.png", 2, null, false, "Lucian", 3, 2, "01DE022", null, null, null, null },
                    { 7L, 2, "http://dd.b.pvp.net/Set1/en_us/img/cards/01PZ008T2.png", false, 1, "<link=vocab.Nexus Strike><style=Vocab>Nexus Strike</style></link>: Double the <link=card.shuffle><style=AssociatedCard>Poison Puffcap</style></link>s in the enemy deck.", "\"Bandle Scout Rule 154: Never fear the unknown! Rule 276: Denizens of the woodlands are our friends! Rule 354: If it's fuzzy, it might be safe to pet but certainly isn't safe to eat! Rule 417...\"", "http://dd.b.pvp.net/Set1/en_us/img/cards/01PZ008T2-full.png", 2, "Elusive", false, "Teemo", 4, 6, "01PZ008T2", null, null, null, null },
                    { 6L, 0, "http://dd.b.pvp.net/Set1/en_us/img/cards/01FR024T2.png", false, 0, "Deal 1 to all enemies.", "The storm that comes before the calm.", "http://dd.b.pvp.net/Set1/en_us/img/cards/01FR024T2-full.png", 0, "Skill", false, "Glacial Storm", 4, 3, "01FR024T2", null, null, null, null },
                    { 5L, 0, "http://dd.b.pvp.net/Set1/en_us/img/cards/01PZ040T3.png", false, 3, @"To play, discard 1. Deal 3 to anything.
                Shuffle a <link=card.level1><style=AssociatedCard>Jinx</style></link> into your deck.", "\"FIRE IN THE CABOODLE!\" - Jinx", "http://dd.b.pvp.net/Set1/en_us/img/cards/01PZ040T3-full.png", 0, "Fast", false, "Jinx's Get Excited!", 4, 6, "01PZ040T3", 2, null, null, null },
                    { 4L, 3, "http://dd.b.pvp.net/Set1/en_us/img/cards/01IO048T1.png", false, 3, "", "\"Oh, yes. The shadows of the Order will suit our new dark intentions.\"", "http://dd.b.pvp.net/Set1/en_us/img/cards/01IO048T1-full.png", 2, "Elusive", false, "Yusari the Slayer", 4, 5, "01IO048T1", null, null, null, null },
                    { 3L, 1, "http://dd.b.pvp.net/Set1/en_us/img/cards/01DE031.png", true, 3, "End of Round: Grant other allies +1|+1 if an ally died this round.", "\"Citizens, evil has taken the hour, but it will not win the day. Remember our fallen, and wear their memories like armor!\"", "http://dd.b.pvp.net/Set1/en_us/img/cards/01DE031-full.png", 4, null, false, "Dawnspeakers", 2, 2, "01DE031", null, null, null, null },
                    { 2L, 5, "http://dd.b.pvp.net/Set1/en_us/img/cards/01NX020T3.png", false, 3, "<link=vocab.Play><style=Vocab>Play</style></link> or <link=vocab.Strike><style=Vocab>Strike</style></link>: Create 2 <link=card.create><style=AssociatedCard>Spinning Axe</style></link> in hand.", "\"You want an autograph? Get in line, pal.\"", "http://dd.b.pvp.net/Set1/en_us/img/cards/01NX020T3-full.png", 4, "Overwhelm", false, "Draven", 4, 1, "01NX020T3", null, null, null, null },
                    { 12L, 0, "http://dd.b.pvp.net/Set1/en_us/img/cards/01FR039T1.png", false, 8, @"Grant an ally +8|+4.
                Shuffle a <link=card.level1><style=AssociatedCard>Tryndamere</style></link> into your deck.", "“I've been told I have a... temper.” - Tryndamere", "http://dd.b.pvp.net/Set1/en_us/img/cards/01FR039T1-full.png", 0, "Burst", false, "Tryndamere's Battle Fury", 4, 3, "01FR039T1", 1, null, null, null },
                    { 25L, 0, "http://dd.b.pvp.net/Set1/en_us/img/cards/01IO022.png", true, 1, "Give an ally <link=keyword.Elusive><sprite name=Elusive><style=Keyword>Elusive</style></link> this round.", "\"Stay hidden, and do not return until your task is finished.\" - Zed", "http://dd.b.pvp.net/Set1/en_us/img/cards/01IO022-full.png", 0, "Burst", false, "Ghost", 0, 5, "01IO022", 1, null, null, null },
                    { 26L, 1, "http://dd.b.pvp.net/Set1/en_us/img/cards/01FR022.png", true, 1, "When I'm summoned, grant the top 2 allies in your deck +1|+1.", "\"Three times our reavers reached Avarosan gates, and three time they were met with ready bows. What trickery warns them of our attacks?\" - Scarthane Steffen", "http://dd.b.pvp.net/Set1/en_us/img/cards/01FR022-full.png", 1, null, false, "Omen Hawk", 0, 3, "01FR022", null, null, null, null },
                    { 27L, 0, "http://dd.b.pvp.net/Set1/en_us/img/cards/01FR042.png", true, 6, "<link=keyword.Frostbite><sprite name=Frostbite><style=Keyword>Frostbite</style></link> 2 enemies. ", "\"You'd challenge me on my own lands? You're ill-prepared, little one.\" - Anivia", "http://dd.b.pvp.net/Set1/en_us/img/cards/01FR042-full.png", 0, "Burst", false, "Harsh Winds", 1, 3, "01FR042", 1, null, null, null },
                    { 50L, 0, "http://dd.b.pvp.net/Set1/en_us/img/cards/01PZ040T2.png", false, 2, "Deal 4 to the enemy nexus and 1 to all other enemies. <link=keyword.Fleeting><sprite name=Fleeting><style=Keyword>Fleeting</style></link>.", "\"See ya!\" - Jinx", "http://dd.b.pvp.net/Set1/en_us/img/cards/01PZ040T2-full.png", 0, "Slow;Fleeting", false, "Super Mega Death Rocket!", 4, 6, "01PZ040T2", 0, null, null, null },
                    { 49L, 9, "http://dd.b.pvp.net/Set1/en_us/img/cards/01DE052.png", true, 9, "<link=vocab.Play><style=Vocab>Play</style></link> or <style=VocabNoTooltip>Attack</style>: Give all allies <link=keyword.Barrier><sprite name=Barrier><style=Keyword>Barrier</style></link>.", @"""This formation is the basis of our tactics. It requires the faith of each soldier in their shield, and in the shields of their companions. So long as they stand, so too shall our realm."" - Garen
                ", "http://dd.b.pvp.net/Set1/en_us/img/cards/01DE052-full.png", 9, "Barrier", false, "Brightsteel Formation", 2, 2, "01DE052", null, null, null, null },
                    { 48L, 3, "http://dd.b.pvp.net/Set1/en_us/img/cards/01PZ025.png", true, 3, "When you cast a spell, plant 3 <link=card.shuffle><style=AssociatedCard>Poison Puffcap</style></link> on random cards in the enemy deck.", @"""These any good?""
                ""Of course! They're all top notch! Spoke to them myself!""
                ""Okay hand em--wait what?""
                ""Mmhmm! Getting married, this one!""
                ""How many have you had...?""
                ""--to a barnacle!""", "http://dd.b.pvp.net/Set1/en_us/img/cards/01PZ025-full.png", 3, "Imbue", false, "Puffcap Peddler", 0, 6, "01PZ025", null, null, null, null },
                    { 47L, 3, "http://dd.b.pvp.net/Set1/en_us/img/cards/01DE045.png", true, 3, "", "\"From arena to tournament, training ground to battleground, I long for a worthy opponent. I will not rest until I know I am the greatest.\"", "http://dd.b.pvp.net/Set1/en_us/img/cards/01DE045-full.png", 3, "Challenger", false, "Fiora", 3, 2, "01DE045", null, null, null, null },
                    { 46L, 0, "http://dd.b.pvp.net/Set1/en_us/img/cards/01NX013.png", true, 5, "<link=keyword.Stun><sprite name=Stunned><style=Keyword>Stun</style></link> an enemy. Give all allies +2|+0 this round.", "\"Any fool can throw overwhelming force at the enemy. It takes vision to conceal that force until the decisive moment.\" - Jericho Swain", "http://dd.b.pvp.net/Set1/en_us/img/cards/01NX013-full.png", 0, "Fast", false, "Decisive Maneuver", 1, 1, "01NX013", 2, null, null, null },
                    { 45L, 4, "http://dd.b.pvp.net/Set1/en_us/img/cards/01PZ040.png", true, 4, "", "\"It's all just fun and games until something gets blown up--then it's a PARTY!\"", "http://dd.b.pvp.net/Set1/en_us/img/cards/01PZ040-full.png", 3, null, false, "Jinx", 3, 6, "01PZ040", null, null, null, null },
                    { 44L, 0, "http://dd.b.pvp.net/Set1/en_us/img/cards/01DE017.png", true, 3, "If you have exactly 1 ally, grant it +3|+3.", "When others fail, it falls upon the shoulders of a true hero to find a path to victory.", "http://dd.b.pvp.net/Set1/en_us/img/cards/01DE017-full.png", 0, "Burst", false, "Stand Alone", 1, 2, "01DE017", 1, null, null, null },
                    { 43L, 7, "http://dd.b.pvp.net/Set1/en_us/img/cards/01DE012T1.png", false, 6, "Start of Round: Ready your attack.", "\"You think me rigid. Single-minded. Predictable. I am rigid, for nothing can sway me. I am single-minded, for I believe in Demacia. And I am predictable, for I will surely defeat you.”", "http://dd.b.pvp.net/Set1/en_us/img/cards/01DE012T1-full.png", 7, "Regeneration", false, "Garen", 4, 2, "01DE012T1", null, null, null, null },
                    { 42L, 5, "http://dd.b.pvp.net/Set1/en_us/img/cards/01IO041T1.png", false, 5, "When you play a spell, cast it again on the same targets.", "\"We'll bring peace to Ionia, whatever the cost.\"", "http://dd.b.pvp.net/Set1/en_us/img/cards/01IO041T1-full.png", 4, "Imbue", false, "Karma", 4, 5, "01IO041T1", null, null, null, null },
                    { 41L, 5, "http://dd.b.pvp.net/Set1/en_us/img/cards/01NX023.png", true, 5, "When I'm summoned, grant other Spider allies +2|+0.", "A single glance and you're hers. A single bite and you're theirs.", "http://dd.b.pvp.net/Set1/en_us/img/cards/01NX023-full.png", 3, null, false, "Arachnoid Host", 1, 1, "01NX023", null, null, null, null },
                    { 40L, 7, "http://dd.b.pvp.net/Set1/en_us/img/cards/01DE002.png", true, 7, "When I'm summoned, ready your attack.", "“Our House has bled for this realm. You’ll not throw away this family’s honor for a few tricks of light.”", "http://dd.b.pvp.net/Set1/en_us/img/cards/01DE002-full.png", 7, "Tough", false, "Tianna Crownguard", 2, 2, "01DE002", null, null, null, null },
                    { 39L, 2, "http://dd.b.pvp.net/Set1/en_us/img/cards/01DE034.png", true, 2, "When you summon an Elite, grant it +1|+1.", "Wars are won in the forge.", "http://dd.b.pvp.net/Set1/en_us/img/cards/01DE034-full.png", 2, null, false, "Battlesmith", 0, 2, "01DE034", null, null, null, null },
                    { 38L, 2, "http://dd.b.pvp.net/Set1/en_us/img/cards/01DE020.png", true, 2, "", "\"We didn't know who or what those creatures were. But we knew the faces of our fellow soldiers by our sides, and that was all we needed.\"", "http://dd.b.pvp.net/Set1/en_us/img/cards/01DE020-full.png", 2, "Tough", false, "Vanguard Defender", 0, 2, "01DE020", null, null, null, null },
                    { 37L, 3, "http://dd.b.pvp.net/Set1/en_us/img/cards/01FR018.png", true, 3, "When I strike a unit with 0 Power, I kill it.", "Predators of the northern reaches have learned that the easiest prey are those already crippled by winter's bite.", "http://dd.b.pvp.net/Set1/en_us/img/cards/01FR018-full.png", 2, "Challenger", false, "Rimefang Wolf", 1, 3, "01FR018", null, null, null, null },
                    { 36L, 2, "http://dd.b.pvp.net/Set1/en_us/img/cards/01IO040.png", true, 4, "", "\"Once, this place held our schools, our temples, our homes. Now, we are left to skulk about its shadow-infested ruins. Zed's Order has defiled the legacy of this sacred place--I will be sure they regret it.\"", "http://dd.b.pvp.net/Set1/en_us/img/cards/01IO040-full.png", 3, "Lifesteal;Elusive", false, "Kinkou Lifeblade", 0, 5, "01IO040", null, null, null, null },
                    { 35L, 6, "http://dd.b.pvp.net/Set1/en_us/img/cards/01NX038.png", true, 6, "", @"""An iron will and a titan's strength. There is no finer general to lead the Trifarian Legion."" - Jericho Swain
                ", "http://dd.b.pvp.net/Set1/en_us/img/cards/01NX038-full.png", 5, "Overwhelm", false, "Darius", 3, 1, "01NX038", null, null, null, null },
                    { 34L, 2, "http://dd.b.pvp.net/Set1/en_us/img/cards/01PZ019.png", true, 3, "When I'm summoned, refill your spell mana.", "Not everyone is cut out to further progress in Piltover immediately. Some need a little guidance--those who look at invention through the wrong lens, for instance.", "http://dd.b.pvp.net/Set1/en_us/img/cards/01PZ019-full.png", 2, null, false, "Eager Apprentice", 0, 6, "01PZ019", null, null, null, null },
                    { 33L, 2, "http://dd.b.pvp.net/Set1/en_us/img/cards/01SI023.png", true, 2, "When you summon an <link=keyword.Ephemeral><sprite name=Ephemeral><style=Keyword>Ephemeral</style></link> ally, grant it +1|+1.", "Only the fallen knew that she did not walk alone. Only they could see the countless companions she led down the path to lands beyond.", "http://dd.b.pvp.net/Set1/en_us/img/cards/01SI023-full.png", 3, null, false, "Soul Shepherd", 0, 4, "01SI023", null, null, null, null },
                    { 32L, 5, "http://dd.b.pvp.net/Set1/en_us/img/cards/01DE010.png", true, 5, "<link=keyword.Last Breath><sprite name=LastBreath><style=Keyword>Last Breath</style></link>: Create an Elite in hand.", "\"It takes a bold heart to trust their life to a silverwing, locked in combat far above solid ground. Bold, and highly durable.\" - Garen", "http://dd.b.pvp.net/Set1/en_us/img/cards/01DE010-full.png", 4, "Challenger", false, "Swiftwing Lancer", 1, 2, "01DE010", null, null, null, null },
                    { 31L, 7, "http://dd.b.pvp.net/Set1/en_us/img/cards/01SI057.png", true, 4, "To play me, kill 2 allies.", @"""Put 'em in the cage, tum-te-dum... 
                Pluck up every soul, one by one...
                Never let ‘em go, no! No sir…
                Else them spirits make quite a stir...""", "http://dd.b.pvp.net/Set1/en_us/img/cards/01SI057-full.png", 7, null, false, "Ancient Crocolith", 1, 4, "01SI057", null, null, null, null },
                    { 30L, 0, "http://dd.b.pvp.net/Set1/en_us/img/cards/01FR009.png", true, 3, "", @"“Papa, tell the one about Braum and his door!”
                ""Or when his fall split a mountain in two!""
                ""Oh! Whattabout when he saved the tavern from the rampaging yeti?!""", "http://dd.b.pvp.net/Set1/en_us/img/cards/01FR009-full.png", 5, "Challenger;Regeneration", false, "Braum", 3, 3, "01FR009", null, null, null, null },
                    { 29L, 0, "http://dd.b.pvp.net/Set1/en_us/img/cards/01SI053T1.png", false, 1, @"If an ally died this round, summon 2 <link=card.create><style=AssociatedCard>Spiderling</style></link>.
                Shuffle a <link=card.level1><style=AssociatedCard>Elise</style></link> into your deck.", "That creeping feeling on your skin isn't nearly as unsettling as the one underneath it.", "http://dd.b.pvp.net/Set1/en_us/img/cards/01SI053T1-full.png", 0, "Slow", false, "Elise's Crawling Sensation", 4, 4, "01SI053T1", 0, null, null, null },
                    { 28L, 0, "http://dd.b.pvp.net/Set1/en_us/img/cards/01SI049.png", true, 2, "Kill an ally to draw 2.", "\"I have erred. We were not meant to peer beyond the pale curtain. Whatever insight lingers there comes at far too great a cost.\" - Arie Wrence, Dauntless Vindicator", "http://dd.b.pvp.net/Set1/en_us/img/cards/01SI049-full.png", 0, "Burst", false, "Glimpse Beyond", 0, 4, "01SI049", 1, null, null, null },
                    { 103L, 2, "http://dd.b.pvp.net/Set1/en_us/img/cards/01NX030.png", true, 2, "When I survive damage, deal 2 to the enemy Nexus.", "\"Edvin! There you are, handsome. I was just thinking of you!\" \"Each of us can go, now…\" \"Escort me. I'll make it fun.\" \"Or nothing at all?\"", "http://dd.b.pvp.net/Set1/en_us/img/cards/01NX030-full.png", 3, null, false, "Crimson Disciple", 1, 1, "01NX030", null, null, null, null },
                    { 104L, 5, "http://dd.b.pvp.net/Set1/en_us/img/cards/01FR028.png", false, 1, "", @"Yetis? I just don't think they exi--AUGHHH!
                ", "http://dd.b.pvp.net/Set1/en_us/img/cards/01FR028-full.png", 5, null, false, "Enraged Yeti", 4, 3, "01FR028", null, null, null, null },
                    { 105L, 0, "http://dd.b.pvp.net/Set1/en_us/img/cards/01PZ010.png", true, 1, "Plant 5 <link=card.shuffle><style=AssociatedCard>Poison Puffcap</style></link> on random cards in the enemy deck.", "First is the soft thump as the puffcap pops. Next, searing, debilitating pain. Finally, the distant sound of giggles...", "http://dd.b.pvp.net/Set1/en_us/img/cards/01PZ010-full.png", 0, "Burst", false, "Mushroom Cloud", 0, 6, "01PZ010", 1, null, null, null },
                    { 106L, 2, "http://dd.b.pvp.net/Set1/en_us/img/cards/01NX007.png", true, 2, "<style=VocabNoTooltip>Attack</style>: Give other battling allies +1|+0 this round.", "He roared with glee. For a moment, the heart of the arena pulsed in time with his and the excitement of the assembled masses was clutched in his triumphant hand.", "http://dd.b.pvp.net/Set1/en_us/img/cards/01NX007-full.png", 1, null, false, "Arena Battlecaster", 1, 1, "01NX007", null, null, null, null },
                    { 181L, 0, "http://dd.b.pvp.net/Set1/en_us/img/cards/01DE033.png", true, 6, "Costs 1 less for each ally that died this round. Summon a random 5 cost follower from Demacia.", "\"Today we rise to right the injustices that felled those before us. The sacrifices of our comrades were not in vain.\" - Radiant Guardian", "http://dd.b.pvp.net/Set1/en_us/img/cards/01DE033-full.png", 0, "Slow", false, "Remembrance", 1, 2, "01DE033", 0, null, null, null },
                    { 180L, 0, "http://dd.b.pvp.net/Set1/en_us/img/cards/01FR019.png", true, 7, "Kill all enemies with 0 Power, then <link=keyword.Frostbite><sprite name=Frostbite><style=Keyword>Frostbite</style></link> all enemies.", "Warmother Winter is the first and last foe faced by any who would invade the Freljord. Her bloodsworn are the merciless wind and the biting frost.", "http://dd.b.pvp.net/Set1/en_us/img/cards/01FR019-full.png", 0, "Slow", false, "Winter's Breath", 2, 3, "01FR019", 0, null, null, null },
                    { 179L, 0, "http://dd.b.pvp.net/Set1/en_us/img/cards/01PZ056T3.png", false, 8, @"Draw 3, then reduce their cost by 1.
                Shuffle a <link=card.level1><style=AssociatedCard>Heimerdinger</style></link> into your deck.", @"PROGRESS DAY!
                Celebrate at the PLAZA OF THE SUN GATES!
                See HEXTECH WONDERS!
                Gasp at the DARING PORO!
                Hear the MAN OF TOMORROW speak on the STATE OF TODAY!
                FREE entry! 
                Piltovan children welcome!", "http://dd.b.pvp.net/Set1/en_us/img/cards/01PZ056T3-full.png", 0, "Burst", false, "Heimerdinger's Progress Day!", 4, 6, "01PZ056T3", 1, null, null, null },
                    { 178L, 0, "http://dd.b.pvp.net/Set1/en_us/img/cards/01IO018.png", true, 1, "Give an ally +1|+0 and <link=keyword.Quick Strike><sprite name=QuickStrike><style=Keyword>Quick Attack</style></link> this round.", "Combat is merely a race to take the life of another before they take yours.", "http://dd.b.pvp.net/Set1/en_us/img/cards/01IO018-full.png", 0, "Burst", false, "Rush", 0, 5, "01IO018", 1, null, null, null },
                    { 177L, 1, "http://dd.b.pvp.net/Set1/en_us/img/cards/01SI043.png", true, 1, "<link=keyword.Last Breath><sprite name=LastBreath><style=Keyword>Last Breath</style></link>: Summon a <link=card.summon><style=AssociatedCard>Spiderling</style></link>.", "\"L-Lady Elise? Where... where did you go?\"", "http://dd.b.pvp.net/Set1/en_us/img/cards/01SI043-full.png", 1, null, false, "Hapless Aristocrat", 0, 4, "01SI043", null, null, null, null },
                    { 176L, 0, "http://dd.b.pvp.net/Set1/en_us/img/cards/01SI034.png", true, 2, "If an ally died this round, deal 3 to an enemy unit.", "\"Our spear sings for the fallen.\" - Kalista", "http://dd.b.pvp.net/Set1/en_us/img/cards/01SI034-full.png", 0, "Fast", false, "Black Spear", 0, 4, "01SI034", 2, null, null, null },
                    { 175L, 2, "http://dd.b.pvp.net/Set1/en_us/img/cards/01SI031.png", true, 3, "<style=VocabNoTooltip>Attack</style>: Grant me +1|+0 for each other <link=keyword.Ephemeral><sprite name=Ephemeral><style=Keyword>Ephemeral</style></link> ally.", "In death, as in life, he bellows the twisted, dark command. And in death, as in life, Hecarim's loyal knights answer, charging forth to slaughter.", "http://dd.b.pvp.net/Set1/en_us/img/cards/01SI031-full.png", 4, "Fearsome", false, "Iron Harbinger", 1, 4, "01SI031", null, null, null, null },
                    { 174L, 0, "http://dd.b.pvp.net/Set1/en_us/img/cards/01PZ057.png", true, 2, "Summon 2 <link=card.summon><style=AssociatedCard>Scrap Scuttler</style></link>.", "Two gentle creatures, once separated by an impassable lane of land, were finally brought together in the tepid waters of the Sump.", "http://dd.b.pvp.net/Set1/en_us/img/cards/01PZ057-full.png", 0, "Slow", false, "Scrapdash Assembly", 0, 6, "01PZ057", 0, null, null, null },
                    { 173L, 3, "http://dd.b.pvp.net/Set1/en_us/img/cards/01FR013.png", true, 6, "When I survive damage, grant me +3|+0.", "\"I would die shivering in the cold before sharing a hearth with Ashe's weaklings. But if they desire warmth, I will give it to them.”", "http://dd.b.pvp.net/Set1/en_us/img/cards/01FR013-full.png", 8, "Overwhelm", false, "Scarmother Vrynna", 2, 3, "01FR013", null, null, null, null },
                    { 172L, 4, "http://dd.b.pvp.net/Set1/en_us/img/cards/01NX042T2.png", false, 4, @"<link=vocab.Play><style=Vocab>Play</style></link>: Ready our attack.
                <link=vocab.Strike><style=Vocab>Strike</style></link>: <link=keyword.Recall><style=Keyword>Recall</style></link> me.", "\"No sir! Just a flash of red. Next thing I know, I look up and it... it was like a slaughterhouse in there.\" - Demacian Border Guard", "http://dd.b.pvp.net/Set1/en_us/img/cards/01NX042T2-full.png", 3, null, false, "Katarina", 4, 1, "01NX042T2", null, null, null, null },
                    { 182L, 3, "http://dd.b.pvp.net/Set1/en_us/img/cards/01SI009.png", true, 2, "<link=vocab.Support><style=Vocab>Support</style></link>: Grant my supported ally +2|+0 and <link=keyword.Ephemeral><sprite name=Ephemeral><style=Keyword>Ephemeral</style></link>.", "Some look at the Ruination and only see the destruction and misery. Others see the glass half full.", "http://dd.b.pvp.net/Set1/en_us/img/cards/01SI009-full.png", 2, null, false, "Stirred Spirits", 0, 4, "01SI009", null, null, null, null },
                    { 171L, 0, "http://dd.b.pvp.net/Set1/en_us/img/cards/01PZ001.png", true, 1, @"To play, discard 2.
                Draw 2.", "\"Oooooh, boy--FIVE ENFORCERS AND A GOLEM? Waitaminute! I have just the thing! Soooooomewhere...\" - Jinx", "http://dd.b.pvp.net/Set1/en_us/img/cards/01PZ001-full.png", 0, "Burst", false, "Rummage", 0, 6, "01PZ001", 1, null, null, null },
                    { 169L, 2, "http://dd.b.pvp.net/Set1/en_us/img/cards/01SI012.png", true, 1, "<link=vocab.Play><style=Vocab>Play</style></link>: Grant an ally in hand <link=keyword.Ephemeral><sprite name=Ephemeral><style=Keyword>Ephemeral</style></link> and reduce its cost by 1.", "Oh, the poor lad...", "http://dd.b.pvp.net/Set1/en_us/img/cards/01SI012-full.png", 1, null, false, "Oblivious Islander", 0, 4, "01SI012", null, null, null, null },
                    { 168L, 3, "http://dd.b.pvp.net/Set1/en_us/img/cards/01NX014.png", true, 4, "I deal double damage to the Nexus.", "\"He said what?! That man has bricks for brains. Can't fault those shoulders, though...\"", "http://dd.b.pvp.net/Set1/en_us/img/cards/01NX014-full.png", 3, null, false, "Shiraza the Blade", 2, 1, "01NX014", null, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "CardId", "Attack", "CardVisualLink", "Collectable", "Cost", "Description", "FlavorText", "FullArtworkLink", "Health", "KeywordsRefs", "Legacy", "Name", "Rarity", "RegionRef", "RiotId", "SpellSpeed", "SubType", "SuperType", "Type" },
                values: new object[,]
                {
                    { 167L, 0, "http://dd.b.pvp.net/Set1/en_us/img/cards/01FR030.png", true, 1, "<link=keyword.Frostbite><sprite name=Frostbite><style=Keyword>Frostbite</style></link> an enemy with 3 or less Health.", "\"Chilly? Ha! Let us hope that your spirits are sturdier than your summerland steel!\" - Braum", "http://dd.b.pvp.net/Set1/en_us/img/cards/01FR030-full.png", 0, "Burst", false, "Brittle Steel", 0, 3, "01FR030", 1, null, null, null },
                    { 166L, 4, "http://dd.b.pvp.net/Set1/en_us/img/cards/01NX029.png", true, 4, "When another ally survives damage, grant it +1|+0.", "He returned from the war on the brink of death, restored only by his husband's touch and the apothecary's balms. Noxus spared no expense to ensure his expert counsel, long after his fighting years.", "http://dd.b.pvp.net/Set1/en_us/img/cards/01NX029-full.png", 5, null, false, "Legion Veteran", 2, 1, "01NX029", null, null, null, null },
                    { 165L, 2, "http://dd.b.pvp.net/Set1/en_us/img/cards/01PZ059.png", true, 3, "", "KILL. CRUSH. DESTROY. REPEAT.", "http://dd.b.pvp.net/Set1/en_us/img/cards/01PZ059-full.png", 5, null, false, "Golden Crushbot", 0, 6, "01PZ059", null, null, null, null },
                    { 164L, 0, "http://dd.b.pvp.net/Set1/en_us/img/cards/01NX006T2.png", false, 0, "For each attacking ally other than <link=card.vlad><style=AssociatedCard>Vladimir</style></link>, deal 1 to it and 1 to the enemy Nexus.", "\"Delicious.\" - Vladimir", "http://dd.b.pvp.net/Set1/en_us/img/cards/01NX006T2-full.png", 0, "Skill", false, "Crimson Pact", 4, 1, "01NX006T2", null, null, null, null },
                    { 163L, 0, "http://dd.b.pvp.net/Set1/en_us/img/cards/01NX054.png", true, 5, "<link=keyword.Stun><sprite name=Stunned><style=Keyword>Stun</style></link> all enemies with 4 or less Power.", "“He’s taking a deep breath - we might get a - yes, there we have it, folks! That’s Thunder’s famous war cry! We’re all shaking in our boots out here, Thuuuunder!” - Arena Battlecaster", "http://dd.b.pvp.net/Set1/en_us/img/cards/01NX054-full.png", 0, "Fast", false, "Intimidating Roar", 1, 1, "01NX054", 2, null, null, null },
                    { 162L, 7, "http://dd.b.pvp.net/Set1/en_us/img/cards/01FR026.png", true, 6, "", "The power of a warhorse, the thoughtless savagery of a cat.", "http://dd.b.pvp.net/Set1/en_us/img/cards/01FR026-full.png", 6, "Overwhelm", false, "Alpha Wildclaw", 0, 3, "01FR026", null, null, null, null },
                    { 161L, 3, "http://dd.b.pvp.net/Set1/en_us/img/cards/01SI051.png", true, 5, "When an ally dies, refill your spell mana.", "He toiled night and day, perfecting his composition. Then, in the blink of an eye, a dark silence blew through him. Others screamed and ran for their lives. He noticed nothing.", "http://dd.b.pvp.net/Set1/en_us/img/cards/01SI051-full.png", 4, null, false, "Tortured Prodigy", 1, 4, "01SI051", null, null, null, null },
                    { 160L, 3, "http://dd.b.pvp.net/Set1/en_us/img/cards/01SI024.png", false, 2, "", "No longer bound by flesh, rider and beast became one, determined to race mindlessly into battles they no longer understood.", "http://dd.b.pvp.net/Set1/en_us/img/cards/01SI024-full.png", 2, "Ephemeral", false, "Spectral Rider", 4, 4, "01SI024", null, null, null, null },
                    { 170L, 0, "http://dd.b.pvp.net/Set1/en_us/img/cards/01SI052T2.png", false, 4, @"Enemies have -1|-0 this round. When the enemy summons a unit this round, deal 4 to it.
                Shuffle a <link=card.level1><style=AssociatedCard>Thresh</style></link> into deck.", "\"Nobody escapes.\" - Thresh", "http://dd.b.pvp.net/Set1/en_us/img/cards/01SI052T2-full.png", 0, "Burst", false, "Thresh's The Box", 4, 4, "01SI052T2", 1, null, null, null },
                    { 183L, 0, "http://dd.b.pvp.net/Set1/en_us/img/cards/01PZ027.png", true, 0, @"To play, spend all your mana.
                <style=Variable>Deal that much to a unit.</style>", "\"We've exhausted both our time and funds, and though the beam works, we haven't been able to regulate its energy consumption.\" - Zaunite Experimenter", "http://dd.b.pvp.net/Set1/en_us/img/cards/01PZ027-full.png", 0, "Slow", false, "Thermogenic Beam", 1, 6, "01PZ027", 0, null, null, null },
                    { 184L, 4, "http://dd.b.pvp.net/Set1/en_us/img/cards/01DE045T1.png", false, 3, "When I've killed 4 enemies and survived, you win the game. <style=Variable></style>", "\"From arena to tournament, training ground to battleground, I long for a worthy opponent. I will not rest until I know I am the greatest.\"", "http://dd.b.pvp.net/Set1/en_us/img/cards/01DE045T1-full.png", 4, "Challenger", false, "Fiora", 4, 2, "01DE045T1", null, null, null, null },
                    { 185L, 5, "http://dd.b.pvp.net/Set1/en_us/img/cards/01FR041.png", true, 5, "When I'm summoned, grant allies in your deck +1|+1.", "\"Many tribes under one banner! Perhaps one day all the Freljord will fight side by side.\"", "http://dd.b.pvp.net/Set1/en_us/img/cards/01FR041-full.png", 6, null, false, "Avarosan Hearthguard", 2, 3, "01FR041", null, null, null, null },
                    { 208L, 1, "http://dd.b.pvp.net/Set1/en_us/img/cards/01PZ055.png", true, 1, "When you draw a card, give me +1|+0 this round.", "Imagination is the spark of great invention. Yet, it is research that makes the spark a conflagration.", "http://dd.b.pvp.net/Set1/en_us/img/cards/01PZ055-full.png", 2, null, false, "Astute Academic", 0, 6, "01PZ055", null, null, null, null },
                    { 207L, 2, "http://dd.b.pvp.net/Set1/en_us/img/cards/01IO036.png", true, 2, "<link=vocab.Strike><style=Vocab>Strike</style></link>: Reduce the cost of the most expensive unit in your hand by 1.", "\"Patrol, we've one... no... TWO massive furry creatures coming our way! Call for ba--Oh. Hold on. Scope's wrong way 'round again...\"", "http://dd.b.pvp.net/Set1/en_us/img/cards/01IO036-full.png", 1, null, false, "Greenglade Lookout", 0, 5, "01IO036", null, null, null, null },
                    { 206L, 2, "http://dd.b.pvp.net/Set1/en_us/img/cards/01DE011.png", true, 3, "", "\"He did WHAT? I entrusted him with Pierre de Guillard's priceless dual-balanced sabre! He said it was only to be used for training!\" - Laurent Bladekeeper", "http://dd.b.pvp.net/Set1/en_us/img/cards/01DE011-full.png", 4, "Challenger", false, "Laurent Protege", 0, 2, "01DE011", null, null, null, null },
                    { 205L, 0, "http://dd.b.pvp.net/Set1/en_us/img/cards/01SI001.png", true, 7, "Kill a unit.", "The betrayed invoke Kalista on their dying breath, hoping her spear brings them vengeance.", "http://dd.b.pvp.net/Set1/en_us/img/cards/01SI001-full.png", 0, "Fast", false, "Vengeance", 0, 4, "01SI001", 2, null, null, null },
                    { 204L, 2, "http://dd.b.pvp.net/Set1/en_us/img/cards/01DE004.png", true, 4, "When I'm summoned, summon an exact copy of me.", "They fell from the clouds like silvery bolts of lightning, swift and sure as they dove toward their targets. Then, as suddenly as they appeared, they were gone. ", "http://dd.b.pvp.net/Set1/en_us/img/cards/01DE004-full.png", 1, "Challenger", false, "Silverwing Vanguard", 1, 2, "01DE004", null, null, null, null },
                    { 203L, 3, "http://dd.b.pvp.net/Set1/en_us/img/cards/01NX017.png", true, 2, "<link=vocab.Support><style=Vocab>Support</style></link>: Give my supported ally <link=keyword.Quick Strike><sprite name=QuickStrike><style=Keyword>Quick Attack</style></link> this round.", "The Legion spread the empire's reach with every beat of her drum. Nothing could stop them. Nothing did.", "http://dd.b.pvp.net/Set1/en_us/img/cards/01NX017-full.png", 2, null, false, "Legion Drummer", 0, 1, "01NX017", null, null, null, null },
                    { 202L, 4, "http://dd.b.pvp.net/Set1/en_us/img/cards/01NX010.png", true, 5, "<link=vocab.Play><style=Vocab>Play</style></link>: Grant me +1|+1 for each unit you've <link=keyword.Stun><sprite name=Stunned><style=Keyword>Stunned</style></link> or <link=keyword.Recall><style=Keyword>Recalled</style></link> this game. <style=Variable></style>", "All Noxians know the three Principles of Strength, but if a soldier is to rise through the ranks, they must learn to master them.", "http://dd.b.pvp.net/Set1/en_us/img/cards/01NX010-full.png", 4, "Fearsome", false, "Legion General", 0, 1, "01NX010", null, null, null, null },
                    { 201L, 3, "http://dd.b.pvp.net/Set1/en_us/img/cards/01SI056.png", true, 3, "When I'm summoned, give other allied Spiders +1|+0 and enemies -1|-0 this round.", "\"They can spin a web the size of a man in less than a minute... would you like a demonstration?\" - Elise", "http://dd.b.pvp.net/Set1/en_us/img/cards/01SI056-full.png", 3, "Fearsome", false, "Frenzied Skitterer", 1, 4, "01SI056", null, null, null, null },
                    { 200L, 4, "http://dd.b.pvp.net/Set1/en_us/img/cards/01IO016.png", true, 6, "<link=vocab.Play><style=Vocab>Play</style></link>: Create an exact copy of a card in hand.", "\"As the warrior wept for his loss, the elder consoled him: 'Seek the sage of the skies. Only he can return that which is lost to this world, but still held in memory.'\" - Saga of the First Lands", "http://dd.b.pvp.net/Set1/en_us/img/cards/01IO016-full.png", 4, null, false, "Zephyr Sage", 1, 5, "01IO016", null, null, null, null },
                    { 199L, 0, "http://dd.b.pvp.net/Set1/en_us/img/cards/01NX002.png", true, 5, "Deal 4 to the enemy Nexus.", "\"Sometimes, it takes tactical genius to break a fortress. Sometimes, you just have to hit it harder.\" - Darius", "http://dd.b.pvp.net/Set1/en_us/img/cards/01NX002-full.png", 0, "Slow", false, "Decimate", 1, 1, "01NX002", 0, null, null, null },
                    { 198L, 3, "http://dd.b.pvp.net/Set1/en_us/img/cards/01NX037.png", true, 2, "<link=keyword.Last Breath><sprite name=LastBreath><style=Keyword>Last Breath</style></link>: Deal 2 to the enemy Nexus.", "Every Noxian is taught that a life spent in service to the empire is well spent, but few spend their lives as spectacularly as the Legion's grenadiers.", "http://dd.b.pvp.net/Set1/en_us/img/cards/01NX037-full.png", 1, null, false, "Legion Grenadier", 0, 1, "01NX037", null, null, null, null },
                    { 197L, 0, "http://dd.b.pvp.net/Set1/en_us/img/cards/01SI030T1.png", false, 2, @"If an ally died this round, deal 3 to an enemy unit.
                Shuffle a <link=card.level1><style=AssociatedCard>Kalista</style></link> into your deck.", "\"Our spear sings for the fallen.\" - Kalista", "http://dd.b.pvp.net/Set1/en_us/img/cards/01SI030T1-full.png", 0, "Fast", false, "Kalista's Black Spear", 4, 4, "01SI030T1", 2, null, null, null },
                    { 196L, 0, "http://dd.b.pvp.net/Set1/en_us/img/cards/01IO056T1.png", false, 0, "<link=keyword.Stun><sprite name=Stunned><style=Keyword>Stun</style></link> 2 enemies.", "\"Stand aside. I have come for the Unforgiven.\" - Yone, Windchaser", "http://dd.b.pvp.net/Set1/en_us/img/cards/01IO056T1-full.png", 0, "Skill", false, "Staggering Strikes", 4, 5, "01IO056T1", null, null, null, null },
                    { 195L, 2, "http://dd.b.pvp.net/Set1/en_us/img/cards/01DE030.png", true, 4, "", "Arrows rained down from the fortress walls in droves, but none could touch that fleck of silver darting through the sky. ", "http://dd.b.pvp.net/Set1/en_us/img/cards/01DE030-full.png", 3, "Elusive;Tough", false, "Silverwing Scout", 0, 2, "01DE030", null, null, null, null },
                    { 194L, 0, "http://dd.b.pvp.net/Set1/en_us/img/cards/01NX043.png", true, 1, "Deal 1 to anything.", "\"In the right hands, a blade can cut through anything... and I do mean anything.\" - Katarina", "http://dd.b.pvp.net/Set1/en_us/img/cards/01NX043-full.png", 0, "Fast", false, "Blade's Edge", 0, 1, "01NX043", 2, null, null, null },
                    { 193L, 2, "http://dd.b.pvp.net/Set1/en_us/img/cards/01DE056.png", true, 4, "<style=VocabNoTooltip>Attack</style>: Grant me +2|+2.", "The battle cry sounds, and my feet are already turning over the soil. I need nothing but my lady's order to know my destiny and enact her will.", "http://dd.b.pvp.net/Set1/en_us/img/cards/01DE056-full.png", 2, null, false, "Vanguard Firstblade", 0, 2, "01DE056", null, null, null, null },
                    { 192L, 1, "http://dd.b.pvp.net/Set1/en_us/img/cards/01DE046.png", true, 2, "", "Just because it's quiet, doesn't mean it's safe.", "http://dd.b.pvp.net/Set1/en_us/img/cards/01DE046-full.png", 4, null, false, "Border Lookout", 0, 2, "01DE046", null, null, null, null },
                    { 191L, 1, "http://dd.b.pvp.net/Set1/en_us/img/cards/01SI007T1.png", false, 1, "", "...each spirit another victim of the relic's allure. They seethe in silence as they await the arrival of the next greedy fool.", "http://dd.b.pvp.net/Set1/en_us/img/cards/01SI007T1-full.png", 1, "Ephemeral", false, "Unleashed Spirit", 4, 4, "01SI007T1", null, null, null, null },
                    { 190L, 1, "http://dd.b.pvp.net/Set1/en_us/img/cards/01DE024.png", true, 1, "<link=keyword.Last Breath><sprite name=LastBreath><style=Keyword>Last Breath</style></link>: Create in hand a 6+ cost spell from a faction other than Demacia.", "\"Arcane items have undeniable intrigue. But these objects of power are best left to the capable hands of our experts, and away from the well-meaning ignorance of our citizens.\" - Mageseeker's Handbook", "http://dd.b.pvp.net/Set1/en_us/img/cards/01DE024-full.png", 1, null, false, "Mageseeker Conservator", 0, 2, "01DE024", null, null, null, null },
                    { 189L, 3, "http://dd.b.pvp.net/Set1/en_us/img/cards/01NX012.png", true, 1, "", "In Noxus, where soldiers are revered for their audacity on the battlefield, rearguard duty is nothing short of a punishment.", "http://dd.b.pvp.net/Set1/en_us/img/cards/01NX012-full.png", 2, "CantBlock", false, "Legion Rearguard", 0, 1, "01NX012", null, null, null, null },
                    { 188L, 6, "http://dd.b.pvp.net/Set1/en_us/img/cards/01DE042T2.png", false, 5, "<style=VocabNoTooltip>Attack</style>: Create a <link=keyword.Fleeting><sprite name=Fleeting><style=Keyword>Fleeting</style></link> <link=card.warcry><style=AssociatedCard>Final Spark</style></link> in hand.", "\"I've always known there's something different about me... a light from within. I'm not sure what is it, but I have to find out!\" ", "http://dd.b.pvp.net/Set1/en_us/img/cards/01DE042T2-full.png", 4, "Barrier", false, "Lux", 4, 2, "01DE042T2", null, null, null, null },
                    { 187L, 3, "http://dd.b.pvp.net/Set1/en_us/img/cards/01FR025.png", true, 4, "When I'm summoned, draw 2 Poros if you have a Poro ally.", @"A herd needs just two things: love, and company. Anything else is just fluff.
                ", "http://dd.b.pvp.net/Set1/en_us/img/cards/01FR025-full.png", 4, null, false, "Poro Herder", 1, 3, "01FR025", null, null, null, null },
                    { 186L, 8, "http://dd.b.pvp.net/Set1/en_us/img/cards/01NX051.png", true, 8, "<link=vocab.Play><style=Vocab>Play</style></link>: Replace your hand with <link=card.Devastate><style=AssociatedCard>Decimate</style></link>s.", "Deep in Zaun's Sump, young Benn Farron was labeled a menace. Unstable. Unacceptable. In the ranks of Noxus he was embraced. Awarded. Unstoppable.", "http://dd.b.pvp.net/Set1/en_us/img/cards/01NX051-full.png", 8, "Overwhelm", false, "Captain Farron", 2, 1, "01NX051", null, null, null, null },
                    { 159L, 0, "http://dd.b.pvp.net/Set1/en_us/img/cards/01PZ031.png", true, 4, @"Deal 1 to two enemies.
                Draw 1.", "\"And that's how we discovered arc discharge! Of course, my predecessor had hypothesized such an event, but underestimated the arc's reach. Poor fellow...\" - Heimerdinger", "http://dd.b.pvp.net/Set1/en_us/img/cards/01PZ031-full.png", 0, "Fast", false, "Statikk Shock", 1, 6, "01PZ031", 2, null, null, null },
                    { 419L, 3, "http://dd.b.pvp.net/Set1/en_us/img/cards/01SI055.png", true, 6, "", "\"As our ships near those haunted lands, I ponder this: did those nightmarish creations originate on these twisted shores? Did they ever truly live?\" - Arie Wrence, Demacian Soldier", "http://dd.b.pvp.net/Set1/en_us/img/cards/01SI055-full.png", 7, "Lifesteal", false, "Soulgorger", 1, 4, "01SI055", null, null, null, null },
                    { 158L, 4, "http://dd.b.pvp.net/Set1/en_us/img/cards/01IO013.png", true, 1, "", "\"What would you sacrifice for power? Your path begins with an oath, and ends only when it has taken all you have to give.\" - Zed", "http://dd.b.pvp.net/Set1/en_us/img/cards/01IO013-full.png", 3, "Ephemeral", false, "Shadow Fiend", 0, 5, "01IO013", null, null, null, null },
                    { 156L, 0, "http://dd.b.pvp.net/Set1/en_us/img/cards/01SI036.png", true, 1, "If an ally died this round, summon 2 <link=card.create><style=AssociatedCard>Spiderling</style></link>.", "That creeping feeling on your skin isn't nearly as unsettling as the one underneath it.", "http://dd.b.pvp.net/Set1/en_us/img/cards/01SI036-full.png", 0, "Slow", false, "Crawling Sensation", 0, 4, "01SI036", 0, null, null, null },
                    { 128L, 2, "http://dd.b.pvp.net/Set1/en_us/img/cards/01IO057.png", true, 3, "When I'm summoned, draw 1.", @"Gracefully she glides
                Noiseless steps in the shadows
                Her claws the only trace.", "http://dd.b.pvp.net/Set1/en_us/img/cards/01IO057-full.png", 2, "Elusive", false, "Shadow Assassin", 0, 5, "01IO057", null, null, null, null },
                    { 127L, 2, "http://dd.b.pvp.net/Set1/en_us/img/cards/01NX009.png", true, 4, "When I'm summoned, grant me +1|+1 for each other ally you have.", "Some reckoners are adored for their charisma. Others, for their swift technique. Vessid possesses neither, but no one turns a rival to splatter with more efficiency.", "http://dd.b.pvp.net/Set1/en_us/img/cards/01NX009-full.png", 2, "Overwhelm", false, "Crowd Favorite", 1, 1, "01NX009", null, null, null, null },
                    { 126L, 1, "http://dd.b.pvp.net/Set1/en_us/img/cards/01SI037.png", true, 1, "", "I mean, there are worse ways to die.", "http://dd.b.pvp.net/Set1/en_us/img/cards/01SI037-full.png", 1, "Fearsome", false, "Sinister Poro", 0, 4, "01SI037", null, null, null, null },
                    { 125L, 1, "http://dd.b.pvp.net/Set1/en_us/img/cards/01FR014.png", true, 1, "<link=keyword.Last Breath><sprite name=LastBreath><style=Keyword>Last Breath</style></link>: Shuffle 2 <link=card.create><style=AssociatedCard>Enraged Yeti</style></link> into our deck.", "\"It was so tiny and peaceful! Hard to believe it would grow up to be... well... a yeti.\" - Avarosan Trapper", "http://dd.b.pvp.net/Set1/en_us/img/cards/01FR014-full.png", 2, null, false, "Yeti Yearling", 0, 3, "01FR014", null, null, null, null },
                    { 124L, 2, "http://dd.b.pvp.net/Set1/en_us/img/cards/01IO028.png", true, 3, "<link=vocab.Play><style=Vocab>Play</style></link>: I am 5|2 or 2|5.", "One of the oldest inhabitants of the Greenglade, it has withstood the test of time through constant adaptation.", "http://dd.b.pvp.net/Set1/en_us/img/cards/01IO028-full.png", 2, null, false, "Scaled Snapper", 0, 5, "01IO028", null, null, null, null },
                    { 123L, 0, "http://dd.b.pvp.net/Set1/en_us/img/cards/01PZ046.png", true, 1, "Pick a card in hand. Shuffle 4 exact copies of it into your deck.", "Imitation is the sincerest form of thievery.", "http://dd.b.pvp.net/Set1/en_us/img/cards/01PZ046-full.png", 0, "Burst", false, "Counterfeit Copies", 1, 6, "01PZ046", 1, null, null, null },
                    { 122L, 0, "http://dd.b.pvp.net/Set1/en_us/img/cards/01FR020.png", true, 4, "Deal 2 to EVERYTHING.", "The soul of every avalanche is a pebble that would not stay put.", "http://dd.b.pvp.net/Set1/en_us/img/cards/01FR020-full.png", 0, "Slow", false, "Avalanche", 1, 3, "01FR020", 0, null, null, null },
                    { 121L, 3, "http://dd.b.pvp.net/Set1/en_us/img/cards/01NX021.png", true, 3, "<style=VocabNoTooltip>Attack</style>: Grant allied Legion Marauders EVERYWHERE +1|+1.", "The Trifarian Legion is trailed by opportunistic brigands who prey on the weak and injured in its wake.", "http://dd.b.pvp.net/Set1/en_us/img/cards/01NX021-full.png", 2, null, false, "Legion Marauder", 0, 1, "01NX021", null, null, null, null },
                    { 120L, 1, "http://dd.b.pvp.net/Set1/en_us/img/cards/01PZ020.png", true, 1, "", "Her first launch was pure accident: she slipped inside a Progress Day cannon while preening herself. Now she's the toast of Piltover, arcing across the sky to the adoring gasps of the crowds below.", "http://dd.b.pvp.net/Set1/en_us/img/cards/01PZ020-full.png", 1, "Elusive", false, "Daring Poro", 0, 6, "01PZ020", null, null, null, null },
                    { 119L, 3, "http://dd.b.pvp.net/Set1/en_us/img/cards/01DE001.png", true, 4, "<link=vocab.Allegiance><style=Vocab>Allegiance</style></link>: Grant all allies +1|+1.", "\"You must understand the weight of our banner. It flies for our king, our houses, our citizens. It is our unwavering belief in Demacia itself. Hold it high. Show them our pride.\" - Tianna Crownguard ", "http://dd.b.pvp.net/Set1/en_us/img/cards/01DE001-full.png", 3, null, false, "Vanguard Bannerman", 1, 2, "01DE001", null, null, null, null },
                    { 129L, 5, "http://dd.b.pvp.net/Set1/en_us/img/cards/01IO028T2.png", false, 3, "", "One of the oldest inhabitants of the Greenglade, it has withstood the test of time through constant adaptation.", "http://dd.b.pvp.net/Set1/en_us/img/cards/01IO028T2-full.png", 2, null, false, "Scaled Snapper", 4, 5, "01IO028T2", null, null, null, null },
                    { 118L, 4, "http://dd.b.pvp.net/Set1/en_us/img/cards/01SI053T2.png", false, 2, "Other Spider allies have <link=keyword.Challenger><sprite name=Challenger><style=Keyword>Challenger</style></link> and <link=keyword.Fearsome><sprite name=Fearsome><style=Keyword>Fearsome</style></link>.", "Beauty is in the many eyes of the beholder.", "http://dd.b.pvp.net/Set1/en_us/img/cards/01SI053T2-full.png", 3, "Fearsome;Challenger", false, "Spider Queen Elise", 4, 4, "01SI053T2", null, null, null, null },
                    { 116L, 1, "http://dd.b.pvp.net/Set1/en_us/img/cards/01DE048.png", true, 4, "<link=vocab.Play><style=Vocab>Play</style></link>: Discard a spell to grant me Power equal to its cost.", "\"Long ago, the wild magicks of the Rune Wars brought all Runeterra to its knees. Thus, our order was created to protect our kingdom by ridding it of magic, whether abroad or within.\" - Mageseeker's Handbook", "http://dd.b.pvp.net/Set1/en_us/img/cards/01DE048-full.png", 4, null, false, "Mageseeker Inciter", 1, 2, "01DE048", null, null, null, null },
                    { 115L, 0, "http://dd.b.pvp.net/Set1/en_us/img/cards/01PZ004.png", true, 7, "Deal 3 to an enemy, 2 to another, 1 to another.", "\"When you've got talent, there's no such thing as a lucky shot.\" - Ezreal", "http://dd.b.pvp.net/Set1/en_us/img/cards/01PZ004-full.png", 0, "Slow", false, "Trueshot Barrage", 2, 6, "01PZ004", 0, null, null, null },
                    { 114L, 3, "http://dd.b.pvp.net/Set1/en_us/img/cards/01DE055.png", true, 3, "<link=vocab.Play><style=Vocab>Play</style></link>: Give an ally <link=keyword.Challenger><sprite name=Challenger><style=Keyword>Challenger</style></link> this round.", "\"He seemed a preening fop with an expensive blade--turns out he really knew how to swing that sword! I'd demand a rematch, but I missed his name with that ridiculous accent.\" - Demacian Ensign", "http://dd.b.pvp.net/Set1/en_us/img/cards/01DE055-full.png", 2, null, false, "Laurent Duelist", 0, 2, "01DE055", null, null, null, null },
                    { 113L, 5, "http://dd.b.pvp.net/Set1/en_us/img/cards/01FR038.png", true, 4, "<style=VocabNoTooltip>Attack</style>: <link=keyword.Frostbite><sprite name=Frostbite><style=Keyword>Frostbite</style></link> the <link=vocab.Strongest><style=Vocab>Strongest</style></link> enemy.", "\"You are not our enemy. Our true foe is the long, lawless winter. We are all people of the Freljord, and this land belongs to all of us!\" ", "http://dd.b.pvp.net/Set1/en_us/img/cards/01FR038-full.png", 3, null, false, "Ashe", 3, 3, "01FR038", null, null, null, null },
                    { 112L, 5, "http://dd.b.pvp.net/Set1/en_us/img/cards/01SI005.png", true, 10, "Reduce my cost by 1 for each ally that died this game.", "Once a beast of burden for a kingdom long forgotten, this monster now scavenges across forgotten battlefields, adding scrap to its shell, and the souls of the dead to its core.", "http://dd.b.pvp.net/Set1/en_us/img/cards/01SI005-full.png", 5, null, false, "Scuttlegeist", 1, 4, "01SI005", null, null, null, null },
                    { 111L, 1, "http://dd.b.pvp.net/Set1/en_us/img/cards/01SI002.png", false, 1, "", "\"What are you afraid of? It's just ONE little spider.\" - Lord Sassen, Hapless Aristocrat", "http://dd.b.pvp.net/Set1/en_us/img/cards/01SI002-full.png", 1, null, false, "Spiderling", 4, 4, "01SI002", null, null, null, null },
                    { 110L, 2, "http://dd.b.pvp.net/Set1/en_us/img/cards/01PZ002.png", true, 4, "When I'm summoned, create a random card in hand for each <link=card.me><style=AssociatedCard>Back Alley Barkeep</style></link> you've summoned this game.", "\"Yeah mate, it's got a slight kick the same way the Sump's got a slight smell. Bucket's by the songspinner.\"", "http://dd.b.pvp.net/Set1/en_us/img/cards/01PZ002-full.png", 2, null, false, "Back Alley Barkeep", 0, 6, "01PZ002", null, null, null, null },
                    { 109L, 0, "http://dd.b.pvp.net/Set1/en_us/img/cards/01PZ013T1.png", false, 0, "Discard your hand. Draw 3. Deal 3 to anything.", "Progress, whatever the price.", "http://dd.b.pvp.net/Set1/en_us/img/cards/01PZ013T1-full.png", 0, "Skill", false, "Reckless Research", 4, 6, "01PZ013T1", null, null, null, null },
                    { 108L, 1, "http://dd.b.pvp.net/Set1/en_us/img/cards/01IO026.png", true, 1, "<link=vocab.Play><style=Vocab>Play</style></link>: Grant an ally in hand +1|+1.", "“Took years to cultivate this deadly physique! Tireless days of spotting birds, describing clouds, and lifting tray after tray of sweet buns! Who else has such dedication?”", "http://dd.b.pvp.net/Set1/en_us/img/cards/01IO026-full.png", 1, null, false, "Inspiring Mentor", 0, 5, "01IO026", null, null, null, null },
                    { 107L, 2, "http://dd.b.pvp.net/Set1/en_us/img/cards/01PZ045.png", true, 1, @"To play me, discard 1.
                <link=keyword.Last Breath><sprite name=LastBreath><style=Keyword>Last Breath</style></link>: Draw 1.", @"""You'd think the sumprats would look after their own.""
                ""Too busy basking in their self-pity, brother.""
                ""Shame. Ah... have you seen my purse?""", "http://dd.b.pvp.net/Set1/en_us/img/cards/01PZ045-full.png", 1, null, false, "Zaunite Urchin", 0, 6, "01PZ045", null, null, null, null },
                    { 117L, 0, "http://dd.b.pvp.net/Set1/en_us/img/cards/01IO024.png", true, 6, "Summon 2 exact copies of an ally. They're <link=keyword.Ephemeral><sprite name=Ephemeral><style=Keyword>Ephemeral</style></link>.", "\"Shen is one man caught between the perils of two worlds, he will fail them both. I devote myself to Ionia alone.\" - Zed", "http://dd.b.pvp.net/Set1/en_us/img/cards/01IO024-full.png", 0, "Slow", false, "Dawn and Dusk", 1, 5, "01IO024", 0, null, null, null },
                    { 130L, 0, "http://dd.b.pvp.net/Set1/en_us/img/cards/01PZ054.png", true, 2, "<style=VocabNoTooltip>Attack</style>: Deal 2 to the enemy Nexus.", @"""You sure about this?""
                ""Nope.""
                ""You were supposed to say 'yes'.""
                ""You weren't supposed to ask.""", "http://dd.b.pvp.net/Set1/en_us/img/cards/01PZ054-full.png", 4, null, false, "Boomcrew Rookie", 0, 6, "01PZ054", null, null, null, null },
                    { 131L, 4, "http://dd.b.pvp.net/Set1/en_us/img/cards/01NX020.png", true, 3, "<link=vocab.Play><style=Vocab>Play</style></link> or <link=vocab.Strike><style=Vocab>Strike</style></link>: Create a <link=card.create><style=AssociatedCard>Spinning Axe</style></link> in hand.", "\"You want an autograph? Get in line, pal.\"", "http://dd.b.pvp.net/Set1/en_us/img/cards/01NX020-full.png", 3, null, false, "Draven", 3, 1, "01NX020", null, null, null, null },
                    { 132L, 0, "http://dd.b.pvp.net/Set1/en_us/img/cards/01PZ052.png", true, 2, "Deal 2 to anything.", "\"I. Never. Miss. But I have been known to fire a warning shot or two...\" - Ezreal", "http://dd.b.pvp.net/Set1/en_us/img/cards/01PZ052-full.png", 0, "Fast", false, "Mystic Shot", 0, 6, "01PZ052", 2, null, null, null },
                    { 155L, 3, "http://dd.b.pvp.net/Set1/en_us/img/cards/01FR037.png", true, 4, "<link=vocab.Allegiance><style=Vocab>Allegiance</style></link>: Grant the top unit in our deck +3|+3 and <link=keyword.Overwhelm><sprite name=Overwhelm><style=Keyword>Overwhelm</style></link>.", "As the rows of reinforcements crested the ridge, the Outriders bowed their heads to the warmother. For with her--their Avarosa in the flesh, their queen Ashe--came the promise of peace.", "http://dd.b.pvp.net/Set1/en_us/img/cards/01FR037-full.png", 3, "Overwhelm", false, "Avarosan Outriders", 1, 3, "01FR037", null, null, null, null },
                    { 154L, 0, "http://dd.b.pvp.net/Set1/en_us/img/cards/01SI045.png", true, 1, "Drain 4 from an ally unit.", "\"What kills you only makes me stronger.\" - Thresh", "http://dd.b.pvp.net/Set1/en_us/img/cards/01SI045-full.png", 0, "Burst", false, "Absorb Soul", 0, 4, "01SI045", 1, null, null, null },
                    { 153L, 3, "http://dd.b.pvp.net/Set1/en_us/img/cards/01DE053.png", true, 4, "<link=vocab.Strike><style=Vocab>Strike</style></link>: Create a random <link=keyword.Challenger><sprite name=Challenger><style=Keyword>Challenger</style></link> follower in hand.", "\"...Good grief.\" - Fiora", "http://dd.b.pvp.net/Set1/en_us/img/cards/01DE053-full.png", 1, "Challenger", false, "Laurent Chevalier", 2, 2, "01DE053", null, null, null, null },
                    { 152L, 3, "http://dd.b.pvp.net/Set1/en_us/img/cards/01IO032T1.png", false, 4, @"<link=vocab.Support><style=Vocab>Support</style></link>: Give my supported ally <link=keyword.Barrier><sprite name=Barrier><style=Keyword>Barrier</style></link>.
                When an ally gets <link=keyword.Barrier><sprite name=Barrier><style=Keyword>Barrier</style></link>, give it +3|+0 this round.", "\"Like hands clasped, the mortal and spirit realms intertwine. Their actions exist in harmony, and under my watch, neither shall overtake the other.\"", "http://dd.b.pvp.net/Set1/en_us/img/cards/01IO032T1-full.png", 7, null, false, "Shen", 4, 5, "01IO032T1", null, null, null, null },
                    { 151L, 3, "http://dd.b.pvp.net/Set1/en_us/img/cards/01FR049.png", true, 2, "When I'm summoned, the enemy summons a <link=card.summon><style=AssociatedCard>Snow Hare</style></link>.", "\"You cannot make a wolf from a hare.\" - Winter's Claw proverb", "http://dd.b.pvp.net/Set1/en_us/img/cards/01FR049-full.png", 2, "Challenger", false, "Stalking Wolf", 0, 3, "01FR049", null, null, null, null },
                    { 150L, 0, "http://dd.b.pvp.net/Set1/en_us/img/cards/01NX040T1.png", false, 0, "Deal 1 to the enemy Nexus.", "\"Boom.\" - Legion Saboteur", "http://dd.b.pvp.net/Set1/en_us/img/cards/01NX040T1-full.png", 0, "Skill", false, "Sabotage", 4, 1, "01NX040T1", null, null, null, null },
                    { 149L, 2, "http://dd.b.pvp.net/Set1/en_us/img/cards/01SI041.png", true, 3, "<link=keyword.Last Breath><sprite name=LastBreath><style=Keyword>Last Breath</style></link>: Revive me at start of round and grant me +1|+1 for each time I've died. <style=Variable></style>", "The old martyr remembered rallying his comrades to their doom. But it had been years since he could remember why...", "http://dd.b.pvp.net/Set1/en_us/img/cards/01SI041-full.png", 2, "CantBlock", false, "The Undying", 2, 4, "01SI041", null, null, null, null },
                    { 148L, 0, "http://dd.b.pvp.net/Set1/en_us/img/cards/01SI003.png", true, 10, "Revive the 6 highest Power units that died this game and grant them <link=keyword.Ephemeral><sprite name=Ephemeral><style=Keyword>Ephemeral</style></link>.", "On certain nights, a tide of hungry spirits swells the Black Mist. It carries them across the seas to prey on the living, and feed the growing darkness with foul new unlife.", "http://dd.b.pvp.net/Set1/en_us/img/cards/01SI003-full.png", 0, "Slow", false, "The Harrowing", 2, 4, "01SI003", 0, null, null, null },
                    { 147L, 5, "http://dd.b.pvp.net/Set1/en_us/img/cards/01PZ021.png", true, 5, "<link=vocab.Nexus Strike><style=Vocab>Nexus Strike</style></link>: Summon an exact copy of me.", @"""Mr. Berz, we found you asleep INSIDE the vault, covered in golden cogs and clutching the safe's broken door.""
                ""Weren't me. Jus' some fella wot look like me.""
                ""You're still holding the door.""
                ""Prove it.""", "http://dd.b.pvp.net/Set1/en_us/img/cards/01PZ021-full.png", 3, null, false, "Midenstokke Henchmen", 1, 6, "01PZ021", null, null, null, null },
                    { 146L, 8, "http://dd.b.pvp.net/Set1/en_us/img/cards/01SI033.png", true, 8, @"<link=vocab.Play><style=Vocab>Play</style></link>: Cut the enemy Nexus Health in half.
                <link=keyword.Last Breath><sprite name=LastBreath><style=Keyword>Last Breath</style></link>: Return me to hand.", "Most spirits lost themselves as the passing years eroded their memories. But anguish anchored Ledros to his past. Some things, even time cannot absolve.", "http://dd.b.pvp.net/Set1/en_us/img/cards/01SI033-full.png", 6, "Fearsome", false, "Commander Ledros", 2, 4, "01SI033", null, null, null, null },
                    { 145L, 0, "http://dd.b.pvp.net/Set1/en_us/img/cards/01DE012T2.png", false, 8, @"A battling ally strikes all battling enemies.
                Shuffle a <link=card.level1><style=AssociatedCard>Garen</style></link> into your deck.", "Justice always comes full circle.", "http://dd.b.pvp.net/Set1/en_us/img/cards/01DE012T2-full.png", 0, "Fast", false, "Garen's Judgment", 4, 2, "01DE012T2", 2, null, null, null },
                    { 144L, 1, "http://dd.b.pvp.net/Set1/en_us/img/cards/01DE049.png", true, 1, "", "\"New recruit has the kind of endurance and courage shown by our finest soldiers. Will he make it to the Vanguard someday? He's... smaller than the rest, but we'll see.\" - Vanguard Sergeant", "http://dd.b.pvp.net/Set1/en_us/img/cards/01DE049-full.png", 1, "Tough", false, "Plucky Poro", 0, 2, "01DE049", null, null, null, null },
                    { 143L, 4, "http://dd.b.pvp.net/Set1/en_us/img/cards/01DE022T1.png", false, 2, "The first time an ally dies each round, ready your attack.", "\"World's full of monsters. If you're lucky, they're the ones you can see. The worst are the ones that stay under your skin.\"", "http://dd.b.pvp.net/Set1/en_us/img/cards/01DE022T1-full.png", 3, null, false, "Lucian", 4, 2, "01DE022T1", null, null, null, null },
                    { 142L, 3, "http://dd.b.pvp.net/Set1/en_us/img/cards/01SI052.png", true, 5, "When an enemy dies, heal me 1.", @"Cling clang, go the chains, someone's out to find you,
                Cling clang, oh the chains, the Warden's right behind you...", "http://dd.b.pvp.net/Set1/en_us/img/cards/01SI052-full.png", 5, "Challenger", false, "Thresh", 3, 4, "01SI052", null, null, null, null },
                    { 141L, 0, "http://dd.b.pvp.net/Set1/en_us/img/cards/01NX038T1.png", false, 5, @"Deal 4 to the enemy Nexus.
                Shuffle a <link=card.level1><style=AssociatedCard>Darius</style></link> into your deck.", "\"Sometimes, it takes tactical genius to break a fortress. Sometimes, you just have to hit it harder.\" - Darius", "http://dd.b.pvp.net/Set1/en_us/img/cards/01NX038T1-full.png", 0, "Slow", false, "Darius's Decimate", 4, 1, "01NX038T1", 0, null, null, null },
                    { 140L, 0, "http://dd.b.pvp.net/Set1/en_us/img/cards/01PZ005.png", true, 6, "Transform a follower into another follower.", @"""YOU KEPT SAYING YOU WANTED TO LOSE WEIGHT.""
                ""SO YOU TURNED ME INTO A YORDLE?!""
                ""YOU LOST WEIGHT!""
                ""...I'M ALSO A YORDLE!""", "http://dd.b.pvp.net/Set1/en_us/img/cards/01PZ005-full.png", 0, "Fast", false, "Hextech Transmogulator", 1, 6, "01PZ005", 2, null, null, null },
                    { 139L, 0, "http://dd.b.pvp.net/Set1/en_us/img/cards/01NX053.png", true, 5, "If you have a 5+ Power ally, kill ALL units with 4 or less Power.", "\"WHO'S READY TO REEEEEECKONNNNNN?!\" - Arena Battlecaster", "http://dd.b.pvp.net/Set1/en_us/img/cards/01NX053-full.png", 0, "Slow", false, "Reckoning", 2, 1, "01NX053", 0, null, null, null },
                    { 138L, 8, "http://dd.b.pvp.net/Set1/en_us/img/cards/01PZ015.png", false, 8, "", "\"IT'S FINALLY COMPLETE! SIX-HUNDRED AND FIFTY-TWO FEET OF ROTARY-TEMPERED, HEX-PLATED, QUADRANIUM-CELL-POWERED STOMPING!!! My finest work, if I daresaysomyself.\" - Heimerdinger's Lab Notes, Vol. 8", "http://dd.b.pvp.net/Set1/en_us/img/cards/01PZ015-full.png", 8, null, false, "T-Hex", 4, 6, "01PZ015", null, null, null, null },
                    { 137L, 4, "http://dd.b.pvp.net/Set1/en_us/img/cards/01SI048T1.png", false, 2, "", "Time may have stopped, but madness remains. ", "http://dd.b.pvp.net/Set1/en_us/img/cards/01SI048T1-full.png", 4, null, false, "Escaped Abomination", 4, 4, "01SI048T1", null, null, null, null },
                    { 136L, 2, "http://dd.b.pvp.net/Set1/en_us/img/cards/01IO028T1.png", false, 3, "", "One of the oldest inhabitants of the Greenglade, it has withstood the test of time through constant adaptation.", "http://dd.b.pvp.net/Set1/en_us/img/cards/01IO028T1-full.png", 5, null, false, "Scaled Snapper", 4, 5, "01IO028T1", null, null, null, null },
                    { 135L, 1, "http://dd.b.pvp.net/Set1/en_us/img/cards/01PZ036.png", true, 3, "<link=vocab.Nexus Strike><style=Vocab>Nexus Strike</style></link>: Create a <link=keyword.Fleeting><sprite name=Fleeting><style=Keyword>Fleeting</style></link> <link=card.create><style=AssociatedCard>Mystic Shot</style></link> in hand.", "\"Impossible is my favorite kind of possible!\"", "http://dd.b.pvp.net/Set1/en_us/img/cards/01PZ036-full.png", 3, "Elusive", false, "Ezreal", 3, 6, "01PZ036", null, null, null, null },
                    { 134L, 2, "http://dd.b.pvp.net/Set1/en_us/img/cards/01DE043.png", true, 2, "<link=vocab.Support><style=Vocab>Support</style></link>: Give my supported ally +1|+1 this round.", "No one in the Demacian army should be trifled with.", "http://dd.b.pvp.net/Set1/en_us/img/cards/01DE043-full.png", 3, null, false, "War Chefs", 0, 2, "01DE043", null, null, null, null },
                    { 133L, 0, "http://dd.b.pvp.net/Set1/en_us/img/cards/01FR024T1.png", false, 6, @"<link=keyword.Frostbite><sprite name=Frostbite><style=Keyword>Frostbite</style></link> 2 enemies.
                Shuffle an <link=card.level1><style=AssociatedCard>Anivia</style></link> into your deck.", "\"You'd challenge me on my own lands? You're ill-prepared, little one.\" - Anivia", "http://dd.b.pvp.net/Set1/en_us/img/cards/01FR024T1-full.png", 0, "Burst", false, "Anivia's Harsh Winds", 4, 3, "01FR024T1", 1, null, null, null },
                    { 157L, 0, "http://dd.b.pvp.net/Set1/en_us/img/cards/01FR009T1.png", false, 3, "When I survive damage, summon a <link=card.create><style=AssociatedCard>Mighty Poro</style></link>.", @"“Papa, tell the one about Braum and his door!”
                ""Or when his fall split a mountain in two!""
                ""Oh! Whattabout when he saved the tavern from the rampaging yeti?!""", "http://dd.b.pvp.net/Set1/en_us/img/cards/01FR009T1-full.png", 7, "Challenger;Regeneration", false, "Braum", 4, 3, "01FR009T1", null, null, null, null },
                    { 420L, 0, "http://dd.b.pvp.net/Set1/en_us/img/cards/01SI047.png", true, 0, "Pick a follower. Create an <link=keyword.Ephemeral><sprite name=Ephemeral><style=Keyword>Ephemeral</style></link> copy of it in hand.", "For a moment, she remembered. Dappled sunlight dancing across her skin, plump dewberries bursting between her teeth, and the glade’s fragile melody drifting over her on the breeze. Then... it was gone.", "http://dd.b.pvp.net/Set1/en_us/img/cards/01SI047-full.png", 0, "Burst", false, "Fading Memories", 1, 4, "01SI047", 1, null, null, null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 13L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 14L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 15L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 16L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 17L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 18L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 19L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 20L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 21L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 22L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 23L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 24L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 25L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 26L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 27L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 28L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 29L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 30L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 31L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 32L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 33L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 34L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 35L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 36L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 37L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 38L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 39L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 40L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 41L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 42L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 43L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 44L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 45L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 46L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 47L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 48L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 49L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 50L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 51L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 52L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 53L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 54L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 55L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 56L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 57L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 58L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 59L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 60L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 61L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 62L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 63L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 64L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 65L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 66L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 67L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 68L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 69L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 70L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 71L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 72L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 73L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 74L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 75L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 76L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 77L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 78L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 79L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 80L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 81L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 82L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 83L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 84L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 85L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 86L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 87L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 88L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 89L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 90L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 91L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 92L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 93L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 94L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 95L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 96L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 97L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 98L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 99L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 100L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 101L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 102L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 103L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 104L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 105L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 106L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 107L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 108L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 109L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 110L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 111L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 112L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 113L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 114L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 115L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 116L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 117L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 118L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 119L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 120L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 121L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 122L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 123L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 124L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 125L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 126L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 127L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 128L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 129L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 130L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 131L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 132L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 133L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 134L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 135L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 136L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 137L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 138L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 139L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 140L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 141L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 142L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 143L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 144L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 145L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 146L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 147L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 148L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 149L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 150L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 151L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 152L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 153L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 154L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 155L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 156L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 157L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 158L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 159L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 160L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 161L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 162L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 163L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 164L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 165L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 166L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 167L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 168L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 169L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 170L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 171L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 172L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 173L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 174L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 175L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 176L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 177L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 178L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 179L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 180L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 181L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 182L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 183L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 184L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 185L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 186L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 187L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 188L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 189L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 190L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 191L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 192L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 193L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 194L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 195L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 196L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 197L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 198L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 199L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 200L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 201L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 202L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 203L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 204L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 205L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 206L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 207L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 208L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 209L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 210L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 211L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 212L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 213L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 214L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 215L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 216L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 217L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 218L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 219L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 220L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 221L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 222L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 223L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 224L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 225L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 226L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 227L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 228L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 229L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 230L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 231L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 232L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 233L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 234L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 235L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 236L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 237L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 238L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 239L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 240L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 241L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 242L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 243L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 244L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 245L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 246L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 247L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 248L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 249L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 250L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 251L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 252L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 253L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 254L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 255L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 256L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 257L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 258L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 259L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 260L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 261L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 262L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 263L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 264L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 265L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 266L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 267L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 268L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 269L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 270L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 271L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 272L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 273L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 274L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 275L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 276L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 277L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 278L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 279L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 280L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 281L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 282L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 283L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 284L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 285L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 286L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 287L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 288L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 289L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 290L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 291L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 292L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 293L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 294L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 295L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 296L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 297L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 298L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 299L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 300L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 301L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 302L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 303L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 304L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 305L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 306L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 307L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 308L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 309L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 310L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 311L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 312L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 313L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 314L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 315L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 316L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 317L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 318L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 319L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 320L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 321L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 322L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 323L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 324L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 325L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 326L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 327L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 328L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 329L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 330L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 331L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 332L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 333L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 334L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 335L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 336L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 337L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 338L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 339L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 340L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 341L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 342L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 343L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 344L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 345L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 346L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 347L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 348L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 349L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 350L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 351L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 352L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 353L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 354L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 355L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 356L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 357L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 358L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 359L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 360L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 361L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 362L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 363L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 364L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 365L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 366L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 367L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 368L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 369L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 370L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 371L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 372L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 373L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 374L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 375L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 376L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 377L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 378L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 379L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 380L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 381L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 382L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 383L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 384L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 385L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 386L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 387L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 388L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 389L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 390L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 391L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 392L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 393L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 394L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 395L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 396L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 397L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 398L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 399L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 400L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 401L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 402L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 403L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 404L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 405L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 406L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 407L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 408L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 409L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 410L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 411L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 412L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 413L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 414L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 415L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 416L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 417L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 418L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 419L);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 420L);

            migrationBuilder.DropColumn(
                name: "Rarity",
                table: "Cards");

            migrationBuilder.AlterColumn<int>(
                name: "RegionRef",
                table: "Cards",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);
        }
    }
}
