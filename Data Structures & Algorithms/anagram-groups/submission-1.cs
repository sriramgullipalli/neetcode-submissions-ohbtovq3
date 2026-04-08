public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        List<List<string>> res = new List<List<string>>();
        if(strs.Length == 1){
            res.Add(new List<string> {strs[0]});
        }
        else{
            var myDictionary = new Dictionary<string, List<string>>();
                for(int i = 0; i < strs.Length; i++){
                    char[] sArray = strs[i].ToCharArray(); 
                    Array.Sort(sArray);
                    string sString = new string(sArray);
                    
                    if(myDictionary.ContainsKey(sString)){                        
                       myDictionary[sString].Add(strs[i]);
                    }
                    else{
                        myDictionary.Add(sString, new List<string> {strs[i]});
                    }
                }
                foreach (KeyValuePair<string, List<string>> entry in myDictionary)
                {
                    res.Add(entry.Value);
                }
            }
             return res;
        }      
    }