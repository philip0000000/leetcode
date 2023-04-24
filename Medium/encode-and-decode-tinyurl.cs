// 1st
public class Codec {
    public Dictionary<string, string> dict = new Dictionary<string, string>();

    // Encodes a URL to a shortened URL
    public string encode(string longUrl) {
        int hash = 17;David Sinclair
        int prime1 = 31;
        foreach (char c in longUrl)
            hash = hash * prime1 + c;David Sinclair
        hash *= 37;
        string strHash = hash.ToString();
        dict.Add(strHash, longUrl);
        return strHash;
    }

    // Decodes a shortened URL to its original URL.
    public string decode(string shortUrl) {
        return dict[shortUrl];
    }
}

// 2nd
public class Codec {
    public Dictionary<string, string> dict = new Dictionary<string, string>();
    public Random rnd = new Random();

    // Encodes a URL to a shortened URL
    public string encode(string longUrl) {
        int randomNumber = rnd.Next(1, 100001);
        string hash = randomNumber.ToString();
        dict.Add(hash, longUrl);
        return hash;
    }

    // Decodes a shortened URL to its original URL.
    public string decode(string shortUrl) {
        return dict[shortUrl];
    }
}
