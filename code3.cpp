#include <iostream>
using namespace std;
int main() {
    int num1, num2;
    int i,j;
    
    cout << "Enter 2 number: ";
    cin >> num1>>num2;
    for (i = num1; i <= num2; ++i) {
        for ( j= 2; j * j <= i; ++j) {
            if (i % j == 0) {
                break;
            }
        }
        if (j * j > i)
            cout << i << endl;
    }

    return 0;
}