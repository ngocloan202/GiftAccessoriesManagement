#include <iostream>
#include <cmath>
#include <iomanip>

using namespace std;

void solveQuadratic(double a, double b, double c) {
    cout << "Phương trình: " << a << "x² + " << b << "x + " << c << " = 0" << endl;
    
    // Trường hợp a = 0: phương trình bậc 1
    if (a == 0) {
        if (b == 0) {
            if (c == 0) {
                cout << "Kết quả: Vô số nghiệm (phương trình có dạng 0 = 0)" << endl;
            } else {
                cout << "Kết quả: Vô nghiệm (phương trình có dạng " << c << " = 0)" << endl;
            }
        } else {
            double x = -c / b;
            cout << "Kết quả: Phương trình bậc 1, có 1 nghiệm: x = " << fixed << setprecision(2) << x << endl;
        }
        return;
    }
    
    // Tính delta
    double delta = b * b - 4 * a * c;
    
    if (delta > 0) {
        // Có 2 nghiệm phân biệt
        double x1 = (-b + sqrt(delta)) / (2 * a);
        double x2 = (-b - sqrt(delta)) / (2 * a);
        cout << "Kết quả: Có 2 nghiệm phân biệt:" << endl;
        cout << "x1 = " << fixed << setprecision(2) << x1 << endl;
        cout << "x2 = " << fixed << setprecision(2) << x2 << endl;
    } else if (delta == 0) {
        // Có 1 nghiệm kép
        double x = -b / (2 * a);
        cout << "Kết quả: Có 1 nghiệm kép: x = " << fixed << setprecision(2) << x << endl;
    } else {
        // Vô nghiệm
        cout << "Kết quả: Vô nghiệm (delta < 0)" << endl;
    }
}

int main() {
    cout << "=== GIẢI PHƯƠNG TRÌNH BẬC 2 ===" << endl;
    cout << "Nhập các hệ số a, b, c của phương trình ax² + bx + c = 0" << endl;
    
    double a, b, c;
    
    cout << "Nhập a: ";
    cin >> a;
    
    cout << "Nhập b: ";
    cin >> b;
    
    cout << "Nhập c: ";
    cin >> c;
    
    cout << "\n" << string(50, '=') << endl;
    solveQuadratic(a, b, c);
    cout << string(50, '=') << endl;
    
    return 0;
}