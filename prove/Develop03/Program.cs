using System;

class Program
{
    static void Main(string[] args)
    {
        Menu menu = new();
        int input = menu.PrintMenu();

        Random random = new();

        List<Scripture> scriptures = new();


        Scripture scripture1 = new("1 Corinthians", 13, 4, 7,
            "Charity suffereth long, and is kind; charity envieth not; charity vaunteth not itself, is not puffed up, " +
            "Doth not behave itself unseemly, seeketh not her own, is not easily provoked, thinketh no evil; " +
            "Rejoiceth not in iniquity, but rejoiceth in the truth; " +
            "Beareth all things, believeth all things, hopeth all things, endureth all things.");
        scriptures.Add(scripture1);

        Scripture scripture2 = new("2 Nephi", 31, 19, 20,
            "After entering the strait and narrow path, continue with unshaken faith in Christ. Press forward with steadfastness, hope, and love, feast upon the word of Christ, and endure to the end.");
        scriptures.Add(scripture2);

        Scripture scripture3 = new("Moroni", 10, 3, 5,
            "Remember the Lord's mercy, ponder it in your hearts, and ask God with a sincere heart and real intent, having faith in Christ, to know the truth through the Holy Ghost.");
        scriptures.Add(scripture3);

        Scripture scripture4 = new("Matthew", 5, 3, 12,
            "Blessed are the poor in spirit: for theirs is the kingdom of heaven. " +
            "Blessed are they that mourn: for they shall be comforted. " +
            "Blessed are the meek: for they shall inherit the earth. " +
            "Blessed are they which do hunger and thirst after righteousness: for they shall be filled. " +
            "Blessed are the merciful: for they shall obtain mercy. " +
            "Blessed are the pure in heart: for they shall see God. " +
            "Blessed are the peacemakers: for they shall be called the children of God. " +
            "Blessed are they which are persecuted for righteousness' sake: for theirs is the kingdom of heaven. " +
            "Blessed are ye, when men shall revile you, and persecute you, and shall say all manner of evil against you falsely, for my sake. " +
            "Rejoice, and be exceeding glad: for great is your reward in heaven: for so persecuted they the prophets which were before you.");
        scriptures.Add(scripture4);

        Scripture scripture5 = new("Doctrine and Covenants", 121, 7, 9,
            "The Lord comforts Joseph Smith in his afflictions, promising that adversity will be temporary and that God is with him.");
        scriptures.Add(scripture5);

        Scripture scripture6 = new("John", 14, 1, 3,
            "Let not your heart be troubled: ye believe in God, believe also in me. " +
            "In my Father's house are many mansions: if it were not so, I would have told you. I go to prepare a place for you. " +
            "And if I go and prepare a place for you, I will come again, and receive you unto myself; that where I am, there ye may be also.");
        scriptures.Add(scripture6);

        Scripture scripture7 = new("Alma", 32, 21, 23,
            "Faith is not a perfect knowledge. It is hope for things that are not seen but are true. God grants his word through angels and prepares a way for people to receive it.");
        scriptures.Add(scripture7);

        Scripture scripture8 = new("Philippians", 4, 6, 7,
            "Be careful for nothing; but in every thing by prayer and supplication with thanksgiving let your requests be made known unto God. " +
            "And the peace of God, which passeth all understanding, shall keep your hearts and minds through Christ Jesus.");
        scriptures.Add(scripture8);

        Scripture scripture9 = new("Mosiah", 2, 17, 18,
            "When you serve your fellow beings, you serve God. King Benjamin teaches his people to be humble, grateful, and diligent in keeping God's commandments.");
        scriptures.Add(scripture9);

        Scripture scripture10 = new("Joshua", 1, 8, 9,
            "This book of the law shall not depart out of thy mouth; but thou shalt meditate therein day and night, that thou mayest observe to do according to all that is written therein: for then thou shalt make thy way prosperous, and then thou shalt have good success. " +
            "Have not I commanded thee? Be strong and of a good courage; be not afraid, neither be thou dismayed: for the Lord thy God is with thee whithersoever thou goest.");
        scriptures.Add(scripture10);

        Scripture scripture11 = new("Matthew", 5, 14, 16,
            "Ye are the light of the world. A city that is set on an hill cannot be hid. " +
            "Neither do men light a candle, and put it under a bushel, but on a candlestick; and it giveth light unto all that are in the house. " +
            "Let your light so shine before men, that they may see your good works, and glorify your Father which is in heaven.");
        scriptures.Add(scripture11);

        Scripture scripture12 = new("Moroni", 7, 45, 48,
            "Charity is patient, kind, humble, and enduring. It rejoices in truth, bears all things, and never fails. Pray with all the energy of your heart to be filled with this pure love of Christ.");
        scriptures.Add(scripture12);

        Scripture scripture13 = new("2 Nephi", 2, 22, 25,
            "Lehi explains the Fall of Adam, the purpose of mortality, and how opposition makes joy possible. Adam fell that men might be; and men are, that they might have joy.");
        scriptures.Add(scripture13);

        Scripture scripture14 = new("Doctrine and Covenants", 6, 33, 37,
            "Fear not to do good. Look unto Christ in every thought, doubt not, and fear not. He will sustain those who trust in him.");
        scriptures.Add(scripture14);

        Scripture scripture15 = new("Matthew", 6, 25, 34,
            "Therefore I say unto you, Take no thought for your life, what ye shall eat, or what ye shall drink; nor yet for your body, what ye shall put on. " +
            "Is not the life more than meat, and the body than raiment? " +
            "Behold the fowls of the air: for they sow not, neither do they reap, nor gather into barns; yet your heavenly Father feedeth them. Are ye not much better than they? " +
            "Which of you by taking thought can add one cubit unto his stature? " +
            "And why take ye thought for raiment? Consider the lilies of the field, how they grow; they toil not, neither do they spin: " +
            "And yet I say unto you, That even Solomon in all his glory was not arrayed like one of these. " +
            "Wherefore, if God so clothe the grass of the field, which to day is, and to morrow is cast into the oven, shall he not much more clothe you, O ye of little faith? " +
            "Therefore take no thought, saying, What shall we eat? or, What shall we drink? or, Wherewithal shall we be clothed? " +
            "For after all these things do the Gentiles seek: for your heavenly Father knoweth that ye have need of all these things. " +
            "But seek ye first the kingdom of God, and his righteousness; and all these things shall be added unto you. " +
            "Take therefore no thought for the morrow: for the morrow shall take thought for the things of itself. Sufficient unto the day is the evil thereof.");
        scriptures.Add(scripture15);


        Scripture scripture16 = new("Proverbs", 3, 5,
            "Trust in the Lord with all thine heart; and lean not unto thine own understanding.");
        scriptures.Add(scripture16);

        Scripture scripture17 = new("John", 11, 35,
            "Jesus wept.");
        scriptures.Add(scripture17);

        Scripture scripture18 = new("Philippians", 4, 13,
            "I can do all things through Christ which strengtheneth me.");
        scriptures.Add(scripture18);

        Scripture scripture19 = new("Joshua", 1, 9,
            "Have not I commanded thee? Be strong and of a good courage; be not afraid, neither be thou dismayed: for the Lord thy God is with thee whithersoever thou goest.");
        scriptures.Add(scripture19);

        Scripture scripture20 = new("Psalms", 46, 10,
            "Be still, and know that I am God: I will be exalted among the heathen, I will be exalted in the earth.");
        scriptures.Add(scripture20);

        Scripture scripture21 = new("Matthew", 5, 9,
            "Blessed are the peacemakers: for they shall be called the children of God.");
        scriptures.Add(scripture21);

        Scripture scripture22 = new("Romans", 8, 28,
            "And we know that all things work together for good to them that love God, to them who are the called according to his purpose.");
        scriptures.Add(scripture22);

        Scripture scripture23 = new("1 Nephi", 3, 7,
            "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.");
        scriptures.Add(scripture23);

        Scripture scripture24 = new("Alma", 37, 6,
            "Now ye may suppose that this is foolishness in me; but behold I say unto you, that by small and simple things are great things brought to pass.");
        scriptures.Add(scripture24);

        Scripture scripture25 = new("Ether", 12, 27,
            "And if men come unto me I will show unto them their weakness. I give unto men weakness that they may be humble; and my grace is sufficient for all men that humble themselves before me; for if they humble themselves before me, and have faith in me, then will I make weak things become strong unto them.");
        scriptures.Add(scripture25);

        Scripture scripture26 = new("2 Nephi", 2, 25,
            "Adam fell that men might be; and men are, that they might have joy.");
        scriptures.Add(scripture26);

        Scripture scripture27 = new("Doctrine and Covenants", 6, 36,
            "Look unto me in every thought; doubt not, fear not.");
        scriptures.Add(scripture27);

        Scripture scripture28 = new("Matthew", 22, 39,
            "And the second is like unto it, Thou shalt love thy neighbour as thyself.");
        scriptures.Add(scripture28);

        Scripture scripture29 = new("1 Corinthians", 16, 14,
            "Let all your things be done with charity.");
        scriptures.Add(scripture29);

        Scripture scripture30 = new("Psalms", 119, 105,
            "Thy word is a lamp unto my feet, and a light unto my path.");
        scriptures.Add(scripture30);

        Scripture scripture31 = new("Moroni", 10, 4,
            "And when ye shall receive these things, I would exhort you that ye would ask God, the Eternal Father, in the name of Christ, if these things are not true; and if ye shall ask with a sincere heart, with real intent, having faith in Christ, he will manifest the truth of it unto you, by the power of the Holy Ghost.");
        scriptures.Add(scripture31);

        Scripture scripture32 = new("John", 14, 6,
            "Jesus saith unto him, I am the way, the truth, and the life: no man cometh unto the Father, but by me.");
        scriptures.Add(scripture32);

        Scripture scripture33 = new("Micah", 6, 8,
            "He hath shewed thee, O man, what is good; and what doth the Lord require of thee, but to do justly, and to love mercy, and to walk humbly with thy God?");
        scriptures.Add(scripture33);

        Scripture scripture34 = new("Mosiah", 2, 17,
            "And behold, I tell you these things that ye may learn wisdom; that ye may learn that when ye are in the service of your fellow beings ye are only in the service of your God.");
        scriptures.Add(scripture34);

        Scripture scripture35 = new("3 Nephi", 12, 16,
            "Therefore let your light so shine before this people, that they may see your good works and glorify your Father who is in heaven.");
        scriptures.Add(scripture35);


        if (input == 1)
        {
            scriptures[random.Next() % scriptures.Count].PrintScripture();            
        }
        
    }
}