#include <iostream>
#include <vector>
#include <algorithm>
using namespace std;

int main()
{
    int t, n, b;
    
    cin >> t;
    
    for (int i = 1; i <= t; i++)
    {
        cin >> n >> b;
        
        int y;
        
        vector<int> prices;
        
        for (int j = 0; j < n; j++)
        {
            int a;
            cin >> a;
            
            prices.push_back(a);
        }
        
        sort(prices.begin(), prices.end());
        
        for (int j = 0; j < n; j++)
        {
            if (b >= prices.at(j))
            {
                b -= prices.at(j);
                y++;
            }
        }
        
        cout << "Case #" << i << ": " << y << endl;
    }
    return 0;
}