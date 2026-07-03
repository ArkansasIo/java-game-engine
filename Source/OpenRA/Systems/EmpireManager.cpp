#include <iostream>

class EmpireManager {
public:
    void Tick() {
        // Simulation logic
        energy += productionRate;
        population += growthRate;
        std::cout << "Empire Tick: Energy=" << energy << " Pop=" << population << std::endl;
    }
private:
    float energy = 100.0f;
    float productionRate = 5.0f;
    int population = 1000;
    float growthRate = 0.1f;
};
