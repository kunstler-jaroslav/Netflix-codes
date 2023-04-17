using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using MvvmHelpers;

namespace Netflix_codes
{
    internal static class Data
    {
        public static List<Gener> GenerData = new List<Gener>();
        public static List<Subgener> SubgenerData = new List<Subgener>();

        public static void FillGener()
        {
            GenerData.Add(new Gener("All genres", "0", "https://www.netflix.com/browse", false));
            GenerData.Add(new Gener("Action & Adventure", "1365", "https://www.netflix.com/browse/genre/1365", false));
            GenerData.Add(new Gener("Anime", "7424", "https://www.netflix.com/browse/genre/7424", false));
            GenerData.Add(new Gener("Children & Family Movies", "783", "https://www.netflix.com/browse/genre/783", false));
            GenerData.Add(new Gener("Classic Movies", "31574", "https://www.netflix.com/browse/genre/31574", false));
            GenerData.Add(new Gener("Comedies", "6548", "https://www.netflix.com/browse/genre/6548", false));
            GenerData.Add(new Gener("Cult Movies", "7627", "https://www.netflix.com/browse/genre/7627", false));
            GenerData.Add(new Gener("Documentaries", "6839", "https://www.netflix.com/browse/genre/6839", false));
            GenerData.Add(new Gener("Dramas", "5763", "https://www.netflix.com/browse/genre/5763", false));
            GenerData.Add(new Gener("Faith & Spirituality", "26835", "https://www.netflix.com/browse/genre/26835", false));
            GenerData.Add(new Gener("Foreign Movies", "7462", "https://www.netflix.com/browse/genre/7462", false));
            GenerData.Add(new Gener("Gay & Lesbian Movies", "5977", "https://www.netflix.com/browse/genre/5977", false));
            GenerData.Add(new Gener("Horror Movies", "8711", "https://www.netflix.com/browse/genre/8711", false));
            GenerData.Add(new Gener("Independent Movies", "7077", "https://www.netflix.com/browse/genre/7077", false));
            GenerData.Add(new Gener("Music", "1701", "https://www.netflix.com/browse/genre/1701", false));
            GenerData.Add(new Gener("Romantic Movies", "8883", "https://www.netflix.com/browse/genre/8883", false));
            GenerData.Add(new Gener("Sci-Fi & Fantasy", "1492", "https://www.netflix.com/browse/genre/1492", false));
            GenerData.Add(new Gener("Sports Movies", "4370", "https://www.netflix.com/browse/genre/4370", false));
            GenerData.Add(new Gener("Thrillers", "8933", "https://www.netflix.com/browse/genre/8933", false));
            GenerData.Add(new Gener("TV Shows", "83", "https://www.netflix.com/browse/genre/83", false));
        }

        public static void FillSubgener()
        {
            //Action 1365
            SubgenerData.Add(new Subgener("Asian Action Movies", "77232", "https://www.netflix.com/browse/genre/77232", false, "1365"));
            SubgenerData.Add(new Subgener("Classic Action & Adventure", "46576", "https://www.netflix.com/browse/genre/46576", false, "1365"));
            SubgenerData.Add(new Subgener("Action Comedies", "43040", "https://www.netflix.com/browse/genre/43040", false, "1365"));
            SubgenerData.Add(new Subgener("Action Thrillers", "43048", "https://www.netflix.com/browse/genre/43048", false, "1365"));
            SubgenerData.Add(new Subgener("Adventures", "7442", "https://www.netflix.com/browse/genre/7442", false, "1365"));
            SubgenerData.Add(new Subgener("Comic Book and Superhero Movies", "10118", "https://www.netflix.com/browse/genre/10118", false, "1365"));
            SubgenerData.Add(new Subgener("Westerns", "7700", "https://www.netflix.com/browse/genre/7700", false, "1365"));
            SubgenerData.Add(new Subgener("Spy Action & Adventure", "10702", "https://www.netflix.com/browse/genre/10702", false, "1365"));
            SubgenerData.Add(new Subgener("Crime Action & Adventure", "9584", "https://www.netflix.com/browse/genre/9584", false, "1365"));
            SubgenerData.Add(new Subgener("Foreign Action & Adventure", "11828", "https://www.netflix.com/browse/genre/11828", false, "1365"));
            SubgenerData.Add(new Subgener("Martial Arts Movies", "8985", "https://www.netflix.com/browse/genre/8985", false, "1365"));
            SubgenerData.Add(new Subgener("Military Action & Adventure", "2125", "https://www.netflix.com/browse/genre/2125", false, "1365"));

            //Anime 7424
            SubgenerData.Add(new Subgener("Adult Animation", "11881", "https://www.netflix.com/browse/genre/11881", false, "7424"));
            SubgenerData.Add(new Subgener("Anime Action", "2653", "https://www.netflix.com/browse/genre/2653", false, "7424"));
            SubgenerData.Add(new Subgener("Anime Comedies", "9302", "https://www.netflix.com/browse/genre/9302", false, "7424"));
            SubgenerData.Add(new Subgener("Anime Dramas", "452", "https://www.netflix.com/browse/genre/452", false, "7424"));
            SubgenerData.Add(new Subgener("Anime Features", "3063", "https://www.netflix.com/browse/genre/3063", false, "7424"));
            SubgenerData.Add(new Subgener("Anime Sci-Fi", "2729", "https://www.netflix.com/browse/genre/2729", false, "7424"));
            SubgenerData.Add(new Subgener("Anime Horror", "10695", "https://www.netflix.com/browse/genre/10695", false, "7424"));
            SubgenerData.Add(new Subgener("Anime Fantasy", "11146", "https://www.netflix.com/browse/genre/11146", false, "7424"));
            SubgenerData.Add(new Subgener("Anime Series", "6721", "https://www.netflix.com/browse/genre/6721", false, "7424"));

            //Children & Family Movies 783
            SubgenerData.Add(new Subgener("Movies for ages 0 to 2", "6796", "https://www.netflix.com/browse/genre/6796", false, "783"));
            SubgenerData.Add(new Subgener("Movies for ages 2 to 4", "6218", "https://www.netflix.com/browse/genre/6218", false, "783"));
            SubgenerData.Add(new Subgener("Movies for ages 5 to 7", "5455", "https://www.netflix.com/browse/genre/5455", false, "783"));
            SubgenerData.Add(new Subgener("Movies for ages 8 to 10", "561", "https://www.netflix.com/browse/genre/561", false, "783"));
            SubgenerData.Add(new Subgener("Movies for ages 11 to 12", "6962", "https://www.netflix.com/browse/genre/6962", false, "783"));
            SubgenerData.Add(new Subgener("Education for Kids", "10659", "https://www.netflix.com/browse/genre/10659", false, "783"));
            SubgenerData.Add(new Subgener("Disney", "67673", "https://www.netflix.com/browse/genre/67673", false, "783"));
            SubgenerData.Add(new Subgener("Movies based on children's books", "10056", "https://www.netflix.com/browse/genre/10056", false, "783"));
            SubgenerData.Add(new Subgener("Family Features", "51056", "https://www.netflix.com/browse/genre/51056", false, "783"));
            SubgenerData.Add(new Subgener("TV Cartoons", "11177", "https://www.netflix.com/browse/genre/11177", false, "783"));
            SubgenerData.Add(new Subgener("Kids' TV", "27346", "https://www.netflix.com/browse/genre/27346", false, "783"));
            SubgenerData.Add(new Subgener("Kids Music", "52843", "https://www.netflix.com/browse/genre/52843", false, "783"));
            SubgenerData.Add(new Subgener("Animal Tales", "5507", "https://www.netflix.com/browse/genre/5507", false, "783"));

            //Clasical movies 31574
            SubgenerData.Add(new Subgener("Classic Comedies", "31694", "https://www.netflix.com/browse/genre/31694", false, "31574"));
            SubgenerData.Add(new Subgener("Classic Dramas", "29809", "https://www.netflix.com/browse/genre/29809", false, "31574"));
            SubgenerData.Add(new Subgener("Classic Sci-Fi & Fantasy", "47147", "https://www.netflix.com/browse/genre/47147", false, "31574"));
            SubgenerData.Add(new Subgener("Classic Thrillers", "46588", "https://www.netflix.com/browse/genre/46588", false, "31574"));
            SubgenerData.Add(new Subgener("Film Noir", "7687", "https://www.netflix.com/browse/genre/7687", false, "31574"));
            SubgenerData.Add(new Subgener("Classic War Movies", "48744", "https://www.netflix.com/browse/genre/48744", false, "31574"));
            SubgenerData.Add(new Subgener("Epics", "52858", "https://www.netflix.com/browse/genre/52858", false, "31574"));
            SubgenerData.Add(new Subgener("Classic Foreign Movies", "32473", "https://www.netflix.com/browse/genre/32473", false, "31574"));
            SubgenerData.Add(new Subgener("Silent Movies", "53310", "https://www.netflix.com/browse/genre/53310", false, "31574"));
            SubgenerData.Add(new Subgener("Classic Westerns", "47465", "https://www.netflix.com/browse/genre/47465", false, "31574"));

            //Comedies 6574
            SubgenerData.Add(new Subgener("Dark Comedies", "869", "https://www.netflix.com/browse/genre/869", false, "6574"));
            SubgenerData.Add(new Subgener("Foreign Comedies", "4426", "https://www.netflix.com/browse/genre/4426", false, "6574"));
            SubgenerData.Add(new Subgener("Late Night Comedies", "1402", "https://www.netflix.com/browse/genre/1402", false, "6574"));
            SubgenerData.Add(new Subgener("Mockumentaries", "26", "https://www.netflix.com/browse/genre/26", false, "6574"));
            SubgenerData.Add(new Subgener("Political Comedies", "2700", "https://www.netflix.com/browse/genre/2700", false, "6574"));
            SubgenerData.Add(new Subgener("Screwball Comedies", "9702", "https://www.netflix.com/browse/genre/9702", false, "6574"));
            SubgenerData.Add(new Subgener("Sports Comedies", "5286", "https://www.netflix.com/browse/genre/5286", false, "6574"));
            SubgenerData.Add(new Subgener("Stand-up Comedy", "11559", "https://www.netflix.com/browse/genre/11559", false, "6574"));
            SubgenerData.Add(new Subgener("Teen Comedies", "3519", "https://www.netflix.com/browse/genre/3519", false, "6574"));
            SubgenerData.Add(new Subgener("Satires", "4922", "https://www.netflix.com/browse/genre/4922", false, "6574"));
            SubgenerData.Add(new Subgener("Romantic Comedies", "5475", "https://www.netflix.com/browse/genre/5475", false, "6574"));
            SubgenerData.Add(new Subgener("Slapstick Comedies", "10256", "https://www.netflix.com/browse/genre/10256", false, "6574"));

            //Cult movies 7627
            SubgenerData.Add(new Subgener("B-Horror Movies", "8195", "https://www.netflix.com/browse/genre/8195", false, "7627"));
            SubgenerData.Add(new Subgener("Campy Movies", "1252", "https://www.netflix.com/browse/genre/1252", false, "7627"));
            SubgenerData.Add(new Subgener("Cult Horror Movies", "10944", "https://www.netflix.com/browse/genre/10944", false, "7627"));
            SubgenerData.Add(new Subgener("Cult Sci-Fi & Fantasy", "4734", "https://www.netflix.com/browse/genre/4734", false, "7627"));
            SubgenerData.Add(new Subgener("Cult Comedies", "9434", "https://www.netflix.com/browse/genre/9434", false, "7627"));
            
            //Documentaries 6839
            SubgenerData.Add(new Subgener("Biographical Documentaries", "3652", "https://www.netflix.com/browse/genre/3652", false, "6839"));
            SubgenerData.Add(new Subgener("Crime Documentaries", "9875", "https://www.netflix.com/browse/genre/9875", false, "6839"));
            SubgenerData.Add(new Subgener("Foreign Documentaries", "5161", "https://www.netflix.com/browse/genre/5161", false, "6839"));
            SubgenerData.Add(new Subgener("Historical Documentaries", "5349", "https://www.netflix.com/browse/genre/5349", false, "6839"));
            SubgenerData.Add(new Subgener("Military Documentaries", "4006", "https://www.netflix.com/browse/genre/4006", false, "6839"));
            SubgenerData.Add(new Subgener("Sports Documentaries", "180", "https://www.netflix.com/browse/genre/180", false, "6839"));
            SubgenerData.Add(new Subgener("Music & Concert Documentaries", "90361", "https://www.netflix.com/browse/genre/90361", false, "6839"));
            SubgenerData.Add(new Subgener("Travel & Adventure Documentaries", "1159", "https://www.netflix.com/browse/genre/1159", false, "6839"));
            SubgenerData.Add(new Subgener("Political Documentaries", "7018", "https://www.netflix.com/browse/genre/7018", false, "6839"));
            SubgenerData.Add(new Subgener("Religious Documentaries", "10005", "https://www.netflix.com/browse/genre/10005", false, "6839"));
            SubgenerData.Add(new Subgener("Science & Nature Documentaries", "2595", "https://www.netflix.com/browse/genre/2595", false, "6839"));
            SubgenerData.Add(new Subgener("Social & Cultural Documentaries", "3675", "https://www.netflix.com/browse/genre/3675", false, "6839"));
            
            //Dramas 5763
            SubgenerData.Add(new Subgener("Biographical Dramas", "3179", "https://www.netflix.com/browse/genre/3179", false, "5763"));
            SubgenerData.Add(new Subgener("Classic Dramas", "29809", "https://www.netflix.com/browse/genre/29809", false, "5763"));
            SubgenerData.Add(new Subgener("Courtroom Dramas", "528582748", "https://www.netflix.com/browse/genre/528582748", false, "5763"));
            SubgenerData.Add(new Subgener("Crime Dramas", "6889", "https://www.netflix.com/browse/genre/6889", false, "5763"));
            SubgenerData.Add(new Subgener("Dramas based on Books", "4961", "https://www.netflix.com/browse/genre/4961", false, "5763"));
            SubgenerData.Add(new Subgener("Dramas based on real life", "3653", "https://www.netflix.com/browse/genre/3653", false, "5763"));
            SubgenerData.Add(new Subgener("Tearjerkers", "6384", "https://www.netflix.com/browse/genre/6384", false, "5763"));
            SubgenerData.Add(new Subgener("Foreign Dramas", "2150", "https://www.netflix.com/browse/genre/2150", false, "5763"));
            SubgenerData.Add(new Subgener("Sports Dramas", "7243", "https://www.netflix.com/browse/genre/7243", false, "5763"));
            SubgenerData.Add(new Subgener("Gay & Lesbian Dramas", "500", "https://www.netflix.com/browse/genre/500", false, "5763"));
            SubgenerData.Add(new Subgener("Independent Dramas", "384", "https://www.netflix.com/browse/genre/384", false, "5763"));
            SubgenerData.Add(new Subgener("Teen Dramas", "9299", "https://www.netflix.com/browse/genre/9299", false, "5763"));
            SubgenerData.Add(new Subgener("Military Dramas", "11", "https://www.netflix.com/browse/genre/11", false, "5763"));
            SubgenerData.Add(new Subgener("Period Pieces", "12123", "https://www.netflix.com/browse/genre/12123", false, "5763"));
            SubgenerData.Add(new Subgener("Political Dramas", "6616", "https://www.netflix.com/browse/genre/6616", false, "5763"));
            SubgenerData.Add(new Subgener("Romantic Dramas", "1255", "https://www.netflix.com/browse/genre/1255", false, "5763"));
            SubgenerData.Add(new Subgener("Showbiz Dramas", "5012", "https://www.netflix.com/browse/genre/5012", false, "5763"));
            SubgenerData.Add(new Subgener("Social Issue Dramas", "3947", "https://www.netflix.com/browse/genre/3947", false, "5763"));

            // Faith & Spirituality 26835
            SubgenerData.Add(new Subgener("Faith & Spirituality Movies", "52804", "https://www.netflix.com/browse/genre/52804", false, "26835"));
            SubgenerData.Add(new Subgener("Spiritual Documentaries", "2760", "https://www.netflix.com/browse/genre/2760", false, "26835"));
            SubgenerData.Add(new Subgener("Kids Faith & Spirituality", "751423", "https://www.netflix.com/browse/genre/751423", false, "26835"));


            // Foreign Movies 7462
            SubgenerData.Add(new Subgener("Art House Movies", "29764", "https://www.netflix.com/browse/genre/29764", false, "7462"));
            SubgenerData.Add(new Subgener("Foreign Action & Adventure", "11828", "https://www.netflix.com/browse/genre/11828", false, "7462"));
            SubgenerData.Add(new Subgener("Classic Foreign Movies", "32473", "https://www.netflix.com/browse/genre/32473", false, "7462"));
            SubgenerData.Add(new Subgener("Foreign Comedies", "4426", "https://www.netflix.com/browse/genre/4426", false, "7462"));
            SubgenerData.Add(new Subgener("Foreign Documentaries", "5161", "https://www.netflix.com/browse/genre/5161", false, "7462"));
            SubgenerData.Add(new Subgener("Foreign Dramas", "2150", "https://www.netflix.com/browse/genre/2150", false, "7462"));
            SubgenerData.Add(new Subgener("Foreign Gay & Lesbian Movies", "8243", "https://www.netflix.com/browse/genre/8243", false, "7462"));
            SubgenerData.Add(new Subgener("Foreign Horror Movies", "8654", "https://www.netflix.com/browse/genre/8654", false, "7462"));
            SubgenerData.Add(new Subgener("Foreign Sci-Fi & Fantasy", "6485", "https://www.netflix.com/browse/genre/6485", false, "7462"));
            SubgenerData.Add(new Subgener("Foreign Thrillers", "10306", "https://www.netflix.com/browse/genre/10306", false, "7462"));
            SubgenerData.Add(new Subgener("Romantic Foreign Movies", "7153", "https://www.netflix.com/browse/genre/7153", false, "7462"));
            SubgenerData.Add(new Subgener("African Movies", "3761", "https://www.netflix.com/browse/genre/3761", false, "7462"));
            SubgenerData.Add(new Subgener("Australian Movies", "5230", "https://www.netflix.com/browse/genre/5230", false, "7462"));
            SubgenerData.Add(new Subgener("Belgian Movies", "262", "https://www.netflix.com/browse/genre/262", false, "7462"));
            SubgenerData.Add(new Subgener("Korean Movies", "5685", "https://www.netflix.com/browse/genre/5685", false, "7462"));
            SubgenerData.Add(new Subgener("Latin American Movies", "1613", "https://www.netflix.com/browse/genre/1613", false, "7462"));
            SubgenerData.Add(new Subgener("Middle Eastern Movies", "5875", "https://www.netflix.com/browse/genre/5875", false, "7462"));
            SubgenerData.Add(new Subgener("New Zealand Movies", "63782", "https://www.netflix.com/browse/genre/63782", false, "7462"));
            SubgenerData.Add(new Subgener("Russian", "11567", "https://www.netflix.com/browse/genre/11567", false, "7462"));
            SubgenerData.Add(new Subgener("Scandinavian Movies", "9292", "https://www.netflix.com/browse/genre/9292", false, "7462"));
            SubgenerData.Add(new Subgener("Southeast Asian Movies", "9196", "https://www.netflix.com/browse/genre/9196", false, "7462"));
            SubgenerData.Add(new Subgener("Spanish Movies", "58741", "https://www.netflix.com/browse/genre/58741", false, "7462"));
            SubgenerData.Add(new Subgener("Greek Movies", "61115", "https://www.netflix.com/browse/genre/61115", false, "7462"));
            SubgenerData.Add(new Subgener("German Movies", "58886", "https://www.netflix.com/browse/genre/58886", false, "7462"));
            SubgenerData.Add(new Subgener("French Movies", "58807", "https://www.netflix.com/browse/genre/58807", false, "7462"));
            SubgenerData.Add(new Subgener("Eastern European Movies", "5254", "https://www.netflix.com/browse/genre/5254", false, "7462"));
            SubgenerData.Add(new Subgener("Dutch Movies", "10606", "https://www.netflix.com/browse/genre/10606", false, "7462"));
            SubgenerData.Add(new Subgener("Irish Movies", "58750", "https://www.netflix.com/browse/genre/58750", false, "7462"));
            SubgenerData.Add(new Subgener("Japanese Movies", "10398", "https://www.netflix.com/browse/genre/10398", false, "7462"));
            SubgenerData.Add(new Subgener("Italian Movies", "8221", "https://www.netflix.com/browse/genre/8221", false, "7462"));
            SubgenerData.Add(new Subgener("Indian Movies", "10463", "https://www.netflix.com/browse/genre/10463", false, "7462"));
            SubgenerData.Add(new Subgener("Chinese Movies", "3960", "https://www.netflix.com/browse/genre/3960", false, "7462"));
            SubgenerData.Add(new Subgener("British Movies", "10757", "https://www.netflix.com/browse/genre/10757", false, "7462"));

            //Gay & Lesbian Movies 5977
            SubgenerData.Add(new Subgener("Gay & Lesbian Comedies", "7120", "https://www.netflix.com/browse/genre/7120", false, "5977"));
            SubgenerData.Add(new Subgener("Gay & Lesbian Dramas", "500", "https://www.netflix.com/browse/genre/500", false, "5977"));
            SubgenerData.Add(new Subgener("Romantic Gay & Lesbian Movies", "3329", "https://www.netflix.com/browse/genre/3329", false, "5977"));
            SubgenerData.Add(new Subgener("Foreign Gay & Lesbian Movies", "8243", "https://www.netflix.com/browse/genre/8243", false, "5977"));
            SubgenerData.Add(new Subgener("Gay & Lesbian Documentaries", "4720", "https://www.netflix.com/browse/genre/4720", false, "5977"));
            SubgenerData.Add(new Subgener("Gay & Lesbian TV Shows", "65263", "https://www.netflix.com/browse/genre/65263", false, "5977"));

            //Horror Movies 8711
            SubgenerData.Add(new Subgener("B-Horror Movies", "8195", "https://www.netflix.com/browse/genre/8195", false, "8711"));
            SubgenerData.Add(new Subgener("Creature Features", "6895", "https://www.netflix.com/browse/genre/6895", false, "8711"));
            SubgenerData.Add(new Subgener("Cult Horror Movies", "10944", "https://www.netflix.com/browse/genre/10944", false, "8711"));
            SubgenerData.Add(new Subgener("Deep Sea Horror Movies", "45028", "https://www.netflix.com/browse/genre/45028", false, "8711"));
            SubgenerData.Add(new Subgener("Foreign Horror Movies", "8654", "https://www.netflix.com/browse/genre/8654", false, "8711"));
            SubgenerData.Add(new Subgener("Horror Comedy", "89585", "https://www.netflix.com/browse/genre/89585", false, "8711"));
            SubgenerData.Add(new Subgener("Monster Movies", "947", "https://www.netflix.com/browse/genre/947", false, "8711"));
            SubgenerData.Add(new Subgener("Slasher and Serial Killer Movies", "8646", "https://www.netflix.com/browse/genre/8646", false, "8711"));
            SubgenerData.Add(new Subgener("Supernatural Horror Movies", "42023", "https://www.netflix.com/browse/genre/42023", false, "8711"));
            SubgenerData.Add(new Subgener("Teen Screams", "52147", "https://www.netflix.com/browse/genre/52147", false, "8711"));
            SubgenerData.Add(new Subgener("Vampire Horror Movies", "75804", "https://www.netflix.com/browse/genre/75804", false, "8711"));
            SubgenerData.Add(new Subgener("Werewolf Horror Movies", "75930", "https://www.netflix.com/browse/genre/75930", false, "8711"));
            SubgenerData.Add(new Subgener("Zombie Horror Movies", "75405", "https://www.netflix.com/browse/genre/75405", false, "8711"));
            SubgenerData.Add(new Subgener("Satanic Stories", "6998", "https://www.netflix.com/browse/genre/6998", false, "8711"));

            //Independent Movies 7077
            SubgenerData.Add(new Subgener("Experimental Movies", "11079", "https://www.netflix.com/browse/genre/11079", false, "7077"));
            SubgenerData.Add(new Subgener("Independent Action & Adventure", "11804", "https://www.netflix.com/browse/genre/11804", false, "7077"));
            SubgenerData.Add(new Subgener("Independent Thrillers", "3269", "https://www.netflix.com/browse/genre/3269", false, "7077"));
            SubgenerData.Add(new Subgener("Romantic Independent Movies", "9916", "https://www.netflix.com/browse/genre/9916", false, "7077"));
            SubgenerData.Add(new Subgener("Independent Comedies", "4195", "https://www.netflix.com/browse/genre/4195", false, "7077"));
            SubgenerData.Add(new Subgener("Independent Dramas", "384", "https://www.netflix.com/browse/genre/384", false, "7077"));

            //Music 1701
            SubgenerData.Add(new Subgener("Kids Music", "52843", "https://www.netflix.com/browse/genre/52843", false, "1701"));
            SubgenerData.Add(new Subgener("Country & Western/Folk", "1105", "https://www.netflix.com/browse/genre/1105", false, "1701"));
            SubgenerData.Add(new Subgener("Jazz & Easy Listening", "10271", "https://www.netflix.com/browse/genre/10271", false, "1701"));
            SubgenerData.Add(new Subgener("Latin Music", "10741", "https://www.netflix.com/browse/genre/10741", false, "1701"));
            SubgenerData.Add(new Subgener("Urban & Dance Concerts", "9472", "https://www.netflix.com/browse/genre/9472", false, "1701"));
            SubgenerData.Add(new Subgener("World Music Concerts", "2856", "https://www.netflix.com/browse/genre/2856", false, "1701"));
            SubgenerData.Add(new Subgener("Rock & Pop Concerts", "3278", "https://www.netflix.com/browse/genre/3278", false, "1701"));
            SubgenerData.Add(new Subgener("Musicals", "13335", "https://www.netflix.com/browse/genre/13335", false, "1701"));
            SubgenerData.Add(new Subgener("Classic Musicals", "32392", "https://www.netflix.com/browse/genre/32392", false, "1701"));
            SubgenerData.Add(new Subgener("Disney Musicals", "59433", "https://www.netflix.com/browse/genre/59433", false, "1701"));
            SubgenerData.Add(new Subgener("Showbiz Musicals", "13573", "https://www.netflix.com/browse/genre/13573", false, "1701"));
            SubgenerData.Add(new Subgener("Stage Musicals", "55774", "https://www.netflix.com/browse/genre/55774", false, "1701"));

            // Romantic Movies 8883
            SubgenerData.Add(new Subgener("Romantic Favorites", "502675", "https://www.netflix.com/browse/genre/502675", false, "8883"));
            SubgenerData.Add(new Subgener("Quirky Romance", "36103", "https://www.netflix.com/browse/genre/36103", false, "8883")); 
            SubgenerData.Add(new Subgener("Romantic Independent Movies", "9916", "https://www.netflix.com/browse/genre/9916", false, "8883"));
            SubgenerData.Add(new Subgener("Romantic Foreign Movies", "7153", "https://www.netflix.com/browse/genre/7153", false, "8883"));
            SubgenerData.Add(new Subgener("Romantic Dramas", "1255", "https://www.netflix.com/browse/genre/1255", false, "8883"));
            SubgenerData.Add(new Subgener("Steamy Romantic Movies", "35800", "https://www.netflix.com/browse/genre/35800", false, "8883"));
            SubgenerData.Add(new Subgener("Classic Romantic Movies", "31273", "https://www.netflix.com/browse/genre/31273", false, "8883"));
            SubgenerData.Add(new Subgener("Romantic Comedies", "5475", "https://www.netflix.com/browse/genre/5475", false, "8883"));

            //Sci-Fi & Fantasy 1492
            SubgenerData.Add(new Subgener("Action Sci-Fi & Fantasy", "1568", "https://www.netflix.com/browse/genre/1568", false, "1492"));
            SubgenerData.Add(new Subgener("Alien Sci-Fi", "3327", "https://www.netflix.com/browse/genre/3327", false, "1492"));
            SubgenerData.Add(new Subgener("Classic Sci-Fi & Fantasy", "47147", "https://www.netflix.com/browse/genre/47147", false, "1492"));
            SubgenerData.Add(new Subgener("Cult Sci-Fi & Fantasy", "4734", "https://www.netflix.com/browse/genre/4734", false, "1492"));
            SubgenerData.Add(new Subgener("Fantasy Movies", "9744", "https://www.netflix.com/browse/genre/9744", false, "1492"));
            SubgenerData.Add(new Subgener("Sci-Fi Adventure", "6926", "https://www.netflix.com/browse/genre/6926", false, "1492"));
            SubgenerData.Add(new Subgener("Sci-Fi Dramas", "3916", "https://www.netflix.com/browse/genre/3916", false, "1492"));
            SubgenerData.Add(new Subgener("Sci-Fi Horror Movies", "1694", "https://www.netflix.com/browse/genre/1694", false, "1492"));
            SubgenerData.Add(new Subgener("Sci-Fi Thrillers", "11014", "https://www.netflix.com/browse/genre/11014", false, "1492"));
            SubgenerData.Add(new Subgener("Foreign Sci-Fi & Fantasy", "6485", "https://www.netflix.com/browse/genre/6485", false, "1492"));

            //Sports Movies 4370
            SubgenerData.Add(new Subgener("Sports Comedies", "5286", "https://www.netflix.com/browse/genre/5286", false, "4370"));
            SubgenerData.Add(new Subgener("Sports Documentaries", "180", "https://www.netflix.com/browse/genre/180", false, "4370"));
            SubgenerData.Add(new Subgener("Sports Dramas", "7243", "https://www.netflix.com/browse/genre/7243", false, "4370"));
            SubgenerData.Add(new Subgener("Baseball Movies", "12339", "https://www.netflix.com/browse/genre/12339", false, "4370"));
            SubgenerData.Add(new Subgener("Football Movies", "12803", "https://www.netflix.com/browse/genre/12803", false, "4370"));
            SubgenerData.Add(new Subgener("Boxing Movies", "12443", "https://www.netflix.com/browse/genre/12443", false, "4370"));
            SubgenerData.Add(new Subgener("Soccer Movies", "12549", "https://www.netflix.com/browse/genre/12549", false, "4370"));
            SubgenerData.Add(new Subgener("Martial Arts, Boxing & Wrestling", "6695", "https://www.netflix.com/browse/genre/6695", false, "4370"));
            SubgenerData.Add(new Subgener("Basketball Movies", "12762", "https://www.netflix.com/browse/genre/12762", false, "4370"));
            SubgenerData.Add(new Subgener("Sports & Fitness", "9327", "https://www.netflix.com/browse/genre/9327", false, "4370"));

            //Thrillers 8933
            SubgenerData.Add(new Subgener("Action Thrillers", "43048", "https://www.netflix.com/browse/genre/43048", false, "8933"));
            SubgenerData.Add(new Subgener("Classic Thrillers", "46588", "https://www.netflix.com/browse/genre/46588", false, "8933"));
            SubgenerData.Add(new Subgener("Crime Thrillers", "10499", "https://www.netflix.com/browse/genre/10499", false, "8933"));
            SubgenerData.Add(new Subgener("Foreign Thrillers", "10306", "https://www.netflix.com/browse/genre/10306", false, "8933"));
            SubgenerData.Add(new Subgener("Independent Thrillers", "3269", "https://www.netflix.com/browse/genre/3269", false, "8933"));
            SubgenerData.Add(new Subgener("Gangster Movies", "31851", "https://www.netflix.com/browse/genre/31851", false, "8933"));
            SubgenerData.Add(new Subgener("Psychological Thrillers", "5505", "https://www.netflix.com/browse/genre/5505", false, "8933"));
            SubgenerData.Add(new Subgener("Political Thrillers", "10504", "https://www.netflix.com/browse/genre/10504", false, "8933"));
            SubgenerData.Add(new Subgener("Mysteries", "9994", "https://www.netflix.com/browse/genre/9994", false, "8933"));
            SubgenerData.Add(new Subgener("Sci-Fi Thrillers", "11014", "https://www.netflix.com/browse/genre/11014", false, "8933"));
            SubgenerData.Add(new Subgener("Spy Thrillers", "9147", "https://www.netflix.com/browse/genre/9147", false, "8933"));
            SubgenerData.Add(new Subgener("Steamy Thrillers", "972", "https://www.netflix.com/browse/genre/972", false, "8933"));
            SubgenerData.Add(new Subgener("Supernatural Thrillers", "11140", "https://www.netflix.com/browse/genre/11140", false, "8933"));

            //TV Shows 83
            SubgenerData.Add(new Subgener("British TV Shows", "52117", "https://www.netflix.com/browse/genre/52117", false, "83"));
            SubgenerData.Add(new Subgener("Classic TV Shows", "46553", "https://www.netflix.com/browse/genre/46553", false, "83"));
            SubgenerData.Add(new Subgener("Crime TV Shows", "26146", "https://www.netflix.com/browse/genre/26146", false, "83"));
            SubgenerData.Add(new Subgener("Cult TV Shows", "74652", "https://www.netflix.com/browse/genre/74652", false, "83"));
            SubgenerData.Add(new Subgener("Food & Travel TV", "72436", "https://www.netflix.com/browse/genre/72436", false, "83"));
            SubgenerData.Add(new Subgener("Kids' TV", "27346", "https://www.netflix.com/browse/genre/27346", false, "83"));
            SubgenerData.Add(new Subgener("Korean TV Shows", "67879", "https://www.netflix.com/browse/genre/67879", false, "83"));
            SubgenerData.Add(new Subgener("Miniseries", "4814", "https://www.netflix.com/browse/genre/4814", false, "83"));
            SubgenerData.Add(new Subgener("Military TV Shows", "25804", "https://www.netflix.com/browse/genre/25804", false, "83"));
            SubgenerData.Add(new Subgener("Science & Nature TV", "52780", "https://www.netflix.com/browse/genre/52780", false, "83"));
            SubgenerData.Add(new Subgener("TV Action & Adventure", "10673", "https://www.netflix.com/browse/genre/10673", false, "83"));
            SubgenerData.Add(new Subgener("TV Comedies", "10375", "https://www.netflix.com/browse/genre/10375", false, "83"));
            SubgenerData.Add(new Subgener("TV Documentaries", "10105", "https://www.netflix.com/browse/genre/10105", false, "83"));
            SubgenerData.Add(new Subgener("TV Dramas", "11714", "https://www.netflix.com/browse/genre/11714", false, "83"));
            SubgenerData.Add(new Subgener("TV Horror", "83059", "https://www.netflix.com/browse/genre/83059", false, "83"));
            SubgenerData.Add(new Subgener("TV Mysteries", "4366", "https://www.netflix.com/browse/genre/4366", false, "83"));
            SubgenerData.Add(new Subgener("TV Sci-Fi & Fantasy", "1372", "https://www.netflix.com/browse/genre/1372", false, "83"));
            SubgenerData.Add(new Subgener("Reality TV", "9833", "https://www.netflix.com/browse/genre/9833", false, "83"));
            SubgenerData.Add(new Subgener("Teen TV Shows", "60951", "https://www.netflix.com/browse/genre/60951", false, "83"));
        }
    } 
}
