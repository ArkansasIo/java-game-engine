// FleetCombatSystem.cpp
#include "Systems.h"
#include <iostream>
#include <vector>

struct Ship {
    std::string id;
    int health;
};

class FleetCombatSystem {
private:
    std::vector<Ship> fleet;

public:
    void AddShip(std::string id) { fleet.push_back({id, 100}); }
    
    void ExecuteAttack() {
        std::cout << "Combat Engine: Engaging fleet with " << fleet.size() << " vessels." << std::endl;
        for(auto& ship : fleet) {
            std::cout << " - Ship " << ship.id << " firing broadsides." << std::endl;
        }
    }
};
