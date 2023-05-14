namespace CheckIfOneStringSwapCanMakeStringsEqual
{
    //https://leetcode.com/problems/check-if-one-string-swap-can-make-strings-equal
public class Program {
    public bool AreAlmostEqual(string s1, string s2) {
        if(s1.Length != s2.Length){
            return false;
        }
        if(s1 == s2){
            return true;
        }
        var pos = new List<int>();
        for(int i=0;i<s1.Length;i++){
            if(s1[i] != s2[i]){
                pos.Add(i);
                if(pos.Count > 2){
                    return false;
                }
            }
        }
        if(pos.Count == 1){
            return false;
        }
        
        if(s1[pos.First()] != s2[pos.Last()] || s1[pos.Last()] != s2[pos.First()]){
            return false;
        }
        return true;
    }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}