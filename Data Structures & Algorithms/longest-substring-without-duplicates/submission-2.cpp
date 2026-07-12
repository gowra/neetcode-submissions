class Solution {
public:
    int lengthOfLongestSubstring(string s) 
    {
        if (s.empty())
            return 0;

        int left = 0;
        int maxLength = 0;

        unordered_set<char> window;

        for (int right = 0; right < s.size(); right++)
        {
            if(window.count(s[right]))
            {
                maxLength = std::max<int>(window.size(), maxLength);

                while (window.count(s[right]))
                    window.erase(s[left++]);
            }

            window.insert(s[right]);
        }

        return std::max<int>(maxLength, window.size());
    }
};
