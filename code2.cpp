#include <iostream>
using namespace std;
int cala(int number){
    int sum=0;
      while (number != 0)
    {
        int temp = number % 10;
        sum = sum + temp;
        number = number / 10;
    }
    return sum;
}

int main() {
    int num1, num2, num3;
    int sum = 0;

    cout << "Enter 3 numbers: ";
    cin >> num1 >> num2 >> num3;

    for (int i = num1; i <= num2; i++) {
    sum = cala(i);

        if (sum == num3) {
            cout << i<< endl;
    }
    }

    return 0;
}