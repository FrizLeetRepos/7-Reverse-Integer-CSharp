public class Solution {
    public int Reverse(int x) {
        var resultList = x.ToString().ToCharArray().ToList();
        resultList.Reverse();
        if (resultList[resultList.Count - 1] == '-') {
            resultList.RemoveAt(resultList.Count - 1);
            resultList.Insert(0, '-');
        }
        if (int.TryParse(new string(resultList.ToArray()), out int result))
            return result;
        return 0;
    }
}