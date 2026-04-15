public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        List<List<string>> res = new List<List<string>>();
        //For Single element in the array.
        if(strs.Length == 1){
            res.Add(new List<string> {strs[0]});
        }
         //For multipule elements in the array.
        else{
            var myDictionary = new Dictionary<string, List<string>>();
                for(int i = 0; i < strs.Length; i++){
                    //Sorting the individual element in the input array.
                    char[] sArray = strs[i].ToCharArray(); 
                    Array.Sort(sArray);
                    string sString = new string(sArray);
                    
                    //Checking if the dict contains the elements then adding the string to it.If not creating new key.
                    if(myDictionary.ContainsKey(sString)){                        
                       myDictionary[sString].Add(strs[i]);
                    }
                    else{
                        myDictionary.Add(sString, new List<string> {strs[i]});
                    }
                }
                //Adding final dict values to result
                foreach (KeyValuePair<string, List<string>> entry in myDictionary)
                {
                    res.Add(entry.Value);
                }
            }
             return res;
        }      
    }