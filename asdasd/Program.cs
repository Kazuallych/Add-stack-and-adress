#include <iostream>
#include <stack>

int main()
{
    using namespace std;
stack<int> s1;
s1.push(10);
    s1.push(20);
    int i = s1.top();
int* p1 = &i;
cout<<"Вершина стека:"<<i<<endl;
    cout<<p1<<endl;
    
    int D = 0;
cout<<"Введите новое значение стека D"<<endl;
    cin>>D;
    s1.push(D);
    int ii = s1.top();
int* p2 = &ii;
cout<<"Новая вершина стека:"<<ii<<endl;
    cout<<p2<<endl;
}