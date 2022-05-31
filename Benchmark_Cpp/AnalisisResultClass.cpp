#include <map>
#include <string>

using namespace std;

class AnalisisResultClass {
   public:
    unsigned int analisisID;
    double temparature;
    string bloodTest;
    map<string, string>* other;

    AnalisisResultClass(unsigned int _analisisID, double _temparature, string _bloodTest, map<string, string>* _other) {
        analisisID = _analisisID;
        temparature = _temparature;
        bloodTest = _bloodTest;
        other = _other;
    }

    ~AnalisisResultClass() {
        delete other;
    }
};