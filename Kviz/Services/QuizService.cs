using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Kviz.Models;

namespace Kviz.Services
{
    public class QuizService
    {
        private List<Quiz> _quizzes;
        public int CurrentQuestionIndex { get; set; }

        public QuizService()
        {
            // Initialize the quiz data
            _quizzes = InitializeQuizzes();
            CurrentQuestionIndex = 0;
        }

        // Method to get the quiz
       
        public Quiz GetQuizByName(string quizName)
        {
            return _quizzes.FirstOrDefault(q => q.Title.Equals(quizName, StringComparison.OrdinalIgnoreCase));
        }

        // Method to validate answers and calculate the score
        public int CalculateScore(string quizName, List<string> userAnswers)
        {
            Quiz quiz = GetQuizByName(quizName);
            if (quiz == null)
            {
                throw new ArgumentException("Quiz not found.", nameof(quizName));
            }

            int score = 0;

            for (int i = 0; i < quiz.Questions.Count; i++)
            {
                if (quiz.Questions[i].CorrectAnswer == userAnswers[i])
                {
                    score++;
                }
            }

            return score;
        }

        // Helper method to initialize the quiz data
        private List<Quiz> InitializeQuizzes()
        {
            List<Quiz> quizzes = new List<Quiz>();

            Quiz Povijest = new Quiz();
            Povijest.Title = "Povijest";

            // Add questions to the quiz
            Question question1 = new Question
            {
                Text = @"Nakon velikih osvajanja tokom 15. i 16. stoljeća,
                           Osmansko Carstvo postepeno slabi te krajem 18. i
                                početkom 19.stoljeća dolazi do političkih i
                                ekonomskih nestabilnosti u ovoj državi. Taj skup
                                problema i nestabilnosti povezanih s Osmanskim
                                Carstvom se nazivao kakvim pitanjem?",
                Answers = new List<string> { "Istočnim", "Bosporskim", "Osmanskim","Islamskim" },
                CorrectAnswer = "Istočnim"
            };
            Povijest.Questions.Add(question1);

            Question question2 = new Question
            {
                Text = "Koje godine je započeo Američki građanski rat?",
                Answers = new List<string> { "1883", "1861", "1872","1868" },
                CorrectAnswer = "1861"
            };
            Povijest.Questions.Add(question2);

            Question question3 = new Question
            {
                Text = @"Koji je hrvatsko-ugarski kralj iz dinastije Arpadovića u 13. stoljeću napisao jedan od najvažnijih
                        dokumenata u povijesti grada Zagreba kojim je Gradec postao slobodni kraljevski grad?",
                Answers = new List<string> { "Bela III", "Koloman I", "Bela IV","Stjepan III" },
                CorrectAnswer = "Bela IV"
            };
            Povijest.Questions.Add(question3);

            Question question4 = new Question
            {
                Text = @"Tko je u grčkoj mitologiji u Hadu čamcem
                        prevozio mrtve duše preko rijeke Aheront i preko
                        rijeke Stiks, a po njemu je ime dobio i najveći
                        satelit Plutona.",
                Answers = new List<string> { "Orfej", "Kerber", "Had","Haron" },
                CorrectAnswer = "Haron"
            };
            Povijest.Questions.Add(question4);

            Question question5 = new Question
            {
                Text = @"Europske zemlje su tijekom povijesti doslovno raskomadale Afriku. 
                Jedino je neovisno, uglavnom zbog nepristupačnosti, ostalo Etiopsko kraljevstvo,
                 i to sve do tridesetih prošlog stoljeća. Koja je to država tada, nakon krvavog rata, 
                 okupirala ovu državu?",
                Answers = new List<string> { "Njemacka", "Italija", "SAD","Francuska" },
                CorrectAnswer = "Italija"
            };
            Povijest.Questions.Add(question5);

            Question question6 = new Question
            {
                Text = @"U periodu između 1920. i 1938. godine postojao je vojni savez između Jugoslavije,
                 Čehoslovačke i Rumunjske. Uzrok njegovog formiranja bio je strah od eventualnog pokušaja
                  Austrije ili Mađarske da vojnim putem povrate teritorije koje je Austrougarska ranije imala.
                   Kako se zvao ovaj savez?",
                Answers = new List<string> { "Mala Antanta", "Centralne sile", "Delski savez","Trojni pakt" },
                CorrectAnswer = "Mala Antanta"
            };
           Povijest.Questions.Add(question6);

            Question question7 = new Question
            {
                Text = "Koga je časopis Time godine 1938. izabrao kao osobu godine?",
                Answers = new List<string> { "Churchill", "Staljin", "Hitler","F.D. Roosevelt" },
                CorrectAnswer = "Hitler"
            };
            Povijest.Questions.Add(question7);

            Question question8 = new Question
            {
                Text = @"Jedan od najvećih vojskovođa antike bio je Temistoklo. 
                On je odmah shvatio da je jedini način da se odbije perzijska najezda na Grčku, 
                tako da ih se porazi na moru. Stoga je u obrambenom savezu grčkih gradova inzistirao 
                i na zajedničkoj floti.Konačna kruna je bila velika pobjeda kraj jednog grčkog otočića.
                Kojeg?",
                Answers = new List<string> { "Santorini", "Salamina", "Rodos","Kreta" },
                CorrectAnswer = "Salamina"
            };
            Povijest.Questions.Add(question8);

            Question question9 = new Question
            {
                Text = @"U drugoj polovici devetog stoljeća Hrvati rade prvi pravi iskorak prema Jadranskom moru.
                 U tom periodu strah su i trepet svim trgovcima koji plove uz istočnu obalu Jadrana.
                  Kolika je snaga njihove mornarice pokazuju 871. godine, kad pomažu, jakom flotom, 
                  kralju Ludoviku II da oslobodi Bari od Arapa . Koji hrvatski knez je tad bio na čelu Hrvatske,
                  a kojeg su protivnici od milja zvali “najgori knez Slavena”?",
                Answers = new List<string> { "Domagoj", "Višeslav", "Mislav","Trpimir" },
                CorrectAnswer = "Domagoj"
            };
            Povijest.Questions.Add(question9);

            Question question10 = new Question
            {
                Text = @"Koji narod je 375. prošao kroz Vrata naroda i svojim prodorom u Europu započeo Veliku seobu naroda?",
                Answers = new List<string> { "Goti", "Germani", "Slaveni","Huni" },
                CorrectAnswer = "Huni"
            };
            Povijest.Questions.Add(question10);

            quizzes.Add(Povijest);

            Quiz Zemljopis = new Quiz();
            Povijest.Title = "Zemljopis";

            Question question11 = new Question
            {
                Text = @"Ovaj grad najpoznatiji je po siru koji je nazvan po
                        samom gradu, drugi je najveći grad regije
                        Emilia-Romagna nakon Bologne. Dom je jednom
                        od najstarijih sveučilišta na svijetu. Koji je to
                         grad?",
                Answers = new List<string> { "Torino", "Modena", "Ferrara","Parma" },
                CorrectAnswer = "Parma"
            };
            Zemljopis.Questions.Add(question11);

            Question question12 = new Question
            {
                Text = @"Ovaj lučki grad je drugi po broju stanovnika u
                        svojoj državi, broji ih malo više od 300 tisuća. Koji
                        je to grad ako znamo da je ime dobio po sestri
                        Aleksandra Makedonskog?",
                Answers = new List<string> { "Solun", "Aleksandrija", "Bitola","Ankara" },
                CorrectAnswer = "Solun"
            };
            Zemljopis.Questions.Add(question12);

            Question question13 = new Question
            {
                Text = @"Koja je jedina rijeka na svijetu koja dvaput(uzvodno i nizvodno) presijeca ekvator? ",
                Answers = new List<string> { "Kongo", "Niger", "Zambezi","Amazona" },
                CorrectAnswer = "Kongo"
            };
            Zemljopis.Questions.Add(question13);

            Question question14 = new Question
            {
                Text = @"U kojoj zemlji se nalazi najveci vulkan na svijetu? ",
                Answers = new List<string> { "Italija", "Čile", "Indonezija","Havaji(SAD)" },
                CorrectAnswer = "Havaji(SAD)"
            };
            Zemljopis.Questions.Add(question14);

            Question question15 = new Question
            {
                Text = @"Koja pustinja je povrskinski najveca na svijetu? ",
                Answers = new List<string> { "Sahara", "Antarktička", "Gobi","Kalahari" },
                CorrectAnswer = "Antarktička"
            };
            Zemljopis.Questions.Add(question15);

            Question question16 = new Question
            {
                Text = @"Koliko službeno vremenskih zona ima Narodna Republika Kina? ",
                Answers = new List<string> { "3", "2", "1","5" },
                CorrectAnswer = "1"
            };
            Zemljopis.Questions.Add(question16);

            Question question17 = new Question
            {
                Text = @"Mađarska graniči sa Hrvatskom,Slovenijom,Rumunjskom,Srbijom,Slovačkom,Austrijom i ...?",
                Answers = new List<string> { "Ukrajinom", "Češkom", "Poljskom","Bugarskom" },
                CorrectAnswer = "Ukrajinom"
            };
            Zemljopis.Questions.Add(question17);

            Question question18 = new Question
            {
                Text = @"Koje je ime valute Kirgistana i
                        Uzbekistana, a ime dijeli sa jednom kod nas
                        rasprostranjenom riječnom ribom?",
                Answers = new List<string> { "Šaran", "Amur", "Som","Karas" },
                CorrectAnswer = "Som"
            };
            Zemljopis.Questions.Add(question18);

            Question question19 = new Question
            {
                Text = @"Kod stockholmskog sindroma talac se
                        emocionalno veže za svog otmičara, a po kojem glavnom gradu se
                        zove suprotan sindrom u kojem se otmičar veže
                        uz taoce te pokazuje samilost?",
                Answers = new List<string> { "Lima", "Tokio", "Pariz","Zagreb" },
                CorrectAnswer = "Lima"
            };
            Zemljopis.Questions.Add(question19);

             Question question20 = new Question
            {
                Text = @"Treće najveće jezero u Africi i deveto na svijetu dijeli svoje ime sa državom čiju trećinu ukupnog teritorija zauzima.Koja je to afrička država?",
                Answers = new List<string> { "Uganda", "Burundi", "Uganda","Malawi" },
                CorrectAnswer = "Malawi"
            };
            Zemljopis.Questions.Add(question20);

            Quiz Sport = new Quiz();
            Sport.Title = "Sport";

            Question question21 = new Question
            {
                Text = @"Nadimka Springboks trenutni su prvaci svijeta u
                            rugbyju, u finalu su svladali Englesku te treći puta
                            osvojili ovo prestižno natjecanje. Koju
                            reprezentaciju tražimo ako znamo da se dio
                            radnje u filmu Invictus vrti upravo oko njih?",
                Answers = new List<string> { "Južna Afrika", "Irska", "Škotska","Novi Zeland" },
                CorrectAnswer = "Južna Afrika"
            };
            Sport.Questions.Add(question21);

            Question question22 = new Question
            {
                Text = @"Ova klasa jedrilice nastala 1970.
                        godine se koristi uglavnom za sportska
                        natjecanja i rekreaciju. 1996. godine
                        prvi put se u njoj natječe i na
                        Olimpijskim igrama, a naš Tonči
                        Stipanović ima osvojena dva srebra iz
                        2016. i 2020. godine. Koja je to klasa?",
                Answers = new List<string> { "Optimist", "Radijal", "Laser","Finn" },
                CorrectAnswer = "Laser"
            };
            Sport.Questions.Add(question22);

            Question question23 = new Question
            {
                Text = @"Koja tenisačica drži rekord sa najviše osvojenih
                        Grand slamova? Većinu ih je osvojila tijekom
                        1960ih godina, a najviše ima Australian Opena,
                        čak 11, jer je logično, rođena u Australiji.",
                Answers = new List<string> { "Billie Jean King", "Chris Evert", "Monica Seles","Margaret Court" },
                CorrectAnswer = "Margaret Court"
            };
            Sport.Questions.Add(question23);


            Question question24 = new Question
            {
                Text = @"Opće je poznato u sportskom svijetu da je vozač s
                            najviše naslova u rallyju Sebastien Loeb sa 9
                            naslova prvaka. Koja država ima najviše osvojenih
                            naslova prvaka u ovom sportu?",
                Answers = new List<string> { "Italija", "Francuska", "Finska","Njemačka" },
                CorrectAnswer = "Francuska"
            };
            Sport.Questions.Add(question24);

            Question question25 = new Question
            {
                Text = @"Miami Heat je ove godine ostvario pothvat koji
                        smo vidjeli samo jednom u povijesti NBA, ušli su u
                        finale kao osmi nositelj Istočne konferencije. Koja
                        ekipa, također u Istočnoj konferenciji, je u
                        playoffu 1999. isto tako uspjela doći do finala u
                        kojem su izgubili od San Antonio Spursa.",
                Answers = new List<string> { "Philadelphia 76ers", "New York Knicks", "Boston Celtics","Chicago Bulls" },
                CorrectAnswer = "New York Knicks"
            };
            Sport.Questions.Add(question25);

            Question question26 = new Question
            {
                Text = @"John Isner i Nicolas Mahut su odigrali najduži meč
                        u povijesti tenisa, trajao je čak 11 sati i 5 minuta.
                        Na kojem turniru su odigrali ovaj spektakularan
                        meč?",
                Answers = new List<string> { "Wimbeldon", "Roland Garros", "US Open","Australian Open" },
                CorrectAnswer = "Wimbeldon"
            };
            Sport.Questions.Add(question26);

            Question question27 = new Question
            {
                Text = @"Kako je to već postalo uobičajeno u isto vrijeme
                        kad se igra NHL playoff, održava se Svjetsko
                        prvenstvo u hokeju na ledu, zbog toga na ovom
                        natjecanju često ne gledamo mnoge najveće
                        zvijezde ovog sporta. Tako je
                        završilo i ovo SP, a pitanje je koja reprezentacija
                        je osvojila naslov?",
                Answers = new List<string> { "Kanada", "Finska", "Rusija","Češka" },
                CorrectAnswer = "Kanada"
            };
            Sport.Questions.Add(question27);

            Question question28 = new Question
            {
                Text = @"Dražen Ladić je definitivno legenda hrvatske nogometne reprezentacije i Dinama.
                 Bez obzira što je gotovo cijelu karijeru proveo u ovom klubu, on nije Zagrepčanin. 
                 U kojem je gradu Ladić rođen?",
                Answers = new List<string> { "Varaždin", "Koprivnica", "Bjelovar","Čakovec" },
                CorrectAnswer = "Čakovec"
            };
            Sport.Questions.Add(question28);

            Question question29 = new Question
            {
                Text = @"Prve ljetne Olimpijske igre na kojima će nastupiti Hrvatska, bile su one u Barceloni 1992. godine, i naš je Olimpijski odbor bio suočen sa dilemom tko će nositi hrvatsku zastavu na otvaranju.
                        Na kraju je izbor bio pravi, jer je nositelj i osvojio odličje.
                        Kako se zvao koji je nosio zastavu na otvaranju te 1992. godine?",
                Answers = new List<string> { "Toni Kukoč", "Goran Ivanišević", "Zoran Primorac","Dražen Petrović" },
                CorrectAnswer = "Goran Ivanišević"
            };
            Sport.Questions.Add(question29);

            Question question30 = new Question
            {
                Text = @"Svi su vjerojatno čuli za legendaran revanš meč Hollyfiled vs. Tyson u kojemu je Tyson Hollyfiledu odgrizao komad uha te time bio diskvalificran.
                        Pitanje glasi nakon pobjede u prvom meču Hollyfield je postao prvak u teškoji kategoriji koji put?",
                Answers = new List<string> { "1", "4", "3","2" },
                CorrectAnswer = "4"
            };
            Sport.Questions.Add(question30);


            Quiz Film = new Quiz();
            Film.Title = "Film";


            Question question31 = new Question
            {
                Text = @"Ovaj film Alfred Hitchcock je režirao odmah nakon
                        Vrtoglavice(Vertigo) te se taj film smarta jednim od
                        najboljih svih vremena. Glavnu ulogu igra Cary
                        Grant kojemu je to bio četvrti i posljednji film u
                        suradnji s Hitchcockom. Koje je to remek djelo?",
                Answers = new List<string> { "The man who knew too much", "Psycho", "The Birds","North by Northwest" },
                CorrectAnswer = "North by Northwest"
            };
            Film.Questions.Add(question31);


            Question question32 = new Question
            {
                Text = @"U kojem djelu F. Scott Fitzgeralda je Nick
                        Carraway narator i jedan od glavnih likova? Četiri
                        filma su snimljena po ovom djelu, a posljedni
                        2013. godine sa Leonardom DiCapriom i Tobey
                        Maguireom.",
                Answers = new List<string> { "Gangs of New York", "Westside story", "The Irishman","Goodfellas" },
                CorrectAnswer = "Westside story"
            };
            Film.Questions.Add(question32);


            Question question33 = new Question
            {
                Text = @"U kojem djelu F. Scott Fitzgeralda je Nick
                        Carraway narator i jedan od glavnih likova? Četiri
                        filma su snimljena po ovom djelu, a posljedni
                        2013. godine sa Leonardom DiCapriom i Tobey
                        Maguireom.",
                Answers = new List<string> { "Catch me if you can", "Shutter Island", "The Great Gatsby","Django Unchained" },
                CorrectAnswer = "The Great Gatsby"
            };
            Film.Questions.Add(question33);


            Question question34 = new Question
            {
                Text = @"Glavni lik koje tv serije je Jack Bauer, agent koji
                        radi za jednu fiktivnu sigurnosnu službu?",
                Answers = new List<string> { "24", "Homeland", "NavyCIS","CSI:New York" },
                CorrectAnswer = "24"
            };
            Film.Questions.Add(question34);


            Question question35 = new Question
            {
                Text = @"U kojoj mini seriji iz 2019. godine možemo
                            susresti povijesne ličnosti poput Valerija
                            Legasova, Borisa Ščerbinu i Anatolija Djatlova koji
                            su ujedno i glavni likovi serije?",
                Answers = new List<string> { "Better Than Us", "The Method", "The Zone","Chernobil" },
                CorrectAnswer = "Chernobil"
            };
            Film.Questions.Add(question35);


            Question question36 = new Question
            {
                Text = @"Koji glumac je igrao glavnu ulogu Mojsija u
                        spektaklu Cecila DeMillea iz 1956. godine Deset
                        zapovijedi.Za tu ulogu je zaradio prvu
                        nominaciju za Zlatni globus, a tri godine nakon je
                        osvojio i Oscara za glavnu ulogu u jednom
                        drugom sjajnom filmu.",
                Answers = new List<string> { "Yul Brynner", "Charles Heston", "John Carradine","Marlon Brando" },
                CorrectAnswer = "Charles Heston"
            };
            Film.Questions.Add(question36);


            Question question37 = new Question
            {
                Text = @"Koje je boje tableta koju uzima Neo(Keanu Reeves) od Morpheusa(Laurence Fishburne) u filmu Matrix iz 1999.",
                Answers = new List<string> { "Žute", "Plave", "Crvene","Zelene" },
                CorrectAnswer = "Crvene"
            };
            Film.Questions.Add(question37);


            Question question38 = new Question
            {
                Text = @"Glava koje životinje je dočekala Jacka Woltza u krevetu u klasiku Francisa Forda Coppole iz 1972. The Godfather?",
                Answers = new List<string> { "Konja", "Psa", "Ribe","Mačke" },
                CorrectAnswer = "Konja"
            };
            Film.Questions.Add(question38);


            Question question39 = new Question
            {
                Text = @"Kad smo kod Coppole,miris čega ujutro voli pukovnik Bill Kilgore(Robert Duvall) u filmu Apokalipsa danas iz 1979?",
                Answers = new List<string> { "Baruta", "Žene", "Napalma","Kiše" },
                CorrectAnswer = "Napalma"
            };
            Film.Questions.Add(question39);


            Question question40 = new Question
            {
                Text = @"Koju je marku revolvera proslavio Prljavi Harry Callahan Clinta Eastwooda?",
                Answers = new List<string> { "Colt", "Browning", "Smith & Wesson","Walther" },
                CorrectAnswer = "Smith & Wesson"
            };
            Film.Questions.Add(question40);
            

            // Add more questions...
      
            return quizzes;
        }
    }
}
