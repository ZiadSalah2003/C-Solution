// Problem-Link : https://leetcode.com/problems/defanging-an-ip-address/description/
// Problem-ID : 1108
// Problem Name: Defanging an IP Address
// Verdict: AC
public class Solution {
    public string DefangIPaddr(string address) {
        string str = "";
        for(int i=0;i<address.Length;i++){
            if(address[i]=='.'){
                str+="[.]";
            }else{
                str+=address[i];
            }
        }
        return str;
    }
}