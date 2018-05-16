using System;
using System.Globalization;
using System.Text;

namespace ScifiStarNameGenerator
{
    public class StarNameGenerator
    {
        // V
        private readonly string[] vowels = { "a", "e", "i", "o", "u" };
        // VD
        private readonly string[] vowelDigraphs = { "ai", "au", "aw", "ay", "ea", "ee", "ei", "eu", "ew", "ey", "ie", "oi", "oo", "ou", "ow", "oy" };
        // C
        private readonly string[] consonants = { "b", "c", "d", "f", "g", "h", "j", "k", "l", "m", "n", "p", "q", "r", "s", "t", "v", "w", "x", "y", "z" };
        // CD - usually for beginning words
        private readonly string[] consonantDigraphs = { "bl", "br", "ch", "ck", "cl", "cr", "dr", "fl", "fr", "gh", "gl", "gr", "ng", "ph", "pl", "pr", "qu", "sc", "sh", "sk", "sl", "sm", "sn", "sp", "st", "sw", "th",
            "tr", "tw", "wh", "wr" };
        // CT - usually for beginning words
        private readonly string[] consonantTrigraphs = { "nth", "sch", "scr", "shr", "spl", "spr", "squ", "str", "thr" };
        // GLN - usually used as first word      
        private readonly string[] greekLetterNames = { "Alpha", "Beta", "Gamma", "Delta", "Epsilon", "Zeta", "Eta", "Theta", "Iota", "Kappa", "Lambda", "Mu", "Nu", "Xi", "Omicron", "Pi", "Rho", "Sigma", "Tau", "Upsilon",
            "Phi", "Chi", "Psi", "Omega" };
        // MN - usually used as last word
        private readonly string[] miscNames = { "Major", "Minor" };
        // FA - usually use after consonant letter
        private readonly string[] flairAffixes = { "er", "ury", "ion", "opa", "asi", "esi", "isi", "osi", "usi", "as", "es", "is", "os", "us", "on", "ov", "uv", "ald", "eld", "ild", "old", "uld", "alt", "elt", "ilt",
            "olt", "ult", "alv", "elv", "ilv", "olv", "ulv", "agh", "egh", "igh", "ogh", "ugh", "ayt", "eyt", "iyt", "oyt", "uyt", "and", "end", "ind", "ond", "und" };
        // S
        private readonly string[] symbols = { "@", "#", "-" };

        private Random random;

        public StarNameGenerator() {
            random = new Random();
        }

        /// <summary>
        /// Supply a number for reproducible names
        /// </summary>
        /// <param name="seed">Any value from -2,147,483,648 to 2,147,483,647</param>
        public StarNameGenerator(int seed) {
            random = new Random(seed);
        }

        /// <summary>
        /// Format must be comma-delimited. Format is executed from left to right order
        /// Can include spaces, i.e GLN, ,C,V,C,V could yield Alpha Tera
        /// If an incorrect format is used, "?" will be added in place
        /// </summary>
        /// <param name="format">Comma-delimited string of desired format</param>
        /// <returns>string</returns>
        public string GenerateName(string format = "GLN, ,C,V,C,V") {
            string[] formatType = format.Split(',');

            StringBuilder sb = new StringBuilder();

            foreach (string s in formatType) {
                switch (s) {
                    case "V":
                        sb.Append(vowels[random.Next(0, vowels.Length)]);
                        break;

                    case "VD":
                        sb.Append(vowelDigraphs[random.Next(0, vowelDigraphs.Length)]);
                        break;

                    case "C":
                        sb.Append(consonants[random.Next(0, consonants.Length)]);
                        break;

                    case "CD":
                        sb.Append(consonantDigraphs[random.Next(0, consonantDigraphs.Length)]);
                        break;

                    case "CT":
                        sb.Append(consonantTrigraphs[random.Next(0, consonantTrigraphs.Length)]);
                        break;

                    case "GLN":
                        sb.Append(greekLetterNames[random.Next(0, greekLetterNames.Length)]);
                        break;

                    case "MN":
                        sb.Append(miscNames[random.Next(0, miscNames.Length)]);
                        break;

                    case "FA":
                        sb.Append(flairAffixes[random.Next(0, flairAffixes.Length)]);
                        break;

                    case "S":
                        sb.Append(symbols[random.Next(0, symbols.Length)]);
                        break;

                    case " ":
                        sb.Append(" ");
                        break;

                    default:
                        sb.Append("?");
                        break;
                }
            }

            string result = sb.ToString();
            result = CultureInfo.InvariantCulture.TextInfo.ToTitleCase(result.ToLower());
            return result;
        }
    }
}
