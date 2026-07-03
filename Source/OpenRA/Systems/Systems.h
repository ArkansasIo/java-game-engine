// Systems.h
#pragma once
#include <iostream>

// Stubs for the actual Game Logic Systems
class FleetSystem {
public:
    static void Move() { std::cout << "FleetMovementSystem::Executing Move Order\n"; }
    static void Attack() { std::cout << "FleetCombatSystem::Targeting Hostiles\n"; }
};

class PlanetSystem {
public:
    static void Build() { std::cout << "ConstructionSystem::Adding Building to Queue\n"; }
};
