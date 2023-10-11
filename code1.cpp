#include <iostream>
using namespace std;

int main()
{
    int number, sum = 0;
    
    cout << "Enter a Number: ";
    cin >> number;
    
    while (number != 0)
    {
        int temp = number % 10;
        sum = sum + temp;
        number = number / 10;
    }
    
    cout << "Sum is : " << sum << endl;
    
    return 0;
}