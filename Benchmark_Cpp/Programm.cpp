#include <chrono>
#include <iostream>
#include <map>

#include "AnalisisResultClass.cpp"
#include "AnalisisResultStruct.cpp"

using namespace std;

double CalculateClasses() {
    auto start = std::chrono::high_resolution_clock::now();
    for (int i = 0; i < 100000; i++) {
        AnalisisResultClass* analisis = new AnalisisResultClass((unsigned int)1, 1.0, string(""), new map<string, string>());
        delete analisis;
    }
    auto finish = std::chrono::high_resolution_clock::now();
    std::chrono::duration<double> elapsed = finish - start;
    return elapsed.count();
}

double CalculateStructures() {
    auto start = std::chrono::high_resolution_clock::now();
    for (int i = 0; i < 100000; i++) {
        AnalisisResultStruct* analisis = new AnalisisResultStruct((unsigned int)1, 1.0, string(""), new map<string, string>());
        delete analisis;
    }
    auto finish = std::chrono::high_resolution_clock::now();
    std::chrono::duration<double> elapsed = finish - start;
    return elapsed.count();
}

int main(int argv, char** argc) {
    cout << "Time for classes:" << CalculateClasses() << endl;
    cout << "Time for structs:" << CalculateStructures() << endl;
}