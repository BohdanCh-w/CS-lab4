#include <map>
#include <string>

using namespace std;

struct AnalisisResultStruct {
   public:
    unsigned int analisisID;
    double temparature;
    string bloodTest;
    map<string, string>* other;

    AnalisisResultStruct(unsigned int _analisisID, double _temparature, string _bloodTest, map<string, string>* _other) {
        analisisID = _analisisID;
        temparature = _temparature;
        bloodTest = _bloodTest;
        other = _other;
    }

    ~AnalisisResultStruct() {
        delete other;
    }
};
